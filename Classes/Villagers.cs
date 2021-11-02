using System;
using System.Collections.Generic;
using System.IO;
using System.IO.Compression;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using Zstandard;
using Zstandard.Net;

namespace ACNHLab.Classes
{
    class Villagers
    {
        public static List<Tuple<string, string>> PreferredClothes = new List<Tuple<string, string>>()
        {
            new Tuple<string, string>("00000009","None"),
            new Tuple<string, string>("00000004","Chinese"),
            new Tuple<string, string>("0000000A","Japanese")
        };
        public static List<Tuple<string, string>> PreferredStyle = new List<Tuple<string, string>>()
        {
            new Tuple<string, string>("00000001","1"),
            new Tuple<string, string>("00000002","2"),
            new Tuple<string, string>("00000003","3"),
            new Tuple<string, string>("00000004","4"),
            new Tuple<string, string>("00000005","5"),
            new Tuple<string, string>("00000006","6")
        };
        public static List<Tuple<string, string>> Unknown1 = new List<Tuple<string, string>>()
        {
            new Tuple<string, string>("26296DD2","Normal"),
            new Tuple<string, string>("D87D25AA","Prefer"),
            new Tuple<string, string>("508E8016","Avoid")
        };
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
        public static List<Tuple<string, string>> SocialType = new List<Tuple<string, string>>()
        {
            new Tuple<string, string>("51374B6B","High"),
            new Tuple<string, string>("26296DD2","Normal"),
            new Tuple<string, string>("AAC53E41","Low")
        };
        public static List<Tuple<string, string>> SingPauseType = new List<Tuple<string, string>>()
        {
            new Tuple<string, string>("1D131A47","Tie"),
            new Tuple<string, string>("1964B988","Stop")
        };
        public static List<Tuple<string, string>> SingRhythmType = new List<Tuple<string, string>>()
        {
            new Tuple<string, string>("26296DD2","Normal"),
            new Tuple<string, string>("1197DFE3","Random"),
            new Tuple<string, string>("FC4360ED","Shuffle")
        };
        public static List<Tuple<string, string>> Color = new List<Tuple<string, string>>()
        {
            new Tuple<string, string>("0","None"),
            new Tuple<string, string>("1","Red"),
            new Tuple<string, string>("2","Green"),
            new Tuple<string, string>("3","Blue"),
            new Tuple<string, string>("4","Yellow"),
            new Tuple<string, string>("5","Orange"),
            new Tuple<string, string>("6","Pink"),
            new Tuple<string, string>("7","Purple"),
            new Tuple<string, string>("8","Light Blue"),
            new Tuple<string, string>("9","Beige"),
            new Tuple<string, string>("10","Brown"),
            new Tuple<string, string>("11","Gray"),
            new Tuple<string, string>("12","White"),
            new Tuple<string, string>("13","Black"),
            new Tuple<string, string>("14","Colorful"),
        };
        public static List<Tuple<string, string>> TalkType = new List<Tuple<string, string>>()
        {
            new Tuple<string, string>("0","Type 1"),
            new Tuple<string, string>("1","Type 2"),
        };
        public static List<Tuple<int, string, string>> Species = new List<Tuple<int, string, string>>();
        public static List<Tuple<string, string>> VillageMelody = new List<Tuple<string, string>>()
        {
            new Tuple<string, string>("1","1"),
            new Tuple<string, string>("2","2"),
            new Tuple<string, string>("3","3"),
            new Tuple<string, string>("6","6"),
            new Tuple<string, string>("8","8"),
            new Tuple<string, string>("10","10"),
            new Tuple<string, string>("12","12"),
            new Tuple<string, string>("14","14"),
            new Tuple<string, string>("18","18")
        };
        public static List<Tuple<string, string>> VillageMelody2 = new List<Tuple<string, string>>()
        {
            new Tuple<string, string>("00000001","1"),
            new Tuple<string, string>("00000002","2"),
            new Tuple<string, string>("00000003","3"),
            new Tuple<string, string>("00000004","4"),
            new Tuple<string, string>("00000005","5"),
            new Tuple<string, string>("00000006","6")
        };

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
            Program.status.Update("[INFO] Loading villager data from BCSV files, please wait...");
            Bcsv.Read(Path.Combine(dir, "Bcsv\\NmlNpcParam.bcsv"));
            int rowNumber = 0;
            foreach (DataGridViewRow row in Bcsv.dataGridView1.Rows)
            {
                rowNumber++;
                if (rowNumber < Bcsv.dataGridView1.Rows.Count)
                {
                    VillagerData villager = new VillagerData();
                    for (int i = 0; i < row.Cells.Count - 1; i++)
                    {
                        switch (i)
                        {
                            case 0: // Preferred Clothes
                                if (row.Cells[i].Value != null && PreferredClothes.Any(x => x.Item1.Equals(row.Cells[i].Value.ToString())))
                                    villager.ClothesType = PreferredClothes.First(x => x.Item1.Equals(row.Cells[i].Value.ToString())).Item2;
                                else
                                    Program.status.Update($"[ERROR] Failed to load {villager.Name} ({villager.Species}{villager.ID}) Preferred Clothes (Row {rowNumber}, Column {i + 1})");
                                break;
                            case 2: // Preferred Style 1
                                if (row.Cells[i].Value != null && PreferredStyle.Any(x => x.Item1.Equals(row.Cells[i].Value.ToString())))
                                    villager.Style = PreferredStyle.First(x => x.Item1.Equals(row.Cells[i].Value.ToString())).Item2;
                                else
                                    Program.status.Update($"[ERROR] Failed to load {villager.Name} ({villager.Species}{villager.ID}) Preferred Style (Row {rowNumber}, Column {i + 1})");
                                break;
                            case 3: // Preferred Style 2
                                if (row.Cells[i].Value != null && PreferredStyle.Any(x => x.Item1.Equals(row.Cells[i].Value.ToString())))
                                    villager.Style2 = PreferredStyle.First(x => x.Item1.Equals(row.Cells[i].Value.ToString())).Item2;
                                else
                                    Program.status.Update($"[ERROR] Failed to load {villager.Name} ({villager.Species}{villager.ID}) Preferred Style 2 (Row {rowNumber}, Column {i + 1})");
                                break;
                            case 4: // Unknown
                                if (row.Cells[i].Value != null && Unknown1.Any(x => x.Item1.Equals(row.Cells[i].Value.ToString())))
                                    villager.Unknown = Unknown1.First(x => x.Item1.Equals(row.Cells[i].Value.ToString())).Item2;
                                else
                                    Program.status.Update($"[ERROR] Failed to load {villager.Name} ({villager.Species}{villager.ID}) Unknown1 (Row {rowNumber}, Column {i + 1})");
                                break;
                            case 5: // Hobby
                                if (row.Cells[i].Value != null && Hobby.Any(x => x.Item1.Equals(row.Cells[i].Value.ToString())))
                                    villager.Hobby = Hobby.First(x => x.Item1.Equals(row.Cells[i].Value.ToString())).Item2;
                                else
                                    Program.status.Update($"[ERROR] Failed to load {villager.Name} ({villager.Species}{villager.ID}) Hobby (Row {rowNumber}, Column {i + 1})"); ;
                                break;
                            case 6: // Personality
                                if (row.Cells[i].Value != null && Personality.Any(x => x.Item1.Equals(row.Cells[i].Value.ToString())))
                                    villager.Personality = Personality.First(x => x.Item1.Equals(row.Cells[i].Value.ToString())).Item2;
                                else
                                    Program.status.Update($"[ERROR] Failed to load {villager.Name} ({villager.Species}{villager.ID}) Personality (Row {rowNumber}, Column {i + 1})");
                                break;
                            case 8: // Social Type
                                if (row.Cells[i].Value != null && SocialType.Any(x => x.Item1.Equals(row.Cells[i].Value.ToString())))
                                    villager.SocialType = SocialType.First(x => x.Item1.Equals(row.Cells[i].Value.ToString())).Item2;
                                else
                                    Program.status.Update($"[ERROR] Failed to load {villager.Name} ({villager.Species}{villager.ID}) Social Type (Row {rowNumber}, Column {i + 1})");
                                break;
                            case 9: // Sing Pause Type
                                if (row.Cells[i].Value != null && SingPauseType.Any(x => x.Item1.Equals(row.Cells[i].Value.ToString())))
                                    villager.SingPauseType = SingPauseType.First(x => x.Item1.Equals(row.Cells[i].Value.ToString())).Item2;
                                else
                                    Program.status.Update($"[ERROR] Failed to load {villager.Name} ({villager.Species}{villager.ID}) Sing Pause Type (Row {rowNumber}, Column {i + 1})");
                                break;
                            case 10: // Sing Rhythm Type
                                if (row.Cells[i].Value != null && SingRhythmType.Any(x => x.Item1.Equals(row.Cells[i].Value.ToString())))
                                    villager.SingRhythmType = SingRhythmType.First(x => x.Item1.Equals(row.Cells[i].Value.ToString())).Item2;
                                else
                                    Program.status.Update($"[ERROR] Failed to load {villager.Name} ({villager.Species}{villager.ID}) Sing Rhythm (Row {rowNumber}, Column {i + 1})");
                                break;
                            case 12: // Photo Item ID
                                if (row.Cells[i].Value != null)
                                    villager.PhotoItemID = Convert.ToInt32(row.Cells[i].Value.ToString());
                                else
                                    Program.status.Update($"[ERROR] Failed to load {villager.Name} ({villager.Species}{villager.ID}) Photo Item ID (Row {rowNumber}, Column {i + 1})");
                                break;
                            case 13: // Floor Type
                                if (row.Cells[i].Value != null)
                                    villager.FloorType = Convert.ToInt32(row.Cells[i].Value.ToString());
                                else
                                    Program.status.Update($"[ERROR] Failed to load {villager.Name} ({villager.Species}{villager.ID}) Floor Type (Row {rowNumber}, Column {i + 1})");
                                break;
                            case 14: // Poster Item ID
                                if (row.Cells[i].Value != null)
                                    villager.PosterItemID = Convert.ToInt32(row.Cells[i].Value.ToString());
                                else
                                    Program.status.Update($"[ERROR] Failed to load {villager.Name} ({villager.Species}{villager.ID}) Poster Item ID (Row {rowNumber}, Column {i + 1})"); ;
                                break;
                            case 15: // Rain Hat
                                if (row.Cells[i].Value != null)
                                    villager.RainHatItemID = Convert.ToInt32(row.Cells[i].Value.ToString());
                                else
                                    Program.status.Update($"[ERROR] Failed to load {villager.Name} ({villager.Species}{villager.ID}) Rain Hat ID (Row {rowNumber}, Column {i + 1})");
                                break;
                            case 16: // Rain Wear
                                if (row.Cells[i].Value != null)
                                    villager.RainWearItemID = Convert.ToInt32(row.Cells[i].Value.ToString());
                                else
                                    Program.status.Update($"[ERROR] Failed to load {villager.Name} ({villager.Species}{villager.ID}) Rain Wear ID (Row {rowNumber}, Column {i + 1})");
                                break;
                            case 18: // Phone Pattern
                                if (row.Cells[i].Value != null)
                                    villager.PhonePattern = Convert.ToInt32(row.Cells[i].Value.ToString());
                                else
                                    Program.status.Update($"[ERROR] Failed to load {villager.Name} ({villager.Species}{villager.ID}) Phone Pattern ID (Row {rowNumber}, Column {i + 1})");
                                break;
                            case 19: // Default Shirt ID
                                if (row.Cells[i].Value != null)
                                    villager.ShirtItemID = Convert.ToInt32(row.Cells[i].Value.ToString());
                                else
                                    Program.status.Update($"[ERROR] Failed to load {villager.Name} ({villager.Species}{villager.ID}) Default Shirt ID (Row {rowNumber}, Column {i + 1})");
                                break;
                            case 20: // Umbrella ID
                                if (row.Cells[i].Value != null)
                                    villager.UmbrellaItemID = Convert.ToInt32(row.Cells[i].Value.ToString());
                                else
                                    Program.status.Update($"[ERROR] Failed to load {villager.Name} ({villager.Species}{villager.ID}) Umbrella ID (Row {rowNumber}, Column {i + 1})");
                                break;
                            case 23: // Birth Day
                                if (row.Cells[i].Value != null)
                                    villager.BirthDay = Convert.ToInt32(row.Cells[i].Value.ToString());
                                else
                                    Program.status.Update($"[ERROR] Failed to load {villager.Name} ({villager.Species}{villager.ID}) Birth Day (Row {rowNumber}, Column {i + 1})");
                                break;
                            case 24: // Birth Month
                                if (row.Cells[i].Value != null)
                                    villager.BirthMonth = Convert.ToInt32(row.Cells[i].Value.ToString());
                                else
                                    Program.status.Update($"[ERROR] Failed to load {villager.Name} ({villager.Species}{villager.ID}) Birth Month (Row {rowNumber}, Column {i + 1})");
                                break;
                            case 25: // Fave Color
                                if (row.Cells[i].Value != null && Color.Any(x => x.Item1.Equals(row.Cells[i].Value.ToString())))
                                    villager.FaveColor = Color.First(x => x.Item1.Equals(row.Cells[i].Value.ToString())).Item2;
                                else
                                    Program.status.Update($"[ERROR] Failed to load {villager.Name} ({villager.Species}{villager.ID}) Fave Color (Row {rowNumber}, Column {i + 1})");
                                break;
                            case 26: // Fave Color 2
                                if (row.Cells[i].Value != null && Color.Any(x => x.Item1.Equals(row.Cells[i].Value.ToString())))
                                    villager.FaveColor2 = Color.First(x => x.Item1.Equals(row.Cells[i].Value.ToString())).Item2;
                                else
                                    Program.status.Update($"[ERROR] Failed to load {villager.Name} ({villager.Species}{villager.ID}) Fave Color 2 (Row {rowNumber}, Column {i + 1})");
                                break;
                            case 30: // Remake ID
                                if (row.Cells[i].Value != null)
                                    villager.RemakeID = Convert.ToInt32(row.Cells[i].Value.ToString());
                                else
                                    Program.status.Update($"[ERROR] Failed to load {villager.Name} ({villager.Species}{villager.ID}) Remake ID (Row {rowNumber}, Column {i + 1})");
                                break;
                            case 31: // Species & ID (also used to add name/phrase)
                                if (row.Cells[i].Value != null)
                                {
                                    string name = row.Cells[i].Value.ToString();
                                    if (Regex.IsMatch(name, @"\A\b[0-9a-fA-F]+\b\Z"))
                                        name = Classes.Bcsv.Hex.FromHexToString(name);
                                    name = name.Substring(0, 5);
                                    string species = name.Substring(0, 3);
                                    string id = name.Substring(3, 2);
                                    villager.Species = Species.First(x => x.Item2.StartsWith(species)).Item3.Replace("\0", "");
                                    villager.ID = Convert.ToInt32(id.Replace("\0", ""));
                                    villager.Name = names.First(x => x.Item2.Equals(name)).Item3.Replace("\0", "");
                                    villager.Catchphrase = phrases.First(x => x.Item2.Equals(name)).Item3.Replace("\0", "");
                                }
                                else
                                    Program.status.Update($"[ERROR] Failed to load {villager.Name} ({villager.Species}{villager.ID}) Species and ID (Row {rowNumber}, Column {i + 1})");
                                break;
                            case 32: // NPC Color (index of the array in the NpcColor BYML in the Pack folder)
                                if (row.Cells[i].Value != null)
                                    villager.NPCColor = Convert.ToInt32(row.Cells[i].Value.ToString());
                                else
                                    Program.status.Update($"[ERROR] Failed to load {villager.Name} ({villager.Species}{villager.ID}) NPC Color (Row {rowNumber}, Column {i + 1})");
                                break;
                            case 33: // Talk Type
                                if (row.Cells[i].Value != null && TalkType.Any(x => x.Item1.Equals(row.Cells[i].Value.ToString())))
                                    villager.TalkType = TalkType.First(x => x.Item1.Equals(row.Cells[i].Value.ToString())).Item2;
                                else
                                    Program.status.Update($"[ERROR] Failed to load {villager.Name} ({villager.Species}{villager.ID}) Talk Type (Row {rowNumber}, Column {i + 1})");
                                break;
                            case 37: // Note Length
                                if (row.Cells[i].Value != null)
                                    villager.NoteLength = Convert.ToInt32(row.Cells[i].Value.ToString());
                                else
                                    Program.status.Update($"[ERROR] Failed to load {villager.Name} ({villager.Species}{villager.ID}) Note Length (Row {rowNumber}, Column {i + 1})");
                                break;
                            case 38: // Village Melody
                                if (row.Cells[i].Value != null && VillageMelody.Any(x => x.Item1.Equals(row.Cells[i].Value.ToString())))
                                    villager.VillageMelody = VillageMelody.First(x => x.Item1.Equals(row.Cells[i].Value.ToString())).Item2;
                                else
                                    Program.status.Update($"[ERROR] Failed to load {villager.Name} ({villager.Species}{villager.ID}) Village Melody (Row {rowNumber}, Column {i + 1})");
                                break;
                            case 39: // Village Melody 2
                                if (row.Cells[i].Value != null && VillageMelody2.Any(x => x.Item1.Equals(row.Cells[i].Value.ToString())))
                                    villager.VillageMelody2 = VillageMelody2.First(x => x.Item1.Equals(row.Cells[i].Value.ToString())).Item2;
                                else
                                    Program.status.Update($"[ERROR] Failed to load {villager.Name} ({villager.Species}{villager.ID}) Village Melody 2 (Row {rowNumber}, Column {i + 1})");
                                break;
                            default:
                                break;
                        }
                    }
                    #if DEBUG
                        Program.status.Update($"[DEBUG] Loaded {villager.Name} ({villager.Species}{villager.ID}) data (Row {rowNumber})");
                    #endif
                    List.Add(villager);
                }
            }
            Program.status.Update("[INFO] Finished loading villager data.");

