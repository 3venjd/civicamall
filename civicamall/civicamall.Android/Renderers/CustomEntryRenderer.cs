using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;

using Android.App;
using Android.Content;
using Android.Graphics.Drawables;
using Android.OS;
using Android.Runtime;
using Android.Views;
using Android.Widget;
using civicamall.Droid.Renderers;
using civicamall.Renders;
using Xamarin.Forms;
using Xamarin.Forms.Platform.Android;

[assembly: ExportRenderer(typeof(CustomEntry), typeof(CustomEntryRenderer))] //vinculacion entre la clase del proyecto principal con este de android
namespace civicamall.Droid.Renderers
{
    public class CustomEntryRenderer : EntryRenderer
    {
        public CustomEntryRenderer(Context context) : base(context) //context son todos los datos que contenga dentro del layout en pantalla
        {

        }

        protected override void OnElementChanged(ElementChangedEventArgs<Entry> e) // ayuda a manipular si existe el control para poder renderizar el control en android
        {
            base.OnElementChanged(e);
            if (e.NewElement != null) // si ya esta creado
            {
                var view = (CustomEntry)Element; //retornar el custom entry

                if (Control != null && this.Element != null) // para ver si el control no esta renderizado, se le pasa el control renderizado
                {
                    DrawControl(view);
                    if (e.NewElement != e.OldElement) // revisa si hay cambios en el render
                    {
                        if (e.OldElement != null)
                        {
                            e.OldElement.PropertyChanged -= ElementPropertyChanged;
                        }
                        if (e.NewElement != null)
                        {
                            e.NewElement.PropertyChanged += ElementPropertyChanged;
                        }
                    }
                }
            }
        }

        private new void ElementPropertyChanged(object sender, PropertyChangedEventArgs args)
        {
            base.OnElementPropertyChanged(sender, args);
            var view = sender as CustomEntry;
            if (args.PropertyName == CustomEntry.BorderColorProperty.PropertyName)
            {
                DrawControl(view);
            }
        }

        private void DrawControl(CustomEntry view)
        {
            //crear color del contorno
            var _background = new GradientDrawable();
            _background.SetShape(ShapeType.Rectangle);
            _background.SetColor(view.BackgroundColor.ToAndroid());

            //crear el ancho y el color del contorno
            _background.SetStroke(view.BorderWidth, view.BorderColor.ToAndroid());

            //crear radio del contorno
            _background.SetCornerRadius(Convert.ToSingle(view.CornerrRadius));

            Control.Background = _background;
        }
    }
}