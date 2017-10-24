using Foundation;
using UIKit;

using FFImageLoading.Forms.Touch;

namespace ThesisDemo.iOS
{
    [Register("AppDelegate")]
    public partial class AppDelegate : global::Xamarin.Forms.Platform.iOS.FormsApplicationDelegate
    {
        public override bool FinishedLaunching(UIApplication app, NSDictionary options)
        {
            global::Xamarin.Forms.Forms.Init();

            // Code for starting up the Xamarin Test Cloud Agent
#if DEBUG
			Xamarin.Calabash.Start();
#endif

            CachedImageRenderer.Init();
            Xamarin.FormsGoogleMaps.Init(Constants.GOOGLE_MAPS_IOS_API_KEY);
            LoadApplication(new App());

            return base.FinishedLaunching(app, options);
        }
    }
}
