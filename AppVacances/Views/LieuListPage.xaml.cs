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
    }
}
