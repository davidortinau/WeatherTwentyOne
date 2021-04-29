using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Microsoft.Maui.Controls;
using Microsoft.Maui.Controls.Xaml;

namespace WeatherTwentyOne.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Next24HrWidget : StackLayout
    {
        public Next24HrWidget()
        {
            InitializeComponent();
        }
    }
}