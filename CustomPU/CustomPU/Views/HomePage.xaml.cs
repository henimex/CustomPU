using CustomPU.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace CustomPU.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class HomePage : ContentPage
    {
        public HomePage()
        {
            InitializeComponent();
        }

        public void test()
        {
            var data = new Quest
            {
                questions = "Soru 1", answer1 = "Evet", answer2 = "Hayır"
            };

            MessagingCenter.Send<HomePage, Quest>(this, "Questions", data);
        }
    }
}