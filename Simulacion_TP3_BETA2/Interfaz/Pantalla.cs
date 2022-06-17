using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Simulacion_TP1.Clases;
using Simulacion_TP1.Controlador;

namespace Simulacion_TP1
{
    public partial class Pantalla : Form
    {

        private Gestor gestor;

        public Gestor Gestor { get => gestor; set => gestor = value; }

        //Constructor
        public Pantalla()
        {
            InitializeComponent();
            this.gestor = new Gestor(this); //Se guarda una referencia al gestor. El gestor tambien contendra una referencia a la pantalla. Esto permite la comunicacion
        }

        //////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
        /////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
        private void Pantalla_Load(object sender, EventArgs e)
        {

            cargarDatosPantalla();
            
        }
        

        
        private void cargarDatosPantalla() // Se cargan los datos a mostrar al usuario al iniciar la aplicación.
        {
            txtCantidadSemanas.Text = "1000";
            txtSemanaDesde.Text = "100";
            txtCapacidadAlmacenamientoActual.Text = "20000";
            txtCostoAlmacenamiento.Text = "2500";
            txtCostoPedido.Text = "25500";
            txtCostoSoprepasoAlmacenamiento.Text = "5000";
            txtStockInicial.Text = "0";

            lblConclusion.Visible = false;
            lblPromedio.Visible = false;

            cargarTablaProbabilidadConsumo();
            cargarTablaProbabilidadReposicion();

            esconderColumnas(gdrProbabilidadConsumo);
            esconderColumnas(gdrProbabilidadReposicion);

        }
        private void cargarTablaProbabilidadConsumo()   //Carga la tabla de probabilidad inicial de Consumo, tomando como datasource la lista generada por el gestor.
        {
            gdrProbabilidadConsumo.DataSource = this.gestor.generarTablaInicialProbabilidadConsumo();
            gdrProbabilidadConsumo.Refresh();


        }
        private void cargarTablaProbabilidadReposicion() //Carga la tabla de probabilidad inicial Reposición, tomando como datasource la lista generada por el gestor.
        {
            gdrProbabilidadReposicion.DataSource = this.gestor.generarTablaInicialProbabilidadReposicion();
            gdrProbabilidadReposicion.Refresh();

        }
        private void esconderColumnas(DataGridView grilla)  //Se utiliza para la interfaz del usuario.
        {
            grilla.Columns[2].Visible = false;
            grilla.Columns[3].Visible = false;
            grilla.Columns[4].Visible = false;
            grilla.Size = new Size(240, 194);
        }

