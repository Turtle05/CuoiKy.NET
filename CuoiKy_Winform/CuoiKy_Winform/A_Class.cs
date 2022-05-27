﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CuoiKy_Winform
{
    public partial class A_Class : Form
    {
        static string frmStatus = "Active";
        String pathA200 = "C:\\Users\\ADMIN\\Documents\\GitHub\\CuoiKy.NET\\CuoiKy_Winform\\CuoiKy_Winform\\Resources\\A200.jpg";
        String pathA220 = "C:\\Users\\ADMIN\\Documents\\GitHub\\CuoiKy.NET\\CuoiKy_Winform\\CuoiKy_Winform\\Resources\\A220.jpg";
        String pathA45 = "C:\\Users\\ADMIN\\Documents\\GitHub\\CuoiKy.NET\\CuoiKy_Winform\\CuoiKy_Winform\\Resources\\A45.jpg";

        public A_Class()
        {
            InitializeComponent();
            pcbA200.Image = Image.FromFile(pathA200);
            pcbA220.Image = Image.FromFile(pathA220);
            pcbA45.Image = Image.FromFile(pathA45);
        }

        private void pcbA200_Click(object sender, EventArgs e)
        {
            frmStatus = "Hidden";
            new Booking().Show();
        }
    }
}
