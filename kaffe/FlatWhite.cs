using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace kaffe
{
    public class FlatWhite : Kaffe, Imælk
    {
        /// <summary>
        /// hvor meget mælk skal bruge i FlatWhite
        /// </summary>
        /// <returns></returns>
        public int MlMælk()
        {
            return 160;
        }

        /// <summary>
        /// prisen på en FlatWhite
        /// </summary>
        /// <returns></returns>
        public override int Pris()
        {
            return 45;
        }

        /// <summary>
        /// styrken på en FlatWhite
        /// </summary>
        /// <returns></returns>
        public override string Styrke()
        {
            return "Mild";
        }
    }
}
