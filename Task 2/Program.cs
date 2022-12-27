namespace Task_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Ededi daxil edin");


            int i = int.Parse(Console.ReadLine());

            int a = 1 * (i / 1000);
            int b = 2 * ((i / 100) % 10);
            int c = 3 * ((i / 10) % 10);
            int d = 4 * (i % 10);

            Console.WriteLine(a + b + c + d);

            
        }
    }
}