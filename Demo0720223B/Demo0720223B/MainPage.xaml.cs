using Demo0720223B.Interfaces;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace Demo0720223B
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }

        private void btnSpeak_Clicked(object sender, EventArgs e)
        {

         DependencyService.Get<ITextToSpeech>().Speak(txtMessage.Text);
            
        }
    }
}
