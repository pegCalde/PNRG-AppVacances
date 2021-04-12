using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using Xamarin.Forms;

namespace AppVacances
{
    public partial class FavoriListPage : ContentPage
    {
        public FavoriListPage(ObservableCollection<Lieu> lieux)
        {
            InitializeComponent();
            BindingContext = new FavoriListPage(lieux);
        }
    }
}
