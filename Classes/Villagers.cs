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
        public static List<Tuple<string, string>> Species = new List<Tuple<string, string>>();
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
            List<Tuple<string, string>> speciesMSBT = MSBT.Deserialize(Path.Combine(dir, "Message\\String_USen\\STR_Race.msbt"), 12);
            // Remove gender from species list
            foreach (var species in speciesMSBT)
                if (!Species.Any(x => x.Item1.Substring(0, 3).Equals(species.Item1.Substring(0, 3))))
                    Species.Add(new Tuple<string, string>(species.Item1.Substring(0, 3).Replace("\0", ""), species.Item2.Replace("\0", "")));
            Program.status.Update("[INFO] Loaded villager species from \"Message\\String_USen\\STR_Race.msbt\".");
            
            List<Tuple<string, string>> names = MSBT.Deserialize(Path.Combine(dir, "Message\\String_USen\\Npc\\STR_NNpcName.msbt"));
            Program.status.Update("[INFO] Loaded villager names from \"Message\\String_USen\\Npc\\STR_NNpcName.msbt\".");
            
            List<Tuple<string, string>> phrases = MSBT.Deserialize(Path.Combine(dir, "Message\\String_USen\\Npc\\STR_NNpcPhrase.msbt"));
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
                                    villager.Species = Species.First(x => x.Item1.StartsWith(species)).Item2.Replace("\0", "");
                                    villager.ID = Convert.ToInt32(id.Replace("\0", ""));
                                    villager.Name = names.First(x => x.Item1.Equals(name)).Item2.Replace("\0", "");
                                    villager.Catchphrase = phrases.First(x => x.Item1.Equals(name)).Item2.Replace("\0", "");
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
                string label = Species.First(x => x.Item2.Equals(villager.Species)).Item1 + villager.ID.ToString("00");
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

            // Update Race list
            List<Tuple<string, string>> newRaces = new List<Tuple<string, string>>();
            foreach (var race in Species)
            {
                newRaces.Add(new Tuple<string, string>($"{race.Item1}_F", $@"&#xE;2\0&#x4;Ā촃{race.Item2}"));
                newRaces.Add(new Tuple<string, string>($"{race.Item1}_M", $@"&#xE;2\0&#x4;Ā촃{race.Item2}"));
            }
            MSBT.Overwrite(newRaces, "Message\\String_USen\\STR_Race.msbt");
            Program.status.Update("[INFO] Overwrote \"Message\\String_USen\\STR_Race.msbt\".");

            // Update Villager names
            List<Tuple<string, string>> newNames = new List<Tuple<string, string>>();
            foreach (var villager in List)
                newNames.Add(new Tuple<string, string>(Species.First(x => 
                    x.Item2.Equals(villager.Species)).Item1 + villager.ID.ToString("00"),
                    villager.Name));
            MSBT.Overwrite(newNames, "Message\\String_USen\\Npc\\STR_NNpcName.msbt");
            Program.status.Update("[INFO] Overwrote \"Message\\String_USen\\Npc\\STR_NNpcName.msbt\".");

            // Update villager catchphrases
            List<Tuple<string, string>> newPhrases = new List<Tuple<string, string>>();
            foreach (var villager in List)
                newPhrases.Add(new Tuple<string, string>(Species.First(x =>
                    x.Item2.Equals(villager.Species)).Item1 + villager.ID.ToString("00"),
                    villager.Catchphrase));
            MSBT.Overwrite(newPhrases, "Message\\String_USen\\Npc\\STR_NNpcPhrase.msbt");
            Program.status.Update("[INFO] Overwrote \"Message\\String_USen\\Npc\\STR_NNpcPhrase.msbt\".");

            /*
             *  Update NPC params in BCSV
             */
            Bcsv.Read(Path.Combine(dir, "Bcsv\\NmlNpcParam.bcsv"));
            // Clear existing rows
            Bcsv.dataGridView1.Rows.Clear();
            // Create blank rows to fill out for each villager
            Bcsv.dataGridView1.Rows.Add(List.Count() - 1);
            // For each villager's row...
            for (int r = 0; r < List.Count(); r++)
            {
                // Get villager data
                VillagerData villager = List[r];
                // For each cell in row...
                for (int c = 0; c < Bcsv.dataGridView1.Rows[r].Cells.Count; c++)
                {
                    switch (c)
                    {
                        case 0: // Preferred Clothes
                            Bcsv.dataGridView1.Rows[r].Cells[c].Value = PreferredClothes.First(x => x.Item2.Equals(villager.ClothesType)).Item1;
                            break;
                        case 1: // Preferred Clothes 2
                            Bcsv.dataGridView1.Rows[r].Cells[c].Value = "00000009";
                            break;
                        case 2: // Preferred Style 1
                            Bcsv.dataGridView1.Rows[r].Cells[c].Value = PreferredStyle.First(x => x.Item2.Equals(villager.Style)).Item1;
                            break;
                        case 3: // Preferred Style 2
                            Bcsv.dataGridView1.Rows[r].Cells[c].Value = PreferredStyle.First(x => x.Item2.Equals(villager.Style2)).Item1;
                            break;
                        case 4: // Unknown
                            Bcsv.dataGridView1.Rows[r].Cells[c].Value = Unknown1.First(x => x.Item2.Equals(villager.Unknown)).Item1;
                            break;
                        case 5: // Hobby
                            Bcsv.dataGridView1.Rows[r].Cells[c].Value = Hobby.First(x => x.Item2.Equals(villager.Hobby)).Item1;
                            break;
                        case 6: // Personality
                            Bcsv.dataGridView1.Rows[r].Cells[c].Value = Personality.First(x => x.Item2.Equals(villager.Personality)).Item1;
                            break;
                        case 7: // Unknown, always 0
                            Bcsv.dataGridView1.Rows[r].Cells[c].Value = "00000000";
                            break;
                        case 8: // Social Type
                            Bcsv.dataGridView1.Rows[r].Cells[c].Value = SocialType.First(x => x.Item2.Equals(villager.SocialType)).Item1;
                            break;
                        case 9: // Sing Pause Type
                            Bcsv.dataGridView1.Rows[r].Cells[c].Value = SingPauseType.First(x => x.Item2.Equals(villager.SingPauseType)).Item1;
                            break;
                        case 10: // Sing Rhythm Type
                            Bcsv.dataGridView1.Rows[r].Cells[c].Value = SingRhythmType.First(x => x.Item2.Equals(villager.SingRhythmType)).Item1;
                            break;
                        case 11: // Wall Accent, Always 0
                            Bcsv.dataGridView1.Rows[r].Cells[c].Value = 0;
                            break;
                        case 12: // Photo Item ID
                            Bcsv.dataGridView1.Rows[r].Cells[c].Value = villager.PhotoItemID;
                            break;
                        case 13: // Floor Type
                            Bcsv.dataGridView1.Rows[r].Cells[c].Value = villager.FloorType;
                            break;
                        case 14: // Poster Item ID
                            Bcsv.dataGridView1.Rows[r].Cells[c].Value = villager.PosterItemID;
                            break;
                        case 15: // Rain Hat
                            Bcsv.dataGridView1.Rows[r].Cells[c].Value = villager.RainHatItemID;
                            break;
                        case 16: // Rain Wear
                            Bcsv.dataGridView1.Rows[r].Cells[c].Value = villager.RainWearItemID;
                            break;
                        case 17: //SmartphoneRemakeCommonPattern
                            Bcsv.dataGridView1.Rows[r].Cells[c].Value = 65535;
                            break;
                        case 18: // Phone Pattern
                            Bcsv.dataGridView1.Rows[r].Cells[c].Value = villager.PhonePattern;
                            break;
                        case 19: // Default Shirt ID
                            Bcsv.dataGridView1.Rows[r].Cells[c].Value = villager.ShirtItemID;
                            break;
                        case 20: // Umbrella ID
                            Bcsv.dataGridView1.Rows[r].Cells[c].Value = villager.UmbrellaItemID;
                            break;
                        case 21: // Incremental Unique ID
                            Bcsv.dataGridView1.Rows[r].Cells[c].Value = r;
                            break;
                        case 22: // Wall Type, always 0
                            Bcsv.dataGridView1.Rows[r].Cells[c].Value = 0;
                            break;
                        case 23: // Birth Day
                            Bcsv.dataGridView1.Rows[r].Cells[c].Value = villager.BirthDay;
                            break;
                        case 24: // Birth Month
                            Bcsv.dataGridView1.Rows[r].Cells[c].Value = villager.BirthMonth;
                            break;
                        case 25: // Fave Color
                            Bcsv.dataGridView1.Rows[r].Cells[c].Value = Color.First(x => x.Item2.Equals(villager.FaveColor)).Item1;
                            break;
                        case 26: // Fave Color 2
                            Bcsv.dataGridView1.Rows[r].Cells[c].Value = Color.First(x => x.Item2.Equals(villager.FaveColor2)).Item1;
                            break;
                        case 27: // Havok Res Name
                            Bcsv.dataGridView1.Rows[r].Cells[c].Value = "NpcNmlClothDog";
                            break;
                        case 28: // Helper Bone Res Name
                            Bcsv.dataGridView1.Rows[r].Cells[c].Value = "NpcNmlHelperBoneDog";
                            break;
                        case 29: // Init Live, always 1
                            Bcsv.dataGridView1.Rows[r].Cells[c].Value = 1;
                            break;
                        case 30: // Remake ID
                            Bcsv.dataGridView1.Rows[r].Cells[c].Value = villager.RemakeID;
                            break;
                        case 31: // Species & ID
                            string label = Species.First(x => x.Item2.Equals(villager.Species)).Item1 + villager.ID.ToString("00");
                            Bcsv.dataGridView1.Rows[r].Cells[c].Value = label;
                            break;
                        case 32: // NPC Color (index of the array in the NpcColor BYML in the Pack folder)
                            Bcsv.dataGridView1.Rows[r].Cells[c].Value = villager.NPCColor;
                            break;
                        case 33: // Talk Type
                            Bcsv.dataGridView1.Rows[r].Cells[c].Value = TalkType.First(x => x.Item2.Equals(villager.TalkType)).Item1;
                            break;
                        case 34: // Res Name
                            Bcsv.dataGridView1.Rows[r].Cells[c].Value = $"NpcNml{Species.First(x => x.Item2.Equals(villager.Species)).Item1.FirstCharToUpper()}{villager.ID.ToString("00")}";
                            break;
                        case 35: // Special ELink, always 0
                            Bcsv.dataGridView1.Rows[r].Cells[c].Value = 0;
                            break;
                        case 36: // Special SLink, always 0
                            Bcsv.dataGridView1.Rows[r].Cells[c].Value = 0;
                            break;
                        case 37: // Note Length
                            Bcsv.dataGridView1.Rows[r].Cells[c].Value = villager.NoteLength;
                            break;
                        case 38: // Village Melody
                            Bcsv.dataGridView1.Rows[r].Cells[c].Value = VillageMelody.First(x => x.Item2.Equals(villager.VillageMelody)).Item1;
                            break;
                        case 39: // Village Melody 2
                            Bcsv.dataGridView1.Rows[r].Cells[c].Value = VillageMelody2.First(x => x.Item2.Equals(villager.VillageMelody2)).Item1;
                            break;
                        default:
                            break;
                    }
                }
                #if DEBUG
                    Program.status.Update($"[DEBUG] Updated NmlNpcParam data for {villager.Name} ({Species.First(x => x.Item2.Equals(villager.Species)).Item1}{villager.ID})");
                #endif
            }
            Bcsv.Write(Path.Combine(dir, "Bcsv\\NmlNpcParam.bcsv"));
            Program.status.Update("[INFO] Finished saving villager params to \"Bcsv\\NmlNpcParam.bcsv\".");

            // Update NPC Amiibo BCSV
            Bcsv.Read(Path.Combine(dir, "Bcsv\\AmiiboData.bcsv"));
            // Get list of Special NPC Amiibos
            List<Tuple<string, string>> specialNPCAmiibos = new List<Tuple<string, string>>();
            foreach (DataGridViewRow row in Bcsv.dataGridView1.Rows)
            {
                if (row.Cells[4].Value != null)
                {
                    string rowChara = Classes.Bcsv.Hex.FromHexToString(row.Cells[4].Value.ToString()).Replace("\0", "");
                    if (rowChara.Length != 5 && rowChara != "")
                        specialNPCAmiibos.Add(new Tuple<string, string>(rowChara, row.Cells[0].Value.ToString()));
                    // TODO: Use special/regular villager bool column for more accurate results
                }
            }
            // Clear existing rows
            Bcsv.dataGridView1.Rows.Clear();
            // Create blank rows to fill out for each villager
            Bcsv.dataGridView1.Rows.Add(List.Count() + specialNPCAmiibos.Count());
            // For each villager's row...
            for (int r = 0; r < List.Count() + specialNPCAmiibos.Count(); r++)
            {
                // Get special NPC data
                if (r < specialNPCAmiibos.Count())
                {
                    for (int c = 0; c < Bcsv.dataGridView1.Rows[r].Cells.Count; c++)
                    {
                        switch (c)
                        {
                            case 0: // Amiibo head
                                Bcsv.dataGridView1.Rows[r].Cells[c].Value = specialNPCAmiibos[r].Item2;
                                break;
                            case 1: // Incremental ID
                                Bcsv.dataGridView1.Rows[r].Cells[c].Value = r;
                                break;
                            case 2: // Always 0?
                                Bcsv.dataGridView1.Rows[r].Cells[c].Value = "0";
                                break;
                            case 3: // Bool, whether can be spawned at photopia
                                Bcsv.dataGridView1.Rows[r].Cells[c].Value = "1";
                                break;
                            case 4: // Villager Label
                                Bcsv.dataGridView1.Rows[r].Cells[c].Value = specialNPCAmiibos[r].Item1;
                                break;
                            case 5: // 1 for special NPC, 0 for regular
                                Bcsv.dataGridView1.Rows[r].Cells[c].Value = "1";
                                break;
                            case 6: // Bool, whether can be spanwed at campsite
                                Bcsv.dataGridView1.Rows[r].Cells[c].Value = "0";
                                break;
                            case 7: // Always 5
                                Bcsv.dataGridView1.Rows[r].Cells[c].Value = "5";
                                break;
                            case 8: // 0 for figure, 1 for card
                                // TODO: Support figures
                                Bcsv.dataGridView1.Rows[r].Cells[c].Value = "00000000";
                                break;
                        }
                    }
                }
                else
                {
                    // Get villager data
                    VillagerData villager = List[r - specialNPCAmiibos.Count()];
                    // For each cell in row...
                    for (int c = 0; c < Bcsv.dataGridView1.Rows[r].Cells.Count; c++)
                    {
                        switch (c)
                        {
                            case 0: // Amiibo head
                                if (villager.Amiibo != "")
                                {
                                    string amiiboName = villager.Amiibo.Replace(")", "").Replace(" (", "*");
                                    string amiiboType = amiiboName.Split('*')[1];
                                    amiiboName = amiiboName.Split('*')[0];
                                    var amiibo = ACNHLab.Amiibos.First(x => x.Item2.Equals(villager.AmiiboSeries) && x.Item3.Equals(amiiboName) && x.Item4.Equals(amiiboType));
                                    string amiiboHead = "00" + amiibo.Item1.Substring(0, 6);
                                    Bcsv.dataGridView1.Rows[r].Cells[c].Value = amiiboHead;
                                }
                                else
                                    Bcsv.dataGridView1.Rows[r].Cells[c].Value = "00000000";
                                #if DEBUG
                                    Program.status.Update($"[DEBUG] Updating AmiiboData for {villager.Name} ({Species.First(x => x.Item2.Equals(villager.Species)).Item1}{villager.ID})");
                                #endif
                                break;
                            case 1: // Incremental ID
                                Bcsv.dataGridView1.Rows[r].Cells[c].Value = r;
                                break;
                            case 2: // Always 0?
                                Bcsv.dataGridView1.Rows[r].Cells[c].Value = "0";
                                break;
                            case 3: // Bool, whether can be spanwed at photopia
                                Bcsv.dataGridView1.Rows[r].Cells[c].Value = "1";
                                break;
                            case 4: // Villager Label
                                string label = Species.First(x => x.Item2.Equals(villager.Species)).Item1 + villager.ID.ToString("00");
                                Bcsv.dataGridView1.Rows[r].Cells[c].Value = label;
                                break;
                            case 5: // 1 for special NPC, 0 for regular
                                Bcsv.dataGridView1.Rows[r].Cells[c].Value = "0";
                                break;
                            case 6: // Bool, whether can be spanwed at campsite
                                Bcsv.dataGridView1.Rows[r].Cells[c].Value = "1";
                                break;
                            case 7: // Always 5
                                Bcsv.dataGridView1.Rows[r].Cells[c].Value = "5";
                                break;
                            case 8: // 0 for figure, 1 for card
                                // TODO: Support figures
                                Bcsv.dataGridView1.Rows[r].Cells[c].Value = "00000000";
                                break;
                        }
                    }
                }
            }
            Bcsv.Write(Path.Combine(dir, "Bcsv\\AmiiboData.bcsv"));
            Program.status.Update("[INFO] Finished saving amiibo data to \"Bcsv\\AmiiboData.bcsv\".");

            // Repack SARCs
            SARC.Build(Path.Combine(dir, "Message\\String_USen"), Path.Combine(dir, "Message\\String_USen.sarc"));
            Program.status.Update("[INFO] Finished saving data to new \"Message\\String_USen.sarc\".");
            SARC.Compress(Path.Combine(dir, "Message\\String_USen.sarc"), Path.Combine(dir, "Message\\String_USen.sarc.zs"));
            Program.status.Update("[INFO] Finished compressing \"Message\\String_USen.sarc.zs\".");

            // TODO: Save room/house data to BYML
        }
    }

    public class VillagerData
    {
        public string Name { get; set; } = "New Villager";
        public string Species { get; set; } = "anteater";
        public int ID { get; set; } = 20;
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
