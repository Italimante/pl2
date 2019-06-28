using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ComiqueriaLogic.Comun
{
    public static class FormatearPrecio
    {
        public static string testFormato(this double d)
        {
            return string.Format("$ {1}", Math.Round(d).ToString());
        }
    }
}