            /*
             *  Get amiibo data from BCSV
             */
            Bcsv.Read(Path.Combine(dir, "Bcsv\\AmiiboData.bcsv"));
            foreach (var villager in List)
            {
                string label = Species.First(x => x.Item3.Equals(villager.Species)).Item2 + villager.ID.ToString("00");
                foreach (DataGridViewRow row in Bcsv.dataGridView1.Rows)
                {
                    if (row.Cells[4].Value != null) 
                    {
                        string name = row.Cells[4].Value.ToString();
                        if (Regex.IsMatch(name, @"\A\b[0-9a-fA-F]+\b\Z"))
                            name = Classes.Bcsv.Hex.FromHexToString(name);
                        name = name.Substring(0, 5);

                        if (name == label)
                        {
                            var amiiboHead = row.Cells[0].Value.ToString().Substring(2);
                            var amiibo = ACNHLab.Amiibos.First(x => x.Item1.ToUpper().StartsWith(amiiboHead));
                            villager.AmiiboSeries = amiibo.Item2;
                            villager.Amiibo = amiibo.Item3 + " (" + amiibo.Item4 + ")";
                        }
                    }
                }   
            }
            Program.status.Update("[INFO] Added amiibo data to villager entries.");

            // TODO: Get room/house data from BYML
        }
        public static void Save()
        {
            string dir = Path.GetDirectoryName(SettingsForm.settings.ProjectPath);

            Program.status.Update("[INFO] Saving villager data to BCSV and MSBT files, please wait...");

            // TODO: Update Race list

            // TODO: Update Villager names
            //List<Tuple<int, string, string>> names = MSBT.Serialize(Path.Combine(dir, "Message\\String_USen\\Npc\\STR_NNpcName.msbt"));
            //Program.status.Update("[INFO] Saved villager names to \"Message\\String_USen\\Npc\\STR_NNpcName.msbt\".");

            // TODO: Update Villager catchphrases
            //List<Tuple<int, string, string>> phrases = MSBT.Serialize(Path.Combine(dir, "Message\\String_USen\\Npc\\STR_NNpcPhrase.msbt"));
            //Program.status.Update("[INFO] Saved villager catchphrases to \"Message\\String_USen\\Npc\\STR_NNpcPhrase.msbt\".");

            /*
             *  Update NPC params in BCSV
             */
            Bcsv.Read(Path.Combine(dir, "Bcsv\\NmlNpcParam.bcsv"));
            //Bcsv.dataGridView1.Rows.Add(Bcsv.dataGridView1.Rows.Count - List.Count());
            int rowNumber = 0;
            foreach (DataGridViewRow row in Bcsv.dataGridView1.Rows)
            {
                if ((string)Bcsv.dataGridView1.Rows[rowNumber].Cells[0].Value != ""
                    && rowNumber < Bcsv.dataGridView1.Rows.Count - 1)
                {
                    VillagerData villager = List[rowNumber];
                    for (int i = 0; i < row.Cells.Count - 1; i++)
                    {
                        switch (i)
                        {
                            case 0: // Preferred Clothes
                                row.Cells[i].Value = PreferredClothes.First(x => x.Item2.Equals(villager.ClothesType)).Item1;
                                break;
                            case 1: // Preferred Clothes 2
                                row.Cells[i].Value = "00000009";
                                break;
                            case 2: // Preferred Style 1
                                row.Cells[i].Value = PreferredStyle.First(x => x.Item2.Equals(villager.Style)).Item1;
                                break;
                            case 3: // Preferred Style 2
                                row.Cells[i].Value = PreferredStyle.First(x => x.Item2.Equals(villager.Style2)).Item1;
                                break;
                            case 4: // Unknown
                                row.Cells[i].Value = Unknown1.First(x => x.Item2.Equals(villager.Unknown)).Item1;
                                break;
                            case 5: // Hobby
                                row.Cells[i].Value = Hobby.First(x => x.Item2.Equals(villager.Hobby)).Item1;
                                break;
                            case 6: // Personality
                                row.Cells[i].Value = Personality.First(x => x.Item2.Equals(villager.Personality)).Item1;
                                break;
                            case 7: // Unknown, always 0
                                row.Cells[i].Value = "00000000";
                                break;
                            case 8: // Social Type
                                row.Cells[i].Value = SocialType.First(x => x.Item2.Equals(villager.SocialType)).Item1;
                                break;
                            case 9: // Sing Pause Type
                                row.Cells[i].Value = SingPauseType.First(x => x.Item2.Equals(villager.SingPauseType)).Item1;
                                break;
                            case 10: // Sing Rhythm Type
                                row.Cells[i].Value = SingRhythmType.First(x => x.Item2.Equals(villager.SingRhythmType)).Item1;
                                break;
                            case 11: // Wall Accent, Always 0
                                row.Cells[i].Value = 0;
                                break;
                            case 12: // Photo Item ID
                                row.Cells[i].Value = villager.PhotoItemID;
                                break;
                            case 13: // Floor Type
                                row.Cells[i].Value = villager.FloorType;
                                break;
                            case 14: // Poster Item ID
                                row.Cells[i].Value = villager.PosterItemID;
                                break;
                            case 15: // Rain Hat
                                row.Cells[i].Value = villager.RainHatItemID;
                                break;
                            case 16: // Rain Wear
                                row.Cells[i].Value = villager.RainWearItemID;
                                break;
                            case 17: //SmartphoneRemakeCommonPattern
                                row.Cells[i].Value = 65535;
                                break;
                            case 18: // Phone Pattern
                                row.Cells[i].Value = villager.PhonePattern;
                                break;
                            case 19: // Default Shirt ID
                                row.Cells[i].Value = villager.ShirtItemID;
                                break;
                            case 20: // Umbrella ID
                                row.Cells[i].Value = villager.UmbrellaItemID;
                                break;
                            case 21: // Incremental Unique ID
                                row.Cells[i].Value = rowNumber;
                                break;
                            case 22: // Wall Type, always 0
                                row.Cells[i].Value = 0;
                                break;
                            case 23: // Birth Day
                                row.Cells[i].Value = villager.BirthDay;
                                break;
                            case 24: // Birth Month
                                row.Cells[i].Value = villager.BirthMonth;
                                break;
                            case 25: // Fave Color
                                row.Cells[i].Value = Color.First(x => x.Item2.Equals(villager.FaveColor)).Item1;
                                break;
                            case 26: // Fave Color 2
                                row.Cells[i].Value = Color.First(x => x.Item2.Equals(villager.FaveColor2)).Item1;
                                break;
                            case 27: // Havok Res Name
                                row.Cells[i].Value = "NpcNmlClothDog";
                                break;
                            case 28: // Helper Bone Res Name
                                row.Cells[i].Value = "NpcNmlHelperBoneDog";
                                break;
                            case 29: // Init Live, always 1
                                row.Cells[i].Value = 1;
                                break;
                            case 30: // Remake ID
                                row.Cells[i].Value = villager.RemakeID;
                                break;
                            case 31: // Species & ID
                                string label = Species.First(x => x.Item3.Equals(villager.Species)).Item2 + villager.ID.ToString("00");
                                /* List<byte> bytes = new List<byte> { 0x00, 0x00, 0x00 };
                                foreach (char c in label.Reverse())
                                    bytes.Add(Convert.ToByte(c));
                                label = BitConverter.ToString(bytes.ToArray()).Replace("-", string.Empty); */
                                row.Cells[i].Value = label;
                                break;
                            case 32: // NPC Color (index of the array in the NpcColor BYML in the Pack folder)
                                row.Cells[i].Value = villager.NPCColor;
                                break;
                            case 33: // Talk Type
                                row.Cells[i].Value = TalkType.First(x => x.Item2.Equals(villager.TalkType)).Item1;
                                break;
                            case 34: // Res Name
                                row.Cells[i].Value = $"NpcNml{Species.First(x => x.Item3.Equals(villager.Species)).Item2.FirstCharToUpper()}{villager.ID.ToString("00")}";
                                break;
                            case 35: // Special ELink, always 0
                                row.Cells[i].Value = 0;
                                break;
                            case 36: // Special SLink, always 0
                                row.Cells[i].Value = 0;
                                break;
                            case 37: // Note Length
                                row.Cells[i].Value = villager.NoteLength;
                                break;
                            case 38: // Village Melody
                                row.Cells[i].Value = VillageMelody.First(x => x.Item2.Equals(villager.VillageMelody)).Item1;
                                break;
                            case 39: // Village Melody 2
                                row.Cells[i].Value = VillageMelody2.First(x => x.Item2.Equals(villager.VillageMelody2)).Item1;
                                break;
                            default:
                                break;
                        }
                    }
                    #if DEBUG
                        Program.status.Update($"[DEBUG] Updated {villager.Name} ({Species.First(x => x.Item3.Equals(villager.Species)).Item2}{villager.ID}) data (Row {rowNumber})");
                    #endif
                }
                rowNumber++;
            }
            Bcsv.Write(Path.Combine(dir, "Bcsv\\NmlNpcParam.bcsv"));
            Program.status.Update("[INFO] Finished saving villager params to \"Bcsv\\NmlNpcParam.bcsv\".");

            // Update NPC Amiibo BCSV
            Bcsv.Read(Path.Combine(dir, "Bcsv\\AmiiboData.bcsv")); 
            foreach (DataGridViewRow row in Bcsv.dataGridView1.Rows)
            {
                if (row.Cells[4].Value != null)
                {
                    // Get species and ID where possible
                    string rowChara = Classes.Bcsv.Hex.FromHexToString(row.Cells[4].Value.ToString()).Replace("\0", "");
                    if (rowChara.Length >= 3)
                    {
                        string species = rowChara.Substring(0, 3);
                        string id = "";
                        if (rowChara.Length == 5)
                            id = rowChara.Substring(3, 2);

                        // Set new string value before saving
                        row.Cells[4].Value = rowChara;
                        
                        // Update amiibo head for each villager found
                        if (rowChara.Length == 5)
                        {
                            // TODO: Support special NPCs?
                            var villagers = List.Where(x => x.ID.Equals(Convert.ToInt32(id)) && x.Species.Equals(Species.First(y => y.Item2.StartsWith(species)).Item3));
                            foreach (var villager in villagers)
                            {
                                Program.status.Update($"[INFO] Updating amiibo for {rowChara}");
                                string amiiboName = villager.Amiibo.Replace(")", "").Replace(" (", "*");
                                string amiiboType = amiiboName.Split('*')[1];
                                amiiboName = amiiboName.Split('*')[0];

                                var amiibo = ACNHLab.Amiibos.First(x => x.Item2.Equals(villager.AmiiboSeries) && x.Item3.Equals(amiiboName) && x.Item4.Equals(amiiboType));
                                string amiiboHead = "00" + amiibo.Item1.Substring(0, 6);
                                row.Cells[0].Value = amiiboHead;
                            }
                        }
                        // TODO: In order to support additional entries, add amiibo head and label to list and add rows after iterating through existing rows
                    }
                    else
                        row.Cells[4].Value = "";

                    // TODO: Support removal of entries (maybe go by which labels have ID numbers but are still hexadecimal?)
                }
            }
            Bcsv.Write(Path.Combine(dir, "Bcsv\\AmiiboData.bcsv"));
            Program.status.Update("[INFO] Finished saving amiibo data to \"Bcsv\\AmiiboData.bcsv\".");

            // TODO: Repack SARCs

            // TODO: Save room/house data to BYML
        }
    }

    public class VillagerData
    {
        public string Name { get; set; } = "";
        public string Species { get; set; } = "";
        public int ID { get; set; } = 0;
        public string TalkType { get; set; } = "Type 1";
        public string Personality { get; set; } = "Boy_normal";
        public string Hobby { get; set; } = "Play";
        public int BirthMonth { get; set; } = 12;
        public int BirthDay { get; set; } = 31;
        public string AmiiboSeries { get; set; } = "";
        public string Amiibo { get; set; } = "";
        public string Catchphrase { get; set; } = "";
        public Interior Interior { get; set; } = new Interior();
        public Exterior Exterior { get; set; } = new Exterior();
        public string ClothesType { get; set; } = "None";
        public string Style { get; set; } = "6";
        public string Style2 { get; set; } = "6";
        public string Unknown { get; set; } = "Normal";
        public string SocialType { get; set; } = "Normal";
        public string SingPauseType { get; set; } = "Tie";
        public string SingRhythmType { get; set; } = "Normal";
        public int PhotoItemID { get; set; } = 6745;
        public int FloorType { get; set; } = 0;
        public int PosterItemID { get; set; } = 10797;
        public int RainHatItemID { get; set; } = 7394;
        public int RainWearItemID { get; set; } = 3170;
        public int PhonePattern { get; set; } = 3;
        public int ShirtItemID { get; set; } = 8205;
        public int UmbrellaItemID { get; set; } = 9955;
        public string FaveColor { get; set; } = "Black";
        public string FaveColor2 { get; set; } = "Red";
        public int RemakeID { get; set; } = 1;
        public int NoteLength { get; set; } = 5;
        public string VillageMelody { get; set; } = "1";
        public string VillageMelody2 { get; set; } = "4";
        public int NPCColor { get; set; } = 72;
    }

    public class Interior
    {
    }

    public class Exterior
    {
    }
}
