using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Base
{
    public class ScaleInfo
    {
        public string _Key { get; set; }

        List<string> _Scale = new List<string>();
        List<string> _Mayor = new List<string>();
        List<string> _Minor = new List<string>();
        List<string> _Diminished = new List<string>();
        List<string> _Augmented = new List<string>();

        List<List<string>> _ShapeOne = new List<List<string>>();
        List<List<string>> _ShapeTwo = new List<List<string>>();
        List<List<string>> _ShapeThree = new List<List<string>>();
        List<List<string>> _ShapeFour = new List<List<string>>();
        List<List<string>> _ShapeFive = new List<List<string>>();
        List<List<string>> _ShapeSix = new List<List<string>>();
        List<List<string>> _ShapeSeven = new List<List<string>>();

        public List<string> Scale
        { 
            get 
            {
                return _Scale; 
            } 
        }
        public List<string> Mayor { get { return _Mayor; } }
        public List<string> Minor { get { return _Minor; } }
        public List<string> Diminished { get { return _Diminished; } }
        public List<string> Augmented { get { return _Augmented; } }

        public List<List<string>> ShapeOne { get { return _ShapeOne; } }
        public List<List<string>> ShapeTwo { get { return _ShapeTwo; } }
        public List<List<string>> ShapeThree { get { return _ShapeThree; } }
        public List<List<string>> ShapeFour { get { return _ShapeFour; } }
        public List<List<string>> ShapeFive { get { return _ShapeFive; } }
        public List<List<string>> ShapeSix { get { return _ShapeSix; } }
        public List<List<string>> ShapeSeven { get { return _ShapeSeven; } }

        public ScaleInfo(List<string> pScale)
        {
            _Scale = pScale;
            _Key = pScale[0];
            CalculateChords();
            CalculateShapes();
        }

        private void CalculateChords()
        {
            for (int i = 0; i < G_Rules.TotalNotes; ++i)
            {
                if (i == 0)
                {
                    _Mayor.Add(_Scale[i]);
                    _Minor.Add(_Scale[i]);
                    _Diminished.Add(_Scale[i]);
                    _Augmented.Add(_Scale[i]);
                }
                if (i == 2)
                {
                    _Mayor.Add(_Scale[i]);
                    _Minor.Add(G_Rules.FlatNote(_Scale[i]));
                    _Diminished.Add(G_Rules.FlatNote(_Scale[i]));
                    _Augmented.Add(_Scale[i]);
                }
                if (i == 4)
                {
                    _Mayor.Add(_Scale[i]);
                    _Minor.Add(_Scale[i]);
                    _Diminished.Add(G_Rules.FlatNote(_Scale[i]));
                    _Augmented.Add(G_Rules.RaiseNote(_Scale[i]));
                }
            }
        }

        public string GoToNextNote(string pNote)
        {
            int index = GetIndexOfNote(pNote);
            if (index == -1) return string.Empty;

            if (index == _Scale.Count - 1)
                return _Scale[0];
            return _Scale[index + 1];  
        }

        public string GoToPrevNote(string pNote)
        {
            int index = GetIndexOfNote(pNote);
            if (index == -1) return string.Empty;

            if (index == 0)
                return _Scale[_Scale.Count-1];
            return _Scale[index - 1];
        }

        public string GetNotFromIndex(int pIndex)
        {
            if (pIndex < 0 || pIndex > _Scale.Count - 1) return string.Empty;
            return _Scale[pIndex];
        }

        public int GetIndexOfNote(string pNote)
        {
            int index = -1;
            for (int i = 0; i < _Scale.Count; ++i)
            {
                if (Scale[i] == pNote)
                    index = i;
            }

            return index; 
        }


        private void CalculateShapes()
        {            
            if (!FretboardImage.Instance.IsSet) return;

            //Calculate on witch note the shape will end.

            int baseInc = - 1;
            for (int i = 0; i < FretboardImage.Instance.FretBoardImg.Count; ++i)
            {
                for (int j = 0; j < G_Rules.ShapeNotesOnString; ++j)
                {                    
                    if (baseInc == G_Rules.TotalNotes - 1)
                        baseInc = 0;
                    else
                        ++baseInc;
                }
            }

            int scaleIncr = baseInc ;
            
            foreach (GuitarString gString in FretboardImage.Instance.FretBoardImg)
            {
                List<string> shapeString = new List<string>();
                for (int noteOnString = 0; noteOnString < G_Rules.ShapeNotesOnString; ++noteOnString)
                {
                    shapeString.Add(_Scale[scaleIncr]);
                    scaleIncr = GetIndexOfNote(GoToPrevNote(_Scale[scaleIncr]));
                }
                _ShapeOne.Add(shapeString);
            }

            //---------------------------------------------------

            if (baseInc == G_Rules.TotalNotes - 1)
                baseInc = 0;
            else
                baseInc += 1;

            scaleIncr = baseInc;

            foreach (GuitarString gString in FretboardImage.Instance.FretBoardImg)
            {
                List<string> shapeString = new List<string>();
                for (int noteOnString = 0; noteOnString < G_Rules.ShapeNotesOnString; ++noteOnString)
                {
                    shapeString.Add(_Scale[scaleIncr]);
                    scaleIncr = GetIndexOfNote(GoToPrevNote(_Scale[scaleIncr]));
                }
                _ShapeTwo.Add(shapeString);
            }

            //---------------------------------------------------

            if (baseInc == G_Rules.TotalNotes - 1)
                baseInc = 0;
            else
                baseInc += 1;

            scaleIncr = baseInc;

            foreach (GuitarString gString in FretboardImage.Instance.FretBoardImg)
            {
                List<string> shapeString = new List<string>();
                for (int noteOnString = 0; noteOnString < G_Rules.ShapeNotesOnString; ++noteOnString)
                {
                    shapeString.Add(_Scale[scaleIncr]);
                    scaleIncr = GetIndexOfNote(GoToPrevNote(_Scale[scaleIncr]));
                }
                _ShapeThree.Add(shapeString);
            }

            //---------------------------------------------------

            if (baseInc == G_Rules.TotalNotes - 1)
                baseInc = 0;
            else
                baseInc += 1;

            scaleIncr = baseInc;

            foreach (GuitarString gString in FretboardImage.Instance.FretBoardImg)
            {
                List<string> shapeString = new List<string>();
                for (int noteOnString = 0; noteOnString < G_Rules.ShapeNotesOnString; ++noteOnString)
                {
                    shapeString.Add(_Scale[scaleIncr]);
                    scaleIncr = GetIndexOfNote(GoToPrevNote(_Scale[scaleIncr]));
                }
                _ShapeFour.Add(shapeString);
            }

            //---------------------------------------------------

            if (baseInc == G_Rules.TotalNotes - 1)
                baseInc = 0;
            else
                baseInc += 1;

            scaleIncr = baseInc;

            foreach (GuitarString gString in FretboardImage.Instance.FretBoardImg)
            {
                List<string> shapeString = new List<string>();
                for (int noteOnString = 0; noteOnString < G_Rules.ShapeNotesOnString; ++noteOnString)
                {
                    shapeString.Add(_Scale[scaleIncr]);
                    scaleIncr = GetIndexOfNote(GoToPrevNote(_Scale[scaleIncr]));
                }
                _ShapeFive.Add(shapeString);
            }

            //---------------------------------------------------

            if (baseInc == G_Rules.TotalNotes - 1)
                baseInc = 0;
            else
                baseInc += 1;

            scaleIncr = baseInc;

            foreach (GuitarString gString in FretboardImage.Instance.FretBoardImg)
            {
                List<string> shapeString = new List<string>();
                for (int noteOnString = 0; noteOnString < G_Rules.ShapeNotesOnString; ++noteOnString)
                {
                    shapeString.Add(_Scale[scaleIncr]);
                    scaleIncr = GetIndexOfNote(GoToPrevNote(_Scale[scaleIncr]));
                }
                _ShapeSix.Add(shapeString);
            }

            //---------------------------------------------------

            if (baseInc == G_Rules.TotalNotes - 1)
                baseInc = 0;
            else
                baseInc += 1;

            scaleIncr = baseInc;

            foreach (GuitarString gString in FretboardImage.Instance.FretBoardImg)
            {
                List<string> shapeString = new List<string>();
                for (int noteOnString = 0; noteOnString < G_Rules.ShapeNotesOnString; ++noteOnString)
                {
                    shapeString.Add(_Scale[scaleIncr]);
                    scaleIncr = GetIndexOfNote(GoToPrevNote(_Scale[scaleIncr]));
                }
                _ShapeSeven.Add(shapeString);
            }

            //---------------------------------------------------

        }
    }
}
