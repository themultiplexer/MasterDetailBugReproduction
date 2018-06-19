using System;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace MasterDetailBugReproduction.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class MasterDetail : MasterDetailPage
    {

        public MasterDetail()
        {
            InitializeComponent();
            Detail = new NavigationPage(new DetailPage());
            Master = new MasterPage();
        }
    }
}