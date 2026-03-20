
using GenericRepository;
using System.Security.Cryptography.X509Certificates;

//CarRepository cars = new CarRepository();
Repository<string, Car> cars = new Repository<string, Car>();


Car c1 = new Car("AB 12 345", 80000);
Car c2 = new Car("CD 34 456", 65000);
Car c3 = new Car("EF 56 567", 28000);

cars.Insert(c1.LicensePlate, c1);
cars.Insert(c2.LicensePlate, c2);
cars.Insert(c3.LicensePlate, c3);
cars.PrintAll();
Console.WriteLine($"Numbers of cars {cars.Count}");

//EmployeeRepository employees = new EmployeeRepository();
Repository<string, Employee> employees = new Repository<string, Employee>();

Employee e1 = new Employee("Allan", 1962);
Employee e2 = new Employee("Bente", 1975);
Employee e3 = new Employee("Carlo", 1973);

employees.Insert(e1.Name, e1);
employees.Insert(e2.Name, e2);
employees.Insert(e3.Name, e3);
employees.PrintAll();
Console.WriteLine($"Numbers of employees {employees.Count}");

Computer co1 = new Computer("123", "POuls network");
Computer co2 = new Computer("321", "Peters network");

//ComputerRepository computers = new ComputerRepository();
Repository<string, Computer> computers = new Repository<string, Computer>();

computers.Insert(co1.SerialNo, co1);
computers.Insert(co2.SerialNo, co2);
computers.PrintAll();
Console.WriteLine($"Numbers of computers {computers.Count}");


Repository<int, Phone> phones = new Repository<int, Phone>();
Phone p1 = new Phone(123, "A13", 2025);
Phone p2 = new Phone(321, "A14", 2026);

phones.Insert(p1.ProductionId, p1);
phones.Insert(p2.ProductionId, p2);

phones.PrintAll();
Console.WriteLine($"Numbers of phones {phones.Count}");
