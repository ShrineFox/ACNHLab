using AmicitiaLibrary.Graphics.RenderWare;
using AmicitiaLibrary.Graphics.SPD;
using AmicitiaLibrary.Graphics.SPR;
using AmicitiaLibrary.Graphics.TMX;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Security.Cryptography;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Forms;
using System.Windows.Input;

namespace ACNHLab
{
    public static class Unpacker
    {
        // Files to auto-copy to project when created
        public static void GetFiles()
        {
            foreach (var file in new string[] { 
                "Bcsv\\AmiiboData.bcsv", "Bcsv\\NmlNpcParam.bcsv",
                "Message\\String_USen.sarc.zs", 
                "Pack\\StaticParam.pack" })
            {
                string inputFile = Path.Combine(SettingsForm.settings.ExtractedPath, file);
                string outputFile = Path.Combine(Path.GetDirectoryName(SettingsForm.settings.ProjectPath), file);
                if (File.Exists(outputFile))
                    Program.status.Update($"[INFO] Skipped copying \"{Path.GetFileName(inputFile)}\" to Project, file already exists.");
                else if (File.Exists(inputFile))
                {
                    Directory.CreateDirectory(Path.GetDirectoryName(outputFile));
                    File.Copy(inputFile, outputFile, false);
                    Program.status.Update($"[INFO] Copied \"{Path.GetFileName(inputFile)}\" to Project.");
                }
                else
                    Program.status.Update($"[INFO] Failed to copy \"{Path.GetFileName(inputFile)}\" to Project, file not found.");
            }
        }

        public static void CopyEntireDirectory(DirectoryInfo source, DirectoryInfo target, bool overwiteFiles = true)
        {
            if (!source.Exists) return;
            if (!target.Exists) target.Create();

            Parallel.ForEach(source.GetDirectories(), (sourceChildDirectory) =>
                CopyEntireDirectory(sourceChildDirectory, new DirectoryInfo(Path.Combine(target.FullName, sourceChildDirectory.Name))));

            Parallel.ForEach(source.GetFiles(), sourceFile =>
                sourceFile.CopyTo(Path.Combine(target.FullName, sourceFile.Name), overwiteFiles));
        }

        public static void DeleteDirectory(string path)
        {

            foreach (string directory in Directory.GetDirectories(path))
            {
                DeleteDirectory(directory);
            }
            try
            {
                Directory.Delete(path, true);
            }
            catch (IOException)
            {
                Directory.Delete(path, true);
            }
            catch (UnauthorizedAccessException)
            {
                Directory.Delete(path, true);
            }
        }
    }
}