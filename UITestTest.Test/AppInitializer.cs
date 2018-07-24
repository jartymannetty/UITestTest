using System;
using Xamarin.UITest;
using Xamarin.UITest.Queries;

namespace UITestTest.Test
{
    public class AppInitializer
    {
        public static IApp StartApp(Platform platform)
        {
            if (platform == Platform.Android)
            {
                return ConfigureApp
                       .Android
                       .EnableLocalScreenshots()
                       .ApkFile(@"C:\Users\mpineault\source\repos\UITestTest\UITestTest\UITestTest.Android\bin\Debug\com.companyname.UITestTest.apk")
                       .StartApp();
            }

            return ConfigureApp
                   .iOS
                   .EnableLocalScreenshots()
                   .StartApp();
        }
    }
}

