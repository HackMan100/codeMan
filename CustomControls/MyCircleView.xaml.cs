using System;
using System.Collections.Generic;
using SkiaSharp;
using SkiaSharp.Views.Forms;
using Xamarin.Forms;

namespace OnlineDrive.CustomControls
{
    public partial class MyCircleView : Grid
    {
        public MyCircleView()
        {
            InitializeComponent();
        }
        public static readonly BindableProperty labelTxtProperty =
            BindableProperty.Create(nameof(Labeltxt), typeof(string), typeof(MyCircleView),
                                    default(string), Xamarin.Forms.BindingMode.OneWay);

        public string Labeltxt
        {
            get
            {
                return (string)GetValue(labelTxtProperty);
            }

            set
            {
                SetValue(labelTxtProperty, value);
            }
        }

        protected override void OnPropertyChanged(string propertyName = null)
        {
            base.OnPropertyChanged(propertyName);

            if (propertyName == labelTxtProperty.PropertyName)
            {
                circletlabeltxt.Text = Labeltxt;
            }
        }



        public void Handle_PaintSurface(object sender, SkiaSharp.Views.Forms.SKPaintSurfaceEventArgs e)
        {


            SKImageInfo info = e.Info;
            SKSurface surface = e.Surface;
            SKCanvas canvas = surface.Canvas;

            canvas.Clear();

            SKPaint paint = new SKPaint
            {
                Style = SKPaintStyle.Stroke,
                Color = Color.FromHex("#E9967A").ToSKColor(),
                StrokeWidth = 10
            };
            canvas.DrawCircle(info.Width / 2, info.Height / 2, 100, paint);


        }
    }
}
