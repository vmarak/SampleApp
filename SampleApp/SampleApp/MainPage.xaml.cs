using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace SampleApp
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }

        private void Entry_Completed(object sender, EventArgs e)
        {
            entry2.Focus();
        }

        private void entry2_Completed(object sender, EventArgs e)
        {
            entry3.Focus();
        }
   
    }
}
