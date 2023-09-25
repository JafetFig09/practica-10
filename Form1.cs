using practicas;

namespace practica10
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnPintarArreglo_Click(object sender, EventArgs e)
        {

            if (int.TryParse(tbNumero.Text.Trim(), out int numero))
            {

                Arreglo arreglo = new Arreglo();

                arreglo.ArregloCuadrado(numero, listBox1);
            }
            else
            {
                MessageBox.Show("Ingrese un número");
            }

        }
    }
}