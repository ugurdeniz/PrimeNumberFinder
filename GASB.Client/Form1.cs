using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GASB.Client
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //var client = new ServiceReference1.PrimeServiceClient();
            //var n = client.GetJob(new Guid());
            //MessageBox.Show(n.ToString());

            var binding = new BasicHttpBinding();
            var adress = new EndPointAdress(servisin adresi);
            var channel=ChannelFactory<IPrimeService>.
        }
    }
}
