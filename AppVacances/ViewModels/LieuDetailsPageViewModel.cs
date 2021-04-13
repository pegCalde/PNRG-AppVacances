using AppVacances.Models;
using AppVacances.Service;
using Newtonsoft.Json;
using System;
using System.Collections.ObjectModel;
using System.Linq;
using System.Threading.Tasks;
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
        string température;
        string icôneMétéo;
        string querry;


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
        public string Température
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

        public string Querry
        {
            get
            {
                return querry;
            }

            set
            {
                SetProperty(ref querry, value);
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




        public ICommand GetCommand => new Command(() =>
          Task.Run(LoadWeatherData)
       );

        async Task LoadWeatherData()
        {
            if (IsBusy)
            {
                return;
            }

            IsBusy = true;
            var client = HttpService.GetInstance();
            var result = await client.GetAsync($"https://api.openweathermap.org/data/2.5/weather?q={Querry}&APPID=6fcb5a969e58b25ffb37b7426ac18d12&units=metric&lang=fr");
            var serializedResponse = await result.Content.ReadAsStringAsync();
            var weatherResponse = JsonConvert.DeserializeObject<WeatherResponse>(serializedResponse);

            if (weatherResponse?.Weather != null && weatherResponse.Weather.Any())
            {
                Température = $"{weatherResponse.Main.Temp}°"; 
            }
            else
            {
             
                Température = "unknown";
            }

            IsBusy = false;
        }
    }
}
