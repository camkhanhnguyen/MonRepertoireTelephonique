/**
 * titre: Mon Répertoire Téléphonique
 * desription: créer une list contact
 * auteur: Khanh NGUYEN
 */
using System;
using System.Drawing;


namespace MonRepertoireTelephonique
{
    /// <summary>
    /// créer la classe mère
    /// </summary>
    [SerializableAttribute]
    public abstract class Contacts : IComparable<Contacts>
    {
        // propriétes
        protected string nom, prenom, tel;
        private Image photo;

        /// <summary>
        /// constructeur
        /// </summary>
        /// <param name="nom">nom</param>
        /// <param name="tel">téléphone</param>
        /// <param name="photo">photo</param>
        public Contacts(string nom, string prenom, string tel, Image photo)
        {
            this.nom = nom;
            this.prenom = prenom;
            this.tel = tel;
            this.photo = photo;
        }

        /// <summary>
        /// getter le nom
        /// </summary>
        public string getNom()
        {
            return nom;
        }

        /// <summary>
        /// getter le prénom
        /// </summary>
        public string getPrenom()
        {
            return prenom;
        }

        /// <summary>
        /// getter téléphone
        /// </summary>
        /// <returns></returns>
        public string getTel()
        {
            return tel;
        }

        /// <summary>
        /// getter photo
        /// </summary>
        /// <returns></returns>
        public Image getPhoto()
        {
            return photo;
        }

        /// <summary>
        /// comparaison des noms et des prénoms dans la list box pour le tri
        /// </summary>
        /// <param name="obj">objet</param>
        /// <returns></returns>
        public int CompareTo(Contacts obj)
        {
            int resultat = nom.CompareTo(obj.nom);
            return resultat;
        }

        /// <summary>
        /// infomation sur le contact
        /// </summary>
        /// <returns></returns>
        public abstract string info();
    }

    /// <summary>
    /// créer la classe fille
    /// </summary>
    [SerializableAttribute]
    public class Famille : Contacts
    {
        /// <summary>
        /// constructeur
        /// </summary>
        /// <param name="prenom"></param>
        public Famille(string nom, string prenom, string tel, Image photo) : base(nom, prenom, tel, photo)
        {
        }

        /// <summary>
        /// information sur le contact
        /// </summary>
        /// <returns></returns>
        public override string info()
        {
            return nom + " " + prenom + " (" + tel + ")";
        }
    }

    /// <summary>
    /// créer la classe fille
    /// </summary>
    [SerializableAttribute]
    public class Amis : Contacts
    {
        // propriéte
        private string adresse;

        /// <summary>
        /// constructeur
        /// </summary>
        public Amis(string nom, string prenom, string tel, string adresse, Image photo) : base(nom, prenom, tel, photo)
        {
            this.adresse = adresse;
        }

        /// <summary>
        /// getter adresse
        /// </summary>
        /// <returns></returns>
        public string getAdresse()
        {
            return adresse;
        }

        /// <summary>
        /// information sur le contact
        /// </summary>
        /// <returns></returns>
        public override string info()
        {
            return nom + " " + prenom + " (Tel: " + tel + ", Adresse: " + adresse + " )";
        }
    }

    /// <summary>
    /// créer la classe fille
    /// </summary>
    [SerializableAttribute]
    public class Professionnel : Contacts
    {
        // propriéte
        private string email;

        /// <summary>
        /// constructeur
        /// </summary>
        /// <param name="nom">nom</param>
        /// <param name="tel">téléphone</param>
        /// <param name="photo">photo</param>
        public Professionnel(string nom, string prenom, string tel, string email, Image photo) : base(nom, prenom, tel, photo) 
        {
            this.email = email;
        }

        /// <summary>
        /// getter email
        /// </summary>
        /// <returns></returns>
        public string getEmail()
        {
            return email;
        }

        /// <summary>
        /// information sur le contact
        /// </summary>
        /// <returns></returns>
        public override string info()
        {
            return nom + " " + prenom + " (Tel: " + tel + ", Email: " + email + " )";
        }
    }
}


