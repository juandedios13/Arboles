using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Arboles
{
    class Arbol
    {
        //public static Nodo Raiz;

        //public bool IsEmpty()
        //{
        //    if (Raiz == null)
        //    {
        //        return true;
        //    }
        //    return false;
        //}

        //public Nodo Insertar(Nodo Raiz1, int Dato)
        //{
        //    if (Raiz1 == null)
        //    {
        //        Raiz1 = new Nodo(Dato);
        //        Raiz1.Nivel++;
        //    }
        //    else
        //    {
        //        if (Dato < Raiz1.Dato)
        //        {
        //            Insertar(Raiz1.Izquierdo, Dato);
        //        }
        //        else if (Dato > Raiz1.Dato)
        //        {
        //            Insertar(Raiz1.Derecho, Dato);
        //        }
        //        else
        //        {
        //            Console.WriteLine("Error");
        //        }
        //    }
        //    if (Raiz1.Nivel == 1)
        //    {
        //        return Raiz;
        //    }
        //    return Raiz;
        //}

        //private static int Alturas(Nodo Raiz)
        //{
        //    return Raiz == null ? -1 : Raiz.Altura;
        //}


        //public void Eliminarnodo(Nodo Raiz,int Dato)
        //{
        //    if (!IsEmpty())
        //    {
        //        if (Dato<Raiz.Dato)
        //        {
        //            Eliminarnodo(Raiz.Izquierdo, Dato);
        //        }
        //        else
        //        {
        //            if (Dato>Raiz.Dato)
        //            {
        //                Eliminarnodo(Raiz.Derecho, Dato);
        //            }
        //            else
        //            {
        //                Nodo NodoEliminar = Raiz;
        //                if (NodoEliminar.Derecho==null)
        //                {
        //                    Raiz = NodoEliminar.Izquierdo;
        //                }
        //                else
        //                {
        //                    if (NodoEliminar.Izquierdo==null)
        //                    {
        //                        Raiz = NodoEliminar.Derecho;
        //                    }
        //                    else
        //                    {
        //                        if (Alturas(Raiz.Izquierdo)-Alturas(Raiz.Derecho)>0)
        //                        {
        //                            Nodo auxiliarNodo = null;
        //                            Nodo auxiliar = Raiz.Izquierdo;
        //                            bool Bandera = false;
        //                            while (auxiliar.Derecho!=null)
        //                            {
        //                                auxiliarNodo = auxiliar;
        //                                auxiliar = auxiliar.Derecho;
        //                                Bandera = true;
        //                            }
        //                            Raiz.Dato = auxiliar.Dato;
        //                            NodoEliminar = auxiliar;
        //                            if (Bandera==true)
        //                            {
        //                                auxiliarNodo.Derecho = auxiliar.Izquierdo;
        //                            }
        //                            else
        //                            {
        //                                Raiz.Izquierdo = auxiliar.Izquierdo;
        //                            }
        //                        }
        //                        else
        //                        {
        //                            if (Alturas(Raiz.Derecho)-Alturas(Raiz.Izquierdo)>0)
        //                            {
        //                                Nodo auxiliarNodo = null;
        //                                Nodo auxiliar = Raiz.Derecho;
        //                                bool Bandera = false;
        //                                while (auxiliar.Izquierdo!=null)
        //                                {
        //                                    auxiliarNodo = auxiliar;
        //                                    auxiliar = auxiliar.Izquierdo;
        //                                    Bandera = true;
        //                                }
        //                                Raiz.Dato = auxiliar.Dato;
        //                                NodoEliminar = auxiliar;
        //                                if (Bandera == true)
        //                                {
        //                                    auxiliarNodo.Izquierdo = auxiliar.Derecho;
        //                                }
        //                                else
        //                                {
        //                                    Raiz.Derecho = auxiliar.Derecho;
        //                                }
        //                            }
        //                            else
        //                            {
        //                                if (Alturas(Raiz.Derecho)-Alturas(Raiz.Izquierdo)==0)
        //                                {
        //                                    Nodo auxiliarNodo = null;
        //                                    Nodo auxiliar = Raiz.Derecho;
        //                                    bool Bandera = false;
        //                                    while (auxiliar.Derecho!=null)
        //                                    {
        //                                        auxiliarNodo = auxiliar;
        //                                        auxiliar = auxiliar.Derecho;
        //                                        Bandera = true;
        //                                    }
        //                                    Raiz.Dato = auxiliar.Dato;
        //                                    NodoEliminar = auxiliar;
        //                                    if (Bandera==true)
        //                                    {
        //                                        auxiliarNodo.Derecho = auxiliar.Izquierdo;
        //                                    }
        //                                    else
        //                                    {
        //                                        Raiz.Izquierdo = auxiliar.Izquierdo;
        //                                    }
        //                                }
        //                            }
        //                        }
        //                    }
        //                }
        //            }

        //        }


        //    }

        //}

        //public Nodo Actualizar(Nodo Raiz1, int Dato, int Dato_Nuevo)
        //{
        //    if (Raiz1 == null)
        //    {
        //        if (Dato < Raiz1.Dato)
        //        {
        //            Insertar(Raiz1.Izquierdo, Dato);
        //        }
        //        else if (Dato > Raiz1.Dato)
        //        {
        //            Insertar(Raiz1.Derecho, Dato);
        //        }
        //        else
        //        {
        //            Raiz1.Dato = Dato_Nuevo;
        //        }
        //    }
        //    return Raiz1;
        //}
        Nodo raiz;
        public int gobla;

        public Arbol()
        {
            raiz = null;
        }

        public void Insertar(int info)
        {
            gobla = info;
            Nodo nuevo;
            nuevo = new Nodo(info);
            nuevo.Dato = info;
            nuevo.Izquierdo = null;
            nuevo.Derecho = null;
            if (raiz == null)
                raiz = nuevo;
            else
            {
                Nodo anterior = null, reco;
                reco = raiz;
                while (reco != null)
                {
                    anterior = reco;
                    if (info < reco.Dato)
                        reco = reco.Izquierdo;
                    else
                        reco = reco.Derecho;
                }
                if (info < anterior.Dato)
                    anterior.Izquierdo = nuevo;
                else
                    anterior.Derecho = nuevo;
            }
        }


        private void ImprimirPre(Nodo reco)
        {
            if (reco != null)
            {
                Console.Write(reco.Dato + " ");
                ImprimirPre(reco.Izquierdo);
                ImprimirPre(reco.Derecho);
            }
        }

        public void ImprimirPre()
        {
            ImprimirPre(raiz);
            Console.WriteLine();
        }

        private void ImprimirEntre(Nodo reco)
        {
            if (reco != null)
            {
                ImprimirEntre(reco.Derecho);
                Console.Write(reco.Derecho + " ");
                ImprimirEntre(reco.Derecho);
            }
        }

        public void ImprimirEntre()
        {
            ImprimirEntre(raiz);
            Console.WriteLine();
        }


        private void ImprimirPost(Nodo reco)
        {
            if (reco != null)
            {
                ImprimirPost(reco.Izquierdo);
                ImprimirPost(reco.Derecho);
                Console.Write(reco.Dato + " ");
            }
        }


        public void ImprimirPost()
        {
            ImprimirPost(raiz);
            Console.WriteLine();
        }
    }
}
