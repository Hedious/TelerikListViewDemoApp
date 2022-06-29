using System;
using System.Collections.Generic;
using System.Text;
using Xamarin.Forms;

namespace DemoEditor
{
    public class CusomEditor : Editor
    {
        public CusomEditor()
        {
            this.TextChanged += (sender, e) =>
            {
                this.InvalidateMeasure();
            };

            this.SetDynamicResource(BackgroundColorProperty, "PrimaryBackgroundColor");
        }
    }
}
