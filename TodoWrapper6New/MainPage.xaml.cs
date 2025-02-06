namespace TodoWrapper6New;

public partial class MainPage : ContentPage
{
    public MainPage()
    {
        InitializeComponent();
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

