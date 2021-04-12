using System;
using System.Collections.Generic;

using Xamarin.Forms;

namespace AppVacances
{
    public partial class LieuDetailsPage : ContentPage
    {
        public LieuDetailsPage()
        {
        }

        public LieuDetailsPage(Lieu lieu)
        {
            InitializeComponent();
            BindingContext = new LieuDetailsPageViewModel(lieu);
        }
    }
}
