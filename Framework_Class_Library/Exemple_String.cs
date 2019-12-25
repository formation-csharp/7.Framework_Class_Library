using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Framework_Class_Library
{
    public class Exemple_String
    {
        public Exemple_String()
        {
            String Nom = "";
            string NomAutre = "";

            if (Nom == String.Empty) // (Nom == "") 
                Console.WriteLine("Le nom est vide");


            Nom = "Madani";
            NomAutre = "Chami";
            Console.WriteLine("\t" + String.Compare(Nom, NomAutre));
            Console.WriteLine("\t" + String.Compare(NomAutre, Nom));
            Console.WriteLine("\t" + String.Compare(Nom, Nom));

            // Obtient le nombre de caractères
            Nom = "Madani";
            Console.WriteLine(Nom.Length);

            Console.WriteLine("\n" + "Indexeur : this[int index]");
            Console.WriteLine("\t" + "Nom = " + Nom);
            for (int i = 0; i < Nom.Length; i++)
            {
                // Attention :  Nom[i] est type Char
                Console.WriteLine($"\t item[{i}] {Nom[i]}");
            }

            Console.WriteLine("\n" + "Split");
            Nom = "Madani-Ali";
            String[] Noms = Nom.Split('-');
            foreach (var item in Noms)
            {
                Console.WriteLine("\t" + item);
            }

            Console.WriteLine(Nom.ToUpper());
            Console.WriteLine(Nom.ToLower());

            Nom = "     " + Nom;
            Console.WriteLine(Nom.Trim());

            Console.Read();
        }
    }
}
