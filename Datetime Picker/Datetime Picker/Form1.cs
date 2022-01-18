﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Datetime_Picker
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnRezervacija_Click(object sender, EventArgs e)
        {
            txtIspis.Clear();

            DateTime datum = dtpDatum.Value;
            DateTime Vrijeme = dtpVrijeme.Value;

            StringBuilder ispis = new StringBuilder();
            ispis.Append("Vaš datum leta je: ");
            ispis.Append(datum.ToShortDateString()+"\n");
            ispis.Append("Vaše vrijeme polaska je: ");
            ispis.Append(Vrijeme.ToShortTimeString());

            string ispis2 = "Vaš datum leta je "
                + datum.ToShortDateString()
                + "\n" + "Vaše vrijeme polaska je: "
                + Vrijeme.ToShortTimeString();

            txtIspis.Text = ispis.ToString();
            txtIspis.AppendText (Environment.NewLine + ispis2);


        }
    }
}
