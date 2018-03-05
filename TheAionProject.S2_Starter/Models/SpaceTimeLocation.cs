using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TheAionProject
{
    /// <summary>
    /// class for the game map locations
    /// </summary>
    public class SpaceTimeLocation
    {
        #region FIELDS

        private string _commonName;
        private int _spaceTimeLocationID; // must be a unique value for each object
        private string _description;
        private List<string> _generalContents;
        private bool _accessable;
        private int _experiencePoints;
        private int _radiation;

        #endregion


        #region PROPERTIES

        public string CommonName
        {
            get { return _commonName; }
            set { _commonName = value; }
        }

        public int SpaceTimeLocationID
        {
            get { return _spaceTimeLocationID; }
            set { _spaceTimeLocationID = value; }
        }

        public string Description
        {
            get { return _description; }
            set { _description = value; }
        }

        public List<string> GeneralContents
        {
            get { return _generalContents; }
            set { _generalContents = value; }
        }

        public bool Accessable
        {
            get { return _accessable; }
            set { _accessable = value; }
        }

        public int ExperiencePoints
        {
            get { return _experiencePoints; }
            set { _experiencePoints = value; }
        }

        public int Radiation
        {
            get { return _radiation; }
            set { _radiation = value; }
        }


        #endregion


        #region CONSTRUCTORS



        #endregion


        #region METHODS



        #endregion


    }
}
