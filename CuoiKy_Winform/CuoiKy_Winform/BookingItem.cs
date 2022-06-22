using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CuoiKy_Winform
{
    class BookingItem : FlowLayoutPanel
    {
        public string car_Path { get; set; }

        public PictureBox pcbcar { get; set; }
        public Label lb_info { get; set; }
        public Label lb_soluong { get; set; }
        public NumericUpDown nud { get; set; }
        public CheckBox cb { get; set; }

        public List<PictureBox> lstpcbcar { get; set; }
        public List<Label> lstlb_info { get; set; }
        public List<NumericUpDown> lstnud { get; set; }
        public List<FlowLayoutPanel> lstfpnl { get; set; }
        public List<CheckBox> lstcb { get; set; }
        //public double[] quantity { get; set; }
    }
}
