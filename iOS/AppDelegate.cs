using System;
using System.Collections.Generic;
using System.Linq;

using Foundation;
using UIKit;

namespace OnlineDrive.iOS
{
    [Register("AppDelegate")]
    public partial class AppDelegate : global::Xamarin.Forms.Platform.iOS.FormsApplicationDelegate
    {
        public override bool FinishedLaunching(UIApplication app, NSDictionary options)
        {
            global::Xamarin.Forms.Forms.Init();
            var deviceheight = UIScreen.MainScreen.Bounds.Height;
            if (deviceheight < 667)
            {
                Console.WriteLine(deviceheight + "5s");
            }

            LoadApplication(new App());

            return base.FinishedLaunching(app, options);
        }
    }
}
