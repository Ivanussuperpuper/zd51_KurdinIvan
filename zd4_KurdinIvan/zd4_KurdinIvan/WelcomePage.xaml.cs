using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace zd4_KurdinIvan
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class WelcomePage :ContentPage
    {
        public WelcomePage ()
        {
            InitializeComponent( );
        }
        private async void OnSignInClicked (object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(usernameEntry.Text))
            {
                await DisplayAlert("Ошибка", "введите тимя пользователя", "OK");
                return;
            }

            if (string.IsNullOrWhiteSpace(passwordEntry.Text))
            {
                await DisplayAlert("Ошибка", "введите пароль", "OK");
                return;
            }

            var mainPage = new MainPage( );
            await Navigation.PushAsync(mainPage);
            mainPage.SetWelcomeMessage(usernameEntry.Text);
        }

        private void OnForgotPasswordTapped (object sender, EventArgs e)
        {
            DisplayAlert("Информация", "Фунция сброса пароля", "OK");
        }
    }
}