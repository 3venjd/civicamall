using System;
using System.Collections.Generic;
using System.Text;
using Xamarin.Forms;

namespace civicamall.Renders
{
    public class CustomEntry : Entry
    {
        public static readonly BindableProperty BorderColorProperty =
            BindableProperty.Create
            (
                nameof(BorderColor),
                typeof(Color),
                typeof(CustomEntry),
                Color.White
            );

        public static readonly BindableProperty BorderWidthProperty =
            BindableProperty.Create
            (
                nameof(BorderWidth),
                typeof(int),
                typeof(CustomEntry),
                2
            );

        public static readonly BindableProperty CornerRadiusProperty =
            BindableProperty.Create
            (
                nameof(CornerrRadius),
                typeof(double),
                typeof(CustomEntry),
                7.0
            );

        public Color BorderColor
        {
            get => (Color)GetValue(BorderColorProperty);
            set => SetValue(BorderColorProperty, value);
        }
        public int BorderWidth
        {
            get => (int)GetValue(BorderWidthProperty);
            set => SetValue(BorderWidthProperty, value);
        }
        public double CornerrRadius
        {
            get => (double)GetValue(CornerRadiusProperty);
            set => SetValue(CornerRadiusProperty, value);
        }
    }
}
