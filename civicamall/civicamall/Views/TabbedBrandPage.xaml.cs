using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xam.TabView;
using Xam.TabView.Control;
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

        private XFTabControl createTab()
        {
            XFTabControl tab = new XFTabControl
            {
            };


            return tab;
        }
        private void Tab_TabClicked(object sender, OnTabClickedEventArgs args)
        {
            //return the tab page. We can change that tab content here also.
        }

        private void Button_Clicked(object sender, System.EventArgs e)
        {
            var control = Tabcomponent;
            control.SelectedIndex = (control.SelectedIndex + 1) % 3;
        }
    }
}