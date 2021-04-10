using System;
using System.Collections.ObjectModel;
using System.Windows.Input;
using Xamarin.Forms;

namespace AppVacances
{
    public class LieuListPageViewModel : BaseViewModel
    {

        ObservableCollection<Lieu> lieux = new ObservableCollection<Lieu>();
        Lieu lieuSelected;

        public ObservableCollection<Lieu> Lieux
        {
            get
            {
                return lieux;
            }

            set
            {
                SetProperty(ref lieux, value);
            }
        }

        public LieuListPageViewModel()
        {
            Lieux.Add(new Lieu
            {
                Intitule = "Rome",
                Description = "textttt"
            });
            Lieux.Add(new Lieu
            {
                Intitule = "hgjkj",
                Description = "ddd"
            });
            Lieux.Add(new Lieu
            {
                Intitule = "ddddt",
                Description = "dddd"
            });

        }

        public LieuListPageViewModel(ObservableCollection<Lieu> newLieux)
        {
            Lieux = newLieux;
        }
 

       

        public ICommand OnButtonShowClickedCommand
        {
            get
            {
                return new Command(ButtonShowClickedCommand);
            }
        }

        void ButtonShowClickedCommand()
        {
            if (LieuSelected != null)
            {
                Application.Current.MainPage.Navigation.PushAsync(new LieuDetailsPage(LieuSelected));
            }
            else
            {
                Device.BeginInvokeOnMainThread(async () =>
                {
                    await Application.Current.MainPage.DisplayAlert("Information", "Veuillez sélectionner un lieu avant d'appuyer sur ce bouton !", "OK");
                    LieuSelected = null;
                });
            }

        }

      
       
       
        

        public Lieu LieuSelected
        {
            get
            {
                return lieuSelected;
            }
            set
            {

                SetProperty(ref lieuSelected, value);
            }
        }

    }
}
