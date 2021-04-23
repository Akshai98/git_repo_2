using System.IO;
using System;

class Class2

{
    void checkOddEven(int a)
    {
        if(a % 2 == 0)
        {
        Console.WriteLine("Num is even");
        
    }
    else
    {
         Console.WriteLine("Num is odd");
    }
    static void Main(string[] args)
    {
        Class2 Class1 = new Class2();
        Class1.checkOddEven(6);
        Console.ReadLine();
    }   
}
}

