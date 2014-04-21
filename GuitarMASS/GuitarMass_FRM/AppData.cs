using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Base;
using System.Drawing;
using GuitarMass_FRM.DirivedClasses;

namespace GuitarMass_FRM
{
    public class AppImage
    {
        public readonly string Name = string .Empty;
        public readonly Image Image = null;

        public AppImage(string pName, Image pImage)
        {
            Name = pName;
            Image = pImage;
        }        
    }

    public class AppData
    {
        private static readonly object _SyncRoot = new object();
        private static AppData _Instance = null;

        public bool IsScaleCreated { get; set; }

        ScaleInfo _MainScale = null;
        public ScaleInfo MainScale { get { return _MainScale; } }
        public void SetMainScale(ScaleInfo pMainScale)
        {
            _MainScale = pMainScale;
            IsScaleCreated = true;
        }

        List<AppImage> _ResourceImages = new List<AppImage>();
        List<AppImage> ResourceImages { get { return _ResourceImages; } }
        public void SetImages(List<AppImage> pImages)
        {
            _ResourceImages = pImages;
        }
        public bool GetImageByName(string pName, ref Image pImage)
        {
            foreach (AppImage image in _ResourceImages)
            { 
                if(image.Name == pName)
                {
                    pImage = image.Image; 
                    return true;
                }
            }
            return false;
        }

        private DoubleBufferPanel _ChordPanel = null;
        public DoubleBufferPanel ChordPanel { get { return _ChordPanel; } }
        public void SetChordPanel(DoubleBufferPanel pPanel)
        {
            _ChordPanel = pPanel;
        }
        public void  InvalidateChordPanel()
        {
            _ChordPanel.Invalidate();
        }    

        private AppData()
        {
            IsScaleCreated = false;
        }

        public static AppData Instance 
        {
            get
            {
                if(_Instance == null)
                {
                    lock(_SyncRoot)
                    {
                        if(_Instance == null)
                        {
                            _Instance = new AppData();
                        }
                    }
                }
                return _Instance;
            }            
        }
    }
}
