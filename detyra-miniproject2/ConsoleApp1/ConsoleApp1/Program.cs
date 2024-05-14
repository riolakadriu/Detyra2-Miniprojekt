namespace ConsoleApp1
{
    class Employee
    {
        public int Id { get; set; }
        public string Emri { get; set; }
        public string Pozita { get; set; }
        public decimal Rroga { get; set; }


        public Employee(int id, string emri, string pozita, decimal rroga)
        {
            Id = id;
            Emri = emri;
            Pozita = pozita;
            Rroga = rroga;
        }
        public virtual decimal CalculateBonus(decimal rroga)
        {
            return 50000;
        }
    }

    class Developer : Employee

    {
        public Developer(int id, string emri, string pozita, decimal rroga)
            : base(id, emri, pozita, rroga)
        {
        }
        public override decimal CalculateBonus(decimal rroga)
        {
            decimal bonusFiks = 50000;
            decimal perqindjeBonus = rroga * 0.20m;

            return Math.Max(bonusFiks, perqindjeBonus);
        }
    }
    class Manager : Employee
    {

        public Manager(int id, string emri, string pozita, decimal rroga)
            : base(id, emri, pozita, rroga)
        {
        }


        public override decimal CalculateBonus(decimal rroga)
        {
            decimal fixedBonus = 50000;
            decimal percentageBonus = rroga * 0.25m;

            return Math.Max(fixedBonus, percentageBonus);
        }
    }

    class Admin : Employee
    {

        public Admin(int id, string emri, string pozita, decimal rroga)
            : base(id, emri, pozita, rroga)
        {
        }


        public override decimal CalculateBonus(decimal rroga)
        {

            return 50000;
        }
    }

    class Program
    {
        static void Main()
        {
            Developer developer = new Developer(1, "John Doe", "Developer", 60000);
            Manager manager = new Manager(2, "Jane Smith", "Manager", 80000);
            Admin admin = new Admin(3, "Alice Johnson", "Admin", 70000);

            DisplayEmployeeDetails(developer);
            DisplayEmployeeDetails(manager);
            DisplayEmployeeDetails(admin);
        }

        static void DisplayEmployeeDetails(Employee employee)
        {
            Console.WriteLine($"Id: {employee.Id}");
            Console.WriteLine($"Emri: {employee.Emri}");
            Console.WriteLine($"Pozita: {employee.Pozita}");
            Console.WriteLine($"Rroga: {employee.Rroga:C}");
            Console.WriteLine($"Bonus: {employee.CalculateBonus(employee.Rroga):C}");
            Console.WriteLine();
        }
    }
}


