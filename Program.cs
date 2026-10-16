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
        static void Main(string[] args)
        {
            Feltolt();
            OsszegzesTetele();
            MegszamlalasTetele();
        }
    }
}
