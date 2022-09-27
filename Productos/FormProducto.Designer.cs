namespace Producto
{
    partial class FormProducto
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.tbcCargaProductos = new System.Windows.Forms.TabControl();
            this.tbpCargaProducto = new System.Windows.Forms.TabPage();
            this.btnCargar = new System.Windows.Forms.Button();
            this.txtStock = new System.Windows.Forms.TextBox();
            this.txtDescripcion = new System.Windows.Forms.TextBox();
            this.txtCodigo = new System.Windows.Forms.TextBox();
            this.lblStock = new System.Windows.Forms.Label();
            this.lblDescripcion = new System.Windows.Forms.Label();
            this.lblCodigo = new System.Windows.Forms.Label();
            this.tbpMovimientoProducto = new System.Windows.Forms.TabPage();
            this.lblStockMovimiento = new System.Windows.Forms.Label();
            this.btnAceptar = new System.Windows.Forms.Button();
            this.rdbEgreso = new System.Windows.Forms.RadioButton();
            this.rdbIngreso = new System.Windows.Forms.RadioButton();
            this.txtMovimiento = new System.Windows.Forms.TextBox();
            this.lblCantidad = new System.Windows.Forms.Label();
            this.lblDescripcionMovimiento = new System.Windows.Forms.Label();
            this.lblCodigoMovimiento = new System.Windows.Forms.Label();
            this.dgvProducto = new System.Windows.Forms.DataGridView();
            this.Codigo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Descripcion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Stock = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Cantidad = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tbcCargaProductos.SuspendLayout();
            this.tbpCargaProducto.SuspendLayout();
            this.tbpMovimientoProducto.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvProducto)).BeginInit();
            this.SuspendLayout();
            // 
            // tbcCargaProductos
            // 
            this.tbcCargaProductos.Controls.Add(this.tbpCargaProducto);
            this.tbcCargaProductos.Controls.Add(this.tbpMovimientoProducto);
            this.tbcCargaProductos.Location = new System.Drawing.Point(34, 27);
            this.tbcCargaProductos.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.tbcCargaProductos.Name = "tbcCargaProductos";
            this.tbcCargaProductos.SelectedIndex = 0;
            this.tbcCargaProductos.Size = new System.Drawing.Size(794, 232);
            this.tbcCargaProductos.TabIndex = 0;
            // 
            // tbpCargaProducto
            // 
            this.tbpCargaProducto.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.tbpCargaProducto.Controls.Add(this.btnCargar);
            this.tbpCargaProducto.Controls.Add(this.txtStock);
            this.tbpCargaProducto.Controls.Add(this.txtDescripcion);
            this.tbpCargaProducto.Controls.Add(this.txtCodigo);
            this.tbpCargaProducto.Controls.Add(this.lblStock);
            this.tbpCargaProducto.Controls.Add(this.lblDescripcion);
            this.tbpCargaProducto.Controls.Add(this.lblCodigo);
            this.tbpCargaProducto.Location = new System.Drawing.Point(4, 24);
            this.tbpCargaProducto.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.tbpCargaProducto.Name = "tbpCargaProducto";
            this.tbpCargaProducto.Padding = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.tbpCargaProducto.Size = new System.Drawing.Size(786, 204);
            this.tbpCargaProducto.TabIndex = 0;
            this.tbpCargaProducto.Text = "Carga de Productos";
            // 
            // btnCargar
            // 
            this.btnCargar.BackColor = System.Drawing.Color.Lime;
            this.btnCargar.Location = new System.Drawing.Point(605, 46);
            this.btnCargar.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnCargar.Name = "btnCargar";
            this.btnCargar.Size = new System.Drawing.Size(120, 40);
            this.btnCargar.TabIndex = 6;
            this.btnCargar.Text = "Cargar";
            this.btnCargar.UseVisualStyleBackColor = false;
            this.btnCargar.Click += new System.EventHandler(this.btnCargar_Click);
            // 
            // txtStock
            // 
            this.txtStock.Location = new System.Drawing.Point(132, 162);
            this.txtStock.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.txtStock.Name = "txtStock";
            this.txtStock.Size = new System.Drawing.Size(116, 23);
            this.txtStock.TabIndex = 5;
            // 
            // txtDescripcion
            // 
            this.txtDescripcion.Location = new System.Drawing.Point(132, 100);
            this.txtDescripcion.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.txtDescripcion.Name = "txtDescripcion";
            this.txtDescripcion.Size = new System.Drawing.Size(312, 23);
            this.txtDescripcion.TabIndex = 4;
            // 
            // txtCodigo
            // 
            this.txtCodigo.Location = new System.Drawing.Point(132, 38);
            this.txtCodigo.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.txtCodigo.Name = "txtCodigo";
            this.txtCodigo.Size = new System.Drawing.Size(116, 23);
            this.txtCodigo.TabIndex = 3;
            // 
            // lblStock
            // 
            this.lblStock.AutoSize = true;
            this.lblStock.Location = new System.Drawing.Point(48, 170);
            this.lblStock.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblStock.Name = "lblStock";
            this.lblStock.Size = new System.Drawing.Size(39, 15);
            this.lblStock.TabIndex = 2;
            this.lblStock.Text = "Stock:";
            // 
            // lblDescripcion
            // 
            this.lblDescripcion.AutoSize = true;
            this.lblDescripcion.Location = new System.Drawing.Point(48, 108);
            this.lblDescripcion.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblDescripcion.Name = "lblDescripcion";
            this.lblDescripcion.Size = new System.Drawing.Size(72, 15);
            this.lblDescripcion.TabIndex = 1;
            this.lblDescripcion.Text = "Descripcion:";
            // 
            // lblCodigo
            // 
            this.lblCodigo.AutoSize = true;
            this.lblCodigo.Location = new System.Drawing.Point(44, 46);
            this.lblCodigo.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblCodigo.Name = "lblCodigo";
            this.lblCodigo.Size = new System.Drawing.Size(49, 15);
            this.lblCodigo.TabIndex = 0;
            this.lblCodigo.Text = "Codigo:";
            // 
            // tbpMovimientoProducto
            // 
            this.tbpMovimientoProducto.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.tbpMovimientoProducto.Controls.Add(this.lblStockMovimiento);
            this.tbpMovimientoProducto.Controls.Add(this.btnAceptar);
            this.tbpMovimientoProducto.Controls.Add(this.rdbEgreso);
            this.tbpMovimientoProducto.Controls.Add(this.rdbIngreso);
            this.tbpMovimientoProducto.Controls.Add(this.txtMovimiento);
            this.tbpMovimientoProducto.Controls.Add(this.lblCantidad);
            this.tbpMovimientoProducto.Controls.Add(this.lblDescripcionMovimiento);
            this.tbpMovimientoProducto.Controls.Add(this.lblCodigoMovimiento);
            this.tbpMovimientoProducto.Location = new System.Drawing.Point(4, 24);
            this.tbpMovimientoProducto.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.tbpMovimientoProducto.Name = "tbpMovimientoProducto";
            this.tbpMovimientoProducto.Padding = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.tbpMovimientoProducto.Size = new System.Drawing.Size(786, 204);
            this.tbpMovimientoProducto.TabIndex = 1;
            this.tbpMovimientoProducto.Text = "Movimiento de Producto";
            // 
            // lblStockMovimiento
            // 
            this.lblStockMovimiento.AutoSize = true;
            this.lblStockMovimiento.Location = new System.Drawing.Point(50, 100);
            this.lblStockMovimiento.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblStockMovimiento.Name = "lblStockMovimiento";
            this.lblStockMovimiento.Size = new System.Drawing.Size(104, 15);
            this.lblStockMovimiento.TabIndex = 7;
            this.lblStockMovimiento.Text = "Stock Movimiento";
            // 
            // btnAceptar
            // 
            this.btnAceptar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnAceptar.Location = new System.Drawing.Point(622, 39);
            this.btnAceptar.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnAceptar.Name = "btnAceptar";
            this.btnAceptar.Size = new System.Drawing.Size(135, 43);
            this.btnAceptar.TabIndex = 6;
            this.btnAceptar.Text = "Aceptar";
            this.btnAceptar.UseVisualStyleBackColor = false;
            this.btnAceptar.Click += new System.EventHandler(this.btnAceptar_Click);
            // 
            // rdbEgreso
            // 
            this.rdbEgreso.AutoSize = true;
            this.rdbEgreso.Location = new System.Drawing.Point(413, 84);
            this.rdbEgreso.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.rdbEgreso.Name = "rdbEgreso";
            this.rdbEgreso.Size = new System.Drawing.Size(60, 19);
            this.rdbEgreso.TabIndex = 5;
            this.rdbEgreso.TabStop = true;
            this.rdbEgreso.Text = "Egreso";
            this.rdbEgreso.UseVisualStyleBackColor = true;
            // 
            // rdbIngreso
            // 
            this.rdbIngreso.AutoSize = true;
            this.rdbIngreso.Location = new System.Drawing.Point(413, 39);
            this.rdbIngreso.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.rdbIngreso.Name = "rdbIngreso";
            this.rdbIngreso.Size = new System.Drawing.Size(64, 19);
            this.rdbIngreso.TabIndex = 4;
            this.rdbIngreso.TabStop = true;
            this.rdbIngreso.Text = "Ingreso";
            this.rdbIngreso.UseVisualStyleBackColor = true;
            // 
            // txtMovimiento
            // 
            this.txtMovimiento.Location = new System.Drawing.Point(121, 145);
            this.txtMovimiento.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.txtMovimiento.Name = "txtMovimiento";
            this.txtMovimiento.Size = new System.Drawing.Size(116, 23);
            this.txtMovimiento.TabIndex = 3;
            // 
            // lblCantidad
            // 
            this.lblCantidad.AutoSize = true;
            this.lblCantidad.Location = new System.Drawing.Point(54, 149);
            this.lblCantidad.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblCantidad.Name = "lblCantidad";
            this.lblCantidad.Size = new System.Drawing.Size(58, 15);
            this.lblCantidad.TabIndex = 2;
            this.lblCantidad.Text = "Cantidad:";
            // 
            // lblDescripcionMovimiento
            // 
            this.lblDescripcionMovimiento.AutoSize = true;
            this.lblDescripcionMovimiento.Location = new System.Drawing.Point(50, 67);
            this.lblDescripcionMovimiento.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblDescripcionMovimiento.Name = "lblDescripcionMovimiento";
            this.lblDescripcionMovimiento.Size = new System.Drawing.Size(137, 15);
            this.lblDescripcionMovimiento.TabIndex = 1;
            this.lblDescripcionMovimiento.Text = "Descripcion Movimiento";
            // 
            // lblCodigoMovimiento
            // 
            this.lblCodigoMovimiento.AutoSize = true;
            this.lblCodigoMovimiento.Location = new System.Drawing.Point(50, 39);
            this.lblCodigoMovimiento.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblCodigoMovimiento.Name = "lblCodigoMovimiento";
            this.lblCodigoMovimiento.Size = new System.Drawing.Size(114, 15);
            this.lblCodigoMovimiento.TabIndex = 0;
            this.lblCodigoMovimiento.Text = "Codigo Movimiento";
            // 
            // dgvProducto
            // 
            this.dgvProducto.AllowUserToOrderColumns = true;
            this.dgvProducto.BackgroundColor = System.Drawing.Color.Red;
            this.dgvProducto.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvProducto.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Codigo,
            this.Descripcion,
            this.Stock,
            this.Cantidad});
            this.dgvProducto.Location = new System.Drawing.Point(38, 294);
            this.dgvProducto.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.dgvProducto.Name = "dgvProducto";
            this.dgvProducto.Size = new System.Drawing.Size(786, 162);
            this.dgvProducto.TabIndex = 1;
            this.dgvProducto.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvProducto_CellClick);
            // 
            // Codigo
            // 
            this.Codigo.HeaderText = "Codigo";
            this.Codigo.Name = "Codigo";
            this.Codigo.Width = 130;
            // 
            // Descripcion
            // 
            this.Descripcion.HeaderText = "Descripcion";
            this.Descripcion.Name = "Descripcion";
            this.Descripcion.Width = 150;
            // 
            // Stock
            // 
            this.Stock.HeaderText = "Stock";
            this.Stock.Name = "Stock";
            this.Stock.Width = 140;
            // 
            // Cantidad
            // 
            this.Cantidad.HeaderText = "Cantidad";
            this.Cantidad.Name = "Cantidad";
            this.Cantidad.Width = 130;
            // 
            // FormProducto
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(841, 509);
            this.Controls.Add(this.dgvProducto);
            this.Controls.Add(this.tbcCargaProductos);
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.Name = "FormProducto";
            this.Text = "FormProducto";
            this.Load += new System.EventHandler(this.FormProducto_Load);
            this.tbcCargaProductos.ResumeLayout(false);
            this.tbpCargaProducto.ResumeLayout(false);
            this.tbpCargaProducto.PerformLayout();
            this.tbpMovimientoProducto.ResumeLayout(false);
            this.tbpMovimientoProducto.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvProducto)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tbcCargaProductos;
        private System.Windows.Forms.TabPage tbpCargaProducto;
        private System.Windows.Forms.Button btnCargar;
        private System.Windows.Forms.TextBox txtStock;
        private System.Windows.Forms.TextBox txtDescripcion;
        private System.Windows.Forms.TextBox txtCodigo;
        private System.Windows.Forms.Label lblStock;
        private System.Windows.Forms.Label lblDescripcion;
        private System.Windows.Forms.Label lblCodigo;
        private System.Windows.Forms.TabPage tbpMovimientoProducto;
        private System.Windows.Forms.Button btnAceptar;
        private System.Windows.Forms.RadioButton rdbEgreso;
        private System.Windows.Forms.RadioButton rdbIngreso;
        private System.Windows.Forms.TextBox txtMovimiento;
        private System.Windows.Forms.Label lblCantidad;
        private System.Windows.Forms.Label lblDescripcionMovimiento;
        private System.Windows.Forms.Label lblCodigoMovimiento;
        private System.Windows.Forms.DataGridView dgvProducto;
        private System.Windows.Forms.Label lblStockMovimiento;
        private System.Windows.Forms.DataGridViewTextBoxColumn Codigo;
        private System.Windows.Forms.DataGridViewTextBoxColumn Descripcion;
        private System.Windows.Forms.DataGridViewTextBoxColumn Stock;
        private System.Windows.Forms.DataGridViewTextBoxColumn Cantidad;
    }
}