using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Palindrome
{
    class Program
    {
        static void Main(string[] args)
        {
            //GET ALL PALINDROME IN A WORD
            //Minimum of 3 letters
            //Example :
            //Input : hannah
            //Output :
            // anna
            // Hannah
            //Limitation : No Validations yet


            Console.WriteLine("Enter a string");
            string userInput = Console.ReadLine(); //Waiting for the user to input some word
            int minLetterCtr = 3; //Minimum letter counter which is 3
            int patternCtr = userInput.Length - minLetterCtr; 
            //patternCtr is a counter on how many times will go through the word
            //example
            //HANNAH = minimum # of letter is 3, so will get HAN,ANN,NNA,and NAH so its 4 times.
            //that 4 is the value of patternCtr
            //as the letter increases, the number of loops in words will decrease
            //example. HANNAH = HANN,ANNA,and NNAH so theres 3 loops now
            //then HANNA, and ANNAH = 2 loops
            int swapLetterCtr = 0; //Will use this as a counter for reversing the letters
            string firstWord = ""; //Will hold first word
            string secondWord = ""; //Will hold reversed second word

            for (int k = 3; k <= userInput.Length; k++)//loop, start 3 letters minimum up to the length of the word
            {
                minLetterCtr = k;
                for (int j = 0; j <= patternCtr; j++) //loop for going through the word
                {
                    for (int i = j; i < minLetterCtr; i++) //put the letters to firstWord
                    {
                        firstWord = firstWord + userInput[i];
                    }
                    swapLetterCtr = firstWord.Length - 1;
                    for (int l = swapLetterCtr; l >= 0; l--) //reversed first word
                    {
                        secondWord = secondWord + firstWord[l];
                    }

                    if (firstWord.ToLower() == secondWord.ToLower()) //check if palindrome then print if it is palindrome
                    {
                        Console.WriteLine(firstWord + " = palindrome"); 
                    }
                    firstWord = "";
                    secondWord = "";
                    minLetterCtr = minLetterCtr + 1;
                }
                firstWord = "";
                secondWord = "";
                patternCtr = patternCtr - 1;
            }
        }
    }
}
