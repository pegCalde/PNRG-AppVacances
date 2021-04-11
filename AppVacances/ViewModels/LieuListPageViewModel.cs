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
                Nom = "Rome",
                Description = "La tentaculaire ville de Rome reste l’une des destinations les plus prisées au monde, grâce à son mélange harmonieux de merveilles antiques et de délices modernes. Vous pouvez visiter les ruines du Colisée, les fontaines emblématiques de la ville, et vous promener dans les rues pavées avec un gelato à la main : Bien d’autres surprises vous y attendent. Rome est une ville sinueuse et spectaculaire, pleine de lieux à découvrir.",
                Img = "rome1.jpg",
                Imgs = new string[] { "rome1.jpg", "rome2.jpg", "rome3.jpg", "rome4.jpg" },
                EstFav = false,
                Notation = 0,
                Température = 20,
                IcôneMétéo = "soleil.jpg"
            });
            Lieux.Add(new Lieu
            {
                Nom = "Madrid",
                Description = "Si Madrid ressemble à un conte de fées, c'est parce qu'elle abrite de nombreux édifices dont l'architecture rappelle de magnifiques châteaux. Même l'Hôtel de Ville, orné de pinacles blancs et d'éléments au style néogothique, vous surprendra. Si vous souhaitez découvrir l'architecture madrilène par vous-même, la grande statue de l'Ours et de l'arbousier sur la place de la Puerta del Sol dans le centre-ville est un bon point de départ. Faites un tour dans le quartier du Palais royal avant de vous laisser imprégner par la beauté naturelle du parc du Retiro, puis enchaînez avec la visite d'un des nombreux musées que compte la ville. L'art s'invite aussi à votre table, alors ne manquez pas de terminer la journée en dégustant un bel assortiment de tapas avec un verre de vin de la Rioja.",
                Img = "madrid1.jpg",
                Imgs = new string[] { "madrid1.jpg", "madrid2.jpg", "madrid3.jpg", "madrid4.jpg" },
                EstFav = false,
                Notation = 0,
                Température = 20,
                IcôneMétéo = "soleil.jpg"
            });
            Lieux.Add(new Lieu
            {
                Nom = "Athènes",
                Description = "Autrefois le cœur de l'une des civilisations les plus puissantes de l'Antiquité, Athènes regorge d'imposantes merveilles architecturales, de l'Acropole au temple de Zeus.  Ses quartiers et ruelles diffusent aujourd'hui une énergie résolument moderne et décontractée, avec des restaurants animés et des galeries branchées qui contrastent avec son riche héritage historique. Laissez derrière vous l'effervescence de la ville en vous promenant le long de son splendide littoral bordé d'eaux pures et de calmes stations balnéaires. L'agora romaine et la tour des vents.",
                Img = "athenes1.jpg",
                Imgs = new string[] { "athenes1.jpg", "athenes2.jpg", "athenes3.jpg", "athenes4.jpg" },
                EstFav = false,
                Notation = 0,
                Température = 20,
                IcôneMétéo = "soleil.jpg"
            });
            Lieux.Add(new Lieu
            {
                Nom = "Londres",
                Description = "Londres est une ville chargée d’histoire, où le médiéval et le style victorien cohabitent avec un monde moderne riche et dynamique. La tour de Londres et l’abbaye de Westminster avoisinent les pubs et les marchés locaux, et des rituels usés par le temps comme la relève de la garde ont lieu pendant que les usagers se précipitent pour prendre le métro. C’est une ville où les touristes peuvent se promener et se divertir et, lorsqu’ils sont fatigués, faire comme les Londoniens : prendre une tasse de thé.",
                Img = "londres1.jpg",
                Imgs = new string[] { "londres1.jpg", "londres2.jpg", "londres3.jpg", "londres4.jpg" },
                EstFav = false,
                Notation = 0,
                Température = 20,
                IcôneMétéo = "soleil.jpg"
            });
            Lieux.Add(new Lieu
            {
                Nom = "Lisbonne",
                Description = "Nichée au milieu de sept collines, cette immense ville piétonne offre une alternative enchanteresse aux capitales les plus populaires d’Europe. Avec une vie nocturne animée, des marchés festifs et des musées dynamiques, Lisbonne offre de nombreuses options pour prendre quelques verres de porto, une généreuse portion de bacalhau et une bonne quantité de pastéis de nata.",
                Img = "lisbonne1.jpg",
                Imgs = new string[] { "lisbonne1.jpg", "lisbonne2.jpg", "lisbonne3.jpg", "lisbonne4.jpg" },
                EstFav = false,
                Notation = 0,
                Température = 20,
                IcôneMétéo = "soleil.jpg"
            });
            Lieux.Add(new Lieu
            {
                Nom = "Paris",
                Description = "Aucun autre endroit au monde ne fait autant rêver que Paris. La ville séduit par son art, son architecture, sa culture et sa cuisine, mais il y a aussi des merveilles plus discrètes qui n’attendent qu’à être explorées : les ruelles pavées pittoresques, les pâtisseries au coin de la rue et les petits bistrots douillets qui vous invitent à boire un verre de beaujolais. Préparez-vous à vous approprier Paris.",
                Img = "paris1.jpg",
                Imgs = new string[] { "paris1.jpg", "paris2.jpg", "paris3.jpg", "paris4.jpg" },
                EstFav = false,
                Notation = 0,
                Température = 20,
                IcôneMétéo = "soleil.jpg"
            });
            Lieux.Add(new Lieu
            {
                Nom = "Honolulu",
                Description = "Le simple nom d'Hawaï évoque des planches de surf et des cocktails colorés. Dans la plus grande ville de l'État, Honolulu, vous trouverez non seulement des spots de surf légendaires et des boissons tropicales délicieuses, mais aussi des  musées d'art, des pistes de VTT et des paysages de rêve. Prenez un bain de soleil sur le sable fin de la célèbre plage de Waikiki Beach ou bien allez faire du surf. Sillonnez l'immense cratère de Diamond Head et profitez des vues imprenables sur l'île d'Oahu. Et entre deux jours de plage, allez jeter un œil aux sites historiques de Iolani Palace et Ali'iolani Hale.",
                Img = "honolulu1.jpg",
                Imgs = new string[] { "honolulu1.jpg", "honolulu2.jpg", "honolulu3.jpg", "honolulu4.jpg" },
                EstFav = false,
                Notation = 0,
                Température = 20,
                IcôneMétéo = "soleil.jpg"
            });
            Lieux.Add(new Lieu
            {
                Nom = "Singapour",
                Description = "Cette minuscule cité - État insulaire est un univers de fusions et de contrastes qui regorge de merveilles à explorer.Des parcs paisibles y côtoient des gratte - ciel futuristes et des centres commerciaux de luxe.La cuisine de rue florissante et des restaurants de classe mondiale offrent d’innombrables façons de déguster et d’explorer le melting - pot culinaire de Singapour.Votre premier voyage à Singapour vous prouvera que parfois les meilleures choses se présentent sous forme de petits paquets.",
                Img = "singapour1.jpg",
                Imgs = new string[] { "singapour1.jpg", "singapour2.jpg", "singapour3.jpg", "singapour4.jpg" },
                EstFav = false,
                Notation = 0,
                Température = 20,
                IcôneMétéo = "soleil.jpg"
            });
            Lieux.Add(new Lieu
            {
                Nom = "Tokyo",
                Description = "Avec ses gratte-ciel futuristes, sa scène gastronomique inégalée et sa vie nocturne endiablée, Tokyo suscite une véritable poussée d’adrénaline. Cette vaste ville aux multiples facettes est réputée pour être à la pointe du progrès, mais ses anciens temples bouddhistes, ses salons de thé d’époque et ses jardins paisibles offrent une évasion sereine et un rappel émouvant de la longue histoire de la ville. Et pour les plus curieux, les petits plaisirs de Tokyo (les endroits secrets où l’on trouve des ramens, les allées commerçantes, les lieux de musique relaxante) se cachent souvent à la vue de tous.",
                Img = "tokyo1.jpg",
                Imgs = new string[] { "tokyo1.jpg", "tokyo2.jpg", "tokyo3.jpg", "tokyo4.jpg" },
                EstFav = false,
                Notation = 0,
                Température = 20,
                IcôneMétéo = "soleil.jpg"
            });
            Lieux.Add(new Lieu
            {
                Nom = "New York",
                Description = "Les plus hauts buildings, les plus grands musées et la meilleure pizza : New York City est la ville des superlatifs, auxquels elle fait largement honneur. Avec l'incroyable scène de Broadway, les splendides galeries du MoMA, les boutiques de SoHo et la multitude de restaurants proposant des plats de tous les coins du monde, vous découvrirez une nouvelle ville à chacune de vos visites. Mais au-delà de ces lieux emblématiques, on trouve un New York moins connu. Même lors d'une courte promenade, vous découvrirez sans aucun doute des boutiques vintage et des cafés fréquentés seulement par les locaux. Et lorsque la foule et le bruit vous fatiguent, levez les yeux : ces gratte-ciel uniques vous rappelleront pourquoi vous souhaitiez tant venir.",
                Img = "newyork1.jpg",
                Imgs = new string[] { "newyork1.jpg", "newyork2.jpg", "newyork3.jpg", "newyork4.jpg" },
                EstFav = false,
                Notation = 0,
                Température = 20,
                IcôneMétéo = "soleil.jpg"
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
