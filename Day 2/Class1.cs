using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day_2
{
    public class Persona
    {
        public Persona(string nome, string cognome, double età)
        {
            Nome = nome;
            Cognome = cognome;
            Età = età;
        }

        public string Nome { get; set; }
        public string Cognome { get; set; }

        public double Età { get; set; }

        public string GetFullPersona()
        {
            return Nome + " " + Cognome + " " + Età;
        }

        public void GetFullPersonaProc() {
            Console.WriteLine(Nome + " " + Cognome + " " + Età);
        }


    }



    public class Prodotto
    {

        public Prodotto(string nomeProdotto, int prezzo, int quantità)
        {
            NomeProdotto = nomeProdotto;
            Prezzo = prezzo;
            Quantità = quantità;

        }

        public string NomeProdotto { get; set; }
        public int Prezzo { get; set; }

        public int Quantità { get; set; }


        public int CostoTotale()
        {
            return (Prezzo * Quantità);
        }


        public void CostoTotaleProc()
        {
            Console.WriteLine(Prezzo * Quantità);

        }



    }
}
