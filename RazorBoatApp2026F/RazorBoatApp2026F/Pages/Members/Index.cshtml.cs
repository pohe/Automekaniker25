using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using SailClubLibrary.Helpers.Filter;
using SailClubLibrary.Interfaces;
using SailClubLibrary.Models;

namespace RazorBoatApp2026F.Pages.Members
{
    public class IndexModel : PageModel
    {
        private IMemberRepository _mRepo;

        public List<Member> Members { get; private set; }


        [BindProperty(SupportsGet = true)]
        public string FilterCriteria { get; set; }

        [BindProperty(SupportsGet = true)]
        public string FilterBy { get; set; } = "All";

        [BindProperty(SupportsGet = true)]
        public MemberType? SelectedMemberType { get; set; }

        public IndexModel(IMemberRepository memberRepository)
        {
            _mRepo = memberRepository;
        }
        public IActionResult OnGet()
        {

            //string email = HttpContext.Session.GetString("Email");
            //if (email == null)
            //{
            //    return RedirectToPage("/Authentication/Login");
            //}
            //else if (!string.IsNullOrEmpty(FilterCriteria))
            //{
            //    Members = mRepo.FilterMembers(FilterCriteria);
            //}
            //else
            //{
            //    Members = mRepo.GetAllMembers();
            //}
            //return Page();


            List<Predicate<Member>> listOfPredicates = new List<Predicate<Member>>();
            Members = _mRepo.GetAllMembers();
            if (!string.IsNullOrWhiteSpace(FilterCriteria))
            {
                string f = FilterCriteria;
                Predicate<Member> predicatePrProperty;
                predicatePrProperty = m =>
                            (m.FirstName?.Contains(f, StringComparison.OrdinalIgnoreCase) == true)
                            || (m.SurName?.Contains(f, StringComparison.OrdinalIgnoreCase) == true)
                            || (m.PhoneNumber?.Contains(f, StringComparison.OrdinalIgnoreCase) == true)
                            || (m.Mail?.Contains(f, StringComparison.OrdinalIgnoreCase) == true)
                            || (m.City?.Contains(f, StringComparison.OrdinalIgnoreCase) == true);

                switch ((FilterBy).ToLowerInvariant())
                {
                    case "firstname":
                        predicatePrProperty = m => m.FirstName?.Contains(f) == true;
                        break;
                    case "surname":
                        predicatePrProperty = m => m.SurName?.Contains(f) == true;
                        break;
                    case "phonenumber":
                        predicatePrProperty = m => m.PhoneNumber?.Contains(f) == true;
                        break;
                    case "mail":
                        predicatePrProperty = m => m.Mail?.Contains(f) == true;
                        break;
                    case "city":
                        predicatePrProperty = m => m.City?.Contains(f, StringComparison.OrdinalIgnoreCase) == true;
                        break;
                    default:
                        predicatePrProperty = m =>
                            (m.FirstName?.Contains(f) == true)
                            || (m.SurName?.Contains(f) == true)
                            || (m.PhoneNumber?.Contains(f) == true)
                            || (m.Mail?.Contains(f) == true)
                            || (m.City?.Contains(f) == true);
                        break;

                }
                listOfPredicates.Add(predicatePrProperty);
            }
            if (SelectedMemberType.HasValue)
            {
                var sel = SelectedMemberType.Value;
                Predicate<Member> predicatePrMemberType;
                predicatePrMemberType = m => m.TheMemberType == sel;
                listOfPredicates.Add(predicatePrMemberType);
            }
            Members = FilterFunctions.Filter(Members, listOfPredicates);

            return Page();
        }
    }
}

