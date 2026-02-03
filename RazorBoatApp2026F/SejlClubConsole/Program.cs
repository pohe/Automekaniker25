// See https://aka.ms/new-console-template for more information
using SailClubLibrary.Models;
using SailClubLibrary.Services;

BoatRepository bRepo = new BoatRepository();
Console.WriteLine("------------------- boats --------------------------");
foreach (Boat boat in bRepo.GetAllBoats())
{
    Console.WriteLine(boat + "\n");
}


Console.WriteLine("------------------- Members --------------------------");
MemberRepository mRepo = new MemberRepository();

foreach(Member member in mRepo.GetAllMembers())
{
    Console.WriteLine(member+ "\n");
}
