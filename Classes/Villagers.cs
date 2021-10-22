﻿using System;
using System.Collections.Generic;
using System.IO;
using System.IO.Compression;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Zstandard;
using Zstandard.Net;

namespace ACNHLab.Classes
{
    class Villagers
    {
        public static List<Tuple<string, string>> Hobby = new List<Tuple<string, string>>() 
        {
            new Tuple<string, string>("59FBDC71","Education"),
            new Tuple<string, string>("C1E504E8","Fitness"),
            new Tuple<string, string>("3696CDA9","Fashion"),
            new Tuple<string, string>("B6748791","Nature"),
            new Tuple<string, string>("FEBB7184","Play"),
            new Tuple<string, string>("0C930D4E","Music")
        };
        public static List<Tuple<string, string>> Personality = new List<Tuple<string, string>>()
        {
            new Tuple<string, string>("D825E1E1","Boy_pride"),
            new Tuple<string, string>("6641BFDA","Boy_active"),
            new Tuple<string, string>("612D6C9E","Boy_snobby"),
            new Tuple<string, string>("0CDA2B3C","Boy_normal"),
            new Tuple<string, string>("CF560862","Girl_active"),
            new Tuple<string, string>("733C0A0D","Girl_pride"),
            new Tuple<string, string>("A5CD9C84","Girl_normal"),
            new Tuple<string, string>("70706744","Girl_big_sis"),
        };
        public static List<Tuple<string, string>> TalkType = new List<Tuple<string, string>>()
        {
            new Tuple<string, string>("0","Type 1"),
            new Tuple<string, string>("1","Type 2"),
        };
        public static List<Tuple<int, string, string>> Species = new List<Tuple<int, string, string>>();

        public static List<VillagerData> List { get; set; } = new List<VillagerData>();
        public static void Load()
        {
            List.Clear();
            string dir = Path.GetDirectoryName(SettingsForm.settings.ProjectPath);

            /*
             *  Decompress and extract SARC with villager related strings
             */
            SARC.Decompress(Path.Combine(dir, "Message\\String_USen.sarc.zs"), Path.Combine(dir, "Message\\String_USen.sarc"));
            SARC.ExtractToDir(Path.Combine(dir, "Message\\String_USen.sarc"), Path.Combine(dir, "Message\\String_USen"));

            /*
             *  Get species list, names and catchphrases from MSBT
             */
            List<Tuple<int, string, string>> speciesMSBT = MSBT.Deserialize(Path.Combine(dir, "Message\\String_USen\\STR_Race.msbt"), 12);
            // Remove gender from species list
            foreach (var species in speciesMSBT)
                if (!Species.Any(x => x.Item2.Substring(0, 3).Equals(species.Item2.Substring(0, 3))))
                    Species.Add(new Tuple<int, string, string>(species.Item1, species.Item2.Substring(0, 3).Replace("\0", ""), species.Item3.Replace("\0", "")));
            Program.status.Update("[INFO] Loaded villager species from \"Message\\String_USen\\STR_Race.msbt\".");
            
            List<Tuple<int, string, string>> names = MSBT.Deserialize(Path.Combine(dir, "Message\\String_USen\\Npc\\STR_NNpcName.msbt"));
            Program.status.Update("[INFO] Loaded villager names from \"Message\\String_USen\\Npc\\STR_NNpcName.msbt\".");
            
            List<Tuple<int, string, string>> phrases = MSBT.Deserialize(Path.Combine(dir, "Message\\String_USen\\Npc\\STR_NNpcPhrase.msbt"));
            Program.status.Update("[INFO] Loaded villager catchphrases from \"Message\\String_USen\\Npc\\STR_NNpcPhrase.msbt\".");
            
            /*
             *  Get NPC data from BCSV
             */
            Bcsv.Read(Path.Combine(dir, "Bcsv\\NmlNpcParam.bcsv"));
            foreach (DataGridViewRow row in Bcsv.dataGridView1.Rows)
            {
                VillagerData villager = new VillagerData();
                for (int i = 0; i < row.Cells.Count - 1; i++)
                {
                    switch (i)
                    {
                        case 5: // Hobby
                            if (row.Cells[i].Value != null && Hobby.Any(x => x.Item1.Equals(row.Cells[i].Value.ToString())))
                                villager.Hobby = Hobby.First(x => x.Item1.Equals(row.Cells[i].Value.ToString())).Item2;
                            break;
                        case 6: // Personality
                            if (row.Cells[i].Value != null && Personality.Any(x => x.Item1.Equals(row.Cells[i].Value.ToString())))
                                villager.Personality = Personality.First(x => x.Item1.Equals(row.Cells[i].Value.ToString())).Item2;
                            break;
                        case 23: // Birth Day
                            if (row.Cells[i].Value != null)
                                villager.BirthDay = Convert.ToInt32(row.Cells[i].Value.ToString().Replace("\0", ""));
                            break;
                        case 24: // Birth Month
                            if (row.Cells[i].Value != null)
                                villager.BirthMonth = Convert.ToInt32(row.Cells[i].Value.ToString().Replace("\0", ""));
                            break;
                        case 31: // Species & ID (also used to add name/phrase)
                            if (row.Cells[i].Value != null)
                            {
                                string name = Classes.Bcsv.Hex.FromHexToString(row.Cells[i].Value.ToString()).Substring(0, 5);
                                string species = name.Substring(0, 3);
                                string id = name.Substring(3, 2);
                                villager.Species = Species.First(x => x.Item2.StartsWith(species)).Item3.Replace("\0","");
                                villager.ID = Convert.ToInt32(id.Replace("\0", ""));
                                villager.Name = names.First(x => x.Item2.Equals(name)).Item3.Replace("\0", "");
                                villager.Catchphrase = phrases.First(x => x.Item2.Equals(name)).Item3.Replace("\0", "");
                            }
                            break;
                        case 33: // Talk Type
                            if (row.Cells[i].Value != null)
                                villager.TalkType = TalkType.First(x => x.Item1.Equals(row.Cells[i].Value.ToString())).Item2;
                            break;
                        default:
                            break;
                    }
                }
                List.Add(villager);
            }
            Program.status.Update("[INFO] Serialized villager data to object list.");

            /*
             *  Get amiibo data from BCSV
             */
            Bcsv.Read(Path.Combine(dir, "Bcsv\\AmiiboData.bcsv"));
            foreach (DataGridViewRow row in Bcsv.dataGridView1.Rows)
                if (row.Cells[4].Value != null)
                    foreach (var villager in List)
                        if (Classes.Bcsv.Hex.FromHexToString(row.Cells[4].Value.ToString()).Equals(villager.Name))
                            villager.Amiibo = row.Cells[0].Value.ToString();
            Program.status.Update("[INFO] Added amiibo data to villager entries.");

            // TODO: Get room/house data from BYML
        }
    }

    public class VillagerData
    {
        public string Name { get; set; } = "";
        public string Species { get; set; } = "";
        public int ID { get; set; } = 0;
        public string TalkType { get; set; } = "Type 1";
        public string Personality { get; set; } = "Normal (Boy)";
        public string Hobby { get; set; } = "Play";
        public int BirthMonth { get; set; } = 12;
        public int BirthDay { get; set; } = 31;
        public string Amiibo { get; set; } = "";
        public string Catchphrase { get; set; } = "";
        public Interior Interior { get; set; } = new Interior();
        public Exterior Exterior { get; set; } = new Exterior();
    }

    public class Interior
    {
        public int FloorType { get; set; } = 54; // 0 or 54
    }

    public class Exterior
    {

    }
}
