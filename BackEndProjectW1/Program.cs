﻿// See https://aka.ms/new-console-template for more information

using System;
using BackEndProjectW1.Moduls;


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


    //decimal ImpostaDaVersare = contribuente.CalcolaImposta();

    Console.WriteLine("======================================");
    Console.WriteLine("CALCOLO DELL'IMPOSTA DA VERSARE");
    Console.WriteLine($"Contribuente: {contribuente.Nome} {contribuente.Cognome}");
    Console.WriteLine($"nato il {contribuente.DataNascita}");
    Console.WriteLine($"residente in {contribuente.ComuneResidenza}");
    Console.WriteLine($"codice fiscale: {contribuente.CodiceFiscale}");
    Console.WriteLine($"Reddito dichiarato: €{contribuente.RedditoAnnuale}");
   //Console.WriteLine($"IMPOSTA DA VERSARE: €{ImpostaDaVersare}");

