using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace gen
{
    class Program
    {
        static void Main(string[] args)
        {
           Console.WriteLine ("Hello world");

           

            Console.WriteLine(gen(97, 122, 3, 6));
            Console.WriteLine(gen(97, 122, 3, 6));
            Console.WriteLine(gen(97, 122, 3,6));
            Console.WriteLine(gen(48, 57, 1, 1));
            Console.WriteLine(gen(48, 57, 3, 5));
            Console.WriteLine(gen(48, 57, 3, 5));
            Console.WriteLine(gen(48, 57, 3, 5));
            Console.Read();



        }

        static string gen(int i, int j, int min, int max)
        {
            string s = "";
            Random rand = new Random(DateTime.Now.Millisecond);
            for (int len = 0; len < rand.Next(min, max); len++)
            {
                char ch= (char)rand.Next(i, j);
                if (!s.Contains(ch)) s += ch;
                else len--;
            }

            /*
            char[] arr = new char[j - i];



            for (int a=0; i <=j ; i++,a++)
            {
                s+= i+"\t"+(char)i+"\n";
            }*/
            return s;
        }
            


        


}
}
