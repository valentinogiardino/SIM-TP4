using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using Simulacion_TP1.Clases;

namespace Simulacion_TP1.Controlador
{
    public class Gestor
    {
        private Pantalla pantalla;
        private List<RenglonProbabilidad> tablaProbabilidadReposicion;
        private List<RenglonProbabilidad> tablaProbabilidadConsumo;
        private double stockInicial;
        private double ko;
        private double km;
        private double ks;
        private double qo; //tope almacenamiento
        private int cantidadSemanas;
        private int semanaDesde;
        private double promedioExcesos;

        public Pantalla Pantalla { get => pantalla; set => pantalla = value; }
        public List<RenglonProbabilidad> TablaProbabilidadReposicion { get => tablaProbabilidadReposicion; set => tablaProbabilidadReposicion = value; }
        public List<RenglonProbabilidad> TablaProbabilidadConsumo { get => tablaProbabilidadConsumo; set => tablaProbabilidadConsumo = value; }
        public double StockInicial { get => stockInicial; set => stockInicial = value; }
        public double PromedioExcesos { get => promedioExcesos; set => promedioExcesos = value; }

        public Gestor(Pantalla pantalla)
        {
            this.pantalla = pantalla;
        }

        //////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
        //Setea los metodos del gestor
        public void tomarDatos(int cantidadSemanas, int semanaDesde, double costoAlmacenamiento, double costoPedido, double costoSobrepaso, double capacidadActual, List<RenglonProbabilidad> tablaProbabilidadConsumo, List<RenglonProbabilidad> tablaProbabilidadReposicion, double stockInicial)
        {
            this.cantidadSemanas = cantidadSemanas;
            this.semanaDesde = semanaDesde;
            this.km = costoAlmacenamiento;
            this.ko = costoPedido;
            this.ks = costoSobrepaso;
            this.qo = capacidadActual;
            this.stockInicial = stockInicial;
            this.TablaProbabilidadConsumo = tablaProbabilidadConsumo;
            this.tablaProbabilidadReposicion = tablaProbabilidadReposicion;
            

        }


        //////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
      

        public List<RenglonProbabilidad> generarTablaInicialProbabilidadConsumo()       //Datos iniciales del enunciado
        {
           
            this.tablaProbabilidadConsumo = new List<RenglonProbabilidad>();
            RenglonProbabilidad renglon1 = new RenglonProbabilidad(6000, 0.05);         
            RenglonProbabilidad renglon2 = new RenglonProbabilidad(7000, 0.15);         
            RenglonProbabilidad renglon3 = new RenglonProbabilidad(8000, 0.2);         
            RenglonProbabilidad renglon4 = new RenglonProbabilidad(9000, 0.3);         
            RenglonProbabilidad renglon5 = new RenglonProbabilidad(10000, 0.2);
            RenglonProbabilidad renglon6 = new RenglonProbabilidad(11000, 0.1);
            this.tablaProbabilidadConsumo.Add(renglon1);
            this.tablaProbabilidadConsumo.Add(renglon2);
            this.tablaProbabilidadConsumo.Add(renglon3);
            this.tablaProbabilidadConsumo.Add(renglon4);
            this.tablaProbabilidadConsumo.Add(renglon5);
            this.tablaProbabilidadConsumo.Add(renglon6);

            return this.tablaProbabilidadConsumo;

        }

        public List<RenglonProbabilidad> generarTablaInicialProbabilidadReposicion()        //Datos iniciales del enunciado
        {

            this.tablaProbabilidadReposicion = new List<RenglonProbabilidad>();
            RenglonProbabilidad renglon1 = new RenglonProbabilidad(8000, 0.6);
            RenglonProbabilidad renglon2 = new RenglonProbabilidad(11000, 0.4);
            this.tablaProbabilidadReposicion.Add(renglon1);
            this.tablaProbabilidadReposicion.Add(renglon2);

            return this.tablaProbabilidadReposicion;
        }

        //////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
        public void borrarFila(RenglonProbabilidad renglon, List<RenglonProbabilidad> tablaProbabilidad)    //Borra una fila de la tabla de probabilidad recibida por parametro
        {
            tablaProbabilidad.Remove(renglon);
        }
        public void agregarFila(double cantidad, double probabilidad, List<RenglonProbabilidad> tablaProbabilidad)  //Agrega una fila a la tabla de probabilidad recibida por parametro
        {
            RenglonProbabilidad renglon = new RenglonProbabilidad(cantidad, probabilidad);
            tablaProbabilidad.Add(renglon);
        }
        //////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
        public void completarTablas()       //Se llama a los metodos para completar las dos tabals de probabilidad y se las setea a los atributos del gestor
        {
            this.tablaProbabilidadConsumo = completarTablaProbabilidad(this.tablaProbabilidadConsumo);
            this.TablaProbabilidadReposicion = completarTablaProbabilidad(this.TablaProbabilidadReposicion);
        }

        public List<RenglonProbabilidad> completarTablaProbabilidad(List<RenglonProbabilidad> tablaProbabilidad)     //Itera los renglones de la tabla completa renglon a renglon
        {
            List<RenglonProbabilidad> tablaProbabilidadCompleta = new List<RenglonProbabilidad>();
            foreach (RenglonProbabilidad renglon in tablaProbabilidad)
            {
                tablaProbabilidadCompleta = completarRenglon(renglon, tablaProbabilidadCompleta);
            }
            return tablaProbabilidadCompleta;
        }

