using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Extensions.Logging;
using SailClubLibrary.Interfaces;
using SailClubLibrary.Models;

namespace RazorBoatApp2026F.Pages.Boats
{
    public class IndexModel : PageModel
    {
        private IBoatRepository bRepo;

        public List<Boat> Boats { get; private set; }

        [BindProperty(SupportsGet = true)]
        public string FilterCriteria { get; set; }
        public IndexModel(IBoatRepository boatRepository)
        {
            bRepo = boatRepository;
        }
        public void OnGet()
        {
            if (!string.IsNullOrEmpty(FilterCriteria))
            {
                Boats = bRepo.FilterBoats(FilterCriteria);
            }
            else
            {
                Boats = bRepo.GetAllBoats();
            }
            

        }
    }
}
