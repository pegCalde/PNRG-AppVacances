using System;
using System.Collections.ObjectModel;
using System.Windows.Input;
using Xamarin.Essentials;
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
        string favIcon;

        public string FavIcon
        {
            get
            {
                if(EstFav)
                {
                    return "heartfill.png";
                } else
                {
                    return "heart.png";
                }
            }
            set 
            {
                SetProperty(ref favIcon, value);
            }
        }
   

      
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

             public string Img
        {
            get
            {
                return img;
            }
            set
            {
                SetProperty(ref img, value);
            }
        }


        public string [] Imgs
        {
            get
            {
                return imgs;
            }
            set
            {
                SetProperty(ref imgs, value);
            }
        }

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
        public int Notation
        {
            get
            {
                return notation;
            }
            set
            {
                SetProperty(ref notation, value);
            }
        }
        public double Température
        {
            get
            {
                return température;
            }
            set
            {
                SetProperty(ref température, value);
            }

        }

              public string IcôneMétéo
        {
            get
            {
                return icôneMétéo;
            }
            set
            {
                SetProperty(ref icôneMétéo, value);
            }
        }

        public LieuDetailsPageViewModel(Lieu lieu)
        {
            Nom = lieu.Nom;
            Description = lieu.Description;
            Img = lieu.Img;
            Imgs = lieu.Imgs;
            EstFav = lieu.EstFav;
            Notation = lieu.Notation;
            Température = lieu.Température;
            IcôneMétéo = lieu.IcôneMétéo;
        }

        public ICommand manageFavoriCommand
        {
            get
            {
                return new Command(manageFavori);
            }
        }

        public void manageFavori()
        {
            if(EstFav == false)
            {
                EstFav = true;
                Preferences.Set(Nom, true);
                FavIcon = "heartfill.png";
                
            } else
            {
                EstFav = false;
                Preferences.Set(Nom, false);
                FavIcon = "heart.png";
            }
            
        }

    }
}
