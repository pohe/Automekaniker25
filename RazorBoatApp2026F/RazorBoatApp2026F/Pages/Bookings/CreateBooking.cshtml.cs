using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using SailClubLibrary.Interfaces;
using SailClubLibrary.Models;

namespace RazorBoatApp2026F.Pages.Bookings
{
    public class CreateBookingModel : PageModel
    {
        private IBoatRepository _bRepo;
        private IMemberRepository _mRepo;
        private IBookingRepository _bookingRepository;

        
        public Boat TheBoatToBeBooked { get; set; }

        [BindProperty]
        public int Id { get; set; }

        [BindProperty]
        public string PhoneNumber { get; set; }

        [BindProperty]
        public DateTime StartDate { get; set; }

        [BindProperty]
        public DateTime EndDate { get; set; }

        [BindProperty]
        public string Destination { get; set; }

        public CreateBookingModel(IBoatRepository boatRepository, IMemberRepository memberRepository, IBookingRepository bookingRepository)
        {
            _bRepo = boatRepository;
            _mRepo = memberRepository;
            _bookingRepository = bookingRepository;
            StartDate = DateTime.Now;
            EndDate = StartDate.AddDays(1);
        }

        public void OnGet(string sailNumber)
        {
            TheBoatToBeBooked = _bRepo.SearchBoat(sailNumber);

        }

        public IActionResult OnPost(string sailNumber)
        {
            Member? theMemberToBook = _mRepo.SearchMember(PhoneNumber);
            if (theMemberToBook ==null)
            {
                ViewData["ErrorMessage"] = "Member not found";
                return Page();
            }
            TheBoatToBeBooked = _bRepo.SearchBoat(sailNumber);
            Booking newBooking = new Booking(Id, StartDate, EndDate, Destination, theMemberToBook, TheBoatToBeBooked);
            _bookingRepository.AddBooking(newBooking);

            return RedirectToPage("Index");
        }
    }
}
