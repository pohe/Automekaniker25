using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.Extensions.Logging;
using SailClubLibrary.Interfaces;
using SailClubLibrary.Models;
using System.Diagnostics.Metrics;

namespace RazorBoatApp2026F.Pages.Boats
{
    public class CreateBoatModel : PageModel
    {
        private IBoatRepository _repo;

       
        [BindProperty]
        public Boat NewBoat { get; set; }


        public CreateBoatModel(IBoatRepository boatRepository)
        {
           
            _repo = boatRepository;
        }
        public void OnGet()  //Bruges til at hente/vise noget
        {
        }

        public IActionResult OnPost() //Bruges til at oprette/update/delete
        {
            _repo.AddBoat(NewBoat);
            return RedirectToPage("Index");
        }

       
    }
}
