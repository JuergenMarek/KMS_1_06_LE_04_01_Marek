using System;
using System.Collections.Generic;

/// <summary>
/// Ausgabe der Daten
/// </summary>

    class Ausgabe
    {
        public void AusgabeMain(string[] args)
        {
            // Erstellen der Beispielliste
            List<GeometrischeFigur> figuren = new List<GeometrischeFigur>
            {
                // Befüllen der Beispielliste mit Werten
                new Kreis(5) { Farbe = "Rot" },
                new Rechteck(3, 4) { Farbe = "Blau" },
                new Dreieck(5, 6, 7) { Farbe = "Grün" },
                new Kreis(7) { Farbe = "Gelb" },
                new Quadrat(3) { Farbe = "Türkis"},
                new Rechteck(6, 8) { Farbe = "Orange" }
            };

            // Ausgabe der Beispielliste am Bildschirm
            foreach (var figur in figuren)
            {
                Console.Write($"Geometrische Figur: {figur.GetType().Name}, Farbe: {figur.Farbe}");
                if (figur is Kreis kreis)
                    Console.WriteLine($", Radius: {kreis.Radius}");
                else if (figur is Rechteck rechteck)
                    Console.WriteLine($", Breite: {rechteck.BreiteRechteck}, Höhe: {rechteck.HoeheRechteck}");
                else if (figur is Quadrat quadrat)
                    Console.WriteLine($", Seitenlänge: {quadrat.SeitenlaengeQuadrat}");
                else if (figur is Dreieck dreieck)
                    Console.WriteLine($", Seite A: {dreieck.SeiteA}, Seite B: {dreieck.SeiteB}, Seite C: {dreieck.SeiteC}");

                Console.WriteLine($"Fläche: {figur.BerechneFlaeche():F2}");
                Console.WriteLine($"Umfang: {figur.BerechneUmfang():F2}");
                Console.WriteLine();
            }
            Console.Write("Drücken Sie eine Taste, um das Programm zu beenden.");
            Console.ReadKey();
        }
    }
