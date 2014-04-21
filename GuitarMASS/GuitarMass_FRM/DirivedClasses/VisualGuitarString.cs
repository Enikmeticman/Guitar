using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Base;
using System.Drawing;

namespace GuitarMass_FRM.DirivedClasses
{
    public class VisualGuitarString : GuitarString
    {
        Image _StringImage = null;
        Point _Position = new Point(0,0);
        private List<VisualFret> _InnerString = new List<VisualFret>();

        public bool IsDrawable { get; set; }
        public Point Position { get { return _Position; } }

        public VisualGuitarString(int pIndex, bool pIsDrawable,Point pPosition) : base(pIndex)
        {
            _Index = pIndex;
            IsDrawable = pIsDrawable;
            _Position = pPosition;
            CunstructString(G_Rules.FretCount);
            SetImages();
        }

        public override void CunstructString(int pNumberOfFrets)
        {
            _InnerString.Clear();

            int xDistance = 1314;
            int xLocationIncrement = xDistance / pNumberOfFrets;

            System.Drawing.Point startLocation = new System.Drawing.Point(xLocationIncrement / 2, _Position.Y);

            for (int i = 0; i < pNumberOfFrets; ++i)
            {
                _InnerString.Add(new VisualFret(true, startLocation));
                startLocation.X += xLocationIncrement + 1;
            }
        }

        public override void UpdateFretIdentitys(string pTuning)
        {
            _Tuning = pTuning;
            int indexCounter = 0;
            int noteIndex = G_Rules.GetNoteIndex(_Tuning);
            foreach (VisualFret fret in _InnerString)
            {
                if (noteIndex == G_Rules.TotalIntvals)
                    noteIndex = 0;

                fret.Identify(G_Rules.RaiseNote(G_Rules.Notes[noteIndex]), indexCounter);

                ++noteIndex;
                ++indexCounter;
            }
        }

        public void Draw(Graphics pGraphics)
        {
            if (!IsDrawable || _StringImage == null) return;

            pGraphics.DrawImage(_StringImage, _Position);
            foreach (VisualFret fret in _InnerString)
            {  
                fret.Draw(pGraphics);
            }            
        }

        public List<VisualFret> GetNotes()
        {
            return _InnerString;
        }

        public void GetNotes(ref List<VisualFret> pNoteList)
        {
            foreach (VisualFret fret in _InnerString)
            {
                pNoteList.Add(fret);
            }
        }

        private void SetImages()
        {
            Image stringImg = null;
            if (AppData.Instance.GetImageByName("String.png", ref stringImg))
                _StringImage = stringImg;
        }

        public override int GetIndexOFNote(string pNote)
        {
            VisualFret fret = _InnerString.Find(s =>
            {
                if (s.Note == pNote)
                    return true;
                return false;
            }
             );

            if (fret != null)
                return fret.Index;
            return -1;
        }

        public override List<string> GetRawString()
        {
            List<string> gString = new List<string>();

            foreach (VisualFret note in _InnerString)
            {
                gString.Add(note.Note);
            }

            return gString;
        }

        public void HideAllNotes()
        {
            foreach (VisualFret fret in _InnerString)
            {
                fret.IsDrawable = false;
            }
        }

        public VisualFret GetVisualFretByIndex(int pIndex)
        {
            foreach (VisualFret note in _InnerString)
            {
                if(note.Index == pIndex)
                    return note;                
            }
            return null;
        }

        public VisualFret GetVisualFretByName(string pNote)
        {
            foreach (VisualFret note in _InnerString)
            {
                if (note.Note == pNote)
                    return note;                
            }
            return null;
        }

        public GuitarString ConvertToGuitarString()
        {
            GuitarString gString = new GuitarString(_Index);
            gString.CunstructString(_InnerString.Count);
            gString.UpdateFretIdentitys(_Tuning);
            return gString;
        }
    }
}
