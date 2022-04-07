using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Number_Generator
{
    public class Console //Hauptklasse
    {
        static void Main(string[] args)
        {
            Start(); //Ich dachte, es sei gut eine eigene Methode dafür zu haben, anstatt alles in Main direkt hineinzuschreiben :)

            void Start()
            {
                int x = 0;
                int y = 0;

                    //start
                System.Console.WriteLine("");
                System.Console.WriteLine("Zuallererst geben Sie bitte die minimalste ganze Zahl ein und danach die größte ganze Zahl. (Zahl: nicht unter 0)");
                System.Console.WriteLine("");
                System.Console.WriteLine("Sie müssen eine Zahl eingeben, ansonsten entsteht ein Fehler.");
                System.Console.WriteLine("");
                System.Console.WriteLine("Bitte geben Sie Ihre gewünschte Zahl zum Ziehen einer zufälligen Zahl hier ein (Bestätigen Sie mit -Enter-): ");

                if (x == 0) //Eingabe für min.
                {
                        //min.
                    int eingabe = Convert.ToInt32(System.Console.ReadLine());
                    
                    System.Console.WriteLine("");
                    System.Console.WriteLine("Sie haben als minimalen Wert " + eingabe + " eingegeben." + " Nun geben Sie bitte Ihren maximal Wert ein: ");

                    x = eingabe;
                }

                if (y == 0) //Eingabe für max.
                {
                        //max.
                    int eingabe2 = Convert.ToInt32(System.Console.ReadLine());
                    System.Console.WriteLine("");
                    System.Console.WriteLine("Sie haben als maximalen Wert " + eingabe2 + " eingegeben." + " Nun wird Ihnen eine zufällige Nummer generiert.");

                    y = eingabe2;

                }
                
                var generator = new RandomGenerator();
                var randomNumber = generator.RandomNumber(x, y);
                System.Console.WriteLine("");
                System.Console.WriteLine("");
                System.Console.WriteLine("Die gezogene Zahl ist: " + randomNumber + "!"); //gibt die Zahl aus
                System.Console.ReadKey();

                System.Console.WriteLine("");
                System.Console.WriteLine("Um eine weitere Zahl zu generieren; starten Sie das Programm neu.");
            }
        }
    }
}