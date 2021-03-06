﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TheAionProject
{
    /// <summary>
    /// class to store static and to generate dynamic text for the message and input boxes
    /// </summary>
    public static class Text
    {
        public static List<string> HeaderText = new List<string>() { "The Aion Project" };
        public static List<string> FooterText = new List<string>() { "Laughing Leaf Productions, 2016" };

        #region INTITIAL GAME SETUP

        public static string MissionIntro()
        {
            string messageBoxText =
            "You have been hired by the Norlon Corporation to participate " +
            "in its latest endeavor, the Aion Project. Your mission is to " +
            "test the limits of the new Aion Engine and report back to " +
            "the Norlon Corporation.\n" +
            " \n" +
            "Press the Esc key to exit the game at any point.\n" +
            " \n" +
            "Your mission begins now.\n" +
            " \n" +
            "\tYour first task will be to set up the initial parameters of your mission.\n" +
            " \n" +
            "\tPress any key to begin the Mission Initialization Process.\n";

            return messageBoxText;
        }

        public static string CurrrentLocationInfo()
        {
            string messageBoxText =
            "You are now in the Norlon Corporation research facility located in " +
            "the city of Heraklion on the north coast of Crete. You have passed through " +
            "heavy security and descended an unknown number of levels to the top secret " +
            "research lab for the Aion Project.\n" +
            " \n" +
            "\tChoose from the menu options to proceed.\n";

            return messageBoxText;
        }

        #region Initialize Mission Text

        public static string InitializeMissionIntro()
        {
            string messageBoxText =
                "Before you begin your mission we much gather your base data.\n" +
                " \n" +
                "You will be prompted for the required information. Please enter the information below.\n" +
                " \n" +
                "\tPress any key to begin.";

            return messageBoxText;
        }

        public static string InitializeMissionGetTravelerName()
        {
            string messageBoxText =
                "Enter your name traveler.\n" +
                " \n" +
                "Please use the name you wish to be referred during your mission.";

            return messageBoxText;
        }

        public static string InitializeMissionGetTravelerAge(string name)
        {
            string messageBoxText =
                $"Very good then, we will call you {name} on this mission.\n" +
                " \n" +
                "Enter your age below.\n" +
                " \n" +
                "Please use the standard Earth year as your reference.";

            return messageBoxText;
        }

        public static string InitializeMissionGetTravelerRace(Traveler gameTraveler)
        {
            string messageBoxText =
                $"{gameTraveler.Name}, it will be important for us to know your race on this mission.\n" +
                " \n" +
                "Enter your race below.\n" +
                " \n" +
                "Please use the universal race classifications below." +
                " \n";

            string raceList = null;

            foreach (Character.RaceType race in Enum.GetValues(typeof(Character.RaceType)))
            {
                if (race != Character.RaceType.None)
                {
                    raceList += $"\t{race}\n";
                }
            }

            messageBoxText += raceList;

            return messageBoxText;
        }

        public static string InitializeMissionEchoTravelerInfo(Traveler gameTraveler)
        {
            string messageBoxText =
                $"Very good then {gameTraveler.Name}.\n" +
                " \n" +
                "It appears we have all the necessary data to begin your mission. You will find it" +
                " listed below.\n" +
                " \n" +
                $"\tTraveler Name: {gameTraveler.Name}\n" +
                $"\tTraveler Age: {gameTraveler.Age}\n" +
                $"\tTraveler Race: {gameTraveler.Race}\n" +
                " \n" +
                "Press any key to begin your mission.";

            return messageBoxText;
        }

        #endregion

        #endregion

        #region MAIN MENU ACTION SCREENS

        public static string TravelerInfo(Traveler gameTraveler)
        {
            string messageBoxText =
                $"\tTraveler Name: {gameTraveler.Name}\n" +
                $"\tTraveler Age: {gameTraveler.Age}\n" +
                $"\tTraveler Race: {gameTraveler.Race}\n" +
                " \n";

            return messageBoxText;
        }

        #endregion

        public static List<string> StatusBox(Traveler traveler)
        {
            List<string> statusBoxText = new List<string>();

            statusBoxText.Add($"Experience Points: {traveler.ExperiencePoints}\n");
            statusBoxText.Add($"Health: {traveler.Health}\n");
            statusBoxText.Add($"Lives: {traveler.Lives}\n");

            return statusBoxText;
        }

        /// <summary>
        /// List all spaceTimeLocations
        /// </summary>
        /// <param name="spaceTimeLocations"></param>
        /// <returns></returns>
        public static string ListSpaceTimeLocations(IEnumerable<SpaceTimeLocation> spaceTimeLocations)
        {
            string messageBoxText =
                "Space-Time Locations\n" +
                " \n" +

                //
                // display table header
                //
                "ID".PadRight(10) + "Name".PadRight(30) + "Region".PadRight(10) + "\n" +
                "---".PadRight(10) + "----------------------".PadRight(30) + "------------" + "\n";

            //
            // display all locations
            //
            string spaceTimeLocationList = null;
            foreach (SpaceTimeLocation spaceTimeLocation in spaceTimeLocations)
            {
                spaceTimeLocationList +=
                    $"{spaceTimeLocation.SpaceTimeLocationID}".PadRight(10) +
                    $"{spaceTimeLocation.CommonName}".PadRight(30) +
                    $"{spaceTimeLocation.Region}".PadRight(10) +
                    Environment.NewLine;
            }

            messageBoxText += spaceTimeLocationList;

            return messageBoxText;
        }

        public static string LookAround(SpaceTimeLocation spaceTimeLocation, Dictionary<string, int> contentValues)
        {
            string messageBoxText =
                $"Current Location: {spaceTimeLocation.CommonName}\n" +
                " \n";

            string contents = null;

            foreach (var content in contentValues)
            {
                if (spaceTimeLocation.GeneralContents.Contains(content.Key))
                {
                    contents +=
                        $"{content.Key}, health points = {content.Value}\n";
                }
            }

            messageBoxText += contents;

            return messageBoxText;
        }

        public static string Travel(Traveler gameTraveler, List<SpaceTimeLocation> spaceTimeLocations)
        {
            string messageTextBox =
                $"{gameTraveler.Name}, Aion Base will need to know the name of the new location. \n" +
                " \n" +
                "Enter the ID number of your desired location from the table below. \n" +
                " \n" +

                //
                // display table header
                //
                "ID".PadRight(5) + "Name".PadRight(30) + "Region".PadRight(15) + "Entry Points".PadRight(10) + "\n" +
                "---".PadRight(5) + "-------------------".PadRight(30) + "--------------".PadRight(15) + "-----".PadRight(10) + "\n";

            //
            // display all locations except the current location
            //
            string spaceTimeLocationList = null;
            foreach (SpaceTimeLocation spaceTimeLocation in spaceTimeLocations)
            {
                if (spaceTimeLocation.SpaceTimeLocationID != gameTraveler.SpaceTimeLocationID)
                {
                    spaceTimeLocationList +=
                        $"{spaceTimeLocation.SpaceTimeLocationID}".PadRight(5) +
                        $"{spaceTimeLocation.CommonName}".PadRight(30) +
                        $"{spaceTimeLocation.Region}".PadRight(15) +
                        $"{spaceTimeLocation.EntryPoints}".PadRight(10) +

                        Environment.NewLine;
                }
            }

            messageTextBox += spaceTimeLocationList;

            return messageTextBox;
        }

        public static string CurrentLocationInfo(SpaceTimeLocation spaceTimeLocation)
        {
            string messageBoxText =
                $"You are currently in the region: {spaceTimeLocation.Region}\n" +
                $"Current Location: {spaceTimeLocation.CommonName}\n" +
                $"Accesible Regions: \n";

            string regionsList = null;
            foreach (SpaceTimeLocation.RegionName region in spaceTimeLocation.AccessabelRegions)
            {
                regionsList += $"\t{region}".PadRight(10) + "\n";
            }

            messageBoxText += regionsList;

            messageBoxText +=
                Environment.NewLine +
                $"Radiation Level: {spaceTimeLocation.Radiation} \n" +
                Environment.NewLine +
                $"{spaceTimeLocation.Description}" +
                Environment.NewLine +
                Environment.NewLine +
                "\tChoose from the menu options to continue.";


            return messageBoxText;
        }

        public static string VisitedLocations(IEnumerable<SpaceTimeLocation> spaceTimeLocations)
        {
            string messageBoxText =
                $"Space-Time Locations Visited\n" +
                " \n" +

                //
                // display table header
                //
                "ID".PadRight(10) + "Name".PadRight(30) + "\n" +
                "---".PadRight(10) + "----------------------".PadRight(30) + "\n";

            //
            // display all locations 
            //
            string spaceTimeLocationList = null;
            foreach (SpaceTimeLocation spaceTimeLocation in spaceTimeLocations)
            {
                spaceTimeLocationList +=
                    $"{spaceTimeLocation.SpaceTimeLocationID}".PadRight(10) +
                    $"{spaceTimeLocation.CommonName}".PadRight(30) +
                    Environment.NewLine;
            }

            messageBoxText += spaceTimeLocationList;

            return messageBoxText;
        }

        public static string GelandriaSpaceTimeLoopHole(Traveler gameTraveler)
        {
            string messageBoxText =
                $"{gameTraveler.Name}, Gelandria is a Space Time Loop Hole! \n" +
                "You will be sent to another space time location. \n" +
                " \n" +
                "Press any key to continye.";

            return messageBoxText;        
        }
    }
}
