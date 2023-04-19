using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Desafio1.Clases
{
    public class AVL
    {

        public Paciente pacienteValor;
        public AVL NodoIzquierdo;
        public AVL NodoDerecho;
        public AVL NodoPadre;
        public int altura;
        private DibujaAVL arbol;

        public AVL()
        {

        }

        //Constructor
        public AVL(Paciente pacienteNuevo, AVL izquierdo, AVL derecho, AVL padre)
        {
            pacienteValor = pacienteNuevo;
            NodoIzquierdo = izquierdo;
            NodoDerecho = derecho;
            NodoPadre = padre;
            altura = 0;

        }

        public DibujaAVL Arbol
        {
            get { return arbol; }
            set { arbol = value; }
        }

        //Funcion para insertar un nuevo valor en el arbol AVL
        public AVL Insertar(Paciente pacienteNuevo, AVL Raiz)
        {
            //Parte para evaluar codigoGenero
            if (Raiz == null) {
                Raiz = new AVL(pacienteNuevo, null, null, null);
            }
            else if (pacienteNuevo.codDibujo < Raiz.pacienteValor.codDibujo)
            {
                Raiz.NodoIzquierdo = Insertar(pacienteNuevo, Raiz.NodoIzquierdo);
            }
            else if (pacienteNuevo.codDibujo > Raiz.pacienteValor.codDibujo)
            {
                Raiz.NodoDerecho = Insertar(pacienteNuevo, Raiz.NodoDerecho);
            }

            return Raiz;
        }

        //FUNCION DE PRUEBA PARA REALIZAR LAS ROTACIONES

        //Función para obtener que rama es mayor
        private static int max(int lhs, int rhs)
        {
            return lhs > rhs ? lhs : rhs;
        }

        private static int Alturas(AVL Raiz)
        {
            return Raiz == null ? -1 : Raiz.altura;
        }

        AVL nodoE, nodoP;

        //public AVL Eliminar(int codigoEliminar, ref AVL Raiz)
        //{
        //    if (Raiz != null)
        //    {
        //        if (codigoEliminar < Raiz.valor)
        //        {
        //            nodoE = Raiz;
        //            Eliminar(codigoEliminar, ref Raiz.NodoIzquierdo);
        //        }
        //        else
        //        {
        //            if (codigoEliminar > Raiz.valor)
        //            {
        //                nodoE = Raiz;
        //                Eliminar(codigoEliminar, ref Raiz.NodoDerecho);
        //            }
        //            else
        //            {
        //                //Posicionando sobre el elemento a eliminar

        //                AVL NodoEliminar = Raiz;
        //                if (NodoEliminar.NodoDerecho == null)
        //                {
        //                    Raiz = NodoEliminar.NodoIzquierdo;

        //                    if (Alturas(nodoE.NodoIzquierdo) - Alturas(nodoE.NodoDerecho) == 2)
        //                    {
        //                        //MesageBox.Show("nodoE" + nodoE.valor.ToString());
        //                        if (codigoEliminar < nodoE.valor)
        //                            nodoP = RotacionIzquierdaSimple(nodoE);
        //                        else
        //                            nodoE = RotacionDerechaSimple(nodoE);
        //                    }

        //                    if (Alturas(nodoE.NodoDerecho) - Alturas(nodoE.NodoIzquierdo) == 2)
        //                    {
        //                        if (codigoEliminar > nodoE.NodoDerecho.valor)
        //                            nodoE = RotacionDerechaSimple(nodoE);
        //                        else
        //                            nodoE = RotacionDerechaDoble(nodoE);
        //                        nodoP = RotacionDerechaSimple(nodoE);
        //                    }
        //                }

        //                else
        //                {
        //                    if (NodoEliminar.NodoIzquierdo == null)
        //                    {
        //                        Raiz = NodoEliminar.NodoDerecho;
        //                    }
        //                    else
        //                    {
        //                        if (Alturas(Raiz.NodoIzquierdo) - Alturas(Raiz.NodoDerecho) > 0)
        //                        {
        //                            AVL AuxiliarNodo = null;
        //                            AVL Auxiliar = Raiz.NodoIzquierdo;
        //                            bool Bandera = false;
        //                            while (Auxiliar.NodoDerecho != null)
        //                            {
        //                                AuxiliarNodo = Auxiliar;
        //                                Auxiliar = Auxiliar.NodoDerecho;
        //                                Bandera = true;
        //                            }
        //                            Raiz.valor = Auxiliar.valor;
        //                            NodoEliminar = Auxiliar;
        //                            if (Bandera == true)
        //                            {
        //                                AuxiliarNodo.NodoDerecho = Auxiliar.NodoIzquierdo;
        //                            }
        //                            else
        //                            {
        //                                Raiz.NodoIzquierdo = Auxiliar.NodoIzquierdo;
        //                            }
        //                            //Realiza las rotaciones simples o dobles segun el caso
        //                        }
        //                        else
        //                        {
        //                            if (Alturas(Raiz.NodoDerecho) - Alturas(Raiz.NodoIzquierdo) > 0)
        //                            {
        //                                AVL AuxiliarNodo = null;
        //                                AVL Auxiliar = Raiz.NodoDerecho;
        //                                bool Bandera = false;
        //                                while (Auxiliar.NodoIzquierdo != null)
        //                                {
        //                                    AuxiliarNodo = Auxiliar;
        //                                    Auxiliar = Auxiliar.NodoIzquierdo;
        //                                    Bandera = true;
        //                                }
        //                                Raiz.valor = Auxiliar.valor;
        //                                NodoEliminar = Auxiliar;
        //                                if (Bandera == true)
        //                                {
        //                                    AuxiliarNodo.NodoIzquierdo = Auxiliar.NodoDerecho;
        //                                }
        //                                else
        //                                {
        //                                    Raiz.NodoDerecho = Auxiliar.NodoDerecho;
        //                                }
        //                            }
        //                            else
        //                            {
        //                                if (Alturas(Raiz.NodoDerecho) - Alturas(Raiz.NodoIzquierdo) == 0)
        //                                {
        //                                    AVL AuxiliarNodo = null;
        //                                    AVL Auxiliar = Raiz.NodoIzquierdo;
        //                                    bool Bandera = false;
        //                                    while (Auxiliar.NodoDerecho != null)
        //                                    {
        //                                        AuxiliarNodo = Auxiliar;
        //                                        Auxiliar = Auxiliar.NodoDerecho;
        //                                        Bandera = true;
        //                                    }
        //                                    Raiz.valor = Auxiliar.valor;
        //                                    NodoEliminar = Auxiliar;
        //                                    if (Bandera == true)
        //                                    {
        //                                        AuxiliarNodo.NodoDerecho = Auxiliar.NodoIzquierdo;
        //                                    }
        //                                    else
        //                                    {
        //                                        Raiz.NodoIzquierdo = Auxiliar.NodoIzquierdo;
        //                                    }
        //                                }
        //                            }
        //                        }
        //                    }
        //                }

        //            }
        //        }
        //    }
        //    else
        //    {
        //        MessageBox.Show("Nodo inexistente en el arbol", "Error", MessageBoxButtons.OK);
        //    }

        //    return nodoP;
        //}

        //Seccion de funciones de rotaciones

        //Rotacion Izquierda Simple
        private static AVL RotacionIzquierdaSimple(AVL k2)
        {
            AVL k1 = k2.NodoIzquierdo;
            k2.NodoIzquierdo = k1.NodoDerecho;
            k1.NodoDerecho = k2;
            k2.altura = max(Alturas(k2.NodoIzquierdo), Alturas(k2.NodoDerecho)) + 1;
            k1.altura = max(Alturas(k1.NodoIzquierdo), k2.altura) + 1;
            MessageBox.Show("Paso realizado: rotacion izquierda simple", "Pasos", MessageBoxButtons.OK);
            return k1;
        }

        //Rotacion derecha simple
        private static AVL RotacionDerechaSimple(AVL k1)
        {
            AVL k2 = k1.NodoDerecho;
            k1.NodoDerecho = k2.NodoIzquierdo;
            k2.NodoIzquierdo = k1;
            k1.altura = max(Alturas(k1.NodoIzquierdo), Alturas(k1.NodoDerecho)) + 1;
            k2.altura = max(Alturas(k2.NodoDerecho), k1.altura) + 1;
            MessageBox.Show("Paso realizado: rotacion derecha simple", "Pasos", MessageBoxButtons.OK);
            return k2;
        }

        //Doble Rotacion Izquierda
        private static AVL RotacionIzquierdaDoble(AVL k3)
        {
            k3.NodoIzquierdo = RotacionDerechaSimple(k3.NodoIzquierdo);
            MessageBox.Show("Paso realizado: rotacion izquierda doble", "Pasos", MessageBoxButtons.OK);
            return RotacionDerechaSimple(k3);
        }
        //Doble Rotacion Derecha
        private static AVL RotacionDerechaDoble(AVL k1)
        {
            k1.NodoDerecho = RotacionIzquierdaSimple(k1.NodoDerecho);
            MessageBox.Show("Paso realizado: rotacion derecha doble", "Pasos", MessageBoxButtons.OK);
            return RotacionDerechaSimple(k1);
        }

        //Funcion para obtener la altura del arbol
        public int getAltura(AVL nodoActual)
        {
            if (nodoActual == null)
                return 0;
            else
                return 1 + Math.Max(getAltura(nodoActual.NodoIzquierdo), getAltura(nodoActual.NodoDerecho));
        }




        //Buscar una valor en el arbol
        //public void buscar(int codigoBuscar, AVL Raiz)
        //{
        //    if (Raiz != null)
        //    {
        //        if (codigoBuscar < Raiz.valor)
        //        {
        //            buscar(codigoBuscar, Raiz.NodoIzquierdo);
        //        }
        //        else
        //        {
        //            if (codigoBuscar > Raiz.valor)
        //            {
        //                buscar(codigoBuscar, Raiz.NodoDerecho);
        //            }
        //        }
        //    }
        //    else
        //    {
        //        MessageBox.Show("Valor no encontrado", "Error", MessageBoxButtons.OK);
        //    }

        //}

        /*++++++++++++++FUNCIONES PARA DIBUJAR EL ÁRBOL++++++++++++++*/
        private const int Radio = 120;
        private const int DistanciaH = 40;
        private const int DistanciaV = 10;

        private int CoordenadaX;
        private int CoordenadaY;

        //Encuentra la posición en donde debe crearse el nodo
        public void PosicionNodo(ref int xmin, int ymin)
        {
            int aux1, aux2;

            CoordenadaY = (int)(ymin + Radio / 2);

            //obtiene la posición del Sub-Árbol izquierdo
            if (NodoIzquierdo != null)
            {
                NodoIzquierdo.PosicionNodo(ref xmin, ymin + Radio + DistanciaV);
            }
            if ((NodoIzquierdo != null) && (NodoDerecho != null))
            {
                xmin += DistanciaH;
            }

            //Si existe el nodo derecho e izquierdo deja un espacio entre ellos.

            if (NodoDerecho != null)
            {
                NodoDerecho.PosicionNodo(ref xmin, ymin + Radio + DistanciaV);
            }
            //Posicion de nodos derecho e izquierdo
            if (NodoIzquierdo != null)
            {
                if (NodoDerecho != null)
                {
                    //centro entre los nodos
                    CoordenadaX = (int)((NodoIzquierdo.CoordenadaX + NodoDerecho.CoordenadaX) / 2);
                }
                else
                {
                    //no hay nodo derecho. centrar al nodo izquierdo
                    aux1 = NodoIzquierdo.CoordenadaX;
                    NodoIzquierdo.CoordenadaX = CoordenadaX - 40;
                    CoordenadaX = aux1;
                }
            }
            else if (NodoDerecho != null)
            {
                aux2 = NodoDerecho.CoordenadaX;
                // no hay nodo izquierdo.centrar al nodo derecho
                NodoDerecho.CoordenadaX = CoordenadaX + 40;
                CoordenadaX = aux2;
            }
            else
            {
                //nodo hoja
                CoordenadaX = (int)(xmin + Radio / 2);
                xmin += Radio;
            }
        }

        //Dibuja las ramas de los nodos izquierdo y derecho
        public void DibujarRamas(Graphics grafo, Pen Lapiz)
        {
            if (NodoIzquierdo != null)
            {
                grafo.DrawLine(Lapiz, CoordenadaX, CoordenadaY, NodoIzquierdo.CoordenadaX, NodoIzquierdo.CoordenadaY);
                NodoIzquierdo.DibujarRamas(grafo, Lapiz);
            }
            if (NodoDerecho != null)
            {
                grafo.DrawLine(Lapiz, CoordenadaX, CoordenadaY, NodoDerecho.CoordenadaX, NodoDerecho.CoordenadaY);
                NodoDerecho.DibujarRamas(grafo, Lapiz);
            }

        }


        //Dibuja el nodo en la posicion especificada
        public void DibujarNodo(Graphics grafo, Font fuente, Brush Relleno, Brush RellenoFuente, Pen Lapiz, Paciente pacienteDato, Brush encuentro)
        {
            //Dibuja el contorno del nodo
            Rectangle rect = new Rectangle((int)(CoordenadaX - Radio / 2), (int)(CoordenadaY - Radio / 2), Radio, Radio);
            if (pacienteValor.codDibujo == pacienteDato.codDibujo)
            {
                grafo.FillEllipse(encuentro, rect);
            } 
            else
            {
                grafo.FillEllipse(encuentro, rect);
                grafo.FillEllipse(Relleno, rect);
            }
            //grafo.DrawEllipse(Lapiz, rect);

            //Dibujar el valor del nodo
            StringFormat formato = new StringFormat();

            formato.Alignment = StringAlignment.Center;
            formato.LineAlignment = StringAlignment.Center;
            grafo.DrawString(pacienteValor.nombre, fuente, Brushes.Black, CoordenadaX, CoordenadaY, formato);

            //Dibuja los nodos hijos derecho e izquierdo

            if (NodoIzquierdo != null)
            {
                NodoIzquierdo.DibujarNodo(grafo, fuente, Brushes.YellowGreen, RellenoFuente, Lapiz, pacienteDato, encuentro);
            }

            if (NodoDerecho != null)
            {
                NodoDerecho.DibujarNodo(grafo, fuente, Brushes.Yellow, RellenoFuente, Lapiz, pacienteDato, encuentro);
            }
            //Colocamos a cada nodo su factor de balanceo
            //grafo.DrawString((Alturas(NodoDerecho) - Alturas(NodoIzquierdo)).ToString(), fuente, Brushes.Black, CoordenadaX + 20, CoordenadaY + 10, formato);

        }

        public void colorear(Graphics grafo, Font fuente, Brush Relleno, Brush RellenoFuente, Pen Lapiz)
        {
            //Dibuja el contorno del nodo
            Rectangle rect = new Rectangle((int)(CoordenadaX - Radio / 2), (int)(CoordenadaY - Radio / 2), Radio, Radio);

            //Dibuja el nombre
            StringFormat formato = new StringFormat();

            formato.Alignment = StringAlignment.Center;
            formato.LineAlignment = StringAlignment.Center;

            grafo.DrawEllipse(Lapiz, rect);
            grafo.FillEllipse(Brushes.PaleVioletRed, rect);
            grafo.DrawString(pacienteValor.codDibujo.ToString().ToString(), fuente, Brushes.Black, CoordenadaX, CoordenadaY, formato);
        }

    }
}
