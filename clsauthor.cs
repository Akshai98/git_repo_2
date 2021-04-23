using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace day2
{
    class Author
    {
        public string name1;
        public int rank1;
    }
    class Class5
    {
        public string name2;
        public int rank2;
        static void Main()
        {
            Class5 class5 = new Class5();
            Author author = new Author();
            bool result;
            result = class5 is Class5;
            Console.WriteLine(result);
            Console.ReadLine();
        }
    }
}
