using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TiendaPC.models;

namespace TiendaPC.models
{
    class Tienda
    {
        public List<dispositivo> Productos;


        public Tienda(List<dispositivo> productos)
        {
            this.Productos = productos;
        }


        //Metodos aniadir, Reparar, entregar

        public void Reparar(dispositivo p, float precio)
        {
            if (precio < p.Precio) throw new Exception("Si no pagas el precio de la reparacion, no hay manera de entregar el producto !");
           p.Reparar(precio);
        }

        public void Aniadir(dispositivo p, IList<dispositivo> lista)
        {
            if (!lista.Contains(p))
            
                throw new Exception("El dispositivo no se encuentra en la tienda !");
            
            lista.Add(p);
        }

        public dispositivo Entregar( List<dispositivo> lista, dispositivo p)
        {
            if (!lista.Contains(p))
            {
                throw new Exception("El dispositivo no se encuentra en la tienda !");
            }
            else
            {
                lista.Remove(p);
                return p;
            }
        }





    }
}
