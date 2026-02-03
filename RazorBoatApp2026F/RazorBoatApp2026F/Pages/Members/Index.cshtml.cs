using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using SailClubLibrary.Interfaces;
using SailClubLibrary.Models;

namespace RazorBoatApp2026F.Pages.Members
{
    public class IndexModel : PageModel
    {
        private IMemberRepository mRepo;

        public List<Member> Members { get; private set; }

        [BindProperty(SupportsGet = true)]
        public string FilterCriteria { get; set; }
        public IndexModel(IMemberRepository memberRepository)
        {
            mRepo = memberRepository;
        }
        public void OnGet()
        {
            if (!string.IsNullOrEmpty(FilterCriteria))
            {
                Members = mRepo.FilterMembers(FilterCriteria);
            }
            else
            {
                Members = mRepo.GetAllMembers();
            }


        }
    }
}
