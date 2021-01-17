using PlayCard.Model;
using System;

namespace PlayCard
{
    class Program
    {

        [STAThread]
        static void Main(string[] args)
        {

            Play playCard = new Play();
            playCard.StartPlay();
        }

       
    }
}
