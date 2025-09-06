using System;

namespace Ejer2
{
    public class Rectangulo : Figuras, IComparable { }
}

public class Rectangulo : Figura, IComparable
{
    public double Largo { get; }
    public double Ancho { get; }

    public Rectangulo(double largo, double ancho)
    {
        Largo = largo;
        Ancho = ancho;
    }

    public override double CalcularArea() => Largo * Ancho;
    public override double CalcularPerimetro() => 2 * (Largo + Ancho);

    public int CompareTo(object obj)
    {
        Figura otra = obj as Figura;
        if (otra == null) throw new ArgumentException("No es una Figura");
        return this.CalcularArea().CompareTo(otra.CalcularArea());
    }

    public override string ToString() =>
        $"Rectángulo - Área: {CalcularArea()}, Perímetro: {CalcularPerimetro()}";
}