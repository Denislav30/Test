namespace StaticFields
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Car.name = "Audi";
            Console.WriteLine(Car.name);

            Car Lamborghini = new Car();
            Lamborghini.price = 400.000;

            Console.WriteLine(Lamborghini.price);

            Car Ferrari = new Car();
            Console.WriteLine(Ferrari.GetHorsepower());

            Car Porsche = new Car();
            Console.WriteLine(Porsche.testMethod());



        }
    }
}
