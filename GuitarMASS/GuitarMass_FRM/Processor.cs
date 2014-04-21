using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Base;
using GuitarMass_FRM.DirivedClasses;

namespace GuitarMass_FRM
{
    class Processor
    {
        public GuitareMass_FRM _MainForm {get; set;}

        private static readonly Object _SyncRoot = new Object();
        private static Processor _Instance = null;

        private Processor() 
        {

        }

        public static Processor Instace
        {
            get
            {
                if (_Instance == null)
                {
                    lock (_SyncRoot)
                    {
                        if (_Instance == null)
                        {
                            _Instance = new Processor();
                        }
                    }
                }
                return _Instance;
            }  
        }

        public void CalculateNewScale(System.Windows.Forms.Button pButton)
        {
            ScaleGeneration_FRM scaleGenForm = new ScaleGeneration_FRM(pButton);
            scaleGenForm.Show();
            scaleGenForm.OnGenerated += SetScaleToAppData;
        }

        public void OnlyShowInScale(List<string> pScale)
        {
            List<VisualFret> notes = VisualFretBoard.Instance.GetAllNotes();
            foreach (VisualFret note in notes)
            {
                if (pScale.Contains(note.Note))
                    note.IsDrawable = true;
                else
                    note.IsDrawable = false;
            }
        }

        public void OnlyShowInChord(List<string> pChord)
        {
            List<VisualFret> notes = VisualFretBoard.Instance.GetAllNotes();
            foreach (VisualFret note in notes)
            {
                if (pChord.Contains(note.Note))
                    note.IsDrawable = true;
                else
                    note.IsDrawable = false;
            }
        }

        public void ShowAllNotes()
        {
            List<VisualFret> notes = VisualFretBoard.Instance.GetAllNotes();
            foreach (VisualFret note in notes)
            {
                note.IsDrawable = true;
            }
        }

        public void ShowShape(G_Rules.Shapes pShapeType)
        {
            VisualFretBoard.Instance.HideAllNotes();

            List<List<string>> Shape = null;

            switch(pShapeType)
            {
                case G_Rules.Shapes.One:
                    {
                        Shape = AppData.Instance.MainScale.ShapeOne;
                    }
                    break;
                case G_Rules.Shapes.Two:
                    {
                        Shape = AppData.Instance.MainScale.ShapeTwo;
                    }
                    break;
                case G_Rules.Shapes.Three:
                    {
                        Shape = AppData.Instance.MainScale.ShapeThree;
                    }
                    break;
                case G_Rules.Shapes.Four:
                    {
                        Shape = AppData.Instance.MainScale.ShapeFour;
                    }
                    break;
                case G_Rules.Shapes.Five:
                    {
                        Shape = AppData.Instance.MainScale.ShapeFive;
                    }
                    break;
                case G_Rules.Shapes.Six:
                    {
                        Shape = AppData.Instance.MainScale.ShapeSix;
                    }
                    break;
                case G_Rules.Shapes.Seven:
                    {
                        Shape = AppData.Instance.MainScale.ShapeSeven;
                    }
                    break;
            }

            for (int i = 0; i < Shape.Count; ++i)
            {
                List<string> shapeString = Shape[i];

                VisualGuitarString gString = VisualFretBoard.Instance.FretBoardInst[i];
                foreach (string note in shapeString)
                {
                    gString.GetVisualFretByName(note).IsDrawable = true;
                }               
            }
        }

        public void SetUpGuitar()
        {
            GuitarSetup_FRM guitareSetupForm = new GuitarSetup_FRM();
            guitareSetupForm.Show();
            guitareSetupForm.OnSetupCompleted += GuitarSetupCompleted;
        }

        #region CallBacks
        void SetScaleToAppData(object sender, ScaleGenerationEventArgs e)
        {
            AppData.Instance.SetMainScale(e.Scale);
            _MainForm.EnableScaleControls();
            _MainForm.ResetDisplayScale();
            _MainForm.DisplayScaleKey(e.Scale.Scale[0]);
            AppData.Instance.InvalidateChordPanel();
        }

        void GuitarSetupCompleted(object sender, EventArgs e)
        {
            _MainForm.DisplayStringKeys(VisualFretBoard.Instance.Tuning);            
            _MainForm.ResetDisplayScale();
        }
        # endregion
    }
}
