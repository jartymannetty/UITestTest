﻿using System;
using System.IO;
using System.Linq;
using NUnit.Framework;
using Xamarin.UITest;
using Xamarin.UITest.Queries;

namespace UITestTest.Test
{
	[TestFixture(Platform.Android)]
	[TestFixture(Platform.iOS)]
	public class Tests
	{
		IApp app;
		Platform platform;

		public Tests(Platform platform)
		{
			this.platform = platform;
		}

		[SetUp]
		public void BeforeEachTest()
		{
			app = AppInitializer.StartApp(platform);
		}
        [Test]
        public void AppLaunches()
        {
            app.Screenshot("First screen.");
        }
        [Test]
		public void EnterName()
		{
            app.Tap(x => x.Marked("name"));
            app.EnterText(x => x.Marked("name"),"Marty");
            app.Tap("saveButton");

            app.Screenshot("Tapped Save");
		}
	}
}
