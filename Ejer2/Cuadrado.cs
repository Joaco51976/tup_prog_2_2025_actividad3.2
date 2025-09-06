public class Cuadrado : Rectangulo
{
    public Cuadrado(double lado) : base(lado, lado) { }

    public override string ToString() =>
        $"Cuadrado - Área: {CalcularArea()}, Perímetro: {CalcularPerimetro()}";
}