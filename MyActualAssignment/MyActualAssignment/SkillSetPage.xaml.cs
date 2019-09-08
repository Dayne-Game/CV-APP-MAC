using System;
using System.Collections.Generic;

using Xamarin.Forms;

namespace MyActualAssignment
{
    public partial class SkillSetPage : ContentPage
    {
        public SkillSetPage()
        {
            InitializeComponent();
        }

        private async void BackToMainPage_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new MainPage());
        }
    }
}
