using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Android.App;
using Android.Content;
using Android.OS;
using Android.Runtime;
using Android.Views;
using Android.Widget;
using MvvmCross.Droid.Views;

namespace Test.Droid.Views
{
    [Activity(Label = "First View", MainLauncher =true)]
    public class FirstView : MvxActivity
    {

        protected override void OnViewModelSet()
        {
            SetContentView(Resource.Layout.FirstView);
        }
    }
}