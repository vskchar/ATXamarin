using System;
using System.IO;
using Xamarin.UITest;
using Xamarin.UITest.Queries;

namespace XamarinUITest
{
    public class AppInitializer
    {
        public static IApp StartApp(Platform platform)
        {
            if (platform == Platform.Android)
            {
                string fileName = Path.GetFileName(@"‪D:\\Softwares\\selendroid-test-app-0.12.0.apk");
                return ConfigureApp.Android.ApkFile(fileName).StartApp();
            }

            return ConfigureApp.iOS.StartApp();
        }
    }
}