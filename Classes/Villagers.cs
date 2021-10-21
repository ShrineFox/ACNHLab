using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ACNHLab.Classes
{
    class Villagers
    {
        public static List<VillagerData> List { get; set; } = new List<VillagerData>();
        public static void Load()
        {
            string dir = Path.GetDirectoryName(SettingsForm.settings.ProjectPath);
            // Serialize villager data from BCSV
            Bcsv.Read(Path.Combine(dir, "Bcsv\\NmlNpcParam.bcsv"));
            // Load name from .msbt
            // Load amiibo ID from .mbst (match to list or add new)
            
            // Load species list from SARC extracted .msbt
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
        public List<String> List { get; set; } = new List<string>();
    }

    public class Amiibo
    {
        public List<String> List { get; set; } = new List<string>();
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
