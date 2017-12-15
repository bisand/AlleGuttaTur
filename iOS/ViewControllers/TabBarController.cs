using System;
using UIKit;

namespace AlleGuttaTur.iOS
{
    public partial class TabBarController : UITabBarController
    {
        public TabBarController(IntPtr handle) : base(handle)
        {
            TabBar.Items[0].Title = "Browse";
            TabBar.Items[1].Title = "Menu";
            TabBar.Items[2].Title = "About";
        }
    }
}
