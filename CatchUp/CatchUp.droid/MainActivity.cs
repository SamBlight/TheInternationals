using Android.App;
using Android.Widget;
using Android.OS;

namespace CatchUp.droid
{
	[Activity(Label = "CatchUp", MainLauncher = true, Icon = "@mipmap/icon")]
	public class MainActivity : Activity
	{
		int count = 1;

		protected override void OnCreate(Bundle savedInstanceState)
		{
			base.OnCreate(savedInstanceState);

			// Set our view from the "main" layout resource
			SetContentView(Resource.Layout.Request);

            // Get our button from the layout resource,
            // and attach an event to it
			Button button = FindViewById<Button>(Resource.Id.Send);

			button.Click += delegate { button.Text = string.Format("Message Sent", count++); };
		}
	}
}


