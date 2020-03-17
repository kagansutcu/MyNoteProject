using Model.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    public class Not:BaseEntity
    {

        public string Subject { get; set; }
        public string Contain { get; set; }
        public SignificanceLevel Level { get; set; }
    }
}
