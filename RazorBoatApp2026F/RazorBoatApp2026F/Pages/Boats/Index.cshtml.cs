using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Extensions.Logging;
using SailClubLibrary.Helpers.Filter;
using SailClubLibrary.Helpers.Sorting;
using SailClubLibrary.Interfaces;
using SailClubLibrary.Models;
using System.Numerics;

namespace RazorBoatApp2026F.Pages.Boats
{
    public class IndexModel : PageModel
    {
        private IBoatRepository bRepo;

        [BindProperty(SupportsGet = true)]
        public string SortBy { get; set; }

        public List<Boat> Boats { get; private set; }

        [BindProperty(SupportsGet = true)]
        public string FilterCriteria { get; set; }
        public IndexModel(IBoatRepository boatRepository)
        {
            bRepo = boatRepository;
        }
        public void OnGet(/*bool sorting*/)
        {
            if (!string.IsNullOrEmpty(FilterCriteria))
            {
                //Boats = bRepo.FilterBoats(FilterCriteria);
                //Boats = FilterFunctions.Filter<Boat>(bRepo.GetAllBoats(), (b => b.Model.Contains(FilterCriteria)) );
            }
            else
            {
                Boats = bRepo.GetAllBoats();
            }
            SortBoats();
        }

        private void SortBoats()
        {
            switch (SortBy)
            {
                case "ID":
                    Boats.Sort();
                    //Events = Events.OrderByDescending(e => e.EventID).ToList();
                    break;
                case "YearOfConstruction":
                    Boats.Sort(new BoatCompareByYear());
                    break;
                case "SailNumber":
                    Boats.Sort(new BoatCompareBySailNumber());
                    break;
                default:
                    break;
            }
        }
    }
}
