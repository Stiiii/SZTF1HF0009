using System;

namespace W92MEN_SZTF1HF0009
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Kezdő házszám: ");
            string kezdhazszam = Console.ReadLine();
            Console.Write("Lecserélendő házak száma: ");
            int lecserelendo = int.Parse(Console.ReadLine());
            int nulla = 0;
            int egy = 0;
            int ketto = 0;
            int harom = 0;
            int negy = 0;
            int ot = 0;
            int hat = 0;
            int het = 0;
            int nyolc = 0;
            int kilenc = 0;

            for (int i = Convert.ToInt32(kezdhazszam); i <= Convert.ToInt32(kezdhazszam) + (2*(lecserelendo-1)); i=i+2)
            {
                char[] szamtomb = Convert.ToString(i).ToCharArray();
                for (int j = 0; j < szamtomb.Length; j++)
                {
                    if (szamtomb[j] == '0')
                    {
                        nulla++;
                    }
                    if (szamtomb[j] == '1')
                    {
                        egy++;
                    }
                    if (szamtomb[j] == '2')
                    {
                        ketto++;
                    }
                    if (szamtomb[j] == '3')
                    {
                        harom++;
                    }
                    if (szamtomb[j] == '4')
                    {
                        negy++;
                    }
                    if (szamtomb[j] == '5')
                    {
                        ot++;
                    }
                    if (szamtomb[j] == '6')
                    {
                        hat++;
                    }
                    if (szamtomb[j] == '7')
                    {
                        het++;
                    }
                    if (szamtomb[j] == '8')
                    {
                        nyolc++;
                    }
                    if (szamtomb[j] == '9')
                    {
                        kilenc++;
                    }
                }
            }
            Console.WriteLine($"{nulla},{egy},{ketto},{harom},{negy},{ot},{hat},{het},{nyolc},{kilenc}");
            Console.ReadKey();
        }
    }
}
