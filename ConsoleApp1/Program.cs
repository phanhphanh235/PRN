namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");
            int a;
            Console.WriteLine("Input a:");
            a = int.Parse(Console.ReadLine());
            double b;
            Console.WriteLine("Input b:");
            b = Convert.ToSingle(Console.ReadLine());
            double c;
            Console.WriteLine("Input c:");
            double.TryParse(Console.ReadLine(), out c);

            Console.WriteLine("c = ", +c);
            Console.WriteLine("c = {0}", c);
            Console.WriteLine($"c ={c}")
        }
    }
}
