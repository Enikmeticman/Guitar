using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Base
{
    public class FretBoard
    {
        protected List<string> _Tuning = new List<string>();
        
        private static FretBoard _Instance = null;
        private static readonly object _SyncRoot = new object();

        List<GuitarString> _InnerFretBoard = new List<GuitarString>();
        
        public List<GuitarString> FretBoardInst { get { return _InnerFretBoard; } }
        public List<string> Tuning { get { return _Tuning; } }

        public static FretBoard Instance
        {
            get
            {
                if(_Instance == null)
                {
                    lock(_SyncRoot)
                    {
                        if(_Instance == null)
                        {
                            _Instance = new FretBoard();
                        }
                    }
                }

                return _Instance;
            }
        }

        protected FretBoard() { }

        public virtual void ConstructBoard(int pStringCount)
        {
            ConstructStrings(pStringCount);            
        }

        protected virtual void ConstructStrings(int pStringCount)
        {
            _InnerFretBoard.Clear();

            for(int i = 0 ; i < pStringCount ; ++i)
            {
                _InnerFretBoard.Add(new GuitarString(i));
            }
        }

        public virtual void UpdateStringIdentitys(List<string> pStringkeys)
        {
            int index = 0;
            _Tuning = pStringkeys;
            foreach (GuitarString gstring in _InnerFretBoard)
            {
                gstring.UpdateFretIdentitys(pStringkeys[index]);
                ++index;
            }

            SetBoardImage();
        }

        protected virtual void SetBoardImage()
        {
            FretboardImage.Instance.SetImage(_InnerFretBoard);
        }
    }
}
