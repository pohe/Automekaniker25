using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using SailClubLibrary.Interfaces;
using SailClubLibrary.Models;

namespace RazorBoatApp2026F.Pages.Authentication
{
    public class LoginModel : PageModel
    {
        [BindProperty] public string UserName { get; set; }
        [BindProperty] public string PassWord { get; set; }
        public string Message { get; set; }

        private IMemberRepository _mRepo;
        public LoginModel(IMemberRepository memberRepository)
        {
            _mRepo = memberRepository;
        }

        public void OnGet()
        {
        }
        public void OnGetLogout()
        {
            HttpContext.Session.Remove("Email");
        }

        public IActionResult OnPost()
        {
            try
            {
                Member loginMember =  _mRepo.VerifyUserAsync(UserName, PassWord);
                if (loginMember != null)
                {
                    HttpContext.Session.SetString("Email", loginMember.Mail);
                    return RedirectToPage("/index");
                }
                else
                {
                    Message = "Invalid Email or password";
                    UserName = "";
                    PassWord = "";
                    return Page();
                }
            }
            catch (Exception ex)
            {
                ViewData["ErrorMessage"] = ex.Message;
            }
            return RedirectToPage("/Authentication/Login");
        }
    }
}
