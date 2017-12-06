using System;
using Xamarin.Forms;
using UIKit;
using Xamarin.Forms.Platform.iOS;
using TestApp.iOS;
using TestApp;

[assembly: ExportRenderer(typeof(CustomButton), typeof(CustomButtonRenderer))]
namespace TestApp.iOS
{
    public class CustomRenderers
    {
        public CustomRenderers()
        {
        }
    }

    public class CustomButtonRenderer : ButtonRenderer
    {
        protected override void OnElementChanged(ElementChangedEventArgs<Button> e)
        {
            base.OnElementChanged(e);

            Control.Layer.BorderColor = UIColor.Red.CGColor;
            Control.Layer.BorderWidth = (System.nfloat)2.0;

            //Only when view is to be replaced
            //SetNativeControl(Control);
        }
    }
}
