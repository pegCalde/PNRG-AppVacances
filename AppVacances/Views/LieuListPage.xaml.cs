using System;
using System.Collections.Generic;

using Xamarin.Forms;

namespace AppVacances
{
    public partial class LieuListPage : ContentPage
    {
        public LieuListPage()
        {
            InitializeComponent();
            BindingContext = new LieuListPageViewModel();
          
        }
        void Selected_Completed(System.Object sender, System.EventArgs e)
        {
            if (BindingContext is LieuDetailsPageViewModel vm)
            {
                vm.GetCommand.Execute(sender);
            }
        }
    }
}
