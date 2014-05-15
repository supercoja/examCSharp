using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net.Http;
using System.IO;

namespace winformTest
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private async void button1_Click(object sender, EventArgs e)
        {
            HttpClient _httpClient = new HttpClient();
            string _content = await _httpClient.GetStringAsync("http://www.microsoft.com").ConfigureAwait(false);
            using (FileStream _sourceStream = new FileStream("temp.html",
                FileMode.Create,FileAccess.Write,FileShare.None,4096,
                useAsync:true))
            {
                byte[] _encodedText = Encoding.Unicode.GetBytes(_content);
                await _sourceStream.WriteAsync(_encodedText, 0, _encodedText.Length).ConfigureAwait(false);
            }
        }
/*
 - Erro de Thread porque não pode acessar a interface do windows form  - output.text ou content
  private async void button1_Click(object sender, EventArgs e)
        {
            HttpClient _httpClient = new HttpClient();
            string _content = await _httpClient.GetStringAsync("http://www.microsoft.com").ConfigureAwait(false);
            Output.Text = _content;
        }
 */
    }
}
