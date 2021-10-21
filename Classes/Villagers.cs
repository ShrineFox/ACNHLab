using System;
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
        public static List<Tuple<string, string>> Gender = new List<Tuple<string, string>>()
        {
            new Tuple<string, string>("0","Male"),
            new Tuple<string, string>("1","Female"),
        };
        public static List<Tuple<string, string>> Species = new List<Tuple<string, string>>();

        public static List<VillagerData> List { get; set; } = new List<VillagerData>();
        public static void Load()
        {
            List.Clear();
            string dir = Path.GetDirectoryName(SettingsForm.settings.ProjectPath);
            // Decompress SARC
            using (var ms = new MemoryStream(File.ReadAllBytes(Path.Combine(dir, "Message\\String_USen.sarc.zs"))))
            using (var compressionStream = new ZstandardStream(ms, CompressionMode.Decompress))
            using (var temp = new MemoryStream())
            {
                compressionStream.CopyTo(temp);
                byte[] output = temp.ToArray();
                File.WriteAllBytes(Path.Combine(dir, "Message\\String_USen.sarc"), output);
            }
            
            // Decode SARC
            //Yaz0.Decode(Path.Combine(dir, "Message\\String_USen.sarc.zs"), Path.Combine(dir, "Message\\String_USen.sarc"));
            // Unpack SARC
            using (Tools.WaitForFile(Path.Combine(dir, "Message\\String_USen.sarc"), FileMode.Open, FileAccess.ReadWrite, FileShare.None)) { };
            SARC.Extract(Path.Combine(dir, "Message\\String_USen.sarc"), Path.Combine(dir, "Message\\String_USen"), true, true);
            // Serialize species list from MSBT
            var str_Race = new MSBT(Path.Combine(dir, "Message\\String_USen\\STR_Race.msbt"));
            foreach (var section in str_Race.SectionOrder)
            {
                MessageBox.Show(section);
            }
            // Serialize villager names from MSBT

            // Serialize villager data from BCSV
            VillagerData villager = new VillagerData();
            Bcsv.Read(Path.Combine(dir, "Bcsv\\NmlNpcParam.bcsv"));
            foreach (DataGridViewRow row in Bcsv.dataGridView1.Rows)
            {
                for (int i = 0; i < row.Cells.Count - 1; i++)
                {
                    switch (i)
                    {
                        case 5:
                            villager.Hobby = Hobby.First(x => x.Item1.Equals(row.Cells[i].Value.ToString())).Item2;
                            break;
                        case 6:
                            villager.Personality = Personality.First(x => x.Item1.Equals(row.Cells[i].Value.ToString())).Item2;
                            break;
                        case 31:
                            string name = Classes.Bcsv.Hex.FromHexToString(row.Cells[i].Value.ToString()).Substring(0,5);
                            string species = name.Substring(0, 3);
                            string id = name.Substring(3, 2);
                            villager.Species = Species.First(x => x.Item1.Equals(species)).Item2;
                            villager.ID = Convert.ToInt32(id);
                            break;
                        default:
                            break;
                    }
                }
                List.Add(villager);
            }

            // Get room data from SARC extracted BCSV
            // Get catchphrase from SARC extracted BCSV
        }
    }

    public class VillagerData
    {
        public string Name { get; set; } = "";
        public string Species { get; set; } = "";
        public int ID { get; set; } = 0;
        public string Gender { get; set; } = "Male";
        public string Personality { get; set; } = "Normal (Boy)";
        public string Hobby { get; set; } = "Play";
        public int BirthMonth { get; set; } = 12;
        public int BirthDay { get; set; } = 31;
        public string Amiibo { get; set; } = "";
        public string Catchphrase { get; set; } = "";
        public Interior Interior { get; set; } = new Interior();
        public Exterior Exterior { get; set; } = new Exterior();
    }

    public class Species
    {
        //public List<String> List { get; set; } = new List<string>();
    }

    public class Amiibo
    {
        //public List<String> List { get; set; } = new List<string>();
    }

    public class Interior
    {
        public int FloorType { get; set; } = 54; // 0 or 54
    }

    public class Exterior
    {
        public int FloorType { get; set; } = 54; // 0 or 54
    }
}
