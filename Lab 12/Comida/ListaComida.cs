﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Comidas
{
    public class ListaComida
    {
        List<Comida> comidas;

        public void Agregar(Comida comida)
        {
            comidas.Add(comida);
        }
        public void Eliminar(Comida comida)
        {
            comidas.Remove(comida);
        }
    }
}
