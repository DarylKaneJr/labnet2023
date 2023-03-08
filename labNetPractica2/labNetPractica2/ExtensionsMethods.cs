using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace labNetPractica2
{
    public static class ExtensionsMethods
    {
        // punto 1
        public static string DividorPorCero(this decimal numero)
        {
            string mensaje = "";
            string mensaje2 = "";
            try
            {
               numero = numero / 0;
            }
            catch (DivideByZeroException ex)
            {
                throw ex;
            }
            finally
            {
                mensaje2 = " Fin de punto 1";
            }
            return mensaje + mensaje2;
        }

        // Punto 2
        public static string Dividir(decimal i, decimal j)
        {
            string mensaje = "";
            string mensajeex = "";
            string messajefinally = "";
            try
            {
                decimal division = i / j;
                division = decimal.Round(division, 2);
                mensaje = "El resultado es " + division;
            }
            catch (DivideByZeroException ex)
            {
                mensaje = "Solo Chuck Norris divide por cero! usted no lo es y " + ex.Message;        
            }
            finally
            {
                messajefinally = " ..Operacion finalizada";
            }
            return mensaje + mensajeex + messajefinally;
        }
    }
}
