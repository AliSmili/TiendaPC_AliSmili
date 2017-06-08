using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TiendaPC.Enum;

namespace TiendaPC.models
{
    class Movil : dispositivo
    {

        public SO sistemaOperativo;


        //CONSTRUCTOR

        public Movil(string marca, string modelo, float precio, int pulgadas, SO sis) : base(marca, modelo, precio, pulgadas)
        {
            this.sistemaOperativo = sis;
        }

        public override void Reparar(float dinero)
        {
            throw new NotImplementedException();
        }
    }
}


          















        public override void Reparar(float dinero)
        {
            throw new NotImplementedException();
        }
    }
}
