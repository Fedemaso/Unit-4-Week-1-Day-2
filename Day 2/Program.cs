using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Nome:");
            string nome = Console.ReadLine();

            Console.WriteLine("Cognome:");
            string cognome = Console.ReadLine();

            Console.WriteLine("Età:");
            int età = Convert.ToInt32(Console.ReadLine());

            Persona persona = new Persona(nome, cognome, età);
            persona.GetFullPersonaProc();

            Console.ReadLine();


            Console.WriteLine("Nome Prodotto:");
            string nomeProdotto = Console.ReadLine();

            Console.WriteLine("Prezzo Prodotto:");
            int prezzo = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Quantità:");
            int quantità = Convert.ToInt32(Console.ReadLine());


            Console.WriteLine("Il costo totale è:");
            Prodotto prodotto = new Prodotto(nomeProdotto, prezzo, quantità);
            prodotto.CostoTotaleProc();

           
            Console.ReadLine();
        }
    }
}
