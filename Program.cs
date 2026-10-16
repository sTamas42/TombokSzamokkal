using Microsoft.VisualBasic;

namespace TombokSzamokkal
{
    internal class Program
    {
        static int[] tomb = new int[15];

        static Random r = new Random();

        static void Feltolt()
        {
            for(int i = 0; i < tomb.Length; i++)
            {
                tomb[i] = r.Next(-20, 21);
            }
            foreach(int item in tomb)
            {
                Console.Write(item + " ");
            }
            Console.WriteLine();
        }

        static void OsszegzesTetele()
        {
            int osszeg = 0;
            foreach (int item in tomb)
            {
                osszeg += item;
            }
            Console.WriteLine($"Összeg: {osszeg}");
        }

        static void MegszamlalasTetele()
        {
            int db = 0;
            foreach (int item in tomb)
            {
                if (item < 0)
                {
                    db++;
                }
                Console.WriteLine($"Negatív számok: {db}");
            }
        }

        static void EldontesTetele()
        {
            int i = 0;
            while ( i < tomb.Length && tomb[i] != 0)
            {
                i++;
            }
            if (i < tomb.Length)
            {
                Console.WriteLine("Van 0 a tömben.");
            }
            else
            {
                Console.WriteLine("Nincs 0 a tömben.");
            }
        }
        static void Main(string[] args)
        {
            Feltolt();
            OsszegzesTetele();
            MegszamlalasTetele();
            EldontesTetele();
        }
    }
}
