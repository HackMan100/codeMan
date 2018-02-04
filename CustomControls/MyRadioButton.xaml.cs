using System;
using System.Collections.Generic;
using Xamarin.Forms;
using SkiaSharp;
using SkiaSharp.Views.Forms;

namespace OnlineDrive.CustomControls
{
    public partial class MyRadioButton : Grid
    {
        public MyRadioButton()
        {
            InitializeComponent();
        }
        public static readonly BindableProperty selectedProperty =
       BindableProperty.Create(nameof(isselected), typeof(int), typeof(MyCircleView),
                               default(int), Xamarin.Forms.BindingMode.TwoWay);

        public static readonly BindableProperty labelTxtProperty =
           BindableProperty.Create(nameof(Labeltxt), typeof(string), typeof(MyCircleView),

                                                  default(string), Xamarin.Forms.BindingMode.OneWay);

        public int isselected
        {
            get
            {
                return (int)GetValue(selectedProperty);
            }

            set
            {
                SetValue(selectedProperty, value);
            }
        }
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
                radiolabeltxt.Text = Labeltxt;
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
            canvas.DrawCircle(info.Width / 2, info.Height / 2, 20, paint);


        }
    }
}
