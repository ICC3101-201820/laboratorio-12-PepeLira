using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Comidas
{
    public class Comida
    {
        string Nombre;
        decimal Carbohidratos;
        decimal Proteinas;
        decimal Grasas;

        public Comida(string Nombre, decimal carboidratos, decimal Proteinas, decimal Grasas)
        {
            this.Nombre = Nombre;
            this.Carbohidratos = carboidratos;
            this.Proteinas = Proteinas;
            this.Grasas = Grasas;
        }

        public decimal Calorias()
        {
            return 4 * Carbohidratos + 4 * Proteinas + 9 * Grasas;
        }
        public override string ToString()
        {
            return $"{Nombre} <Carbohidratos: {Carbohidratos},Proteinas: {Proteinas},Grasas: {Grasas} >";
        }

    }
}
