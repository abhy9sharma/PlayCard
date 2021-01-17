using PlayCard.Model;
using System;

namespace PlayCard
{
    class Program
    {

        [STAThread]
        static void Main(string[] args)
        {
            Console.WriteLine("Hello Lets Play card Dude");
            Play playCard = new Play();
            playCard.StartPlay();

        }

       
    }
}
