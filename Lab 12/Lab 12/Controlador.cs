using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Comidas;

namespace Lab_12
{
    class Controlador
    {
        public Form1 form1;
        private ListaComida comidas;

        public Controlador()
        {
            comidas = new ListaComida();
        }

        public void OnAgregarComida(string nombre, decimal carbohidratos, decimal proteinas, decimal grasas)
        {
            Comida comida = new Comida(nombre, carbohidratos, proteinas, grasas);
            comidas.Agregar(comida);
            form1.AgregarComida(comida);
        }
    }
}
