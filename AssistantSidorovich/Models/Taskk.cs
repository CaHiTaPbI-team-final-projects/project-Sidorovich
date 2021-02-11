using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AssistantSidorovich.Models
{
    class Taskk
    {
        public string Title { get; set; }
        public string Description { get; set; }
        public string Deadline { get; set; }

        public override string ToString()
        {
            return $"{Title}   {Deadline}";
        }
    }
}
