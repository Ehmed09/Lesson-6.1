namespace ConsoleApp4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string number = "28";
            byte b=byte.Parse(number);
            nint ni = (nint)b;
            int i =(int)ni;
            Console.WriteLine(i.GetType());
        }
    }
}
