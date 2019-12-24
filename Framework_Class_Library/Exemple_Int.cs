using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Framework_Class_Library
{
    public class Exemple_Int
    {
        public Exemple_Int() {

         
            // Exemple 1
            int i; //  
            i = 3;
            Console.WriteLine(i);

            // Exemple 2
            Int32 i2 = 3;
            Console.WriteLine(i2);

            // Exemple 3 - 
            // C# est un langage totalement Orienté objet
            Int32 i3 = new Int32();
            i3 = 3;
            Console.WriteLine(i3);

            //4. Int32 - Parse
            string lettre = Console.ReadLine();
            int i4 = int.Parse(lettre); Convert.ToInt32(lettre);
            Console.WriteLine(i4);

            // 5 Int32 - ToString
            Int32 i5 = 3;
            Console.WriteLine(i5.ToString());
        
        }
    }
}
