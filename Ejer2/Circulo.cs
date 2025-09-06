using System;

public class Circulo : Figuras, IComparable
{
    public double Radio { get; }

    public Circulo(double radio) { Radio = radio; }

    public override double CalcularArea() => Math.PI * Radio * Radio;
    public override double CalcularPerimetro() => 2 * Math.PI * Radio;

    public int CompareTo(object obj)
    {
        Figura otra = obj as Figura;
        if (otra == null) throw new ArgumentException("No es una Figura");
        return this.CalcularArea().CompareTo(otra.CalcularArea());
    }

    public override string ToString() =>
        $"Círculo - Área: {CalcularArea():0.00}, Perímetro: {CalcularPerimetro():0.00}";
}