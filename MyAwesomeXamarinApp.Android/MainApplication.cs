using System;
using Android.App;
using Android.Runtime;
using ScanbotSDK.Xamarin.Forms;

namespace MyAwesomeXamarinApp.Droid
{
    [Application(LargeHeap = true)]
    public class MainApplication : Application
    {
        const string LICENSE_KEY = null;

        public MainApplication(IntPtr javaReference, JniHandleOwnership transfer)
            : base(javaReference, transfer) { }

        public override void OnCreate()
        {
            var configuration = new SBSDKConfiguration
            {
                EnableLogging = true,
                DetectorType = DocumentDetectorType.MLBased,
            };
            SBSDKInitializer.Initialize(this, LICENSE_KEY, configuration);
        }
    }
}
