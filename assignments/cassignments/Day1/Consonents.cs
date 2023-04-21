using System;
using System.Collections.Generic;


namespace cassignments.Day1
{
    public class Consonents
    {
        public void consonent(string args)
        { 
          string inputstring;
        int i;
            //vowels,
            Console.Write("Enter the inputstring: ");
            inputstring = Console.ReadLine();
       
        int consonants = 0;
        int len = inputstring.Length;

        // Iterating the string from left to right
        for (i = 0; i<len; i++)
        {

            // Check if the character is a vowel
            if (inputstring[i] == 'a' || inputstring[i] == 'e' ||
                inputstring[i] == 'i' || inputstring[i] == 'o' ||
                inputstring[i] == 'u' || inputstring[i] == 'A' ||
                inputstring[i] == 'E' || inputstring[i] == 'I' ||
                inputstring[i] == 'O' || inputstring[i] == 'U')
            {

                // Increment the vowels
                //vowels++;
            }
            // Check if the character is a alphabet
            // other than vowels
            else if ((inputstring[i] >= 'a' && inputstring[i] <= 'z') ||
                     (inputstring[i] >= 'A' && inputstring[i] <= 'Z'))
            {

                // Increment the consonants
                consonants++;
            }
}



Console.WriteLine("count of consonant = " + consonants);
    }
}

       
    }

