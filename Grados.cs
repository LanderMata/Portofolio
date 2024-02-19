using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Temperaturas
{
    public static class Grados
    {
        //Métodos estáticos para convertir de grados centígrados a farenheit
        public static double Cent_a_Far(double gradosC)
        {

            return (gradosC * 9 / 5) + 32;

        }
        //Métodos estáticos para convertir de grados farenheit a centígrados
        public static double Far_a_Cent(double gradosF)
        {

            return (gradosF - 32) * 5 / 9;

        }
    }
}
