using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TheAionProject;

namespace TheAionProject
{
    /// <summary>
    /// class of the game map
    /// </summary>
    public class Universe
    {
        // dictinary to hold health value of content

        private Dictionary<string, int> _contentValues;


        #region ***** define all lists to be maintained by the Universe object *****
        private List<SpaceTimeLocation> _spaceTimeLocations;

        #endregion

        #region Properties

        public List<SpaceTimeLocation> SpaceTimeLocations
        {
            get { return _spaceTimeLocations; }
            set { _spaceTimeLocations = value; }
        }


        public Dictionary<string, int> ContentValues
        {
            get { return _contentValues; }
            set { _contentValues = value; }
        }

        #endregion

        #region ***** constructor *****

        //
        // default Universe constructor
        //
        public Universe()
        {
            //
            // add all of the universe objects to the game
            // 
            IntializeUniverse();
        }

        #endregion

        #region ***** define methods to initialize all game elements *****

        /// <summary>
        /// initialize the universe with all of the space-time locations
        /// </summary>
        private void IntializeUniverse()
        {
            _spaceTimeLocations = UniverseObjects.SpaceTimeLocations;

            _contentValues = new Dictionary<string, int>()
            {
                { "Fish Taco", 10 },
                { "Pizza", 5 },
                { "Rotten Apple", -10 },
                { "Super Potato", 50 }
            };
        }

        #endregion

        #region ***** define methods to return game element objects and information *****
        
        /// <summary>
        /// determine if the Space-Time Location Id is valid
        /// </summary>
        /// <param name="spaceTimeLocationId">true if Space-Time Location exists</param>
        /// <returns></returns>
        public bool IsValidSpaceTimeLocationId(int spaceTimeLocationId)
        {
            List<int> spaceTimeLocationIds = new List<int>();

            //
            // create a list of space-time location ids
            //
            foreach (SpaceTimeLocation stl in _spaceTimeLocations)
            {
                spaceTimeLocationIds.Add(stl.SpaceTimeLocationID);
            }

            //
            // determine if the space-time location id is a valid id and return the result
            //
            if (spaceTimeLocationIds.Contains(spaceTimeLocationId))
            {
                return true;
            }
            else
            {
                return false;
            }

        }


        /// <summary>
        /// determine if a location is accessible to the player
        /// </summary>
        /// <param name="spaceTimeLocationId"></param>
        /// <returns>accessible</returns>
        public bool IsAccessibleLocation(int spaceTimeLocationId, Traveler gameTraveler)
        {

            SpaceTimeLocation spaceTimeLocation = GetSpaceTimeLocationById(spaceTimeLocationId);
            SpaceTimeLocation currentLocation = GetSpaceTimeLocationById(gameTraveler.SpaceTimeLocationID);
            if (spaceTimeLocation.AccessabelRegions.Contains(currentLocation.Region))
            {
                if (gameTraveler.ExperiencePoints >= spaceTimeLocation.EntryPoints)
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
            else
            {
                return false;
            }




        }

        /// <summary>
        /// return the next available ID for a SpaceTimeLocation object
        /// </summary>
        /// <returns>next SpaceTimeLocationObjectID </returns>
        public int GetMaxSpaceTimeLocationId()
        {
            int MaxId = 0;

            foreach (SpaceTimeLocation spaceTimeLocation in SpaceTimeLocations)
            {
                if (spaceTimeLocation.SpaceTimeLocationID > MaxId)
                {
                    MaxId = spaceTimeLocation.SpaceTimeLocationID;
                }
            }

            return MaxId;
        }

        /// <summary>
        /// get a SpaceTimeLocation object using an Id
        /// </summary>
        /// <param name="Id">space-time location ID</param>
        /// <returns>requested space-time location</returns>
        public SpaceTimeLocation GetSpaceTimeLocationById(int Id)
        {
            SpaceTimeLocation spaceTimeLocation = null;

            //
            // run through the space-time location list and grab the correct one
            //
            foreach (SpaceTimeLocation location in _spaceTimeLocations)
            {
                if (location.SpaceTimeLocationID == Id)
                {
                    spaceTimeLocation = location;
                }
            }

            //
            // the specified ID was not found in the univers
            // throw an exception
            //

            if (spaceTimeLocation == null)
            {
                string feedBackMessage = $"The Space-Time Location Id {Id} does not exist in the current Universe.";
                throw new ArgumentException(Id.ToString(), feedBackMessage);
            }

            return spaceTimeLocation;
        }



        #endregion
    }
}
