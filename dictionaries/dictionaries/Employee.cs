namespace dictionaries
{
    internal partial class Program
    {
        public class Employee
        {
            public int Id { get; set; }
            public string Name { get; set; }
            public string Surname { get; set; }
            public decimal Wage { get; set; }

            public Employee(string name, string surname, decimal wage)
            {
                Name = name;
                Surname = surname;
                Wage = wage;
            }

            public override string ToString()
            {
                return $"{Name,-5} {Surname,-5} {Wage,-5}";
            }
        }

    }
}
