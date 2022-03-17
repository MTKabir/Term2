using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment1
{
    internal class Program
    {

        static void Main(string[] args)
        {
            Program myPrograme = new Program();
            myPrograme.Start();
        }
        void Start()
        {
            Console.Write("Enter a message:");
            string messange=Console.ReadLine();

            Console.Write("Enter shift number:");
            int shiftNumber=int.Parse(Console.ReadLine());

            Console.Write($"Encrypted message: {ShiftMessage(messange, shiftNumber)}");
            Console.Write($"Decrypted message: {ShiftMessage(messange, shiftNumber)}");


            Console.Read();
        }
        int ShiftAlphabetPosition(int position,int shift)
        {
           int newPosition = position + shift;
            /*if (newPosition  <0)
                shift = shift + 26;

            if (newPosition > 26)
                shift = shift - 26;*/
            return newPosition;

        }
 
        
        string ShiftMessage(string message,int shift)
        {
            if (message == null) return null;
            char[] alphabet =
            {
            'a', 'b', 'c', 'd', 'e', 'f', 'g', 'h', 'i', 'j', 'k', 'l', 'm',
            'n', 'o', 'p', 'q', 'r', 's', 't', 'u', 'v', 'w', 'x', 'y', 'z'
            };
            string shiftedText = string.Empty;
            string changeToLower=message.ToLower();
            foreach (var character in changeToLower)
            {
                var position = Array.IndexOf(alphabet, character);

                if (position < 0)
                {
                    shiftedText += character;
                }
                else
                {
                    ShiftAlphabetPosition(position, shift);
                    var newIndex = position- shift;
                    if (newIndex < 0) newIndex += 26;
                    shiftedText += alphabet[newIndex];
                } 
            }
            return shiftedText;

        }
 
    }
}
