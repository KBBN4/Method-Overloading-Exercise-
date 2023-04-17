namespace MethodOverloading
{
    public class Program
    {
        static void Main(string[] args)
        {
            //Methods.Add(7, 8);
            //Methods.Add(5.86365m, 5.89654m);
             var answer = Methods.Add(0,1, true);
            Console.WriteLine(answer);
        }
    }
}
