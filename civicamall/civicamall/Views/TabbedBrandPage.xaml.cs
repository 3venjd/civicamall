using System;
using System.ComponentModel;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace civicamall.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class TabbedBrandPage : ContentPage
    {
        public TabbedBrandPage()
        {
            InitializeComponent();
        }
        void TapIndex1(object sender, EventArgs args)
        {

            Label1.BackgroundColor = Color.FromHex("#F2EDF8");
            Label1.TextColor = Color.FromHex("#7E2081");

            Label2.BackgroundColor = Color.FromHex("#7E2081");
            Label2.TextColor = Color.FromHex("#F2EDF8");

            Label3.BackgroundColor = Color.FromHex("#7E2081");
            Label3.TextColor = Color.FromHex("#F2EDF8");

            Tabcomponent.SelectedIndex = 0;
        }

        void TapIndex2(object sender, EventArgs args)
        {
            Label1.BackgroundColor = Color.FromHex("#7E2081");
            Label1.TextColor = Color.FromHex("#F2EDF8");

            Label2.BackgroundColor = Color.FromHex("#F2EDF8");
            Label2.TextColor = Color.FromHex("#7E2081");

            Label3.BackgroundColor = Color.FromHex("#7E2081");
            Label3.TextColor = Color.FromHex("#F2EDF8");

            Tabcomponent.SelectedIndex = 1;

        }

        void TapIndex3(object sender, EventArgs args)
        {
            Label1.BackgroundColor = Color.FromHex("#7E2081"); ;
            Label1.TextColor = Color.FromHex("#F2EDF8");

            Label2.BackgroundColor = Color.FromHex("#7E2081");
            Label2.TextColor = Color.FromHex("#F2EDF8");

            Label3.BackgroundColor = Color.FromHex("#F2EDF8");
            Label3.TextColor = Color.FromHex("#7E2081");

            Tabcomponent.SelectedIndex = 2;
        }
    }
}
