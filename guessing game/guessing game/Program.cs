using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace guessing_game
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int playerGuess;
            string playerInput;
            bool isNumberGuessed = false;
            int TheAnswer;
            int numberofguesses;
            numberofguesses = 0;
            Random rng = new Random();
            TheAnswer = rng.Next(1, 21);
            

            do
            {
                Console.Write("1-20 arası tahminini alayım göt:");
                playerInput = Console.ReadLine();

                playerGuess = int.Parse(playerInput);

                if (playerGuess == TheAnswer)
                {
                    Console.WriteLine("Büyük Götsün!");
                    isNumberGuessed = true;
                }
                else
                {
                    if (playerGuess > TheAnswer)
                        Console.WriteLine("in lan!");
                    if (playerGuess < TheAnswer)
                        Console.WriteLine("çık lan!");
                    if (playerGuess > 20 || playerGuess < 0 )
                        Console.WriteLine("Mal mısın birader");

                    {
                        if (playerGuess >= 1 && playerGuess <= 20)
                            numberofguesses++;
                        
                         
                      Console.WriteLine(" " + (numberofguesses) + " tahmin hakkın kaldı");
                        if (numberofguesses > 5)
                          Console.WriteLine("Bul artık AMK!");
                        
                       
                        
                    }
                }

            } 
            while (!isNumberGuessed);
            {
                Console.ReadLine();
            }

        }
    }
}
