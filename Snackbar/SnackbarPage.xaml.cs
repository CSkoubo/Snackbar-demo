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
			userNotificationService.Notify("Magic snack!!", 5000, "Puff!", obj => { });
		}
	}
}
