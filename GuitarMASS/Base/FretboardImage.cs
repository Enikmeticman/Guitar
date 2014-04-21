using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Base
{
    public class FretboardImage
    {
        private bool _IsSet = false;
        public bool IsSet { get { return _IsSet; } }
        private static FretboardImage _Instance = null;
        private static readonly object _Syncrooth = new object();

        private List<GuitarString> _FretBoard = new List<GuitarString>();
        public List<GuitarString> FretBoardImg { get { return _FretBoard; } }

        public static FretboardImage Instance
        {
            get
            {
                if (_Instance == null)
                {
                    lock (_Syncrooth)
                    {
                        if (_Instance == null)
                        {
                            _Instance = new FretboardImage();
                        }
                    }                    
                }
                return _Instance;
            }
        }

        private FretboardImage() { }

        public void SetImage(List<GuitarString> pFretBoardImage)
        {
            _FretBoard = pFretBoardImage;
            _IsSet = true;
        }
    }
}
