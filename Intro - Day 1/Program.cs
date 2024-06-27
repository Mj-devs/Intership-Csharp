namespace Intro___Day_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
           
            Console.WriteLine("Hello, World!");
        }
        
       
    }


    public class MJay
    {
        public static string Name { get; set; }
        private protected static void GreetMj()
        {
            Console.WriteLine("Hello There,  Mjay!");
        }
    }

    public class NewMjay: MJay
    {
        public void JustaFunc()
        {
            GreetMj();  
        }
    }
}
