using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;
using System.Reflection;
using System.Windows.Forms;
using System.Drawing;

namespace GuitarMass_FRM
{
    public static class Loader
    {
        public static List<AppImage> LoadImagesFromResources(List<string> pResourceNames)
        {
            Assembly assembly = Assembly.GetExecutingAssembly();
            Stream stream = null;

            List<AppImage> images = new List<AppImage>();

            foreach (string path in pResourceNames)
            {
                stream = assembly.GetManifestResourceStream("GuitarMass_FRM." + "Resources." + path);
                images.Add(new AppImage(path,Image.FromStream(stream)));
            }

            return images;
        }
    }
}
