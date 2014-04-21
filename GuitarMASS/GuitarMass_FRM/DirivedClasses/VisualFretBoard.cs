using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Base;
using System.Drawing;

namespace GuitarMass_FRM.DirivedClasses
{
    public class VisualFretBoard : FretBoard
    {
        private bool _IsVisable = false;

        private static VisualFretBoard _Instance = null;
        private static readonly object _SyncRoot = new object();

        public int GetStringCount { get { return FretBoardInst.Count; } }

        List<VisualGuitarString> _InnerFretBoard = new List<VisualGuitarString>();        

        public new List<VisualGuitarString> FretBoardInst { get { return _InnerFretBoard; } }
        public new List<string> Tuning { get { return _Tuning; } }

        private VisualFretBoard() : base() { }

        public new static VisualFretBoard Instance
        {
            get
            {
                if(_Instance == null)
                {
                    lock(_SyncRoot)
                    {
                        if(_Instance == null)
                        {
                            _Instance = new VisualFretBoard();
                        }
                    }
                }

                return _Instance;
            }
        }

        public void ConstructBoard(int pStringCount, bool pIsVisual)
        {
            _IsVisable = pIsVisual;
            ConstructStrings(pStringCount);
        }

        protected override void ConstructStrings(int pStringCount)
        {
            _InnerFretBoard.Clear();


            int yDistance = 241;
            int yLocationIncrement = yDistance / pStringCount;

            System.Drawing.Point startLocation = new System.Drawing.Point(0, yLocationIncrement / 2);

            for (int i = 0; i < pStringCount; ++i)
            {
                _InnerFretBoard.Add(new VisualGuitarString(i, _IsVisable, startLocation));
                startLocation.Y += yLocationIncrement +1;
            }            
        }

        public override void UpdateStringIdentitys(List<string> pStringkeys)
        {
            int index = 0;
            _Tuning = pStringkeys;
            foreach (VisualGuitarString gstring in _InnerFretBoard)
            {
                gstring.UpdateFretIdentitys(pStringkeys[index]);
                ++index;
            }

            SetBoardImage();
        }

        public void Draw(Graphics pGraphics)
        {
            foreach(VisualGuitarString gString in _InnerFretBoard)
            {
                gString.Draw(pGraphics);
            }
        }

        public void HideAllNotes()
        {
            foreach (VisualGuitarString gString in _InnerFretBoard)
            {
                gString.HideAllNotes();
            }
        }

        public List<VisualFret> GetAllNotes()
        {
            List<VisualFret> notes = new List<VisualFret>();

            foreach (VisualGuitarString gstring in _InnerFretBoard)
            {
                gstring.GetNotes(ref notes);
            }
            return notes;
        }

        protected override void SetBoardImage()
        {
            List<GuitarString> _Board = new List<GuitarString>();

            foreach (VisualGuitarString gString in _InnerFretBoard)
            {
                _Board.Add(gString.ConvertToGuitarString());
            }

            FretboardImage.Instance.SetImage(_Board);
        }
    }
}
