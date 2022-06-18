using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CuoiKy_Winform
{
    interface General
    {
        List<string> carName { get; set; }
        List<string> carPath { get; set; }
        Booking bk { get; set; }
    }
}
