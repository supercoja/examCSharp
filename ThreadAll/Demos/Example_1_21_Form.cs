using System;
using System.Net.Http;
using System.Windows.Forms;
using System.IO;
using System.Text;

namespace Demos
{
    public partial class Example_1_21_Form : Form
    {
        public Example_1_21_Form()
        {
            InitializeComponent();
        }

        private async void button1_Click(object sender, EventArgs e)
        {
            HttpClient httpClient = new HttpClient();
            string _contentSite = await httpClient
                .GetStringAsync("http://www.microsoft.com")
                .ConfigureAwait(false);
            using (FileStream _sourceStream = new FileStream("temp.html",
                FileMode.Create, FileAccess.Write, FileShare.None, 4096,
                useAsync: true))
            {
                byte[] _encodedText = Encoding.Unicode.GetBytes(_contentSite);
                await _sourceStream.WriteAsync(_encodedText, 0, _encodedText.Length).ConfigureAwait(false);
            };
        }
    }
}
