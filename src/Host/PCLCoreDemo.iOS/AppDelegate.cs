﻿using Foundation;
using UIKit;
using PCLCoreDemo.ViewModels;
using PCLAppDemo.iOS;
using PCLCoreApp.iOS;

namespace PCLCoreDemo.iOS
{
    [Register("AppDelegate")]
    public partial class AppDelegate : CoreAppDelegate
    {
        //
        // This method is invoked when the application has loaded and is ready to run. In this 
        // method you should instantiate the window, load the UI into it and then make the window
        // visible.
        //
        // You have 17 seconds to return from this method, or iOS will terminate your application.
        //
        public override bool FinishedLaunching(UIApplication app, NSDictionary options)
        {   
            // Set your start viewmodel here 
            RunApplication<PCLCoreDemoApplication, HomeViewModel>(InitialisePlatformContainers);

            return base.FinishedLaunching(app, options);
        }

        private static void InitialisePlatformContainers()
        {
            // register ios specific dependencies
        }
    }
}