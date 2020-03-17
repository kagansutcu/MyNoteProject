using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    public class Hata: BaseEntity
    {
        public string TypeOf { get; set; }
        public string WhyFor { get; set; }
        public string Howfixed { get; set; }
    }
}
