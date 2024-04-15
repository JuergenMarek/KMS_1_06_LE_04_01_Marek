using System;

/// <summary>
/// Hauptklasse der geometrischen Figuren
/// </summary>
class GeometrischeFigur
{
    public string Farbe { get; set; }

    /// <summary>
    /// Flächenberechnung
    /// </summary>
    /// <returns>Gibt eine Leermeldung zurück, da die Methoden von den einzelnen Subklassen überschrieben werden.</returns>
    public virtual double BerechneFlaeche()
    {
        return 0;
    }

    /// <summary>
    /// Umfangberechnung
    /// </summary>
    /// <returns>Gibt eine Leermeldung zurück, da die Methoden von den einzelnen Subklassen überschrieben werden.</returns>
    public virtual double BerechneUmfang()
    {
        return 0;
    }
}

/// <summary>
/// Subklasse Kreis, Vererbung von Hauptklasse
/// </summary>
sealed class Kreis : GeometrischeFigur
{
    /// <summary>
    /// Definition der Properties
    /// </summary>
    public double Radius { get; set; }

    /// <summary>
    /// Konstruktor der Subklasse Kreis
    /// </summary>
    /// <param name="radius">Wert wird vom Aufruf der Methode übernommen</param>
    public Kreis(double radius)
    {
        Radius = radius;
    }

    /// <summary>
    /// Überschreiben der Berechnung der Fläche von der Hauptklasse
    /// </summary>
    /// <returns>Es wird die berechnete Fläche zurückgegeben.</returns>
    public override double BerechneFlaeche()
    {
        return Math.PI * Radius * Radius;
    }

    /// <summary>
    /// Überschreiben der Berechnung der Fläche von der Hauptklasse
    /// </summary>
    /// <returns>Es wird der berechnete Umfang zurückgegeben.</returns>
    public override double BerechneUmfang()
    {
        return 2 * Math.PI * Radius;
    }
}

/// <summary>
/// Subklasse Rechteck, Vererbung von Hauptklasse
/// </summary>
sealed class Rechteck : GeometrischeFigur
{
    /// <summary>
    /// Definition der Properties
    /// </summary>
    public double BreiteRechteck { get; set; }
    public double HoeheRechteck { get; set; }

    /// <summary>
    /// Konstruktor der Subklasse Rechteck
    /// </summary>
    /// <param name="breiterechteck">Breite des Rechtecks</param>
    /// <param name="hoeherechteck">Höhe des Rechtecks</param>
    public Rechteck(double breiterechteck, double hoeherechteck)
    {
        BreiteRechteck = breiterechteck;
        HoeheRechteck = hoeherechteck;
    }

    /// <summary>
    /// Überschreiben der Berechnung der Fläche von der Hauptklasse
    /// </summary>
    /// <returns>Es wird die berechnete Fläche zurückgegeben.</returns>
    public override double BerechneFlaeche()
    {
        return BreiteRechteck * HoeheRechteck;
    }

    /// <summary>
    /// Überschreiben der Berechnung des Umfangs von der Hauptklasse
    /// </summary>
    /// <returns>Es wird der berechnete Umfang zurückgegeben.</returns>
    public override double BerechneUmfang()
    {
        return 2 * (BreiteRechteck + HoeheRechteck);
    }
}

/// <summary>
/// Subklasse Dreieck, Vererbung von Hauptklasse
/// </summary>
sealed class Dreieck : GeometrischeFigur
{
    /// <summary>
    /// Definition der Properties
    /// </summary>
    public double SeiteA { get; set; }
    public double SeiteB { get; set; }
    public double SeiteC { get; set; }

    /// <summary>
    /// Konstruktor der Subkklasse Dreieck
    /// </summary>
    /// <param name="a">Seite A des Dreiecks</param>
    /// <param name="b">Seite B des Dreiecks</param>
    /// <param name="c">Seite C des Dreiscks</param>
    public Dreieck(double a, double b, double c)
    {
        SeiteA = a;
        SeiteB = b;
        SeiteC = c;
    }

    /// <summary>
    /// Überschreiben der Berechnung der Fläche von der Hauptklasse
    /// </summary>
    /// <returns>Es wird die berechnete Fläche zurückgegeben.</returns>
    public override double BerechneFlaeche()
    {
        double s = (SeiteA + SeiteB + SeiteC) / 2;
        return Math.Sqrt(s * (s - SeiteA) * (s - SeiteB) * (s - SeiteC));
    }

    /// <summary>
    /// Überschreiben der Berechnung des Umfangs von der Hauptklasse
    /// </summary>
    /// <returns>Es wird der berechnete Umfang zurückgegeben.</returns>
    public override double BerechneUmfang()
    {
        return SeiteA + SeiteB + SeiteC;
    }
}

/// <summary>
/// Subklasse Quadrat, Vererbung von Hauptklasse
/// </summary>
sealed class Quadrat : GeometrischeFigur
{
    /// <summary>
    /// Definition der Properties
    /// </summary>
    public double SeitenlaengeQuadrat { get; set; }

    /// <summary>
    /// Konstruktor der Subklasse Quadrat
    /// </summary>
    /// <param name="seitenlaengequadrat">Die Seitenlänge des Quadrats</param>
    public Quadrat(double seitenlaengequadrat)
    {
        SeitenlaengeQuadrat = seitenlaengequadrat;
    }

    /// <summary>
    /// Überschreiben der Berechnung der Fläche von der Hauptklasse
    /// </summary>
    /// <returns>Es wird die berechnete Fläche zurückgegeben.</returns>
    public override double BerechneFlaeche()
    {
        return SeitenlaengeQuadrat * SeitenlaengeQuadrat;
    }

    /// <summary>
    /// Überschreiben der Berechnung des Umfangs von der Hauptklasse
    /// </summary>
    /// <returns>Es wird der berechnete Umfang zurückgegeben.</returns>
    public override double BerechneUmfang()
    {
        return 4 * SeitenlaengeQuadrat;
    }
}
