using System;
using System.Linq;
using UIKit;
using Xamarin.Forms;
using Xamarin.Forms.Platform.iOS;

namespace HelloSharedUI
{
    public class UIHelpers
    {
        MyPage view;
        public UIHelpers()
        {
            if(!Forms.IsInitialized)
                Forms.Init();
            view = new MyPage();
        }


        public void ShowMyPage()
        {
            var controller = view.CreateViewController();
            var vc = GetVisibleViewController();

            if (vc.NavigationController != null)
                vc.NavigationController.PushViewController(controller, true);
            else
                vc.PresentViewController(controller, true, () => { });
        }

        UIViewController GetVisibleViewController()
        {
            UIViewController viewController = null;
            var window = UIApplication.SharedApplication.KeyWindow;


            if (window != null && window.WindowLevel == UIWindowLevel.Normal)
                viewController = window.RootViewController;

            if (viewController == null)
            {
                window = UIApplication.SharedApplication.Windows.OrderByDescending(w => w.WindowLevel).FirstOrDefault(w => w.RootViewController != null && w.WindowLevel == UIWindowLevel.Normal);
                if (window == null)
                    throw new InvalidOperationException("Could not find current view controller");
                else
                    viewController = window.RootViewController;
            }

            while (viewController.PresentedViewController != null)
                viewController = viewController.PresentedViewController;

            var navController = viewController as UINavigationController;
            if (navController != null)
                viewController = navController.ViewControllers.Last();
            
            return viewController;
        }
    }
}
