using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Navg_Page
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class esmaspaev : ContentPage
    {
        public esmaspaev()
        {
            string[] tasks = new string[] { "Просыпаюсь", "Завтракаю", "Еду на учебу", "Завершение учебного дня", "Еду домой", "Занимаюсь своими делами", "Сон" };
            ListView list = new ListView();
            Button back = new Button { Text = "Назад", BackgroundColor = Color.Wheat };
            back.Clicked += Back_Clicked;

            list.ItemsSource = tasks;
            list.ItemSelected += List_ItemSelected;
            Content = new StackLayout { Children = { list, back } };
        }

        private async void List_ItemSelected(object sender, SelectedItemChangedEventArgs e)
        {
            throw new NotImplementedException();
        }

        private async void Back_Clicked(object sender, EventArgs e)
        {
            await Navigation.PopAsync();
        }
    }
}