﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UniversityLibraryManagement
{
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        private void Form3_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'Library_Management_SystemDataSet.STUDENT' table. You can move, or remove it, as needed.
            this.STUDENTTableAdapter.Fill(this.Library_Management_SystemDataSet.STUDENT);

            this.reportViewer1.RefreshReport();
        }
    }
}
