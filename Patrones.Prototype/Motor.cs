namespace Patrones.Prototype
{
    public class Motor
    {
        public Motor(string cilindrada, int potencia)
        {
            Cilindrada = cilindrada;
            Potencia = potencia;
        }

        public string Cilindrada { get; set; }
        public int Potencia { get; set; }

        public Motor Clonar() => new Motor(Cilindrada, Potencia);

        public override string ToString() => $"{Cilindrada} ({Potencia} CV)";
    }
}
