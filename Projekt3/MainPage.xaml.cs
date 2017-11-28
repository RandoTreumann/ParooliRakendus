using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Controls.Primitives;
using Windows.UI.Xaml.Data;
using Windows.UI.Xaml.Input;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Navigation;

// The Blank Page item template is documented at https://go.microsoft.com/fwlink/?LinkId=402352&clcid=0x409

namespace Projekt3
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class MainPage : Page
    {
        int loginfail = 0;
        public MainPage()
        {
            this.InitializeComponent();
        }
        string kasutajanimi = "Rando";
        string parool = "parool";
       
        private void button1_Click(object sender, RoutedEventArgs e)
        {
            if (loginfail < 3) {
                if (passwordbox1.Password == parool && textbox1.Text == kasutajanimi)
                {
                    textblock1.Text = "Sisselogimine õnnestus!";
                }
                else
                {
                    textblock1.Text = "Sisselogimine ebaõnnestus!";
                    loginfail++;
                }
            }
            else
            {
                textblock1.Text = "Sisestasid 3 korda vale parooli, teil pole enam luba sisselogida!";
            }
        }
    }
}
