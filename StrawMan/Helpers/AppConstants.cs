using System;
namespace StrawMan.Helpers
{
    public class AppConstants
    {
		public static string AppCenterStart
        {
            get
            {
                string startup = string.Empty;

                if (Guid.TryParse(Secrets.AppCenter_iOS_Secret, out Guid iOSSecret))
                {
                    startup += $"ios={iOSSecret};";
                }

                if (Guid.TryParse(Secrets.AppCenter_Android_Secret, out Guid AndroidSecret))
                {
                    startup += $"android={AndroidSecret};";
                }

                return startup;
            }
        }
    }
}
