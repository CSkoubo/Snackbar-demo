using System;
using Android.App;
using Xamarin.Forms;

[assembly: Dependency(typeof(Snackbar.Droid.UserNotificationService))]
namespace Snackbar.Droid
{
	public class UserNotificationService : IUserNotificationService
	{
		public void Notify(string message, int duration, string actionText, Action<object> action)
		{
			var contentView = ((Activity)Forms.Context).FindViewById(Android.Resource.Id.Content);
			var snackbar = Android.Support.Design.Widget.Snackbar.Make(contentView, message, duration);
			if (actionText != null && action != null)
				snackbar.SetAction(actionText, action);
			snackbar.Show();
		}
	}
}