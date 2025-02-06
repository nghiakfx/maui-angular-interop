namespace TodoWrapper6New;

public partial class MainPage : ContentPage
{
    public MainPage()
    {
        InitializeComponent();

        var handler = new HttpClientHandler();

#if DEBUG
        handler.ServerCertificateCustomValidationCallback = (message, cert, chain, errors) =>
        {
            if (cert != null && cert.Issuer.Equals("CN=localhost"))
                return true;
            return errors == System.Net.Security.SslPolicyErrors.None;
        };
#endif

        var client = new HttpClient(handler);

    }

    private void Bwv_BlazorWebViewInitialized(object sender, Microsoft.AspNetCore.Components.WebView.BlazorWebViewInitializedEventArgs e)
    {
        // change the 'localhost' to '10.0.2.2'
        //e.WebView.LoadRequest(new NSUrlRequest(new NSUrl("https://10.0.2.2:5001/")));


#if ANDROID
        //e.WebView.Settings.MixedContentMode = Android.Webkit.MixedContentHandling.AlwaysAllow;
#else
        //e.WebView.Configuration.Preferences.SetValueForKey(NSNumber.FromBoolean(true), new NSString("allowFileAccessFromFileURLs"));
#endif
    }
}

