using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WMS.Models
{
    public partial class Document
    {
        public double? TotalGross { get { return DocumentPosition.Sum(x => x.Amount * x.Gross); } }
        public double? TotalNet { get { return DocumentPosition.Sum(x => x.Amount * x.Net); } }

    }
}
