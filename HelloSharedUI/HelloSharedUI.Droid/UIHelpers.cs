using System;
using Android.App;
using Android.Content;
using Android.Runtime;
using Java.Interop;
using Xamarin.Forms;
using Xamarin.Forms.Platform.Android;

namespace HelloSharedUI.Droid
{
    [Register("UIHelpers")]
    public class UIHelpers : Java.Lang.Object
    {
        public UIHelpers()
        {
        }

        [Export]
        public Android.Support.V4.App.Fragment GetMyPageFragment(Context context)
        {
            if (!Forms.IsInitialized)
                Forms.Init(context, null);

            return new MyPage().CreateSupportFragment(context);
        }
    }
}
