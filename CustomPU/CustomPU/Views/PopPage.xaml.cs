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
    public partial class PopPage : ContentPage
    {
        public PopPage()
        {
            InitializeComponent();

            MessagingCenter.Subscribe<HomePage, Quest>(this, "Question", (page, data) => {

                _lblQuest.Text = data.questions;
                _lblans1.Text = data.answer1;
                _lblans2.Text = data.answer2;
            });
        }
    }
}