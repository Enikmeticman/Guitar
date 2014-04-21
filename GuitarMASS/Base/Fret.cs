using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Base
{
    public class Fret
    {
        protected string _Note = string.Empty;
        protected int _Index = 0;        

        public string Note { get { return _Note; } }
        public int Index { get { return _Index; } }

        public bool IsSelected { get; set; }

        public Fret()
        {
            _Note = string.Empty;
            IsSelected = false;
        }

        public virtual void Identify(string pNote, int pIndex)
        {
            _Note = pNote;
            _Index = pIndex;
        }
    }
}
