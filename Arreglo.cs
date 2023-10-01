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


        public static void resultado(decimal[,] matriz, ListBox listBox)
        {
            int filas = matriz.GetLength(0);
            int columnas = matriz.GetLength(1);
            listBox.Items.Clear(); // Limpiamos el ListBox antes de agregar nuevos elementos
            for (int i = 0; i < filas; i++)
            {
                string fila = "";
                for (int j = 0; j < columnas; j++)
                {
                    fila += $"{Math.Round(matriz[i, j], 0)}\t";
                }
                listBox.Items.Add(fila);
            }
        }
        public void GaussJordan(int size, ListBox listBox)
        {
            if (size == 0)
            {
                return;
            }

            decimal[,] Matrizgauss = new decimal[size, size];

            for (int i = 0; i < size; i++)
            {
                for (int x = 0; x < size; x++)
                {
                    string input = Microsoft.VisualBasic.Interaction.InputBox($"Ingrese posición [{i}, {x}]:", "Ingresar valor");
                    if (decimal.TryParse(input, out Matrizgauss[i, x]))
                    {
                        // Agregar el valor al ListBox
                        listBox.Items.Add($"[{i}, {x}]: {Matrizgauss[i, x]}");
                    }
                    else
                    {
                        MessageBox.Show("Número inválido. Inténtelo de nuevo.");
                        x--;
                    }
                }
            }

          

            for (int k = 0; k < size; k++)
            {
                if (Matrizgauss[k, k] == 0)
                {
                    MessageBox.Show("El pivote es 0, no se puede continuar.");
                    return;
                }

                decimal pivote = Matrizgauss[k, k];
                MessageBox.Show($"Paso {k + 1}: Dividir la fila {k} por {pivote}");
                for (int j = 0; j < size; j++)
                {
                    Matrizgauss[k, j] /= pivote;
                }
          

                for (int i = 0; i < size; i++)
                {
                    if (i != k)
                    {
                        decimal factor = Matrizgauss[i, k];
                        MessageBox.Show($"Paso {k + 1}: Restar {factor} veces la fila {k} de la fila {i}");
                        for (int j = 0; j < size; j++)
                        {
                            Matrizgauss[i, j] -= factor * Matrizgauss[k, j];
                        }
                       
                    }
                }
            }


            resultado(Matrizgauss, listBox);
        }



    }
}
