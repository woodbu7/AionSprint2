using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TheAionProject
{
    /// <summary>
    /// static class to hold all objects in the game universe; locations, game objects, npc's
    /// </summary>
    public static class UniverseObjects
    {
        public static List<SpaceTimeLocation> SpaceTimeLocations = new List<SpaceTimeLocation>()
        {

            new SpaceTimeLocation
            {
                Region = SpaceTimeLocation.RegionName.Earth,
                CommonName = "Aion Base Lab",
                SpaceTimeLocationID = 1,
                Description = "The Norlon Corporation research facility located in " +
                    "the city of Heraklion on the north coast of Crete and the top secret " +
                    "research lab for the Aion Project.\n" +
                    "The lab is a large, well lit room, and staffed " +
                    "by a small number of scientists, all wearing light blue uniforms with the " +
                    "hydra-like Norlan Corporation logo. \n",
                GeneralContents = new List<string>()
                {
                    "Pizza"
                },
                ExperiencePoints = 10,
                Radiation = 0,
                EntryPoints = 0,
                AccessabelRegions = new List<SpaceTimeLocation.RegionName>()
                {
                    SpaceTimeLocation.RegionName.Earth,
                    SpaceTimeLocation.RegionName.Lappona
                }

            },

            new SpaceTimeLocation
            {
                Region = SpaceTimeLocation.RegionName.Lappona,
                CommonName = "Felandrian Plains",
                SpaceTimeLocationID = 2,
                Description = "The Felandrian Plains are a common destination for tourist. " +
                    "Located just north of the equatorial line on the planet of Corlon, they " +
                    "provide excellent habitat for a rich ecosystem of flora and fauna.",
                GeneralContents = new List<string>()
                {
                    "Fish Taco"
                },
                ExperiencePoints = 20,
                Radiation = 0,
                EntryPoints = 5,
                AccessabelRegions = new List<SpaceTimeLocation.RegionName>()
                {
                    SpaceTimeLocation.RegionName.Earth,
                    SpaceTimeLocation.RegionName.Calypso,
                    SpaceTimeLocation.RegionName.Lappona
                }

            },

            new SpaceTimeLocation
            {
                Region = SpaceTimeLocation.RegionName.Calypso,
                CommonName = "Xantoria Market",
                SpaceTimeLocationID = 3,
                Description = "The Xantoria market, once controlled by the Thorian elite, is now an " +
                              "open market managed by the Xantorian Commerce Coop. It is a place " +
                              "where many races from various systems trade goods.",
                GeneralContents = new List<string>()
                {
                    "Super Potato"
                },
                ExperiencePoints = 50,
                Radiation = 5,
                EntryPoints = 30,
                AccessabelRegions = new List<SpaceTimeLocation.RegionName>()
                {
                    SpaceTimeLocation.RegionName.Lappona,
                    SpaceTimeLocation.RegionName.Calypso
                }
            },

            new SpaceTimeLocation
            {
                Region = SpaceTimeLocation.RegionName.Earth,
                CommonName = "Norlon Corporate Headquarters",
                SpaceTimeLocationID = 4,
                Description = "The Norlon Corporation Headquarters is located in just outside of Detroit Michigan." +
                              "Norlon, founded in 1985 as a bio-tech company, is now a 36 billion dollar company " +
                              "with huge holdings in defense and space research and development.",
                GeneralContents = new List<string>()
                {
                    "Pizza"
                },
                ExperiencePoints = 10,
                Radiation = 0,
                EntryPoints = 10,
                AccessabelRegions = new List<SpaceTimeLocation.RegionName>()
                {
                    SpaceTimeLocation.RegionName.Earth,
                    SpaceTimeLocation.RegionName.Lappona
                }
            },

                new SpaceTimeLocation
                {
                    Region = SpaceTimeLocation.RegionName.Lappona,
                    CommonName = "Sputnik Space Station",
                    SpaceTimeLocationID = 5,
                    Description = "The Sputnik Space Station is an old space station located between the planet Corlon. " +
                        "and the planet Karifa. The station was once run by russion scientist, but is now an abondoed " +
                        "station. But there seems to have been others here very recently.",
                    GeneralContents = new List<string>()
                    {
                        "Rotten Apple",
                        "Smelly shoe"
                    },
                    ExperiencePoints = - 20,
                    Radiation = 25,
                    EntryPoints = 0,
                    AccessabelRegions = new List<SpaceTimeLocation.RegionName>()
                    {
                        SpaceTimeLocation.RegionName.Earth,
                        SpaceTimeLocation.RegionName.Lappona,
                        SpaceTimeLocation.RegionName.Calypso
                    }
                },

                new SpaceTimeLocation
                {
                    Region = SpaceTimeLocation.RegionName.Calypso,
                    CommonName = "Gelandria",
                    SpaceTimeLocationID = 6,
                    Description = "You can't be here!",
                    GeneralContents = new List<string>()
                    {
                        "Nothing is here"
                    },
                    ExperiencePoints = 0,
                    Radiation = 0,
                    EntryPoints = 0,
                    AccessabelRegions = new List<SpaceTimeLocation.RegionName>()
                    {
                        SpaceTimeLocation.RegionName.All
                    }
                }

        };
    }
}
