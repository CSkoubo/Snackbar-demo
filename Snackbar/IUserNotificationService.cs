using System;
namespace Snackbar
{
	public interface IUserNotificationService
	{
		void Notify(string message, int duration, string actionText, Action<object> action);
	}
}
