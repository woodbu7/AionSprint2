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
        /*
        public static List<Region> RegionLocations = new List<Region>()
        {
            new Region
            {
                RegionName = "Halo Region",
                Description = "Some description...",
                RegionLocations = new List<SpaceTimeLocation>()
                {
                    new SpaceTimeLocation
                    {
                        CommonName = "Felandrian Plains",
                        SpaceTimeLocationID = 2,
                        Description = "The Felandrian Plains are a common destination for tourist. " +
                            "Located just north of the equatorial line on the planet of Corlon, they " +
                            "provide excellent habitat for a rich ecosystem of flora and fauna.",
                        GeneralContents = "- stuff in the room -",
                        Accessable = true,
                        ExperiencePoints = 10
                    },

                    new SpaceTimeLocation
                    {
                         CommonName = "Sputnik Space Station",
                         SpaceTimeLocationID = 5,
                         Description = "The Sputnik Space Station is an old space station located between the planet Corlon. " +
                            "and the planet Karifa. The station was once run by russion scientist, but is now an abondoed " +
                            "station. But there seems to have been others here very recently.",
                         GeneralContents = "- stuff in the room -",
                         Accessable = true,
                         ExperiencePoints = - 10
                    }

                }
            },

            new Region
            {
                RegionName = "Adromeda",
                Description = "Some description...",
                RegionLocations = new List<SpaceTimeLocation>()
                {
                    new SpaceTimeLocation
                    {
                        CommonName = "Xantoria Market",
                        SpaceTimeLocationID = 3,
                        Description = "The Xantoria market, once controlled by the Thorian elite, is now an " +
                                      "open market managed by the Xantorian Commerce Coop. It is a place " +
                                      "where many races from various systems trade goods.",
                        GeneralContents = "- stuff in the room -",
                        Accessable = false,
                        ExperiencePoints = 20
                    },

                    new SpaceTimeLocation
                    {
                        CommonName = "Aion Base Lab",
                        SpaceTimeLocationID = 1,
                        Description = "The Norlon Corporation research facility located in " +
                            "the city of Heraklion on the north coast of Crete and the top secret " +
                            "research lab for the Aion Project.\n",
                        GeneralContents = "The lab is a large, well lit room, and staffed " +
                            "by a small number of scientists, all wearing light blue uniforms with the " +
                            "hydra-like Norlan Corporation logo. \n",
                        Accessable = true,
                        ExperiencePoints = 10
                    }
                }
            }
        };
        */

        public static List<SpaceTimeLocation> SpaceTimeLocations = new List<SpaceTimeLocation>()
        {

            new SpaceTimeLocation
            {
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
                    "Flute",
                    "Pistol"
                },
                Accessable = true,
                ExperiencePoints = 10,
                Radiation = 0
                
            },

            new SpaceTimeLocation
            {
                CommonName = "Felandrian Plains",
                SpaceTimeLocationID = 2,
                Description = "The Felandrian Plains are a common destination for tourist. " +
                    "Located just north of the equatorial line on the planet of Corlon, they " +
                    "provide excellent habitat for a rich ecosystem of flora and fauna.",
                GeneralContents = new List<string>()
                {
                    "Old socks",
                    "Pizza"
                },
                Accessable = true,
                ExperiencePoints = 10,
                Radiation = 0
                
            },

            new SpaceTimeLocation
            {
                CommonName = "Xantoria Market",
                SpaceTimeLocationID = 3,
                Description = "The Xantoria market, once controlled by the Thorian elite, is now an " +
                              "open market managed by the Xantorian Commerce Coop. It is a place " +
                              "where many races from various systems trade goods.",
                GeneralContents = new List<string>()
                {
                    "Shops",
                    "Dirt"
                },
                Accessable = false,
                ExperiencePoints = 20,
                Radiation = 5
            },

            new SpaceTimeLocation
            {
                CommonName = "Norlon Corporate Headquarters",
                SpaceTimeLocationID = 4,
                Description = "The Norlon Corporation Headquarters is located in just outside of Detroit Michigan." +
                              "Norlon, founded in 1985 as a bio-tech company, is now a 36 billion dollar company " +
                              "with huge holdings in defense and space research and development.",
                GeneralContents = new List<string>()
                {
                    "Bike",
                    "Computer"
                },
                Accessable = true,
                ExperiencePoints = 10,
                Radiation = 0
            },

                new SpaceTimeLocation
                {
                CommonName = "Sputnik Space Station",
                SpaceTimeLocationID = 5,
                Description = "The Sputnik Space Station is an old space station located between the planet Corlon. " +
                    "and the planet Karifa. The station was once run by russion scientist, but is now an abondoed " +
                    "station. But there seems to have been others here very recently.",
                GeneralContents = new List<string>()
                {
                    "Can of soup",
                    "Smelly shoe"
                },
                Accessable = true,
                ExperiencePoints = - 10,
                Radiation = 25
                }
        };
    }
}
