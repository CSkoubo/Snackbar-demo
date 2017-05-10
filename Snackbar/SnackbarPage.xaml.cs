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
			userNotificationService.Notify("Magic snack!!", 10000, "Puff!", obj => { });
		}

        private void Button_Clicked(object sender, System.EventArgs e)
        {
            userNotificationService.Notify("Default notify without action");
        }
    }
}
