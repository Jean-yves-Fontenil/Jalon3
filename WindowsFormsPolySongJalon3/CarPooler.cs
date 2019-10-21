
namespace WindowsFormsPolySongJalon3
{
    /// <summary>
    /// Classe CarPooler qui représente un covoitureur
    /// </summary>
    class CarPooler
    {
        #region Constructeur
        /// <summary>
        /// Constructeur de la classe CarPooler
        /// </summary>
        /// <param name="id">L'identifiant du covoitureur.</param>
        /// <param name="firstName">Son prénom.</param>
        /// <param name="lastName">Son nom.</param>
        public CarPooler(int id, string firstName, string lastName)
        {
            Id = id;
            FirstName = firstName;
            LastName = lastName;
        }
        #endregion  Constructeur

        #region Accesseurs
        /// <summary>
        /// Retourne ou initialise l'identifiant du covoitureur.
        /// </summary>
        internal int Id { get; set; }
        /// <summary>
        /// Retourne ou initialise le prénom du covoitureur.
        /// </summary>
        internal string FirstName { get; set; }
        /// <summary>
        /// Retourne ou initialise le nom du covoitureur.
        /// </summary>
        internal string LastName { get; set; }
        #endregion Accesseurs

        #region surcharge de ToString()
        /// <summary>
        /// Surcharche de la méthode ToString().
        /// </summary>
        /// <returns>retourne la concaténation du prénom et nom du covoitureur</returns>
        public override string ToString()
        {
            return FirstName + " " + LastName;
        }
        #endregion surcharge de ToString()
    }
}
