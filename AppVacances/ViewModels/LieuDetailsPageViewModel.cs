using System;
using System.Collections.ObjectModel;
using System.Windows.Input;
using Xamarin.Forms;

namespace AppVacances
{
    public class LieuDetailsPageViewModel : BaseViewModel


    {

        string intitule;
        string description;
        string image;



        public string Intitule
        {
            get
            {
                return intitule;
            }
            set
            {
                SetProperty(ref intitule, value);
            }
        }
        public string Description
        {
            get
            {
                return description;
            }
            set
            {
                SetProperty(ref description, value);
            }
        }
        public string Image
        {
            get
            {
                return image ;
            }
            set
            {
                SetProperty(ref image, value);
            }
        }
        public LieuDetailsPageViewModel(Lieu lieu)
        {
            Intitule = "Rome";
            Description = "texte";
            Image = "rome.jpg";
        }
       
    }
}
