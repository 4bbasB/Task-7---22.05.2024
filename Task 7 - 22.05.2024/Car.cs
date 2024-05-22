namespace Task_7___22._05._2024
{
    public class Car
    {
        public string Brand;
        public string Model;
        public double CurrentFuel;
        public double FuelFor1km;
        public double Millage;

        public void Drive(double km)
        {

            Millage += km;
            CurrentFuel -= km * FuelFor1km;
            if (CurrentFuel < 0)
            {
                Console.WriteLine("Benzininiz kifayet etmir!!!");
                return;
            }
            else
            {
                Console.WriteLine($"Millage: {Millage}, Current Fuel: {CurrentFuel}");
            }
        }
    }
}
