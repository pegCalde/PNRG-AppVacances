using System;
using System.Collections.ObjectModel;
using System.Windows.Input;
using Xamarin.Forms;

namespace AppVacances
{
    public class LieuDetailsPageViewModel : BaseViewModel


    {
        string nom;
        string description;
        string img;
        string[] imgs;
        bool estFav;
        int notation;
        double température;
        string icôneMétéo;

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
    }
}
