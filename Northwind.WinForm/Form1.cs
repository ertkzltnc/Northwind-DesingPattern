﻿using Northwind.WinForm.ProductServiceReference;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Northwind.WinForm
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            ServiceOf_ProductDTOClient client = new ServiceOf_ProductDTOClient();
            dataGridView1.DataSource = client.Listind();
            
        }
    }
}
