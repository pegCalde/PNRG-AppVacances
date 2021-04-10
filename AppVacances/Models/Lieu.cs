using System;
namespace AppVacances
{
    public class Lieu
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
            get;
            set;
        }

        public string Description
        {
            get;
            set;
        }

        public string Img
        {
            get;
            set;
        }

        public string[] Imgs
        {
            get;
            set;
        }

        public bool EstFav
        {
            get;
            set;
        }

        public int Notation
        {
            get;
            set;
        }

        public double Température
        {
            get;
            set;
        }

        public string IcôneMétéo
        {
            get;
            set;
        }

        public Lieu()
        {
           
        }
    }
}
