using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AssistantSidorovich.Models
{
    class Bind
    {
        public string FullName { get; set; }
        public string Name { get; set; }
        public Keys first { get; set; }
        public Keys second { get; set; }
        public Keys third { get; set; }
        public int AutoLoad { get; set; }

        public override string ToString()
        {
            return $"{Name}: {first} + {second} + {third}";
        }
    }
}
