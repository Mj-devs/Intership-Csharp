namespace Intro___Day_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Dog myDog = new Dog("Falon");
            Dog yourDog = new Dog("Beauty");
           // Console.WriteLine(myDog.Name);
            //Console.WriteLine(yourDog.Name);
            myDog.MakeSound();
            yourDog.MakeSound();

            
        Cat myCat = new Cat("Betty");
        Console.WriteLine(myCat.Newname);
                myCat.lives();
            GoodGames myGames = new GoodGames("Manhunt");
            Console.WriteLine(myGames.Gamename);
            myGames.Genre();
        }
        
    }


}
