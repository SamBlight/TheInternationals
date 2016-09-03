using MvvmCross.Core.ViewModels;
using System.Windows.Input;

// Author: Andreas Andersson n9795383, Marie-Luise Lux n9530801, Samuel Blight n8312885

namespace CatchUp.Core.ViewModels
{
	public class FirstViewModel
		: MvxViewModel
	{
		private string _hello = "Hello MvvmCross";
		public string Hello
		{
			get { return _hello; }
			set { SetProperty(ref _hello, value); }
		}

		//Andreas code

		private string action = "Actions will be displayed here!";
		public string Action
		{
			get { return action; }
			set
			{
				if (value != null && value != action)
				{
					action = value;
					RaisePropertyChanged(() => Action);
				}
			}
		}

		private string firstname = "John";
		public string Firstname
		{
			get { return firstname; }
			set
			{
				if (value != null && value != firstname)
				{
					firstname = value;
				}
			}
		}

		private string lastname = "Doe";
		public string Lastname
		{
			get { return lastname; }
			set
			{
				if (value != null && value != lastname)
				{
					lastname = value;
				}
			}
		}
		//End of Andreas Code

		//Code Marie

		private string responseText = "This is a example Text. If you press the \"send\" button it will change.";
		public string ResponseText
		{
			get { return responseText; }
			set
			{
				if (value != null && value != responseText)
				{
					responseText = "You have just clicked the send button.";
					RaisePropertyChanged(() => ResponseText);
				}
			}
		}
		//End of Marie's Code.

		//Code Samuel
   
		private string sendReqText = "Send";
		private int count = 0;
		public string SendReqText
		{
			get { return sendReqText; }
			set
			{
				count++;
				sendReqText = value+ count;
					RaisePropertyChanged(() => SendReqText);
			}
		}
		//End of Samuel's Code.

		public ICommand BtnSaveCommand { get; private set; }
		public ICommand BtnDisturbCommand { get; private set; }
		public ICommand BtnNormalCommand { get; private set; }
		public ICommand BtnVibrationCommand { get; private set; }
		public ICommand BtnSoundCommand { get; private set; }
		//Marie Code
		public ICommand SendResponse { get; private set; }
		//End of Marie's Code
		//Samuel's Code
		public ICommand BtnSendReqCommand { get; private set; }
		//End of Samuel's Code

		//Andreas Code
		private bool sound;
		private bool vibration;

		public FirstViewModel()
		{
			BtnSaveCommand = new MvxCommand(() =>
			{
				Action = "Save Button was pressed! User settings saved as, Firstname:"+
					firstname+" Lastname:"+lastname;
			});

			BtnDisturbCommand = new MvxCommand(() =>
			{
				Action = "Don't Disturb Mode Button was pressed!";
			});

			BtnNormalCommand = new MvxCommand(() =>
			{
				Action = "Normal Mode Button was pressed!";
			});

			BtnVibrationCommand = new MvxCommand(() =>
			{
				if (vibration)
				{
					vibration = false;
					Action = "Vibration Off!";
				}
				else {
					vibration = true;
					Action = "Vibration On!";
				}
			});

			BtnSoundCommand = new MvxCommand(() =>
			{
				if (sound)
				{
					sound = false;
					Action = "Sound Off!";
				}
				else {
					sound = true;
					Action = "Sound On!";
				}
			});
			//End of Andreas Code.

			//Marie Code
			SendResponse = new MvxCommand(() =>
			{
			ResponseText = "Save Button was pressed!";
				});
			//End of Marie's Code

			//Samuel's Codee
			BtnSendReqCommand = new MvxCommand(() =>
			{
				SendReqText = "Message Sent!";
			});
			//End of Samuel's Code

		}


	}
}


