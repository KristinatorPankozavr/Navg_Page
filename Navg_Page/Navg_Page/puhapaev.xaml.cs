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
    public partial class puhapaev : ContentPage
    {
        public puhapaev()
        {
            Title = "воскресение";
            string[] tasks = new string[] { "Проснуться", "Завтрак", "Уборка дома", "Встреча с другом", "Сходить в магазин", "Дорога домой", "Домашние дела/отдых", "Сон" };

            ListView list = new ListView { BackgroundColor = Color.Wheat, SeparatorColor = Color.Black, RowHeight = 100 };
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
                kell = "10:00";
            }

            if (e.SelectedItemIndex == 1)
            {
                kell = "10:30";
            }

            if (e.SelectedItemIndex == 2)
            {
                kell = "11:00-14:00";
            }

            if (e.SelectedItemIndex == 3)
            {
                kell = "15:00";
            }

            if (e.SelectedItemIndex == 4)
            {
                kell = "20:00";
            }

            if (e.SelectedItemIndex == 5)
            {
                kell = "21:00";
            }

            if (e.SelectedItemIndex == 6)
            {
                kell = "21:30-00:00";
            }

            if (e.SelectedItemIndex == 7)
            {
                kell = "01:00";
            }
    }
}}