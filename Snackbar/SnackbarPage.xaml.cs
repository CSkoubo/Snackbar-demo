using Xamarin.Forms;

namespace Snackbar
{
	public partial class SnackbarPage : ContentPage
	{
		IUserNotificationService userNotificationService;
		public SnackbarPage()
		{
			InitializeComponent();
			userNotificationService = DependencyService.Get<IUserNotificationService>();
		}

		void Handle_Clicked(object sender, System.EventArgs e)
		{
			userNotificationService.Snack("Magic snack!!", 10000, "Puff!");
		}

        private void Button_Clicked(object sender, System.EventArgs e)
        {
            userNotificationService.Snack("Default notify without action");
        }
    }
}
