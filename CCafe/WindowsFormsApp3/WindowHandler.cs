using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp3
{
    static public class WindowHandler
    {

         public static CMain cmain;
         public static CFeedback cfeedback;
         public static CSUBS csubs;

        public static void Intialaize()
        {
             cmain = new CMain();
             cfeedback = new CFeedback();
             csubs = new CSUBS();
        }
    }
}
