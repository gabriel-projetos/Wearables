using System;

using Android.App;
using Android.Content;
using Android.Runtime;
using Android.Views;
using Android.Widget;
using Android.OS;
using Android.Support.Wearable.Views;
using Android.Support.V4.App;
using Android.Support.V4.View;
using Android.Support.Wearable.Activity;
using Java.Interop;
using Android.Views.Animations;

namespace Hello
{
    [Activity(Label = "@string/app_name", MainLauncher = true)]
    public class MainActivity : WearableActivity
    {
        TextView textView;
        TextView totalClick;
        Button botaoAdicionar;

        protected override void OnCreate(Bundle bundle)
        {
            base.OnCreate(bundle);
            SetContentView(Resource.Layout.activity_main);            

            textView = FindViewById<TextView>(Resource.Id.text);
            SetAmbientEnabled();

            botaoAdicionar = FindViewById<Button>(Resource.Id.click_button);
            botaoAdicionar.Click += BotaoAdicionar_Click;
            totalClick = FindViewById<TextView>(Resource.Id.result);
        }

        int count = 1;
        private void BotaoAdicionar_Click(object sender, EventArgs e)
        {
            totalClick.Text = string.Format("{0} clicks!", count++);
        }
    }
}


