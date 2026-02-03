using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using SailClubLibrary.Interfaces;
using SailClubLibrary.Models;

namespace RazorBoatApp2026F.Pages.Members
{
    public class DeleteMemberModel : PageModel
    {
        private IMemberRepository _repo;

        [BindProperty]
        public Member DeleteMember { get; set; }


        public DeleteMemberModel(IMemberRepository repo)
        {
            _repo = repo;
        }
        public IActionResult OnGet(string phoneNumber)
        {
            DeleteMember = _repo.SearchMember(phoneNumber);
            return Page();
        }

        public IActionResult OnPostDelete(string phoneNumber)
        {
            _repo.RemoveMember(DeleteMember);
            return RedirectToPage("Index");
        }
        public IActionResult OnPostCancel()
        {
            return RedirectToPage("Index");
        }
    }
}
