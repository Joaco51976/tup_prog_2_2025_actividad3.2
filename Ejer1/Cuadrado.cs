public class Cuadrado : Rectangulo
{
    public Cuadrado(double lado) : base(lado, lado) { }

    public override string ToString()
    {
        return $"Cuadrado {CalcularArea():0.00}";
    }
}