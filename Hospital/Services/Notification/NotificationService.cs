using MudBlazor;
using System.Diagnostics;

namespace Hospital.Services.Notification
{
	/// <summary>
	/// Сервис, который создает уведомления для пользователя
	/// </summary>
	public class NotificationService
	{
		public enum Type
		{
			Success,
			Warning,
			Error,
			Info
		}
		private ISnackbar _snackbar { get; set; }
		SnackbarOptions Config = new CommonSnackbarOptions()
		{
			VisibleStateDuration = 10000,
			ShowTransitionDuration = 500,
			HideTransitionDuration = 500,
		};


		public MudSnackbarElement Create(Type type, string text)
		{
			Severity severity = Severity.Normal;
			switch (type)
			{
				case Type.Success:
					severity = Severity.Success;
					break;
				case Type.Warning:
					severity = Severity.Warning;
					break;
				case Type.Error:
					severity = Severity.Error;
					break;
				case Type.Info:
					severity = Severity.Info;
					break;
				default:
					severity = Severity.Normal;
					Debug.WriteLine("Присвоено значение severity в MudSnackbarElement > Create по умолчанию");
					break;
			}
			_snackbar.Add(text, severity, Config);

			return null;
		}
	}
}
