namespace SandBox
{
    internal class Car
    {
        public static int NumberOfCars = 0;
        private string _brand = "";

        public string Brand
        {
            get
            {
                if (IsLuxury)
                {
                    return _brand + " - Luxury Edition";
                }
                else
                {
                    return _brand;
                }

            }
            set
            {
                if (string.IsNullOrEmpty(value))
                {
                    Console.WriteLine("You entered NOTHING");
                    _brand = "Unknown Brand";

                }
                else
                {
                    _brand = value;
                }

            }
        }
        public string Model { get; }
        public bool IsLuxury { get; }

        public Car()
        {
            IncreaseNumberOfCars();
        }

        public Car(string model, string brand, bool isLuxury = false)
        {
            IncreaseNumberOfCars();

            Brand = brand;
            Model = model;
            IsLuxury = isLuxury;
        }

        public void Drive()
        {
            Console.WriteLine($"I am a {Model} and I am driving");
        }

        private void IncreaseNumberOfCars()
        {
            NumberOfCars++;
        }
    }
}
