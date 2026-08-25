using System.Collections.Generic;

namespace Patrones.Prototype
{
    public abstract class AutoPrototype
    {
        public string Color { get; set; }
        public string Modelo { get; set; }
        public Motor Motor { get; set; }
        public List<string> Equipamiento { get; set; } = new List<string>();

        protected abstract string Marca { get; }

        // Conserva las referencias a los objetos mutables.
        public AutoPrototype ClonarSuperficial()
        {
            return (AutoPrototype)MemberwiseClone();
        }

        // También copia los objetos mutables del auto.
        public AutoPrototype Clonar()
        {
            AutoPrototype clon = (AutoPrototype)MemberwiseClone();
            clon.Motor = Motor?.Clonar();
            clon.Equipamiento = Equipamiento == null
                ? new List<string>()
                : new List<string>(Equipamiento);
            return clon;
        }

        public override string ToString()
        {
            string equipamiento = Equipamiento == null ? "sin equipamiento" : string.Join(", ", Equipamiento);
            return $"{Marca} {Modelo}, color {Color}, motor {Motor}, equipamiento: {equipamiento}";
        }
    }
}
