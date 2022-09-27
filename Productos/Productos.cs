using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Producto
{

    public class Productos
    {

        #region Atributos
        private int codigo;
        private string descripcion;
        private int stock;
        #endregion


        #region Propiedades
        public int Codigo
        { 
             set { codigo = value; }
             get { return codigo; }
        }


        public string Descripcion
        { 
            set { descripcion = value; }
            get { return descripcion; }
        }


        public int Stock
        {
            get { return stock; }
        }
        #endregion



        #region Constructores
        public Productos(int cod, string desc)
        { 
               codigo = cod;
               descripcion = desc;
               stock = 0;
        }

        public Productos(int cod, string desc, int cantidad)
        {
            codigo = cod;
            descripcion = desc;
            stock = cantidad;
        }

        #endregion


        #region Metodos
        public void Ingreso(int cant)
        {
            stock = stock + cant;
        }


        public void Salida(int cant)
        {
            stock = stock - cant;
        }
        #endregion


    }


}
