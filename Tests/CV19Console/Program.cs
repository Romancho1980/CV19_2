namespace CV19Console
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");
            double number = 24.7;
            string result=string.Format("{0:C0}",number);
            Console.WriteLine(result);
            string result2 = string.Format("{0:C2}", number);
            Console.WriteLine(result2);
        }
    }
}
