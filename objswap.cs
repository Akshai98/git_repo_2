using System.IO;
using System;

class Class2

{
//Example of Call by value
    void Swap(int a, int b)
    {
        //logic for swapping
        int temp = a;
        a = b;
        b = temp;
     Console.WriteLine(" Inside swap fun");
        Console.WriteLine("a= "+a);
         Console.WriteLine("b="+b);
        
    }
   
    static void Main(string[] args)
    {
        Class2 Class1 = new Class2(); // creating an objct
        int a=5, b=6;
         Console.WriteLine("Inside Main fun");
        Console.WriteLine("a= "+a);
         Console.WriteLine("b="+b);
        
        Console.ReadLine();
    }   
}
}

