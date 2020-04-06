using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace App2
{
    // Learn more about making custom code visible in the Xamarin.Forms previewer
    // by visiting https://aka.ms/xamarinforms-previewer
    [DesignTimeVisible(false)]
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();

            ImageButton imgBtn = new ImageButton
            {
                Aspect = Aspect.AspectFill,
                BackgroundColor = Color.Brown,
                Source = "icon_gear_wheel.png",

            };
            imgBtn.Clicked += ImgBtn_Clicked;

            slImageButton.Children.Add(imgBtn);
        }

        private async void ImgBtn_Clicked(object sender, EventArgs e)
        {
            await DisplayAlert("Image Button", "You have clicked code created Image Button", "OK");
        }

        private async void ImageButton_Clicked(object sender, EventArgs e)
        {
            await DisplayAlert("Image Button", "You have clicked XAML based Image Button", "OK");
        }
    }
}
