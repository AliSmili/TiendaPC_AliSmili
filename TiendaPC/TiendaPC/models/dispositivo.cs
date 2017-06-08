using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using TiendaPC.interfaces;


namespace TiendaPC.models
{
    abstract class dispositivo : IReparable
    {

        private string _marca;
        private string _modelo;
        private float _precio;


        private int _pulgadas;

        //CONSTRUCTORES

        public dispositivo(string marca, string modelo)
        {
            this.Modelo = modelo;
            this.Marca = marca;
        }

        public dispositivo(string marca, string modelo, float precio, int pulgadas)
        {
            this.Modelo = modelo;
            this.Marca = marca;
            this.Precio = precio;
            this._pulgadas = pulgadas;
        }



        public abstract void Reparar(float dinero);


        public virtual string GenerarMAC()
        {
            var mac = "";                                   //Generar un random al gusto
            return mac;
        }

        public override string ToString()
        {
            return String.Format("{0} {1}", Marca, Modelo);
        }

        //gettes y setters

        public int Pulgadas
        {

            get
            {
                return _pulgadas;
            }
            set
            {
                if (value <= 0 || value > 1000) throw new Exception("Valor de pulgadas surrealista!");
                _pulgadas = value;
            }

        }

        public float Precio
        {
            get
            {
              
                return _precio;
            }

            set
            {
                
                if (value <= 0) throw new Exception("El valor del precio np puede ser nulo o negativo !");


            }
        }

        public string Marca
        {
            get
            {
                return _marca;
            }
            set
            {
                if (value == null) throw new Exception("Hay que introducier la marca !");
                _marca = value;
            }


        }


        public string Modelo
        {
            get
            {
                return _modelo;
            }
            set
            {
                if (value == null) throw new Exception("Hay que itroducir el modelo !");
                _modelo = value;
            }


        }

    }
}
    
