using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using SailClubLibrary.Interfaces;
using SailClubLibrary.Models;

namespace RazorBoatApp2026F.Pages.Bookings
{
    public class ChooseBoatModel : PageModel
    {
        private IBoatRepository bRepo;

        public List<Boat> Boats { get; private set; }

        public ChooseBoatModel(IBoatRepository boatRepository)
        {
            bRepo = boatRepository;
        }
        public void OnGet()
        {
            Boats = bRepo.GetAllBoats();
        }
    }
}
