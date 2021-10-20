using AmicitiaLibrary.Graphics.RenderWare;
using AmicitiaLibrary.Graphics.SPD;
using AmicitiaLibrary.Graphics.SPR;
using AmicitiaLibrary.Graphics.TMX;
using GFDLibrary;
using GFDLibrary.Textures;
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