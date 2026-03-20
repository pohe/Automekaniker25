using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using SailClubLibrary.Interfaces;
using SailClubLibrary.Models;

namespace RazorBoatApp2026F.Pages.Bookings
{
    public class UpdateBookingModel : PageModel
    {
        private IBookingRepository _repo;
        private IMemberRepository _mrepo;

        [BindProperty]
        public Booking BookingToUpdate { get; set; }

        public UpdateBookingModel(IBookingRepository bookingRepository, IMemberRepository memberRepository)
        {

            _repo = bookingRepository;
            _mrepo = memberRepository;
        }
        public void OnGet(int id )
        {
            BookingToUpdate = _repo.GetAllBookings().Find(b=>b.Id ==id);
        }

        public IActionResult OnPostUpdate()
        {
            Member member = _mrepo.SearchMember(BookingToUpdate.TheMember.PhoneNumber);
            BookingToUpdate.TheMember = member;
            _repo.UpdateBooking(BookingToUpdate.Id, BookingToUpdate);
            return RedirectToPage("Index");
        }

        public IActionResult OnPostDelete()
        {
            _repo.RemoveBooking(BookingToUpdate);
            return RedirectToPage("Index");
        }
    }
}
