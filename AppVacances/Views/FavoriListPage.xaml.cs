using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using Xamarin.Essentials;
using Xamarin.Forms;

namespace AppVacances
{
    public partial class FavoriListPage : ContentPage
    {
        public ObservableCollection<Lieu> lieuxSave;
        public FavoriListPage(ObservableCollection<Lieu> lieux)
        {
            InitializeComponent();
            BindingContext = new FavoriListPageViewModel(lieux);
            lieuxSave = lieux;
        }

        protected override void OnAppearing()
        {
            ObservableCollection<Lieu> favoris = new ObservableCollection<Lieu>();

            for (int i = 0; i < lieuxSave.Count; i++)
            {
                if (Preferences.ContainsKey(lieuxSave[i].Nom))
                {
                    if (Preferences.Get(lieuxSave[i].Nom, false) == true)
                    {
                        favoris.Add(lieuxSave[i]);
                    }
                }
            }

            BindingContext = new FavoriListPageViewModel(favoris);
            base.OnAppearing();
        }
    }
}
