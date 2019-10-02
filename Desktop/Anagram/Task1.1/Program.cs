using System;
using System.Linq;
using System.Text;

namespace Task1._1
{
    
    class Program
    {
        static void Main( string[] args )
        {

            string line = "";
            while (string.IsNullOrEmpty(line))
            {
                Console.WriteLine( "Input text: " );
                line = Console.ReadLine();
                Console.WriteLine( "String is empty!" );
            } 

             char[] lineChar = line.ToCharArray();
            for (int i = 0,  j = (line.Length - 1); i < j; )
            {
                if (!Char.IsLetter(lineChar[i]))
                {
                    i++;
                }
                else if (!Char.IsLetter(lineChar[j]))
                {
                    j--;
                }
                else
                {
                    char temp = lineChar[i];
                    lineChar[i] = lineChar[j];
                    lineChar[j] = temp;
                    i++;
                    j--;
                } 
            }
            Console.Write(lineChar);
           
        }
    }
}
