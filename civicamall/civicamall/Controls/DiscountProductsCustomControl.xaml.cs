using System;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace civicamall.Controls
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class DiscountProductsCustomControl : ContentView
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

        public static readonly BindableProperty ProductBaseCostProperty =
            BindableProperty.Create
            (
                propertyName: "BaseCost",
                defaultValue: string.Empty,
                returnType: typeof(string),
                declaringType: typeof(ProductCustomControl),
                defaultBindingMode: BindingMode.TwoWay,
                propertyChanged: ProductBaseCostChanged
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
        public static readonly BindableProperty IsDiscountProperty =
            BindableProperty.Create
            (
                propertyName: "Discount",
                defaultValue: false,
                returnType: typeof(bool),
                declaringType: typeof(ProductCustomControl),
                defaultBindingMode: BindingMode.TwoWay,
                propertyChanged: ProducIsDiscountPropertyChanged
            );

        public static readonly BindableProperty ProductDiscountValueProperty =
            BindableProperty.Create
            (
                propertyName: "DisctountV",
                defaultValue: string.Empty,
                returnType: typeof(string),
                declaringType: typeof(ProductCustomControl),
                defaultBindingMode: BindingMode.TwoWay,
                propertyChanged: ProductDiscountValueChanged
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

        public string ProductBaseCost
        {
            get { return base.GetValue(ProductFinalCostProperty).ToString(); }
            set { base.SetValue(ProductFinalCostProperty, value); }
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

        public bool IsDiscount
        {
            get { return (bool)base.GetValue(IsFavoriteProperty); }
            set { base.SetValue(IsFavoriteProperty, value); }
        }

        public string ProductDiscountValue
        {
            get { return base.GetValue(ProductFinalCostProperty).ToString(); }
            set { base.SetValue(ProductFinalCostProperty, value); }
        }
        private static void PhotoUrlPropertyChanged(BindableObject bindable, object oldValue, object newValue)
        {
            var ProductControl = (DiscountProductsCustomControl)bindable;

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
            var ProductControl = (DiscountProductsCustomControl)bindable;

            ProductControl.ProductNameLabel.Text = (string)newValue;
        }

        private static void ProductBaseCostChanged(BindableObject bindable, object oldValue, object newValue)
        {
            var ProductControl = (DiscountProductsCustomControl)bindable;

            ProductControl.ProductBaseCostLabel.Text = (string)newValue;
        }

        private static void ProductFinalCostChanged(BindableObject bindable, object oldValue, object newValue)
        {
            var ProductControl = (DiscountProductsCustomControl)bindable;

            ProductControl.ProductFinalCostLabel.Text = (string)newValue;
        }

        private static void ProducIsFavoritePropertyChanged(BindableObject bindable, object oldValue, object newValue)
        {
            var ProductControl = (DiscountProductsCustomControl)bindable;
            ProductControl.PancakeViewFavorite.IsVisible = (bool)newValue;
        }

        private static void ProducIsDiscountPropertyChanged(BindableObject bindable, object oldValue, object newValue)
        {
            var ProductControl = (DiscountProductsCustomControl)bindable;
            ProductControl.PancakeViewDiscount.IsVisible = (bool)newValue;
            ProductControl.XDiscount.IsVisible = (bool)newValue;
            ProductControl.ProductBaseCostLabel.IsVisible = (bool)newValue;
        }

        private static void ProductDiscountValueChanged(BindableObject bindable, object oldValue, object newValue)
        {
            var ProductControl = (DiscountProductsCustomControl)bindable;

            ProductControl.DiscountValue.Text = (string)newValue;
        }
        public DiscountProductsCustomControl()
        {
            InitializeComponent();
        }
    }
}