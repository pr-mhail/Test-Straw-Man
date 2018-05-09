using System;
using UIKit;

namespace StrawMan.iOS {
    public partial class TabBarController : UITabBarController {
        public TabBarController(IntPtr handle) : base(handle) {
            TabBar.Items[0].Title = "Browse";
            TabBar.Items[1].Title = "About";
        }
    }
}
