using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using SailClubLibrary.Exceptions;
using SailClubLibrary.Interfaces;
using SailClubLibrary.Models;

namespace RazorBoatApp2026F.Pages.Members
{
    public class CreateMemberModel : PageModel
    {
        private IMemberRepository _repo;

        private IWebHostEnvironment webHostEnvironment;

        [BindProperty]
        public Member NewMember { get; set; }

        [BindProperty]
        public IFormFile Photo { get; set; }


        public CreateMemberModel(IMemberRepository memberRepository, IWebHostEnvironment webHost)

        {
            _repo = memberRepository;
            webHostEnvironment = webHost;

        }
        public void OnGet()  //Bruges til at hente/vise noget
        {
        }

        public IActionResult OnPost() //Bruges til at oprette/update/delete
        {
            if (Photo != null)
            {
                if (NewMember.MemberImage != null)
                {
                    string filePath = Path.Combine(webHostEnvironment.WebRootPath, "/images/MemberImages", NewMember.MemberImage);
                    System.IO.File.Delete(filePath);
                }

                NewMember.MemberImage = ProcessUploadedFile();

                try
                {
                    _repo.AddMember(NewMember);
                }
                catch (MemberPhoneNumberExistsException mpeex)
                {
                    ViewData["ErrorMessage"] = mpeex.Message;
                    return Page();
                }
                catch (Exception exp)
                {
                    ViewData["ErrorMessage"] = exp.Message;
                    return Page();
                }
            }
            return RedirectToPage("Index");
        }

        private string ProcessUploadedFile()
        {
            string uniqueFileName = null;
            if (Photo != null)
            {
                string uploadsFolder = Path.Combine(webHostEnvironment.WebRootPath, "images/MemberImages");
                uniqueFileName = Guid.NewGuid().ToString() + "_" + Photo.FileName;
                string filePath = Path.Combine(uploadsFolder, uniqueFileName);
                using (var fileStream = new FileStream(filePath, FileMode.Create))
                {
                    Photo.CopyTo(fileStream);
                }
            }
            return uniqueFileName;
        }

    }
}
