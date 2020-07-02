using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xam.TabView;
using Xam.TabView.Control;
using Xamarin.Forms;
using Xamarin.Forms.Markup;
using Xamarin.Forms.Xaml;

namespace civicamall.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class TabbedBrandPage : ContentPage, INotifyPropertyChanged
    {
        public TabbedBrandPage()
        {
            InitializeComponent();
        }

        private void Tab_TabClicked(object sender, OnTabClickedEventArgs args)
        {
            //return the tab page. We can change that tab content here also.
            OnPropertyChanged();
            var white = Color.FromHex("#FFFFFF");
            var purple = Color.FromHex("#7E2081");

            var sel = Tabcomponent.SelectedIndex ;

            if (Label1.BackgroundColor == purple)
            {
                Label1.BackgroundColor = white;
                Label1.TextColor = purple;

                Label2.BackgroundColor = purple;
                Label2.TextColor = white;

                Label3.BackgroundColor = purple;
                Label3.TextColor = white;
            }
            else if (Label2.BackgroundColor == white)
            {
                Label1.BackgroundColor = purple;
                Label1.TextColor = white;

                Label2.BackgroundColor = white;
                Label2.TextColor = purple;

                Label3.BackgroundColor = purple;
                Label3.TextColor = white;
            }
            else if (Label3.BackgroundColor == white)
            {
                Label1.BackgroundColor = purple;
                Label1.TextColor = white;

                Label2.BackgroundColor = purple;
                Label2.TextColor = white;

                Label3.BackgroundColor = white;
                Label3.TextColor = purple;
            }


        }
    }
}
