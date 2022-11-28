using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ThorHulkFight
{
    internal class CannotTeleport : ITeleports
    {
        public string teleport()
        {
            return "Fails at Teleporting";
        }
    }
}
