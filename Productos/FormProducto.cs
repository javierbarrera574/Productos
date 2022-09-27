using System;
using System.Data;
using System.Windows.Forms;




namespace Producto
{

    public partial class FormProducto : Form
    {
        Productos NuevoProd;
        Productos ProdExistente;
        bool nuevo = true;
        int fila;

        public FormProducto()
        {
            /*paso los constructores de la clase Productos
             * desde la el constructor del formulario
             */


            


        }

        private void FormProducto_Load(object sender, EventArgs e)
        {
            dgvProducto.Columns.Add("0", "Código");
            dgvProducto.Columns.Add("1", "Descripción");
            dgvProducto.Columns.Add("2", "Stock");
            dgvProducto.Columns[0].Width = 100;
            dgvProducto.Columns[1].Width = 300;
            dgvProducto.Columns[2].Width = 60;

        }

        private void btnCargar_Click(object sender, EventArgs e)
        {


            //Instanciamos utilizando el constructor con parámetros


            NuevoProd = new Productos(int.Parse(txtCodigo.Text),
            txtDescripcion.Text);

            lblCodigoMovimiento.Text = NuevoProd.Codigo.ToString();

            lblDescripcionMovimiento.Text = NuevoProd.Descripcion;

            lblStockMovimiento.Text = "Hay " + NuevoProd.Stock.ToString() + "unidades";

            tbcCargaProductos.SelectedTab = tbpMovimientoProducto;

            txtMovimiento.Clear();

            txtMovimiento.Focus();

            LlevarProdAldgv(NuevoProd);

            nuevo = true;


        }

        private void LlevarProdAldgv(Productos nuevoProd)
        {

            dgvProducto.Rows.Add(nuevoProd.Codigo.ToString(), 
                
            nuevoProd.Descripcion,
                
            nuevoProd.Stock.ToString());


            fila = (dgvProducto.Rows.Count - 1);


        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {

            if (nuevo == true)
            {
                if (rdbIngreso.Checked == true)
                {
                    NuevoProd.Ingreso(int.Parse(tbpMovimientoProducto.Text));

                }
                if (rdbEgreso.Checked == true)
                {
                    NuevoProd.Salida(int.Parse(tbpMovimientoProducto.Text));

                }
                LlevarProdAldgv(NuevoProd, fila);
            }
            else
            {
                if (rdbIngreso.Checked == true)
                {
                    ProdExistente.Ingreso(int.Parse(tbpMovimientoProducto.Text));

                }
                if (rdbEgreso.Checked == true)
                {
                    ProdExistente.Salida(int.Parse(tbpMovimientoProducto.Text));

                }
                LlevarProdAldgv(ProdExistente, fila);
            }

        }

        private void LlevarProdAldgv(Productos prodExistente, int fila)
        {

            dgvProducto[0, fila].Value = prodExistente.Codigo.ToString();
            dgvProducto[1, fila].Value = prodExistente.Descripcion;
            dgvProducto[2, fila].Value = prodExistente.Stock.ToString();


        }

        private void dgvProducto_CellClick(object sender, DataGridViewCellEventArgs e)
        {



            ProdExistente = new

            Productos(Convert.ToInt32(dgvProducto.CurrentRow.Cells[0].Value),

            dgvProducto.CurrentRow.Cells[1].Value.ToString(),

            Convert.ToInt32(dgvProducto.CurrentRow.Cells[2].Value));

            lblStockMovimiento.Text = ProdExistente.Codigo.ToString();

            lblDescripcionMovimiento.Text = ProdExistente.Descripcion;

            lblStockMovimiento.Text = "Hay " + 
                
            ProdExistente.Stock.ToString() + " unidades";

            txtMovimiento.Clear();
        
            fila = e.RowIndex;

            nuevo = false;


        }
    }
}
