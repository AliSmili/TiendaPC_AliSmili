using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TiendaPC.models;

namespace TiendaPC
{
    class Program
    {
        static void Main(string[] args)
        {
           
            Tienda cosmopolitans = new Tienda(CargarDispositivos());

            dispositivo p1 = new Movil("LG", "g4", 600.4F, 4, Enum.SO.Windows);
            List<dispositivo> listaMoviles = new List<dispositivo>();

            try
            {
                cosmopolitans.Aniadir(p1 ,listaMoviles );
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
            }

            //Fin de programa
            Console.ReadLine();
        }
    

        private static List<dispositivo> CargarDispositivos()             
        {
            var lista = new List<dispositivo>();
            var listaComponentes = new List<string>();          //Para aniadir componentes, hay que generar un constructor de varios parametros

            lista.Add(new Movil("sony", "g3", 320.4F, 4, Enum.SO.iOS));
            lista.Add(new Movil("LG", "g4", 600.4F, 4, Enum.SO.Windows));
            lista.Add(new Tablet("samsung", "galaxy s9", 700f, 4, Enum.SO.Windows));
            lista.Add(new Portatil("HP", "Pavilion", 1000f, 17, Enum.RAM._32GB, listaComponentes, "I7", "Windows10"));



            return lista;
        }

      
    }

    }

    

