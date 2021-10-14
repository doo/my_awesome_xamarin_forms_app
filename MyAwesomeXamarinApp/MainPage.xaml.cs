using System;
using Xamarin.Forms;
using ScanbotSDK.Xamarin.Forms;

namespace MyAwesomeXamarinApp
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }

        async void ScanDocumentButtonClicked(object sender, EventArgs args)
        {
            var config = new DocumentScannerConfiguration()
            {
                MultiPageEnabled = false,
                IgnoreBadAspectRatio = true,
            };

            var result = await SBSDK.UI.LaunchDocumentScannerAsync(config);

            if (result.Status == OperationResult.Ok)
            {
                ScannedDocumentImage.Source = await result.Pages[0].DecryptedDocumentPreview();
            }
        }
    }
}
