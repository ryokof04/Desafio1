using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Desafio1.Clases
{
    public class DibujaAVL
    {
        // rcfq- 10 - esto viene de Clases\AVL.cs
        public AVL Raiz;
        public AVL aux;


        //constructor
        public DibujaAVL()
        {
            aux = new AVL();

        }

        public DibujaAVL(AVL RaizNueva)
        {
            Raiz = RaizNueva;
        }



        //Agregua un nuevo valor al arbol

        public void Insertar(Paciente pacienteNuevo)
        {
            if (Raiz == null)
                Raiz = new AVL(pacienteNuevo, null, null, null);
            else {
                Raiz = Raiz.Insertar(pacienteNuevo, Raiz);
            }
        }

        //Eliminar un valor del arbol
        //public void Eliminar(int codigoEliminar)
        //{
        //    if (Raiz == null)
        //        Raiz = new AVL(codigoEliminar, null, null, null);
        //    else
        //        Raiz.Eliminar(codigoEliminar, ref Raiz);
        //}

        private const int Radio = 30;
        private const int DistanciaH = 40;
        private const int DistanciaV = 10;

        private int CoordenadaX;
        private int CoordenadaY;

        public void PosicionNodorecorrido(ref int xmin, ref int ymin)
        {
            CoordenadaY = (int)(ymin + Radio / 2);
            CoordenadaX = (int)(xmin + Radio / 2);
            xmin += Radio;
        }

        public void colorear(Graphics grafo, Font fuente, Brush Relleno, Brush RellenoFuente, Pen Lapiz, AVL Raiz, bool post, bool inor, bool preor)
        {
            Brush entorno = Brushes.Red;

            //if (inor == true)
            //{
                if (Raiz != null)
                {
                    colorear(grafo, fuente, Brushes.Blue, RellenoFuente, Lapiz, Raiz.NodoIzquierdo, false, false, false);
                    Raiz.colorear(grafo, fuente, entorno, RellenoFuente, Lapiz);
                    Thread.Sleep(500);
                    Raiz.colorear(grafo, fuente, Relleno, RellenoFuente, Lapiz);
                    Thread.Sleep(500);
                    Raiz.colorear(grafo, fuente, Relleno, RellenoFuente, Lapiz);
                    colorear(grafo, fuente, Relleno, RellenoFuente, Lapiz, Raiz.NodoDerecho, false, false, false);
                }
            //}
            //else if (preor == true)
            //{
            //    if (Raiz != null)
            //    {
            //        Raiz.colorear(grafo, fuente, Brushes.Yellow, Brushes.Blue, Pens.Black);
            //        Thread.Sleep(500);
            //        Raiz.colorear(grafo, fuente, Brushes.White, Brushes.Black, Pens.Black);
            //        colorear(grafo, fuente, Brushes.Blue, RellenoFuente, Lapiz, Raiz.NodoDerecho, post, inor, preor);
            //        colorear(grafo, fuente, Relleno, RellenoFuente, Lapiz, Raiz.NodoDerecho, post, inor, preor);
            //    }
            //}
            //else if (post == true)
            //{
            //    if (Raiz != null)
            //    {
            //        colorear(grafo, fuente, Relleno, RellenoFuente, Lapiz, Raiz.NodoIzquierdo, post, inor, preor);
            //        colorear(grafo, fuente, Relleno, RellenoFuente, Lapiz, Raiz.NodoDerecho, post, inor, preor);
            //        Raiz.colorear(grafo, fuente, entorno, RellenoFuente, Lapiz);
            //        Thread.Sleep(500);
            //        Raiz.colorear(grafo, fuente, entorno, RellenoFuente, Lapiz);
            //    }
            //}
        }

        //public void colorearB(Graphics grafo, Font fuente, Brush Relleno, Brush RellenoFuente, Pen Lapiz, AVL Raiz, int codigoBusqueda)
        //{
        //    Brush entorno = Brushes.Red;
        //    if (Raiz != null)
        //    {
        //        Raiz.colorear(grafo, fuente, entorno, RellenoFuente, Lapiz);

        //        if (codigoBusqueda < Raiz.valor)
        //        {
        //            Thread.Sleep(500);
        //            Raiz.colorear(grafo, fuente, entorno, Brushes.Blue, Lapiz);
        //            colorearB(grafo, fuente, Relleno, RellenoFuente, Lapiz, Raiz.NodoIzquierdo, codigoBusqueda);
        //        }
        //        else
        //        {
        //            if (codigoBusqueda > Raiz.valor)
        //            {
        //                Thread.Sleep(500);
        //                Raiz.colorear(grafo, fuente, entorno, RellenoFuente, Lapiz);
        //                colorearB(grafo, fuente, Relleno, RellenoFuente, Lapiz, Raiz.NodoDerecho, codigoBusqueda);
        //            }
        //            else
        //            {
        //                Raiz.colorear(grafo, fuente, entorno, RellenoFuente, Lapiz);
        //                Thread.Sleep(500);
        //            }
        //        }
        //    }
        //}

        //Dibuja el árbol
        public void DibujarArbol(Graphics grafo, Font fuente, Brush Relleno, Brush RellenoFuente, Pen Lapiz, Paciente pacienteDato, Brush encuentro)
        {
            int x = 40;
            int y = 65;

            if (Raiz == null) return;

            //Posicion de todos los nodos
            Raiz.PosicionNodo(ref x, y);

            //Dibuja los Enlaces entre nodos
            Raiz.DibujarRamas(grafo, Lapiz);

            //Dibuja todos los Nodos
            Raiz.DibujarNodo(grafo, fuente, Relleno, RellenoFuente, Lapiz, pacienteDato , encuentro);

        }

        public int x1 = 100;
        public int y2 = 75;

        public void restablecer_valores()
        {
            x1 = 100;
            y2 = 75;
        }

        //public void buscar(int codigoBuscar)
        //{
        //    if (Raiz == null)
        //        MessageBox.Show("Arbol AVL Vacío", "Error", MessageBoxButtons.OK);
        //    else
        //        Raiz.buscar(codigoBuscar, Raiz);
        //}

        // Retornamos recorrido en pre-orden del arbol
        //public String RecorrerPreOrden()
        //{
        //    if (Raiz == null) return "El arbol esta vacio";
        //    return Raiz.RecorridoPreOrden();
        //}

        //Retornamos recorrido en Post-orden
        //public String RecorrerPostOrden()
        //{
        //    if (Raiz == null) return "El arbol esta vacio";
        //    return Raiz.RecorridoPostOrden();
        //}

        // Retornamos recorrido en In-Orden
        //public String RecorrerInOrden()
        //{
        //    if (Raiz == null) return "El arbol esta vacio";
        //    return Raiz.RecorridoInOrden();
        //}

    }
}
