using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Imaging;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Newtonsoft.Json;

namespace BigApp.Forms
{
    [System.ComponentModel.TypeConverter(typeof(System.Windows.Forms.OpacityConverter))]
    
    public partial class FormCurrency : Form
    {
        public string test;
        //public new double Opacity { get; set; }
        public FormCurrency()
        {
            InitializeComponent();
            
        }

        public class MyJson
        {
            public int r030 { get; set; }
            public string txt { get; set; }
            public double rate { get; set; }
            public string cc { get; set; }
            public string exchangedate { get; set; }
        }

        public async void FormCurrency_Load(object sender, EventArgs e)
        {
            GetValutes getValutes = new GetValutes();

            await getValutes.GetResponse();

            test = getValutes.respJson;

            var jsnConvert = JsonConvert.DeserializeObject<List<MyJson>>(test);

            foreach (var currency in jsnConvert)
            {

                listCurrency.Items.Add(currency.cc);

            }
            var ww = jsnConvert[0];
            //textBox2.Text = $"Info {ww.r030}";

            




            this.Opacity = .50;
            //this.BackColor = Color.Transparent;
            this.BackgroundImage = ThemeColor.SetImageOpacity(BackgroundImage, 0.10F);
        }

        private void result_TextChanged(object sender, EventArgs e)
        {
           
        }

        private async void listCurrency_SelectedIndexChanged(object sender, EventArgs e)
        {
            GetValutes getValutes = new GetValutes();

            await getValutes.GetResponse();

            test = getValutes.respJson;

            var jsnConvert = JsonConvert.DeserializeObject<List<MyJson>>(test);

            switch (listCurrency.Text)
            {
                case "AUD":
                    priceToUAH.Text = $"{jsnConvert[0].rate}";
                    NameOfValute.Text = $"{jsnConvert[0].txt}";
                    break;

                case "CAD":
                    priceToUAH.Text = $"{jsnConvert[1].rate}";
                    NameOfValute.Text = $"{jsnConvert[1].txt}";
                    break;

                case "CNY":
                    priceToUAH.Text = $"{jsnConvert[2].rate}";
                    NameOfValute.Text = $"{jsnConvert[2].txt}";
                    break;

                case "HRK":
                    priceToUAH.Text = $"{jsnConvert[3].rate}";
                    NameOfValute.Text = $"{jsnConvert[3].txt}";
                    break;

                case "CZK":
                    priceToUAH.Text = $"{jsnConvert[4].rate}";
                    NameOfValute.Text = $"{jsnConvert[4].txt}";
                    break;

                case "DKK":
                    priceToUAH.Text = $"{jsnConvert[5].rate}";
                    NameOfValute.Text = $"{jsnConvert[5].txt}";
                    break;

                case "HKD":
                    priceToUAH.Text = $"{jsnConvert[6].rate}";
                    NameOfValute.Text = $"{jsnConvert[6].txt}";
                    break;

                case "HUF":
                    priceToUAH.Text = $"{jsnConvert[7].rate}";
                    NameOfValute.Text = $"{jsnConvert[7].txt}";
                    break;

                case "INR":
                    priceToUAH.Text = $"{jsnConvert[8].rate}";
                    NameOfValute.Text = $"{jsnConvert[8].txt}";
                    break;

                case "IDR":
                    priceToUAH.Text = $"{jsnConvert[9].rate}";
                    NameOfValute.Text = $"{jsnConvert[9].txt}";
                    break;



            }

            //if (listCurrency.Text == "USD")
            //{

            //    priceToUAH.Text = $"{jsnConvert[25].rate}";
            //}
            //if (listCurrency.Text == "AUD")
            //{

            //    priceToUAH.Text = $"{jsnConvert[0].rate}";
            //}

            

        }

        private void priceToUAH_TextChanged(object sender, EventArgs e)
        {

        }

        private void summ_TextChanged(object sender, EventArgs e)
        {

        }

        private async void btnConvert_Click(object sender, EventArgs e)
        {
            GetValutes getValutes = new GetValutes();

            await getValutes.GetResponse();

            test = getValutes.respJson;

            var jsnConvert = JsonConvert.DeserializeObject<List<MyJson>>(test);

            double a = Convert.ToDouble(summ.Text);
            double b = Convert.ToDouble(priceToUAH.Text);

            result.Text = $"{a * b}";
        }

        private void btnCopy_Click(object sender, EventArgs e)
        {
            string textData = $"{result.Text}";
            Clipboard.SetData(DataFormats.Text, (Object)textData);
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            result.Text = "";
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {
            this.BackColor = Color.FromArgb(215, 228, 242);
        }
    }
}
