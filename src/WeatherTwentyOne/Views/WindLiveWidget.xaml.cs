using Microsoft.Maui.Controls;
using Microsoft.Maui.Controls.Xaml;
using System;
using System.Timers;

namespace WeatherTwentyOne.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class WindLiveWidget : Grid
    {
        Random rand;
        private Timer aTimer;

        public WindLiveWidget()
        {
            InitializeComponent();
            
            if (aTimer == null)
                Start();
        }

        public void Start()
        {
            rand = new Random();

            // Create a timer with a two second interval.
            aTimer = new System.Timers.Timer(300);
            // Hook up the Elapsed event for the timer. 
            aTimer.Elapsed += UpdateLiveWind;
            aTimer.AutoReset = true;
            aTimer.Enabled = true;
        }

        public void Stop()
        {
            aTimer.Enabled = false;
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
            if (aTimer == null)
                Start();
            else
                aTimer.Enabled = !aTimer.Enabled;
        }
    }
}