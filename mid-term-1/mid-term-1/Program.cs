using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace hang_man
{
    class random
    {
        public int result, numword;
        public string word;
        char[] useingword;

        public random()
        {
            string[] words = new string[3];
            words[0] = "tennis";
            words[1] = "football";
            words[2] = "badminton";
            //random Question 
            Random random = new Random();
            result = random.Next(0, 3);
            //random
            word = words[result];
            //length of word 
            numword = word.Length;
            //change string to char arry
            useingword = word.ToCharArray();
        }
    }
    class Game
    {
        public Game()
        {
            int correct = 0;
            int incorrect = 0;
            string Newguess;

            Console.WriteLine(" Play Game Hangman ");
            Console.WriteLine(" =-=-=-=-=-=--=-=-=");
            Console.WriteLine("Incorrect Score: {0} ", correct);


            random randoms = new random();
            char[] guess = new char[randoms.numword];
            for (int i = 0; i < randoms.numword; i++)
            {
                guess[i] = '_';
                Console.Write("{0}", guess[i]);
            }
            Console.Write("\ninput alphabet : ");
            do
            {
                char charecter = char.Parse(Console.ReadLine());
                for (int j = 0; j < randoms.numword; j++)
                {
                    if (charecter == randoms.word[j])
                    {
                        guess[j] = charecter;
                    }
                    else if (charecter != randoms.word[j])
                    {
                        correct = correct - 1;
                    }
                }
                //score 
                if (correct == randoms.numword)
                {
                    incorrect = incorrect + 1;
                    correct = 0;
                }
                if (correct == randoms.numword - 1)
                {
                    correct = 0;
                }
                correct = 0;

                Console.Clear();
                Console.WriteLine(" Play Game Hangman ");
                Console.WriteLine(" =-=-=-=-=-=--=-=-=");
                Console.WriteLine("Incorrect Score: {0} ", incorrect);

                Console.WriteLine(guess);
                Console.WriteLine("input alphabet : ");
                Newguess = new string(guess);
            }
            while (true && (incorrect < 6 && Newguess != randoms.word));
            {
                if (incorrect == 6)
                {
                    Console.Clear();
                    Console.WriteLine("You lose");
                }
                if (incorrect < 6);
                {

                }
            }
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            string menu;
            do
            {
                Console.Clear();
                Console.WriteLine("Welcome to Hangman Game");
                Console.WriteLine("1. Play game ");
                Console.WriteLine("2. Exit");
                menu = Console.ReadLine();
            }
            while (menu != "1" && menu != "2");
            {
                if(menu == "1")
                {
                    Console.Clear();
                    Game game = new Game();
                }
                else if (menu =="2")
                {
                    Console.WriteLine(" ");
                }    
            }
        }
    }
}