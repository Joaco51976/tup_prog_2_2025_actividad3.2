using System;
using Ejer1;

public class Rectangulo : IFigura, IComparable
{
    public double Largo { get; set; }
    public double Ancho { get; set; }

    public Rectangulo(double largo, double ancho)
    {
        Largo = largo;
        Ancho = ancho;
    }

    public double CalcularArea()
    {
        return Largo * Ancho;
    }

    public double CalcularPerimetro()
    {
        return 2 * (Largo + Ancho);
    }

    public int CompareTo(object obj)
    {
        IFigura otra = obj as IFigura;
        if (otra == null) return 0;
        return CalcularArea().CompareTo(otra.CalcularArea());
    }

    public override string ToString()
    {
        return $"Cuadrado {CalcularArea():0.00}";
    }
}