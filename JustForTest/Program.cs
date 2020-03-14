using System;

namespace JustForTest
{
    class Program
    {
        static void Main(string[] args)
        {
            string sentence = "GTACGGT";  
            char[] charArr = sentence.ToCharArray();  
            char[] charArray= new char[charArr.Length]; 
            for (int i = 0; i < charArr.Length; i++)
            {
                if (charArr[i] == 'G')
                { 
                    charArray[i]='C';
                } 
                if (charArr[i] == 'C')
                {
                    charArray[i]='G';
                } 
                if (charArr[i]== 'A')
                {
                    charArray[i]='T';
                } 
                if (charArr[i] == 'T')
                {
                    charArray[i]='A';
                } 
            }
            string str = new string(charArray);
            Console.WriteLine("///"+str);
        }
    }
}