        private List<RenglonProbabilidad> completarRenglon(RenglonProbabilidad renglon, List<RenglonProbabilidad> tablaProbabilidadCompleta)    //Completa el renglon de la tabla de probabilidad 
        {                                                                                                                                       //Calculando su Pac e intervalos
            if (tablaProbabilidadCompleta.Count == 0)
            {
                renglon.ProbabilidadAc = renglon.Probabilidad;
                renglon.Desde = 0;
                renglon.Hasta = renglon.Desde + renglon.Probabilidad;
                
            }
            else
            {
                RenglonProbabilidad renglonAnterior = tablaProbabilidadCompleta.Last();
                //Ceiling se usa para redondear para arriba. Se incluyó debido a un problema con la presicion de los double, no es tan preciso como "decimal"
                renglon.ProbabilidadAc = Math.Ceiling((renglonAnterior.ProbabilidadAc + renglon.Probabilidad) * 100) / 100;                                                                                              
                renglon.Desde = Math.Ceiling((renglonAnterior.Hasta)*100)/100;                                                      
                renglon.Hasta = Math.Ceiling((renglon.Desde + renglon.Probabilidad) * 100) / 100;
            }

            tablaProbabilidadCompleta.Add(renglon);
            return tablaProbabilidadCompleta;

        }

        //////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
        //genera la tabla de la simulacion
        public List<FilaSimulacion> generarTablaSimulacion()
        {
            Random generadorRandomConsumo = new Random();       //Se crea un generador de RNDs para el consumo
            Random generadorRandomReposicion = new Random(100); //Se crea un generador de RNDs para la reposicion
            FilaSimulacion filaNueva = null;
            List<FilaSimulacion> listaFilasMuestra = new List<FilaSimulacion>();
            for (int i = 0; i <= this.cantidadSemanas; i++)     //Se genera la simulacion para las N semanas ingresadas
            {
                filaNueva = generarRenglones(i, filaNueva, generadorRandomConsumo, generadorRandomReposicion);
                if (this.semanaDesde <= i && i <= (this.semanaDesde + 400) || i == cantidadSemanas)  //Si pertenece a las semanas que se piden mostrar, se la guarda en la lista de filas a mostrar
                {
                    listaFilasMuestra.Add(filaNueva);
                }
            }
            this.PromedioExcesos = filaNueva.ContadorExceso / filaNueva.Semana;
            return listaFilasMuestra;
        }

        private FilaSimulacion generarRenglones(int i, FilaSimulacion filaAnterior, Random generadorRandomConsumo, Random generadorRandomReposicion)  //Genera el renglon de la tabla de simulacion
        {
            FilaSimulacion filaNueva;
            

            if (i == 0)     //Generacion de la fila para la Semana 0.
            {
                FilaSimulacion fila = new FilaSimulacion(0, 0, 0, 0, 0, this.stockInicial, 0, 0, 0, 0, 0, 0, 0, 0);
                filaNueva = fila;
            }
            else            //Generacion de las demas filas
            {
                double rndConsumo = generadorRandomConsumo.NextDouble();          //obtiene el siguiente RND del generador de randoms de Consumo
                double consumo = obtenerCantidad(rndConsumo, this.tablaProbabilidadConsumo);
                double rndReposicion = generadorRandomReposicion.NextDouble();    //obtiene el siguiente RND del generador de randoms de Reposicion
                double reposicion = obtenerCantidad(rndReposicion, this.tablaProbabilidadReposicion);
                double almacenamiento = filaAnterior.EnAlmacenamiento + reposicion - consumo;   //Calculo del almacenamiento actual
                double ko = this.ko;                                    //Como en todas las semanas se hace un pedido, el costo de pedido será una constante para todas las semanas de la simulacion                                                                
                double km = obtenerKm(almacenamiento);
                double ks = obtenerKs(almacenamiento);
                double costoTotal = ko + km + ks;                                       //calcula el costo total
                double costoAcumulado = costoTotal + filaAnterior.CostoAcumulado;       //calcula el costo acumulado
                double promedio = costoAcumulado / i;                                   //calcula el promedio
                int huboExceso = hayExceso(ks);
                double contadorExceso = filaAnterior.ContadorExceso + huboExceso;       //cuenta todos las semanas que hubo exceso de almacenamiento

                filaNueva = new FilaSimulacion(i, rndConsumo, consumo, rndReposicion, reposicion, almacenamiento, ko, km, ks, costoTotal, costoAcumulado, promedio, huboExceso, contadorExceso);
            }
            return filaNueva;

        }

        private double obtenerCantidad(double rnd, List<RenglonProbabilidad> tablaProbabilidad)
        {
            double cantidad = -1;
            foreach (RenglonProbabilidad renglon in tablaProbabilidad)      //Recorre la tabla de probabilidad y retorna la cantidad correspondiente para el rnd segun los intervalos
            {
                if (rnd < renglon.Hasta)
                {
                    cantidad = renglon.Cantidad;
                    break;
                }
            }
            return cantidad;
        }

        private double obtenerKm(double almacenamiento) //calcula el costo de mantenimiento para el almacenamiento actual
        {
            if (almacenamiento >= 0)
            {
                return (this.km * almacenamiento);
            }
            return 0;
        }
        private double obtenerKs(double almacenamiento) //Calcula el costo de exceso de almacenamiento para el almacentamienot actual
        {
            double exceso = almacenamiento - this.qo;
            if (exceso > 0)
            {
                return this.ks * exceso;
            }
            return 0;
        }
        private int hayExceso(double ks)        //Bandera para indicar si en la semana hubo exceso. 1 es SI, 0 NO.
        {
            if (ks > 0)
            {
                return 1;
            }
            return 0;
        }

         



    }
}
