using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TiendaPC.Enum;

namespace TiendaPC.models
{
    class PC : dispositivo
    {
        private RAM ram;
        private String FuenteAlimentacion;
        private IList<String> Componentes;
        private string procesador;
        private String sistema;


        //CONSTRUCTORES

        public PC(string marca, string modelo, float precio, int pulgadas, RAM ram, string fuente, IList<String> Componentes, string procesador, String sistema):base(marca, modelo, precio, pulgadas)
        {
            this.ram = ram;
            this.FuenteAlimentacion = fuente;
            this.Componentes = Componentes;
            this.procesador = procesador;
            this.sistema = sistema;
        }

        public override void Reparar(float dinero)
        {
            throw new NotImplementedException();
        }
    }
}
