using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TableListSample.ViewModels;
using Xamarin.Forms;

namespace TableListSample.Pages
{
    public partial class SamplePage : ContentPage
    {
        public SamplePage()
        {
            InitializeComponent();

            this.BindingContext = new SampleViewModel();
        }
    }
}
