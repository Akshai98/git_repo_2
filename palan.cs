using System.IO;
using System;

namespace Day_2
{
    class Class10
    {
       
        static void Main()
        {
         
         Console.WriteLine("Enter a string");
         string inputString = Console.ReadLine();
         char[] revredStringArray=new char[inputString.Length];
}
}
}for(int i=inputstring,Length-1; i>=0;i--)
{
    revredStringArray[i]=inputString[i];
}
string revredString = new string(revredStringArray);
if(revredString==inputString)
{
    Console.WriteLine("it is palandrome");
    
}
else
{
    Console.WriteLine("Please re-enter a palandrom");
}
Console.ReadLine();
}
}
}