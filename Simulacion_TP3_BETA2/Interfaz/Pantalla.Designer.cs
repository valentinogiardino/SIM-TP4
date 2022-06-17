
namespace Simulacion_TP1
{
    partial class Pantalla
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.lblCostoPedido = new System.Windows.Forms.Label();
            this.btnGenerar = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btnEliminarReposicion = new System.Windows.Forms.Button();
            this.btnEliminarConsumo = new System.Windows.Forms.Button();
            this.btnAgregarReposicion = new System.Windows.Forms.Button();
            this.txtNuevaProbabilidadReposicion = new System.Windows.Forms.TextBox();
            this.txtNuevaReposicion = new System.Windows.Forms.TextBox();
            this.lblNuevaProbabilidadReposicion = new System.Windows.Forms.Label();
            this.lblNuevaReposicion = new System.Windows.Forms.Label();
            this.btnAgregarConsumo = new System.Windows.Forms.Button();
            this.txtNuevaProbabilidad = new System.Windows.Forms.TextBox();
            this.txtNuevoConsumo = new System.Windows.Forms.TextBox();
            this.lblNuevaProbabilidad = new System.Windows.Forms.Label();
            this.lblNuevoConsumo = new System.Windows.Forms.Label();
            this.lblTablaProbabilidadReposicion = new System.Windows.Forms.Label();
            this.lblTablaProbabilidadConsumo = new System.Windows.Forms.Label();
            this.gdrProbabilidadReposicion = new System.Windows.Forms.DataGridView();
            this.txtCapacidadAlmacenamientoActual = new System.Windows.Forms.MaskedTextBox();
            this.gdrProbabilidadConsumo = new System.Windows.Forms.DataGridView();
            this.lblCapacidadActual = new System.Windows.Forms.Label();
            this.txtSemanaDesde = new System.Windows.Forms.MaskedTextBox();
            this.lblSemanaDesdeMostrar = new System.Windows.Forms.Label();
            this.txtCostoSoprepasoAlmacenamiento = new System.Windows.Forms.MaskedTextBox();
            this.lblCostoSobrepaso = new System.Windows.Forms.Label();
            this.txtCostoAlmacenamiento = new System.Windows.Forms.MaskedTextBox();
            this.lblCostoAlmacenamiento = new System.Windows.Forms.Label();
            this.txtCostoPedido = new System.Windows.Forms.MaskedTextBox();
            this.txtCantidadSemanas = new System.Windows.Forms.MaskedTextBox();
            this.lblCantidadSemanas = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.txtStockInicial = new System.Windows.Forms.MaskedTextBox();
            this.lblStockInicial = new System.Windows.Forms.Label();
            this.lblConclusion = new System.Windows.Forms.Label();
            this.lblPromedio = new System.Windows.Forms.Label();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gdrProbabilidadReposicion)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gdrProbabilidadConsumo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // lblCostoPedido
            // 
            this.lblCostoPedido.AutoSize = true;
            this.lblCostoPedido.Location = new System.Drawing.Point(403, 19);
            this.lblCostoPedido.Name = "lblCostoPedido";
            this.lblCostoPedido.Size = new System.Drawing.Size(73, 13);
            this.lblCostoPedido.TabIndex = 0;
            this.lblCostoPedido.Text = "Costo Pedido:";
            // 
            // btnGenerar
            // 
            this.btnGenerar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGenerar.Location = new System.Drawing.Point(619, 82);
            this.btnGenerar.Name = "btnGenerar";
            this.btnGenerar.Size = new System.Drawing.Size(81, 36);
            this.btnGenerar.TabIndex = 8;
            this.btnGenerar.Text = "Simular";
            this.btnGenerar.UseVisualStyleBackColor = true;
            this.btnGenerar.Click += new System.EventHandler(this.btnGenerar_Click);
            // 
            // panel2
            // 
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Controls.Add(this.lblConclusion);
            this.panel2.Controls.Add(this.txtStockInicial);
            this.panel2.Controls.Add(this.lblStockInicial);
            this.panel2.Controls.Add(this.btnEliminarReposicion);
            this.panel2.Controls.Add(this.btnEliminarConsumo);
            this.panel2.Controls.Add(this.btnAgregarReposicion);
            this.panel2.Controls.Add(this.txtNuevaProbabilidadReposicion);
            this.panel2.Controls.Add(this.txtNuevaReposicion);
            this.panel2.Controls.Add(this.lblNuevaProbabilidadReposicion);
            this.panel2.Controls.Add(this.lblNuevaReposicion);
            this.panel2.Controls.Add(this.btnAgregarConsumo);
            this.panel2.Controls.Add(this.txtNuevaProbabilidad);
            this.panel2.Controls.Add(this.txtNuevoConsumo);
            this.panel2.Controls.Add(this.lblNuevaProbabilidad);
            this.panel2.Controls.Add(this.lblNuevoConsumo);
            this.panel2.Controls.Add(this.lblTablaProbabilidadReposicion);
            this.panel2.Controls.Add(this.lblTablaProbabilidadConsumo);
            this.panel2.Controls.Add(this.gdrProbabilidadReposicion);
            this.panel2.Controls.Add(this.txtCapacidadAlmacenamientoActual);
            this.panel2.Controls.Add(this.gdrProbabilidadConsumo);
            this.panel2.Controls.Add(this.lblCapacidadActual);
            this.panel2.Controls.Add(this.txtSemanaDesde);
            this.panel2.Controls.Add(this.lblSemanaDesdeMostrar);
            this.panel2.Controls.Add(this.txtCostoSoprepasoAlmacenamiento);
            this.panel2.Controls.Add(this.lblCostoSobrepaso);
            this.panel2.Controls.Add(this.txtCostoAlmacenamiento);
            this.panel2.Controls.Add(this.lblCostoAlmacenamiento);
            this.panel2.Controls.Add(this.txtCostoPedido);
            this.panel2.Controls.Add(this.txtCantidadSemanas);
            this.panel2.Controls.Add(this.lblCantidadSemanas);
            this.panel2.Controls.Add(this.lblCostoPedido);
            this.panel2.Controls.Add(this.btnGenerar);
            this.panel2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panel2.Location = new System.Drawing.Point(12, 12);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1447, 383);
            this.panel2.TabIndex = 10;
            // 
            // btnEliminarReposicion
            // 
            this.btnEliminarReposicion.Location = new System.Drawing.Point(833, 270);
            this.btnEliminarReposicion.Name = "btnEliminarReposicion";
            this.btnEliminarReposicion.Size = new System.Drawing.Size(52, 23);
            this.btnEliminarReposicion.TabIndex = 16;
            this.btnEliminarReposicion.Text = "Eliminar";
            this.btnEliminarReposicion.UseVisualStyleBackColor = true;
            this.btnEliminarReposicion.Click += new System.EventHandler(this.btnEliminarReposicion_Click);
            // 
            // btnEliminarConsumo
            // 
            this.btnEliminarConsumo.Location = new System.Drawing.Point(108, 270);
            this.btnEliminarConsumo.Name = "btnEliminarConsumo";
            this.btnEliminarConsumo.Size = new System.Drawing.Size(52, 23);
            this.btnEliminarConsumo.TabIndex = 12;
            this.btnEliminarConsumo.Text = "Eliminar";
            this.btnEliminarConsumo.UseVisualStyleBackColor = true;
            this.btnEliminarConsumo.Click += new System.EventHandler(this.btnEliminarConsumo_Click);
            // 
            // btnAgregarReposicion
            // 
            this.btnAgregarReposicion.Location = new System.Drawing.Point(833, 241);
            this.btnAgregarReposicion.Name = "btnAgregarReposicion";
            this.btnAgregarReposicion.Size = new System.Drawing.Size(52, 23);
            this.btnAgregarReposicion.TabIndex = 15;
            this.btnAgregarReposicion.Text = "Agregar";
            this.btnAgregarReposicion.UseVisualStyleBackColor = true;
            this.btnAgregarReposicion.Click += new System.EventHandler(this.btnAgregarReposicion_Click);
            // 
            // txtNuevaProbabilidadReposicion
            // 
            this.txtNuevaProbabilidadReposicion.Location = new System.Drawing.Point(822, 203);
            this.txtNuevaProbabilidadReposicion.Name = "txtNuevaProbabilidadReposicion";
            this.txtNuevaProbabilidadReposicion.Size = new System.Drawing.Size(63, 20);
            this.txtNuevaProbabilidadReposicion.TabIndex = 14;
            // 
            // txtNuevaReposicion
            // 
            this.txtNuevaReposicion.Location = new System.Drawing.Point(822, 177);
            this.txtNuevaReposicion.Name = "txtNuevaReposicion";
            this.txtNuevaReposicion.Size = new System.Drawing.Size(63, 20);
            this.txtNuevaReposicion.TabIndex = 13;
            // 
            // lblNuevaProbabilidadReposicion
            // 
            this.lblNuevaProbabilidadReposicion.AutoSize = true;
            this.lblNuevaProbabilidadReposicion.Location = new System.Drawing.Point(750, 203);
            this.lblNuevaProbabilidadReposicion.Name = "lblNuevaProbabilidadReposicion";
            this.lblNuevaProbabilidadReposicion.Size = new System.Drawing.Size(71, 13);
            this.lblNuevaProbabilidadReposicion.TabIndex = 36;
            this.lblNuevaProbabilidadReposicion.Text = "Probabilidad: ";
            // 
            // lblNuevaReposicion
            // 
            this.lblNuevaReposicion.AutoSize = true;
            this.lblNuevaReposicion.Location = new System.Drawing.Point(753, 180);
            this.lblNuevaReposicion.Name = "lblNuevaReposicion";
            this.lblNuevaReposicion.Size = new System.Drawing.Size(63, 13);
            this.lblNuevaReposicion.TabIndex = 35;
            this.lblNuevaReposicion.Text = "Reposición:";
            // 
            // btnAgregarConsumo
            // 
            this.btnAgregarConsumo.Location = new System.Drawing.Point(107, 241);
            this.btnAgregarConsumo.Name = "btnAgregarConsumo";
            this.btnAgregarConsumo.Size = new System.Drawing.Size(53, 23);
            this.btnAgregarConsumo.TabIndex = 11;
            this.btnAgregarConsumo.Text = "Agregar";
            this.btnAgregarConsumo.UseVisualStyleBackColor = true;
            this.btnAgregarConsumo.Click += new System.EventHandler(this.btnAgregarConsumo_Click);
            // 
            // txtNuevaProbabilidad
            // 
            this.txtNuevaProbabilidad.Location = new System.Drawing.Point(97, 200);
            this.txtNuevaProbabilidad.Name = "txtNuevaProbabilidad";
            this.txtNuevaProbabilidad.Size = new System.Drawing.Size(63, 20);
            this.txtNuevaProbabilidad.TabIndex = 10;
            // 
            // txtNuevoConsumo
            // 
            this.txtNuevoConsumo.Location = new System.Drawing.Point(97, 174);
            this.txtNuevoConsumo.Name = "txtNuevoConsumo";
            this.txtNuevoConsumo.Size = new System.Drawing.Size(63, 20);
            this.txtNuevoConsumo.TabIndex = 9;
            // 
            // lblNuevaProbabilidad
            // 
            this.lblNuevaProbabilidad.AutoSize = true;
            this.lblNuevaProbabilidad.Location = new System.Drawing.Point(25, 200);
            this.lblNuevaProbabilidad.Name = "lblNuevaProbabilidad";
            this.lblNuevaProbabilidad.Size = new System.Drawing.Size(71, 13);
            this.lblNuevaProbabilidad.TabIndex = 31;
            this.lblNuevaProbabilidad.Text = "Probabilidad: ";
            // 
            // lblNuevoConsumo
            // 
            this.lblNuevoConsumo.AutoSize = true;
            this.lblNuevoConsumo.Location = new System.Drawing.Point(37, 177);
            this.lblNuevoConsumo.Name = "lblNuevoConsumo";
            this.lblNuevoConsumo.Size = new System.Drawing.Size(54, 13);
            this.lblNuevoConsumo.TabIndex = 30;
            this.lblNuevoConsumo.Text = "Consumo:";
            // 
            // lblTablaProbabilidadReposicion
            // 
            this.lblTablaProbabilidadReposicion.AutoSize = true;
            this.lblTablaProbabilidadReposicion.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTablaProbabilidadReposicion.Location = new System.Drawing.Point(898, 136);
            this.lblTablaProbabilidadReposicion.Name = "lblTablaProbabilidadReposicion";
            this.lblTablaProbabilidadReposicion.Size = new System.Drawing.Size(307, 18);
            this.lblTablaProbabilidadReposicion.TabIndex = 29;
            this.lblTablaProbabilidadReposicion.Text = "Tabla de Probabiliad para la Reposición";
            // 
            // lblTablaProbabilidadConsumo
            // 
            this.lblTablaProbabilidadConsumo.AutoSize = true;
            this.lblTablaProbabilidadConsumo.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTablaProbabilidadConsumo.Location = new System.Drawing.Point(173, 136);
            this.lblTablaProbabilidadConsumo.Name = "lblTablaProbabilidadConsumo";
            this.lblTablaProbabilidadConsumo.Size = new System.Drawing.Size(304, 18);
            this.lblTablaProbabilidadConsumo.TabIndex = 28;
            this.lblTablaProbabilidadConsumo.Text = "Tabla de Probabilidad para el Consumo";
            // 
            // gdrProbabilidadReposicion
            // 
            this.gdrProbabilidadReposicion.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gdrProbabilidadReposicion.Location = new System.Drawing.Point(901, 157);
            this.gdrProbabilidadReposicion.Name = "gdrProbabilidadReposicion";
            this.gdrProbabilidadReposicion.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.gdrProbabilidadReposicion.Size = new System.Drawing.Size(524, 194);
            this.gdrProbabilidadReposicion.TabIndex = 18;
            this.gdrProbabilidadReposicion.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.gdrProbabilidadReposicion_KeyPress);
            // 
            // txtCapacidadAlmacenamientoActual
            // 
            this.txtCapacidadAlmacenamientoActual.Location = new System.Drawing.Point(191, 72);
            this.txtCapacidadAlmacenamientoActual.Mask = "9999999999";
            this.txtCapacidadAlmacenamientoActual.Name = "txtCapacidadAlmacenamientoActual";
            this.txtCapacidadAlmacenamientoActual.Size = new System.Drawing.Size(64, 20);
            this.txtCapacidadAlmacenamientoActual.TabIndex = 3;
            // 
            // gdrProbabilidadConsumo
            // 
            this.gdrProbabilidadConsumo.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gdrProbabilidadConsumo.Location = new System.Drawing.Point(176, 157);
            this.gdrProbabilidadConsumo.Name = "gdrProbabilidadConsumo";
            this.gdrProbabilidadConsumo.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.gdrProbabilidadConsumo.Size = new System.Drawing.Size(524, 194);
            this.gdrProbabilidadConsumo.TabIndex = 17;
            this.gdrProbabilidadConsumo.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.gdrProbabilidadConsumo_KeyPress);
            // 
            // lblCapacidadActual
            // 
            this.lblCapacidadActual.AutoSize = true;
            this.lblCapacidadActual.Location = new System.Drawing.Point(23, 73);
            this.lblCapacidadActual.Name = "lblCapacidadActual";
            this.lblCapacidadActual.Size = new System.Drawing.Size(156, 13);
            this.lblCapacidadActual.TabIndex = 27;
            this.lblCapacidadActual.Text = "Capacidad de almacenamiento:";
            // 
            // txtSemanaDesde
            // 
            this.txtSemanaDesde.Location = new System.Drawing.Point(191, 46);
            this.txtSemanaDesde.Mask = "9999999999";
            this.txtSemanaDesde.Name = "txtSemanaDesde";
            this.txtSemanaDesde.Size = new System.Drawing.Size(64, 20);
            this.txtSemanaDesde.TabIndex = 2;
            // 
            // lblSemanaDesdeMostrar
            // 
            this.lblSemanaDesdeMostrar.AutoSize = true;
            this.lblSemanaDesdeMostrar.Location = new System.Drawing.Point(35, 49);
            this.lblSemanaDesdeMostrar.Name = "lblSemanaDesdeMostrar";
            this.lblSemanaDesdeMostrar.Size = new System.Drawing.Size(144, 13);
            this.lblSemanaDesdeMostrar.TabIndex = 25;
            this.lblSemanaDesdeMostrar.Text = "Semana Desde para mostrar:";
            // 
            // txtCostoSoprepasoAlmacenamiento
            // 
            this.txtCostoSoprepasoAlmacenamiento.Location = new System.Drawing.Point(483, 64);
            this.txtCostoSoprepasoAlmacenamiento.Mask = "9999999999";
            this.txtCostoSoprepasoAlmacenamiento.Name = "txtCostoSoprepasoAlmacenamiento";
            this.txtCostoSoprepasoAlmacenamiento.Size = new System.Drawing.Size(64, 20);
            this.txtCostoSoprepasoAlmacenamiento.TabIndex = 7;
            // 
            // lblCostoSobrepaso
            // 
            this.lblCostoSobrepaso.AutoSize = true;
            this.lblCostoSobrepaso.Location = new System.Drawing.Point(306, 71);
            this.lblCostoSobrepaso.Name = "lblCostoSobrepaso";
            this.lblCostoSobrepaso.Size = new System.Drawing.Size(172, 13);
            this.lblCostoSobrepaso.TabIndex = 21;
            this.lblCostoSobrepaso.Text = "Costo Sobrepaso Almacenamiento:";
            // 
            // txtCostoAlmacenamiento
            // 
            this.txtCostoAlmacenamiento.Location = new System.Drawing.Point(483, 38);
            this.txtCostoAlmacenamiento.Mask = "9999999999";
            this.txtCostoAlmacenamiento.Name = "txtCostoAlmacenamiento";
            this.txtCostoAlmacenamiento.Size = new System.Drawing.Size(64, 20);
            this.txtCostoAlmacenamiento.TabIndex = 6;
            // 
            // lblCostoAlmacenamiento
            // 
            this.lblCostoAlmacenamiento.AutoSize = true;
            this.lblCostoAlmacenamiento.Location = new System.Drawing.Point(360, 45);
            this.lblCostoAlmacenamiento.Name = "lblCostoAlmacenamiento";
            this.lblCostoAlmacenamiento.Size = new System.Drawing.Size(118, 13);
            this.lblCostoAlmacenamiento.TabIndex = 19;
            this.lblCostoAlmacenamiento.Text = "Costo Almacenamiento:";
            // 
            // txtCostoPedido
            // 
            this.txtCostoPedido.Location = new System.Drawing.Point(483, 12);
            this.txtCostoPedido.Mask = "9999999999";
            this.txtCostoPedido.Name = "txtCostoPedido";
            this.txtCostoPedido.Size = new System.Drawing.Size(64, 20);
            this.txtCostoPedido.TabIndex = 5;
            // 
            // txtCantidadSemanas
            // 
            this.txtCantidadSemanas.Location = new System.Drawing.Point(191, 12);
            this.txtCantidadSemanas.Mask = "9999999999";
            this.txtCantidadSemanas.Name = "txtCantidadSemanas";
            this.txtCantidadSemanas.Size = new System.Drawing.Size(64, 20);
            this.txtCantidadSemanas.TabIndex = 1;
            this.txtCantidadSemanas.ValidatingType = typeof(int);
            // 
            // lblCantidadSemanas
            // 
            this.lblCantidadSemanas.AutoSize = true;
            this.lblCantidadSemanas.Location = new System.Drawing.Point(70, 19);
            this.lblCantidadSemanas.Name = "lblCantidadSemanas";
            this.lblCantidadSemanas.Size = new System.Drawing.Size(109, 13);
            this.lblCantidadSemanas.TabIndex = 9;
            this.lblCantidadSemanas.Text = "Número de Semanas:";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(21, 423);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(1438, 308);
            this.dataGridView1.TabIndex = 11;
            // 
            // txtStockInicial
            // 
            this.txtStockInicial.Location = new System.Drawing.Point(191, 98);
            this.txtStockInicial.Mask = "9999999999";
            this.txtStockInicial.Name = "txtStockInicial";
            this.txtStockInicial.Size = new System.Drawing.Size(64, 20);
            this.txtStockInicial.TabIndex = 4;
            // 
            // lblStockInicial
            // 
            this.lblStockInicial.AutoSize = true;
            this.lblStockInicial.Location = new System.Drawing.Point(111, 101);
            this.lblStockInicial.Name = "lblStockInicial";
            this.lblStockInicial.Size = new System.Drawing.Size(68, 13);
            this.lblStockInicial.TabIndex = 38;
            this.lblStockInicial.Text = "Stock Inicial:";
            // 
            // lblConclusion
            // 
            this.lblConclusion.AutoSize = true;
            this.lblConclusion.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblConclusion.Location = new System.Drawing.Point(718, 19);
            this.lblConclusion.Name = "lblConclusion";
            this.lblConclusion.Size = new System.Drawing.Size(93, 18);
            this.lblConclusion.TabIndex = 39;
            this.lblConclusion.Text = "Conslusion";
            // 
            // lblPromedio
            // 
            this.lblPromedio.AutoSize = true;
            this.lblPromedio.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPromedio.Location = new System.Drawing.Point(931, 739);
            this.lblPromedio.Name = "lblPromedio";
            this.lblPromedio.Size = new System.Drawing.Size(81, 18);
            this.lblPromedio.TabIndex = 40;
            this.lblPromedio.Text = "Promedio";
            // 
            // Pantalla
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1471, 766);
            this.Controls.Add(this.lblPromedio);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.panel2);
            this.Name = "Pantalla";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Simulación Montecarlo de Inventario: Fábrica de Caños";
            this.Load += new System.EventHandler(this.Pantalla_Load);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gdrProbabilidadReposicion)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gdrProbabilidadConsumo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblCostoPedido;
        private System.Windows.Forms.Button btnGenerar;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label lblCantidadSemanas;
        private System.Windows.Forms.MaskedTextBox txtCostoPedido;
        private System.Windows.Forms.MaskedTextBox txtCantidadSemanas;
        private System.Windows.Forms.MaskedTextBox txtSemanaDesde;
        private System.Windows.Forms.Label lblSemanaDesdeMostrar;
        private System.Windows.Forms.MaskedTextBox txtCostoSoprepasoAlmacenamiento;
        private System.Windows.Forms.Label lblCostoSobrepaso;
        private System.Windows.Forms.MaskedTextBox txtCostoAlmacenamiento;
        private System.Windows.Forms.Label lblCostoAlmacenamiento;
        private System.Windows.Forms.MaskedTextBox txtCapacidadAlmacenamientoActual;
        private System.Windows.Forms.Label lblCapacidadActual;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridView gdrProbabilidadConsumo;
        private System.Windows.Forms.DataGridView gdrProbabilidadReposicion;
        private System.Windows.Forms.Label lblTablaProbabilidadReposicion;
        private System.Windows.Forms.Label lblTablaProbabilidadConsumo;
        private System.Windows.Forms.Button btnAgregarConsumo;
        private System.Windows.Forms.TextBox txtNuevaProbabilidad;
        private System.Windows.Forms.TextBox txtNuevoConsumo;
        private System.Windows.Forms.Label lblNuevaProbabilidad;
        private System.Windows.Forms.Label lblNuevoConsumo;
        private System.Windows.Forms.Button btnAgregarReposicion;
        private System.Windows.Forms.TextBox txtNuevaProbabilidadReposicion;
        private System.Windows.Forms.TextBox txtNuevaReposicion;
        private System.Windows.Forms.Label lblNuevaProbabilidadReposicion;
        private System.Windows.Forms.Label lblNuevaReposicion;
        private System.Windows.Forms.Button btnEliminarReposicion;
        private System.Windows.Forms.Button btnEliminarConsumo;
        private System.Windows.Forms.MaskedTextBox txtStockInicial;
        private System.Windows.Forms.Label lblStockInicial;
        private System.Windows.Forms.Label lblConclusion;
        private System.Windows.Forms.Label lblPromedio;
    }
}

