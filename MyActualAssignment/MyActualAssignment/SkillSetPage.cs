using System;

using Xamarin.Forms;

namespace MyActualAssignment
{
    public class SkillSetPage : ContentPage
    {
        public SkillSetPage()
        {
            Content = new StackLayout
            {
                Children = {
                    new Label { Text = "Hello ContentPage" }
                }
            };
        }
    }
}

