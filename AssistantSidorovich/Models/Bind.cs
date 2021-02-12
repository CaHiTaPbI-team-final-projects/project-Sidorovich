using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using WK.Libraries.HotkeyListenerNS;
namespace AssistantSidorovich.Models
{
    class Bind
    {
        public string FullName { get; set; }
        public string Name { get; set; }
        public int AutoLoad { get; set; }
        public int FirstBind { get; set; }
        public int SecondBind { get; set; }
        public int ThirdBind { get; set; }


        public override string ToString()
        {
            return $"{Name}: {(Keys)FirstBind} + {(Keys)SecondBind} + {(Keys)ThirdBind}";
        }
    }
}
