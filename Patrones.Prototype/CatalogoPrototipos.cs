using System;
using System.Collections.Generic;

namespace Patrones.Prototype
{
    public class CatalogoPrototipos
    {
        private readonly Dictionary<string, AutoPrototype> _prototipos =
            new Dictionary<string, AutoPrototype>(StringComparer.OrdinalIgnoreCase);

        public void Registrar(string nombre, AutoPrototype prototipo)
        {
            if (string.IsNullOrWhiteSpace(nombre))
                throw new ArgumentException("Debe indicar el nombre del prototipo.", nameof(nombre));
            if (prototipo == null)
                throw new ArgumentNullException(nameof(prototipo));
            _prototipos[nombre] = prototipo;
        }

        public AutoPrototype Crear(string nombre)
        {
            if (!_prototipos.TryGetValue(nombre, out AutoPrototype prototipo))
                throw new KeyNotFoundException($"No existe el prototipo '{nombre}'.");
            return prototipo.Clonar();
        }
    }
}
