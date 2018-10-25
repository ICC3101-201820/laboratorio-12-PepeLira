using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Comidas;


namespace Lab_12
{
    public delegate void AgregarComidaDelegate(string nombre, decimal carbohidratos, decimal proteinas, decimal grasas);
    public partial class Form1 : Form
    {
        public event AgregarComidaDelegate OnAgregarComida;
        public Form1()
        {
            InitializeComponent();
        }

        private void agregarButton_Click(object sender, EventArgs e)
        {
            if (OnAgregarComida != null)
            {
                // Notificar a los suscritos
                OnAgregarComida.Invoke(nombreTextBox.Text, carbohidratosNumeric.Value, proteinasNumeric.Value, grasasNumeric.Value);
            }
        }
        public void AgregarComida(Comida comida)
        {
            listadoComidas.Items.Add(comida);
        }
    }
}
