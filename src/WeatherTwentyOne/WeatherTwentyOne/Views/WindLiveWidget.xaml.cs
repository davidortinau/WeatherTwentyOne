using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Timers;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace WeatherTwentyOne.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class WindLiveWidget : ContentView
    {
        Random rand;
        private Timer aTimer;

        public WindLiveWidget()
        {
            InitializeComponent();
            rand = new Random();

            // Create a timer with a two second interval.
            aTimer = new System.Timers.Timer(300);
            // Hook up the Elapsed event for the timer. 
            aTimer.Elapsed += UpdateLiveWind;
            aTimer.AutoReset = true;
            aTimer.Enabled = true;
        }

        void UpdateLiveWind(Object source, ElapsedEventArgs e)
        {
            Needle.RotateTo(WindValues[GetDirection()], 200, Easing.SpringOut);
        }

        double[] WindValues = {98,84,140,92,55};
        private int GetDirection()
        {
            return rand.Next(0, WindValues.Length-1);
        }

        private void TapGestureRecognizer_Tapped(object sender, EventArgs e)
        {
            aTimer.Enabled = !aTimer.Enabled;
        }
    }
}