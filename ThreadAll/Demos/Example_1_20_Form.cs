﻿using System;
using System.Net.Http;
using System.Windows.Forms;

namespace Demos
{
    public partial class Example_1_20_Form : Form
    {
        public Example_1_20_Form()
        {
            InitializeComponent();
        }

        private async void button1_Click(object sender, EventArgs e)
        {
            HttpClient httpClient = new HttpClient();
            string _contentSite = await httpClient
                .GetStringAsync("http://www.microsoft.com")
                .ConfigureAwait(false);
            txtOutput.Text = _contentSite;
        }
    }
}
