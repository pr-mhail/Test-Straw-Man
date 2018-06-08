using System;
using Microsoft.AppCenter.Analytics;
using Microsoft.AppCenter.Crashes;
using StrawMan.Helpers;

namespace StrawMan {
    public class App {
        public static bool UseMockDataStore = true;
        public static string BackendUrl = "http://localhost:5000";

        public static void Initialize() {
            if (UseMockDataStore)
                ServiceLocator.Instance.Register<IDataStore<Item>, MockDataStore>();
            else
                ServiceLocator.Instance.Register<IDataStore<Item>, CloudDataStore>();

			Microsoft.AppCenter.AppCenter.Start(AppConstants.AppCenterStart,
                               typeof(Analytics), typeof(Crashes));
        }
    }
}
