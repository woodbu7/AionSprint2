using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TheAionProject
{
    /// <summary>
    /// region to hold spacetime locations
    /// </summary>
    public class Region
    {
        #region Fields

        private string _regionName;
        private string _description;
        private List<SpaceTimeLocation> _regionLocations;

        #endregion

        #region Properties

        public string RegionName
        {
            get { return _regionName; }
            set { _regionName = value; }
        }

        public string Description
        {
            get { return _description; }
            set { _description = value; }
        }

        public List<SpaceTimeLocation> RegionLocations
        {
            get { return _regionLocations; }
            set { _regionLocations = value; }
        }

        #endregion

        #region Constructor

        #endregion

        #region Methods

        #endregion
    }
}
