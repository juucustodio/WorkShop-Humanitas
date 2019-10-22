using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace DemoHumanitas
{
    // Learn more about making custom code visible in the Xamarin.Forms previewer
    // by visiting https://aka.ms/xamarinforms-previewer
    [DesignTimeVisible(false)]
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }

        private void Somar(object sender, System.EventArgs e)
        {
            
            int primeiro = int.Parse(NumeroUm.Text);
            int segundo = int.Parse(NumeroDois.Text);
            int resultado = primeiro + segundo;

            LabelResultado.Text = "Total: "+ resultado.ToString();
        }
    }
}
