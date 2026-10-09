namespace SandBox
{
    public class Person
    {
        protected string Name { get; private set; }
        protected int Age { get; private set; }

        public Person(string name, int age)
        {
            Name = name;
            Age = age;

            Console.WriteLine("Person constructor called");
        }

        public virtual void DisplayPersonInfo()
        {
            Console.WriteLine($"Name: {Name}, Age: {Age}");
        }
    }

    public class Employee : Person
    {
        public string JobTitle { get; set; }
        public int EmployeeID { get; set; }

        public Employee(string name, int age, string jobTitle, int employeeID)
            : base(name, age)
        {
            JobTitle = jobTitle;
            EmployeeID = employeeID;
            Console.WriteLine("Employee (derived class) constructor called");
        }

        public override void DisplayPersonInfo()
        {
            Console.WriteLine($"Name: {Name}, " +
                $"Age: {Age}, JobTitle: {JobTitle}, EmployeeID: {EmployeeID}");
        }
    }
}
