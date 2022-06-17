using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Simulacion_TP1.Clases
{
    //Clase que representa una fila de la tabla de simulacion
    public class FilaSimulacion
    {
        private int semana;
        private double rndConsumo;
        private double consumo;
        private double rndReposicion;
        private double reposicion;
        private double enAlmacenamiento;
        private double ko;
        private double km;
        private double ks;
        private double costoTotal;
        private double costoAcumulado;
        private double promedio;
        private int huboExceso;
        private double contadorExceso;

        public FilaSimulacion(int semana, double rndConsumo, double consumo, double rndReposicion, double reposicion, double enAlmacenamiento, double ko, double km, double ks, double costoTotal, double costoAcumulado, double promedio, int huboExceso, double contadorExceso)
        {
            this.Semana = semana;
            this.RndConsumo = rndConsumo;
            this.Consumo = consumo;
            this.RndReposicion = rndReposicion;
            this.Reposicion = reposicion;
            this.EnAlmacenamiento = enAlmacenamiento;
            this.Ko = ko;
            this.Km = km;
            this.Ks = ks;
            this.CostoTotal = costoTotal;
            this.CostoAcumulado = costoAcumulado;
            this.Promedio = promedio;
            this.HuboExceso = huboExceso;
            this.ContadorExceso = contadorExceso;
        }

        public int Semana { get => semana; set => semana = value; }
        public double RndConsumo { get => rndConsumo; set => rndConsumo = value; }
        public double Consumo { get => consumo; set => consumo = value; }
        public double RndReposicion { get => rndReposicion; set => rndReposicion = value; }
        public double Reposicion { get => reposicion; set => reposicion = value; }
        public double EnAlmacenamiento { get => enAlmacenamiento; set => enAlmacenamiento = value; }
        public double Ko { get => ko; set => ko = value; }
        public double Km { get => km; set => km = value; }
        public double Ks { get => ks; set => ks = value; }
        public double CostoTotal { get => costoTotal; set => costoTotal = value; }
        public double CostoAcumulado { get => costoAcumulado; set => costoAcumulado = value; }
        public double Promedio { get => promedio; set => promedio = value; }
        public int HuboExceso { get => huboExceso; set => huboExceso = value; }
        public double ContadorExceso { get => contadorExceso; set => contadorExceso = value; }
    }
}
