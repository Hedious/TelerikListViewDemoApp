using Android.App;
using Android.Content;
using Android.OS;
using Android.Runtime;
using Android.Views;
using Android.Widget;
using DemoEditor.Droid;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Xamarin.Forms;
using Xamarin.Forms.Platform.Android;



[assembly: ExportRenderer(typeof(Editor), typeof(EditorRender))]
namespace DemoEditor.Droid
{
    public class EditorRender : EditorRenderer
    {
        protected override void OnElementChanged(ElementChangedEventArgs<Editor> e)
        {
            base.OnElementChanged(e);

            //this.Control.SetPadding(10, 10, 10, 3);
            //this.Control.SetBackgroundColor(Android.Graphics.Color.ParseColor("#FAFAFA"));
           
                this.Control.SetBackgroundColor(Android.Graphics.Color.ParseColor("#FAFAFA"));
          

        }
    }
}