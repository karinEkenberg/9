using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Övning1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Användaren får berätta sitt namn och ålder, blir välkomnad och får sedan veta hur många dagar gammal den är.
            Console.WriteLine("Skriv ditt för och efternamn:"); // konsolapplikation som skriver ut det som står mellan "" 
            string förOchEfternamn = Console.ReadLine();  // string-variabeln som skriver ut det användaren matade in i konsolapplikationen.
            Console.WriteLine("Hej och välkommen " + förOchEfternamn + ", kan du skriva hur gammal du är?"); //konsolapplikationen skriver ut det som står mellan "" och lägger till det användaren har matat in.
            int användarTal = Convert.ToInt32(Console.ReadLine()); // här deklarerar jag att det ska vara en heltalsvariabel med namnet användarTal, samt använder en slags konvertering mellan siffra och text
            Console.WriteLine("Du angav att din ålder är: " + användarTal); // konsolapplikation som skriver ut det som står mellan "" och den siffra användaren mata in.
            användarTal = användarTal * 365; // tilldelar åldern som användaren skriver in ett värde som multipliceras med 365, för att räkna ut hur många dagar användaren är. 
            Console.WriteLine("Du har levt ungefär så här många dagar: " + användarTal); // konsolapplikation som skriver ut det som står mellan "" samt åldern som räknas ut i raden ovanför.
            Console.ReadLine(); //konsolapplikation som läser in det användaren skriver och gör det till en string-variabel som sen skrivs ut i programmet samt för att programmet inte ska stängas ner på en gång utan inväntar att användaren trycker enter
        }
    }
}
