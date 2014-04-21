using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Base
{
    public class GuitarString
    {
        protected string _Tuning = string.Empty;
        private List<Fret> _InnerString = new List<Fret>();
        protected int _Index = 0;        

        public string Tuning { get { return _Tuning; } }
        public int Index { get { return _Index; } }
        
        public GuitarString(int pIndex)
        {
            _Index = pIndex;            
            CunstructString(G_Rules.FretCount);
        }

        public virtual void CunstructString(int pNumberOfFrets)
        {
            _InnerString.Clear();
            for (int i = 0; i < pNumberOfFrets; ++i)
            {
                _InnerString.Add(new Fret());
            }
        }

        public virtual void UpdateFretIdentitys(string pTuning)
        {
            _Tuning = pTuning;
            int indexCounter = 0;
            int noteIndex = G_Rules.GetNoteIndex(_Tuning);
            foreach (Fret fret in _InnerString)
            {
                if (noteIndex == G_Rules.TotalIntvals)
                    noteIndex = 0;
                
                fret.Identify(G_Rules.Notes[noteIndex], indexCounter);
                
                ++noteIndex;
                ++indexCounter;
            }
        }

        public Fret GetFretByIndex(int pIndex)
        {
            foreach (Fret note in _InnerString)
            {
                if (note.Index == pIndex)
                    return note;                
            }
            return null;
        }

        public Fret GetFretByName(string pNote)
        {
            foreach (Fret note in _InnerString)
            {
                if (note.Note == pNote)
                    return note;                
            }
            return null;
        }

        public virtual int GetIndexOFNote(string pNote)
        {
           Fret fret = _InnerString.Find(s => 
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

        public virtual List<string> GetRawString()
        {
            List<string> gString = new List<string>();
            
            foreach (Fret note in _InnerString)
            {
                gString.Add(note.Note);
            }

            return gString;
        }
    }
}
