using System;
using System.Collections.ObjectModel;
using System.Diagnostics;
using System.Threading.Tasks;
using System.Windows.Input;
using Xamarin.Essentials;
using Xamarin.Forms;

namespace AppVacances
{
    public class FavoriListPageViewModel : BaseViewModel
    {
        public FavoriListPageViewModel()
        {

        }

        ObservableCollection<Lieu> lieuxFav = new ObservableCollection<Lieu>();
        public ObservableCollection<Lieu> LieuxFav
        {
            get
            {
                return lieuxFav;
            }
            set
            {
                SetProperty(ref lieuxFav, value);
            }
        }

        string message = "";
        public string Message
        {
            get
            {
                return message;
            }
            set
            {
                SetProperty(ref message, value);
            }
        }

        public FavoriListPageViewModel(ObservableCollection<Lieu> lieuxFavItems)
        {
            LieuxFav = lieuxFavItems;

            if(LieuxFav.Count == 0)
            {
                Message = "Vous avez aucun favoris pour l'instant";
            }
            else
            {
                Message = "Liste des lieux favoris";
            }
        }

        Lieu lieuFavSelected;
        public Lieu LieuFavSelected
        {
            get
            {
                return lieuFavSelected;
            }
            set
            {
                SetProperty(ref lieuFavSelected, value);
                if (value != null)
                {
                    Application.Current.MainPage.Navigation.PushAsync(new LieuDetailsPage(lieuFavSelected));
                    LieuFavSelected = null;
                }
            }
        }

        bool estFav;
        public bool EstFav
        {
            get
            {
                return estFav;
            }
            set
            {
                SetProperty(ref estFav, value);

            }
        }

        string nom;
        public string Nom
        {
            get
            {
                return nom;
            }
            set
            {
                SetProperty(ref nom, value);
            }
        }

        public ICommand DeleteCommand
        {
            get
            {
                return new Command<Lieu>(async (lieuFavToDel) => await OnDeleteCommand(lieuFavToDel));
            }
        }

        Task OnDeleteCommand(Lieu lieuFavToDel)
        {
            Preferences.Set(lieuFavToDel.Nom, false);
            
            LieuxFav.Remove(lieuFavToDel);

            return Task.CompletedTask;
        }
    }
}
