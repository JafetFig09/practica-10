using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace practicas
{
    public class Arreglo
    {


        public void ArregloCuadrado(int numero, ListBox listBox)
        {
            int[,] arreglo = new int[numero, numero];


            for (int i = 0; i < numero; i++)
            {
                for (int j = 0; j < numero; j++)
                {
                    arreglo[i, j] = (i == j) ? 1 : 0;
                }

            }


            //for (int i = 0;i < numero; i++)
            //{
            //    arreglo[i, i] = 1;
            //}

            listBox.Items.Clear();

            for (int i = 0; i < numero; i++)
            {
                string fila = "";
                for (int j = 0; j < numero; j++)
                {
                    fila += arreglo[i, j] + "";
                }
                listBox.Items.Add(fila);
            }

        }
    }
}
