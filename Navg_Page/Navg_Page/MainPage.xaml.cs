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
        public MainPage()
        {
        
            StackLayout st = new StackLayout();
            Button esm_Btn = new Button { Text = "esmaspaev" };
            Button teis_Btn = new Button { Text = "teisipaev" };
            Button kolm_Btn = new Button { Text = "kolmapaev" };
            Button nelj_Btn = new Button { Text = "neljapaev" };
            Button reed_Btn = new Button { Text = "reede" };
            Button laul_Btn = new Button { Text = "laupaev" };
            Button puh_Btn = new Button { Text = "puhapaev" };

            st.Children.Add(esm_Btn);
            st.Children.Add(teis_Btn);
            st.Children.Add(kolm_Btn);
            st.Children.Add(nelj_Btn);
            st.Children.Add(reed_Btn);
            st.Children.Add(laul_Btn);
            st.Children.Add(puh_Btn);

            esm_Btn.Clicked += new EventHandler(buttons_Click);
            teis_Btn.Clicked += new EventHandler(buttons_Click);
            kolm_Btn.Clicked += new EventHandler(buttons_Click);
            nelj_Btn.Clicked += new EventHandler(buttons_Click);
            reed_Btn.Clicked += new EventHandler(buttons_Click);
            laul_Btn.Clicked += new EventHandler(buttons_Click);
            puh_Btn.Clicked += new EventHandler(buttons_Click);

            Content = st;
        }

        private async void buttons_Click(object sender, EventArgs e)
        {
            var btn = (Button)sender;
            switch (btn.Text)//Проверяеем текст на кнопке
            {
                case "esmaspaev":
                    await Navigation.PopAsync();//Закрываем страницу
                    await Navigation.PushAsync(new esmaspaev());//Открываем страницу
                    break;

                case "teisispaev":
                    await Navigation.PopAsync();//Закрываем страницу
                    await Navigation.PushAsync(new teisipaev());//Открываем страницу
                    break;

                case "kolmapaev":
                    await Navigation.PopAsync();//Закрываем страницу
                    await Navigation.PushAsync(new kolmapaev());//Открываем страницу
                    break;

                case "neljapaev":
                    await Navigation.PopAsync();//Закрываем страницу
                    await Navigation.PushAsync(new neljapaev());//Открываем страницу
                    break;

                case "reede":
                    await Navigation.PopAsync();//Закрываем страницу
                    await Navigation.PushAsync(new reede());//Открываем страницу
                    break;

                case "laupaev":
                    await Navigation.PopAsync();//Закрываем страницу
                    await Navigation.PushAsync(new laupaev());//Открываем страницу
                    break;

                case "puhapaev":
                    await Navigation.PopAsync();//Закрываем страницу
                    await Navigation.PushAsync(new puhapaev());//Открываем страницу
                    break;

            }
        }
    }
}
