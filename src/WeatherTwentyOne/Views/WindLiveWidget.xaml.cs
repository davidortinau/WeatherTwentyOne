using Microsoft.Maui;
using Microsoft.Maui.Controls;
using System;
using System.Timers;

namespace WeatherTwentyOne.Views
{
    public partial class WindLiveWidget
    {
        Random rand;
        Timer aTimer;

        public WindLiveWidget()
        {
            InitializeComponent();

            if (aTimer == null && Device.RuntimePlatform != Device.Android)
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

        void UpdateLiveWind(object source, ElapsedEventArgs e)
        {
            var direction = GetDirection();

            Device.BeginInvokeOnMainThread(() =>
            {
                Needle.RotateTo(WindValues[direction], 200, Easing.SpringOut);
            });
        }

        readonly double[] WindValues = { 98, 84, 140, 92, 55 };

        private int GetDirection()
        {
            return rand.Next(0, WindValues.Length - 1);
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