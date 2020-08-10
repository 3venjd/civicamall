using System;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace civicamall.Controls
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class ProductCustomControl : ContentView
    {
        public static readonly BindableProperty ProductImageProperty =
            BindableProperty.Create
            (
                propertyName: "ProductUrlImage",
                defaultValue: String.Empty,
                returnType: typeof(string),
                declaringType: typeof(ProductCustomControl),
                defaultBindingMode: BindingMode.TwoWay,
                propertyChanged: PhotoUrlPropertyChanged
            );
        public static readonly BindableProperty ProductNameProperty =
            BindableProperty.Create
            (
                propertyName: "ProductName",
                defaultValue: string.Empty,
                returnType: typeof(string),
                declaringType: typeof(ProductCustomControl),
                defaultBindingMode: BindingMode.TwoWay,
                propertyChanged: ProductNamePropertyChanged
            );

        public static readonly BindableProperty ProductFinalCostProperty =
            BindableProperty.Create
            (
                propertyName: "FinalCost",
                defaultValue: string.Empty,
                returnType: typeof(string),
                declaringType: typeof(ProductCustomControl),
                defaultBindingMode: BindingMode.TwoWay,
                propertyChanged: ProductFinalCostChanged
            );

        public static readonly BindableProperty IsFavoriteProperty =
            BindableProperty.Create
            (
                propertyName: "Favorite",
                defaultValue: false,
                returnType: typeof(bool),
                declaringType: typeof(ProductCustomControl),
                defaultBindingMode: BindingMode.TwoWay,
                propertyChanged: ProducIsFavoritePropertyChanged
            );


        public string ProductImage
        {
            get { return base.GetValue(ProductImageProperty).ToString(); }
            set { base.SetValue(ProductImageProperty, value); }
        }

        public string ProductName
        {
            get { return base.GetValue(ProductNameProperty).ToString(); }
            set { base.SetValue(ProductNameProperty, value); }
        }

        public string ProductFinalCost
        {
            get { return base.GetValue(ProductFinalCostProperty).ToString(); }
            set { base.SetValue(ProductFinalCostProperty, value); }
        }

        public bool IsFavorite
        {
            get { return (bool)base.GetValue(IsFavoriteProperty); }
            set { base.SetValue(IsFavoriteProperty, value); }
        }
        private static void PhotoUrlPropertyChanged(BindableObject bindable, object oldValue, object newValue)
        {
            var ProductControl = (ProductCustomControl)bindable;

            try
            {
                ProductControl.ProductImageField.Source = ImageSource.FromFile((string)newValue);
            }
            catch
            {
                ProductControl.ProductImageField.Source = ImageSource.FromUri(new Uri("https://matthewsenvironmentalsolutions.com/images/com_hikashop/upload/not-available_1481220154.png"));
            }
        }

        private static void ProductNamePropertyChanged(BindableObject bindable, object oldValue, object newValue)
        {
            var ProductControl = (ProductCustomControl)bindable;

            ProductControl.ProductNameLabel.Text = (string)newValue;
        }

        private static void ProductFinalCostChanged(BindableObject bindable, object oldValue, object newValue)
        {
            var ProductControl = (ProductCustomControl)bindable;

            ProductControl.ProductFinalCostLabel.Text = (string)newValue;
        }

        private static void ProducIsFavoritePropertyChanged(BindableObject bindable, object oldValue, object newValue)
        {
            var ProductControl = (ProductCustomControl)bindable;
            ProductControl.PancakeViewFavorite.IsVisible = (bool)newValue;
        }
        public ProductCustomControl()
        {
            InitializeComponent();
        }
    }
}