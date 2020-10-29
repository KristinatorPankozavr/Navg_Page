using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace Navg_Page
{
    public partial class MainPage : ContentPage
    {
        private View esm_Button;


        public MainPage()
        {
            StackLayout bib = new StackLayout();
            ScrollView scrollView = new ScrollView { Content = bib };
            BackgroundColor = Color.BurlyWood;

            Button Esm_Button = new Button { Text = "Понедельник", ImageSource = "f.png"};
            bib.Children.Add(Esm_Button);
            Esm_Button.Clicked += EsmButton_Clicked;
            Esm_Button.BackgroundColor = Color.Transparent;
            BackgroundColor = Color.Wheat;

            Button Teis_Button = new Button { Text = "Вторник", ImageSource = "d.png" };
            bib.Children.Add(Teis_Button);
            Teis_Button.Clicked += TeisButton_Clicked;
            Teis_Button.BackgroundColor = Color.Transparent;
            BackgroundColor = Color.Wheat;

            Button Kolm_Button = new Button { Text = "Среда", ImageSource = "e.png" };
            bib.Children.Add(Kolm_Button);
            Kolm_Button.Clicked += KolmButton_Clicked;
            Kolm_Button.BackgroundColor = Color.Transparent;
            BackgroundColor = Color.Wheat;

            Button Nel_Button = new Button { Text = "Четверг", ImageSource = "a.png" };
            bib.Children.Add(Nel_Button);
            Nel_Button.Clicked += NelButton_Clicked;
            Nel_Button.BackgroundColor = Color.Transparent;
            BackgroundColor = Color.Wheat;

            Button Reede_Button = new Button { Text = "Пятница", ImageSource = "g.png" };
            bib.Children.Add(Reede_Button);
            Reede_Button.Clicked += ReedeButton_Clicked;
            Reede_Button.BackgroundColor = Color.Transparent;
            BackgroundColor = Color.Wheat;

            Button Lau_Button = new Button { Text = "Суббота", ImageSource = "c.png" };
            bib.Children.Add(Lau_Button);
            Lau_Button.Clicked += LauButton_Clicked;
            Lau_Button.BackgroundColor = Color.Transparent;
            BackgroundColor = Color.Wheat;

            Button Puh_Button = new Button { Text = "Воскресенье", ImageSource = "b.png" };
            bib.Children.Add(Puh_Button);
            Puh_Button.Clicked += PuhButton_Clicked;
            Puh_Button.BackgroundColor = Color.Transparent;
            BackgroundColor = Color.Wheat;

            InitializeComponent();
            Content = scrollView;
        }

        private async void EsmButton_Clicked(object sender, EventArgs e)
        {
            await Navigation.PopAsync();
            await Navigation.PushAsync(new esmaspaev());
        }

        private async void TeisButton_Clicked(object sender, EventArgs e)
        {
            await Navigation.PopAsync();
            await Navigation.PushAsync(new teisipaev());
        }

        private async void KolmButton_Clicked(object sender, EventArgs e)
        {
            await Navigation.PopAsync();
            await Navigation.PushAsync(new kolmapaev());
        }

        private async void NelButton_Clicked(object sender, EventArgs e)
        {
            await Navigation.PopAsync();
            await Navigation.PushAsync(new neljapaev());
        }

        private async void ReedeButton_Clicked(object sender, EventArgs e)
        {
            await Navigation.PopAsync();
            await Navigation.PushAsync(new reede());
        }

        private async void LauButton_Clicked(object sender, EventArgs e)
        {
            await Navigation.PopAsync();
            await Navigation.PushAsync(new laupaev());
        }

        private async void PuhButton_Clicked(object sender, EventArgs e)
        {
            await Navigation.PopAsync();
            await Navigation.PushAsync(new puhapaev());
        }

    }
}
