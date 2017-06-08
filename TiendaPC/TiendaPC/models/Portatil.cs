using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TiendaPC.Enum;

namespace TiendaPC.models
{
    class Portatil : dispositivo
    {

        private RAM ram;
        private string procesador;
        private String sistema;
        private List<string> _componentes ;


        //CONSTRUCTOR

        public Portatil(string marca, string modelo, float precio, int pulgadas, RAM ram,  List<String> Componentes, string procesador, String sistema):base(marca, modelo, precio, pulgadas)
        {
            this.ram = ram;
            this.procesador = procesador;
            this.sistema = sistema;
            this._componentes = Componentes;
          
        }

        public override void Reparar(float dinero)
        {
            throw new NotImplementedException();
        }

        public List<string> Componentes
        {
            get
            {
                return _componentes;
            }
            set
            {
                _componentes = value;
            }
        }
    }
}
