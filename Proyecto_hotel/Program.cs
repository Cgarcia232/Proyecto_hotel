using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Proyecto_hotel {

    public class Program {

        public static void Main (String[] args) { 
        //Camila: flujo principal:creé un menú espero sirva, se puede adapatar, muestra las opciones y según la opción elegida se ejecutan las distintas opciones. 
            bool fin = true;
            while (fin)
            {
                Console.WriteLine(" Bienvenido");
                Console.WriteLine("1.Reservar habitación");
                Console.WriteLine("0.Salir");
                string opcion = Console.ReadLine();
                switch (opcion)
                {
                    case "1":

                        break;
                    case "0":
                        Console.WriteLine("Hasta pronto");
                        fin = false;
                        break;
                }
            }
        
        }
        //Camila: aquí realize un método para pedir el tipo de pago que se va a realizar. 
        public int tipo_pago()  
        {
            bool fin = false;
            while(!false){

                Console.WriteLine("---------Tipo de pago---------");
                Console.WriteLine("Selecione un ipo de pago");
                Console.WriteLine("1.Débito");
                Console.WriteLine("2.Crédito");
                Console.WriteLine("3.Tranferencia directa");
                Console.WriteLine("4.Efectivo");
                string respuesta = Console.ReadLine();
                switch (respuesta)
                {
                    case "1":
                    case "2":
                    case "3":
                    case "4":
                        fin = true;
                        return Convert.ToInt32(respuesta);
                    break;
                    default:
                        Console.WriteLine("No se reconoce la opción ingresada, intente nuevamente");
                        Console.ReadLine();
                        break;
                }

            } 
        }
       
        


}



}

