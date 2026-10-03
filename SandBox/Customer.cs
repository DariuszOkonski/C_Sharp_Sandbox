namespace SandBox
{
    internal class Customer
    {
        private static int nextId = 0;

        private readonly int _id;

        private string _password;


        public string Password
        {
            set
            {
                _password = value;
            }
        }
        public string Name { get; set; }
        public string Address { get; set; }
        public string ContactNumber { get; set; }

        public int Id { get { return _id; } }


        public Customer(string name, string address = "N/A", string contactNumber = "N/A")
        {
            _id = nextId++;
            Name = name;
            Address = address;
            ContactNumber = contactNumber;
        }

        public Customer()
        {
            _id = nextId++;
            Name = "New Customer";
            Address = "No Address";
            ContactNumber = "No ContactNumber";
        }

        public void SetDetails(string name, string address, string contactNumber = "N/A")
        {
            Name = name;
            Address = address;
            ContactNumber = contactNumber;
        }

        public void GetDetails()
        {
            Console.WriteLine($"Details about the customer: Name: {Name}, Id: {Id}, Password: {_password}");
        }

        public static void DoSomeCustomerStaff()
        {
            Console.WriteLine("I am doing some customer staff");
        }
    }
}
