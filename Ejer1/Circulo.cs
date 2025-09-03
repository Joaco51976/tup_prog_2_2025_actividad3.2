using System;
using Ejer1;

public class Circulo : IFigura, IComparable
{
    public double Radio { get; }

    public Circulo(double radio)
    {
        Radio = radio;
    }

    public double CalcularArea()
    {
        return Math.PI * Radio * Radio;
    }

    public double CalcularPerimetro()
    {
        return 2 * Math.PI * Radio;
    }

    public int CompareTo(object obj)
    {
        IFigura otra = obj as IFigura;
        if (otra == null) return 0;
        return CalcularArea().CompareTo(otra.CalcularArea());
    }

    public override string ToString()
    {
        return $"Círculo {CalcularArea():0.00}";
    }
}