        //////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
        /////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
        private void btnGenerar_Click(object sender, EventArgs e) //Dispara la generación de la simulación
        {




            if (validarCampos())
            {
                int cantidadSemanas = int.Parse(txtCantidadSemanas.Text);                       //Se toman los datos de la pantalla
                double costoAlmacenmiento = double.Parse(txtCostoAlmacenamiento.Text);
                double costoPedido = double.Parse(txtCostoPedido.Text);
                double costoSoprepasoAlmacenamiento = double.Parse(txtCostoSoprepasoAlmacenamiento.Text);
                int semanaDesde = int.Parse(txtSemanaDesde.Text);
                double capacidadActual = double.Parse(txtCapacidadAlmacenamientoActual.Text);
                double stockInicial = double.Parse(txtStockInicial.Text);
                List<RenglonProbabilidad> tablaProbabilidadConsumo = tomarFila(gdrProbabilidadConsumo);
                List<RenglonProbabilidad> tablaProbabilidadReposicion = tomarFila(gdrProbabilidadReposicion);


                if (!validarProbabilidad(tablaProbabilidadConsumo))
                {
                    MessageBox.Show("Las probabilidades de Tabla Probabilidad Consumo tienen que sumar 1." + "\n" + "Revise y vuelva a cargar los datos...", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

                else
                {
                    if (!validarProbabilidad(tablaProbabilidadReposicion))
                    {
                        MessageBox.Show("Las probabilidades de Tabla Probabilidad Reposicion tienen que sumar 1." + "\n" + "Revise y vuelva a cargar los datos...", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    else
                    {               //Se le envian al gestor los parametros necesarios para la simulacion
                        this.gestor.tomarDatos(cantidadSemanas, semanaDesde, costoAlmacenmiento, costoPedido, costoSoprepasoAlmacenamiento, capacidadActual, tablaProbabilidadConsumo, tablaProbabilidadReposicion, stockInicial);

                        completarTablasProbabilidad();      //Se completan las tablas de probabilidad
                        cargarTabla();                      //Se muestra la tabla de simulacion generada
                        mostrarConclusion();
                    }
                }
            }
            else
            {
                MessageBox.Show("No pueden haber campos vacios!" + "\n" + "Revise y vuelva a cargar los datos...", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            
        }

        private bool validarCampos()    //Valida que no haya campos vacios
        {
            if (txtCantidadSemanas.Text == "" || txtCostoAlmacenamiento.Text == "" || txtCostoPedido.Text == "" || txtCostoSoprepasoAlmacenamiento.Text == "" || txtSemanaDesde.Text == "" || txtCapacidadAlmacenamientoActual.Text == "" || txtStockInicial.Text == "")
            {
                return false;
            }
            return true;
        }

        private List<RenglonProbabilidad> tomarFila(DataGridView tablaProbabilidad)     //Recibe como parametro una grilla y se encarga de recopilar los datos cargados en ella.
        {
            List<RenglonProbabilidad> listaRenglones = new List<RenglonProbabilidad>();
            for (int i = 0; i < tablaProbabilidad.Rows.Count; i++)
            {
                RenglonProbabilidad renglon = tablaProbabilidad.Rows[i].DataBoundItem as RenglonProbabilidad;   //Convertimos las rows en objetos
                listaRenglones.Add(renglon);                                                                    //Agregamos el nuevo objeto renglon a la lista
            }
            return listaRenglones;
        }

        private bool validarProbabilidad(List<RenglonProbabilidad> tablaProbabilidad)  //Controla que las probabilidades de la tabla sumen 1.
        {
            bool esValida = false;
            double contador = 0;
            foreach (RenglonProbabilidad renglon in tablaProbabilidad)
            {
                contador += renglon.Probabilidad;
            }
            //Ceiling se usa para redondear para arriba. Se incluyó debido a un problema con la presicion de los double, no es tan preciso como "decimal"
            if ((Math.Ceiling(contador * 100) / 100) == 1)
            {
                esValida = true;
            }
            return esValida;
        }

        private void completarTablasProbabilidad()  //Se completan las tablas de probabilidad
        {
            this.gestor.completarTablas();      //El gestor calcula los datos de las nuevas columnas a mostrar
            actualizarTablaConsumo();           //Se actualizan las tablas
            actualizarTablaReposicion();

            mostrarColumnas(gdrProbabilidadConsumo);    //Se muestran las neuvas columnas calculadas
            mostrarColumnas(gdrProbabilidadReposicion);
        }

        private void actualizarTablaConsumo()   //Actualiza la tabla con los nuevos datos que calculó el gestor.
        {
            gdrProbabilidadConsumo.DataSource = null;
            gdrProbabilidadConsumo.DataSource = this.gestor.TablaProbabilidadConsumo;
            gdrProbabilidadConsumo.Columns[2].ReadOnly = true;      //No permite editar esas columnas
            gdrProbabilidadConsumo.Columns[3].ReadOnly = true;
            gdrProbabilidadConsumo.Columns[4].ReadOnly = true;
            gdrProbabilidadConsumo.Refresh();
        }

        private void actualizarTablaReposicion() //Actualiza la tabla con los nuevos datos que calculó el gestor.
        {
            gdrProbabilidadReposicion.DataSource = null;
            gdrProbabilidadReposicion.DataSource = this.gestor.TablaProbabilidadReposicion;
            gdrProbabilidadReposicion.Columns[2].ReadOnly = true;      //No permite editar esas columnas
            gdrProbabilidadReposicion.Columns[3].ReadOnly = true;
            gdrProbabilidadReposicion.Columns[4].ReadOnly = true;
            gdrProbabilidadReposicion.Refresh();
        }

        
        private void mostrarColumnas(DataGridView grilla)   //Muestra las columnas de probabilidad acumulada e intervalo recientemente calculadas.
        {
            grilla.Columns[2].Visible = true;
            grilla.Columns[3].Visible = true;
            grilla.Columns[4].Visible = true;
            grilla.Size = new System.Drawing.Size(524, 194);    //Cambia el tamaño de la grilla.
        }

        //////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
        /////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
        public void cargarTabla()               //Se crea y muestra la tabla de simulacion
        {
            List<FilaSimulacion> fila = gestor.generarTablaSimulacion();    //Se le delega al gestor la generacion de la tabla
            dataGridView1.DataSource = fila;                      //Al establecer el dataSource como el objeto fila, el programa genera la grilla tomando como nombre de columna
                                                                  //El getter de cada atributo del objeto. Cada atributo del objeto del dataSource se ubica en su correspondiente columna
                                                                        
            dataGridView1.Columns[5].HeaderText = "En Almacenamiento"; //Se cambia el nombre de algunas columnas
            dataGridView1.Columns[9].HeaderText = "Costo Total";
            dataGridView1.Columns[10].HeaderText = "Costo Acumulado";
            dataGridView1.Columns[11].HeaderText = "Promedio";
            dataGridView1.Columns[12].HeaderText = "Hay Exceso";
            dataGridView1.Columns[13].HeaderText = "Exceso Acumulado";

            dataGridView1.Refresh();
        }


        


        
        //////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
        /////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
        //Eventos para manejar la modificacion de las tablas de probabilidad
        private void btnAgregarConsumo_Click(object sender, EventArgs e)
        {
            double nuevoConsumo = double.Parse(txtNuevoConsumo.Text);
            double nuevaProbabilidad = double.Parse(txtNuevaProbabilidad.Text);
            this.gestor.agregarFila(nuevoConsumo, nuevaProbabilidad, this.gestor.TablaProbabilidadConsumo);
            actualizarTablaConsumo();
        }

        private void btnAgregarReposicion_Click(object sender, EventArgs e)
        {
            double nuevaReposicion = double.Parse(txtNuevaReposicion.Text);
            double nuevaProbabilidad = double.Parse(txtNuevaProbabilidadReposicion.Text);
            this.gestor.agregarFila(nuevaReposicion, nuevaProbabilidad, this.gestor.TablaProbabilidadReposicion);
            actualizarTablaReposicion();
        }

        private void btnEliminarConsumo_Click(object sender, EventArgs e)
        {
            eliminarConsumo();
        }
        private void gdrProbabilidadConsumo_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)(Keys.Delete) || (e.KeyChar == (char)(Keys.Back)))
            {
                eliminarConsumo();

            }
        }
        private void eliminarConsumo()
        {
            try
            {
                this.gestor.borrarFila(gdrProbabilidadConsumo.SelectedRows[0].DataBoundItem as RenglonProbabilidad, gestor.TablaProbabilidadConsumo);
                actualizarTablaConsumo();
            }
            catch (Exception exp)
            {
                MessageBox.Show("No hay más filas por borrar", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }
        private void btnEliminarReposicion_Click(object sender, EventArgs e)
        {
            eliminarReposicion();
        }
        private void gdrProbabilidadReposicion_KeyPress(object sender, KeyPressEventArgs e) //Permite eliminar con la tecla Delete
        {
            if (e.KeyChar == (char)(Keys.Delete) || (e.KeyChar == (char)(Keys.Back)))
            {
                eliminarReposicion();

            }
        }
        private void eliminarReposicion()
        {
            try
            {
                this.gestor.borrarFila(gdrProbabilidadReposicion.SelectedRows[0].DataBoundItem as RenglonProbabilidad, gestor.TablaProbabilidadReposicion);
                actualizarTablaReposicion();
            }
            catch (Exception exp)
            {
                MessageBox.Show("No hay más filas por borrar", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }
        //////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
        /////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
        private void mostrarConclusion()
        {
            double promedio = this.gestor.PromedioExcesos;
            if (promedio > 0.5)
            {
                lblConclusion.Text = "Para el modelo planteado, LA CAPACIDAD DEL DEPÓSITO NO ES ADECUADA." + "\n" + "Durante la simulación, en más de la mitad de las semanas" + "\n" + "se incurrió a un exceso de almacenamiento lo que aumentó significativamente los costos.";
                lblConclusion.ForeColor = Color.Red;
                lblConclusion.Visible = true;
            }
            else
            {
                lblConclusion.Text = "Para el modelo planteado, LA CAPACIDAD DEL DEPÓSITO ES SUFICIENTE." + "\n" + "Durante la simulación en menos de la mitad de las semanas" + "\n" + "se incurrió a un exceso de almacenamiento.";
                lblConclusion.ForeColor = Color.Green;
                lblConclusion.Visible = true;
            }
            lblPromedio.Text = "Promedio de excesos por semana: " + promedio.ToString();
            lblPromedio.Visible = true;
            lblPromedio.ForeColor = Color.Blue;
        }
    }
}
