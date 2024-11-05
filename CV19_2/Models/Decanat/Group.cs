using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CV19_2.Models.Decanat
{
    public class Group
    {
        public string Name { get; set; }
        public ICollection<Student> Students { get; set; }
        public string Description { get; set; }
    }
}
