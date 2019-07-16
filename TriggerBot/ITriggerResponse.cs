using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cinnamine
{
    public interface ITriggeredAction
    {
        void OnColourUpdate(Color color, ParsableDynamicObject config);
    }
}
