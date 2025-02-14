// See https://aka.ms/new-console-template for more information

using System;
using BackEndProjectW1.Moduls;

static void Main()
{
    var contribuente = new Contribuente();

    Console.Write("Ciao, Benvenuto alla Registrazione dei tuoi Dati");
    Console.WriteLine("");
    Console.WriteLine("");
    Console.WriteLine("");


    Console.WriteLine("Inserisci Nome");
    contribuente.Nome = Console.ReadLine();

    Console.WriteLine("Inserisci Cognome");
    contribuente.Cognome = Console.ReadLine();


    Console.WriteLine("Inserisci Data di Nascita 31/12/1999");
    contribuente.DataNascita = DateTime.Parse(Console.ReadLine());

    Console.WriteLine("Inserisci Codice Fiscale");
    contribuente.CodiceFiscale = Console.ReadLine();

    Console.WriteLine("Inserisci il comune di residenza");
    contribuente.ComuneResidenza = Console.ReadLine();

    Console.WriteLine("Inserisci il Reddito Annuale");
    contribuente.RedditoAnnuale = int.Parse(Console.ReadLine());




}
