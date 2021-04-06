# Projet xamarin DAM

## Nom de l'application

PNRG-AppVacances 

## Membres du groupe

Peggy Calderon-Kayser  
Nawel Aittahar  
Raoua Messai  
Guillaume Savin

## CdC

Application de Lieu de vacances  

Membres : Peggy, Guillaume, Raoua et Nawel  

Cette application permet à l’utilisateur de consulter différents lieux de vacances et d’accéder aux informations de chaque lieu, ensuite il peut ajouter des lieux à sa liste de favoris et ajouter une note personnelle au lieu.  

* Persistance de certaines données : La note de l’utilisateur pour un lieu  

* Utilisation d’une API externe : API météo (donner des informations de météo sur le lieu de vacances)  

* Utilisation de fonctionnalités natives (Custom Renderer et Dependency Service) : (à définir)  

* Utilisation d’une navigation avancée (TabbedPage, SideMenu…) :  
    * Main page = la liste des lieux de vacances  
    * l’utilisateur pourra accéder à une autre page grâce à un menu pour voir sa liste de lieu favoris  

## Découpage des tâches

### Back/Front -> .cs/.xaml

* structure -> MVVM   X
   * Classe lieux de vacances (que contient l'objet/entité -> nom, pays,...)
* menu = nav par onglets en bas  X
   * Page accueil
   * Page infos lieu choisi
   * Liste favoris
* Liste des favoris  X
   * Système de mise en favoris
* Liste des lieux  X
   * Au clic sur lieu -> envoi sur la page du lieu
* Connexion à l'API météo  X
   * Création d'une fonction d'appel à l'API
   * Connexion avec le front
   * Récupération de la température du lieu
   * Récupération de la météo du lieu sur qq jours -> icônes
* Persistance des données  X
* Code coverage -> on verra si on a le tps
* Système de notation du lieu -> par étoiles  X
* ...

### Front -> .xaml uniquement

* Création partie user sur page accueil -> nom + img profil  X
* "Caroussel" img de lieu -> 3 img max avec flèches droite-gauche  X
* ...

### Présentation et recherches utiles au projet

* Recherches pour remplissage infos des lieux  X
   * img du lieu
   * 3 img max des lieux à voir ds le lieu
   * Nom du lieu
   * différentes infos diverses sur lieu 
* PowerPoint présentation projet -> on décidera plus tard qui fait ca
* ...


## Maquette

![Untitled Diagram](https://user-images.githubusercontent.com/50577515/113722394-ab963f00-96f0-11eb-8446-5ce20369ed5d.png)

## Répartition

### Guillaume
* Structure
* Persistance des données
* Classe lieux de vacances (que contient l'objet/entité -> nom, pays,...)
* Création partie user sur page accueil -> nom + img profil
* Custom Renderer
*  Liste des lieux
   * Au clic sur lieu -> envoi sur la page du lieu
* ...

### Nawel
* Liste de favoris
   * Possibilité de supprimer lieu
* Afficher élément au clic
* Classe lieux de vacances (que contient l'objet/entité -> nom, pays,...)
* Custom Renderer
* ...

### Raoua
* Page du lieu
* Custom Renderer
* Système de notation du lieu -> par étoiles
* Classe lieux de vacances (que contient l'objet/entité -> nom, pays,...)
* Connexion à l'API météo
   * Création d'une fonction d'appel à l'API
   * Connexion avec le front
   * Récupération de la température du lieu
   * Récupération de la météo du lieu sur qq jours -> icônes
* ...

### Peggy
* Classe lieux de vacances (que contient l'objet/entité -> nom, pays,...)
* Custom Renderer
* Recherches pour remplissage infos des lieux
   * img du lieu
   * 3 img max des lieux à voir ds le lieu
   * Nom du lieu
   * différentes infos diverses sur lieu 
* "Caroussel" img de lieu -> 3 img max avec flèches droite-gauche
* menu = nav par onglets en bas
   * Page accueil
   * Page infos lieu choisi
   * Liste favoris
* ...

## Classe lieux de vacances

* Nom -> string
* img -> string => img de pres du lieu
* liste d'imgs -> string[] => caroussel (optionnel SI TPS)
* estFav -> bool
* notation -> int (optionnel SI TPS)
* Température -> double
* icône météo -> switch case (optionnel SI TPS)
* description -> string
* ...

## Custom Renderer

A mettre sur le coeur à cocher/décocher + étoiles de notation si on a le tps  
Faire des recherches sur ce custom renderer  
Celui qui a le tps prend

## ..
