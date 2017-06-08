using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TiendaPC.models;

namespace TiendaPC.interfaces
{
    interface IReparable
    {
        float Precio
        {
            get;
            set;
        }
        void Reparar(float dinero);
    }
}
