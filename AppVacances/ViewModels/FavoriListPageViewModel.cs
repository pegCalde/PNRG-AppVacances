using System;
using System.Collections.ObjectModel;
using System.Threading.Tasks;
using System.Windows.Input;
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
        public FavoriListPageViewModel(ObservableCollection<Lieu> lieuxFavItems)
        {
            LieuxFav = lieuxFavItems;
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

        public ICommand DeleteCommand
        {
            get
            {
                return new Command<Lieu>(async (lieuFavToDel) => await OnDeleteCommand(lieuFavToDel));
            }
        }

        Task OnDeleteCommand(Lieu lieuFavToDel)
        {
            LieuxFav.Remove(lieuFavToDel);
            return Task.CompletedTask;
        }
    }
}
