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
    public partial class reede : ContentPage
    {
        public reede()
        {
            Title = "Пятница";
            string[] tasks = new string[] { "Проснуться", "Завтрак", "Собраться", "Дорога до учебы", "Учеба", "Дорога домой", "Домашние дела/отдых", "Сон" };

            ListView list = new ListView { BackgroundColor = Color.Wheat, SeparatorColor = Color.Black, RowHeight = 100 };
            // определяем источник данных
            list.ItemsSource = tasks;

            Button bb = new Button { Text = "Назад" };
            bb.Clicked += Bb_Clicked;

            list.ItemSelected += List_ItemSelected;
            Content = new StackLayout { Children = { list, bb } };
        }

        private void Bb_Clicked(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        string kell;
        private async void List_ItemSelected(object sender, SelectedItemChangedEventArgs e)
        {
            string text = e.SelectedItem.ToString();
            if (e.SelectedItemIndex == 0)
            {
                kell = "7:00";
            }

            if (e.SelectedItemIndex == 1)
            {
                kell = "7:10";
            }

            if (e.SelectedItemIndex == 2)
            {
                kell = "7:30";
            }

            if (e.SelectedItemIndex == 3)
            {
                kell = "7:50-8:20";
            }

            if (e.SelectedItemIndex == 4)
            {
                kell = "8:30-16:45";
            }

            if (e.SelectedItemIndex == 5)
            {
                kell = "17:00-17:30";
            }

            if (e.SelectedItemIndex == 6)
            {
                kell = "17:50-23:00";
            }

            if (e.SelectedItemIndex == 7)
            {
                kell = "00:00";
            }
            await DisplayAlert(kell, text, "Да");
        }
    }
}