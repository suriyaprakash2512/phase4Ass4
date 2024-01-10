using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConAppAss
{
    public class Products
    {
        public int Id { get; set; }
        public string? PName { get; set; }
        public int PPrice { get; set; }
        public string? PBrand { get; set; }
        public DateTime MfgDate { get; set; }
        public DateTime ExpDate { get; set; }

    }
}