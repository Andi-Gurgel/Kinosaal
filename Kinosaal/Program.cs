using System.Text;

namespace Kinosaal
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;
            int auswahl = -1;

            

            while (true)
            {

                Menue.Anzeigen();

                try
                {
                    Console.WriteLine("Wähle aus! \n");
                    Console.Write("Auswahl: ");
                    auswahl = int.Parse(Console.ReadLine());
                    Console.WriteLine();
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                }

                switch (auswahl)
                {
                    case 1:
                        Kinosaal.Anzeigen();
                        break;
                    case 2:
                        Console.WriteLine("buchen fehlt noch");
                        break;
                    case 3:
                        Console.WriteLine("reservieren fehlt noch");
                        break;
                    case 4:
                        Console.WriteLine("freimachen fehlt noch");
                        break;
                    case 5:
                        Console.WriteLine("Auf Wiedersehen!");
                        return;
                    default:
                        Console.WriteLine("Falsche Eingabe");
                        break;
                }
                Console.WriteLine();
                Console.Clear();
            }



        }


    }
}
