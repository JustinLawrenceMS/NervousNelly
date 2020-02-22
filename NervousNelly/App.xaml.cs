using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace NervousNelly
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();

            CarouselPage carouselPage = new CarouselPage();

            MainPage mainPage = new MainPage();
            carouselPage.Children.Add(mainPage);
            carouselPage.Children.Add(new CrudPage1());

            MainPage = carouselPage;

        }

        protected override void OnStart()
        {
        }

        protected override void OnSleep()
        {
        }

        protected override void OnResume()
        {
        }
    }
}
