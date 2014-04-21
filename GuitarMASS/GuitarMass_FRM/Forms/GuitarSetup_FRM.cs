using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Base;
using GuitarMass_FRM.DirivedClasses;

namespace GuitarMass_FRM
{
    public partial class GuitarSetup_FRM : Form
    {
        List<string> _PrevTuning = new List<string>();
        List<ComboBox> _Strings = new List<ComboBox>();
        Tuning _Tuning = Tuning.None;

        public EventHandler OnSetupCompleted = null;

        public GuitarSetup_FRM()
        {
            InitializeComponent();
            FillinTuning();
            dmUpDowStringCount.SelectedItem = "6";
            lbxTunings.SelectedItem = "Standard";
        }

        private void FillinTuning()
        {
            foreach (string name in  System.Enum.GetNames(typeof(Base.Tuning)))
            {
                if(name != "None")
                    lbxTunings.Items.Add(name);
            }
        }

        private void ClearOldComboBoxes()
        {
            foreach (ComboBox box in _Strings)
            {
                this.Controls.Remove(box);
            }            
            _Strings.Clear();
        }

        private void dmUpDowStringCount_SelectedItemChanged(object sender, EventArgs e)
        {
            SavePrevTuning();
            ClearOldComboBoxes();
            int stringCount = 0;
            int yLocationIncrement = 30;
            System.Drawing.Size comboBoxSize = new System.Drawing.Size(121, 24);
            System.Drawing.Point startLocation = new System.Drawing.Point(29, 69);

            string stringCountStr = dmUpDowStringCount.SelectedItem as string;
            if (Int32.TryParse(stringCountStr, out stringCount))
            {
                for (int i = 0; i < stringCount; ++i)
                {
                    ComboBox temBox = new ComboBox();

                    temBox.FormattingEnabled = true;
                    temBox.Location = startLocation;
                    temBox.Name = "String_" + i;
                    temBox.Size = comboBoxSize;
                    temBox.TabIndex = i + 1;

                    foreach(string note in G_Rules.Notes)
                    {
                        temBox.Items.Add(note);
                    }

                    temBox.SelectedIndex = 1;
                    Controls.Add(temBox);
                    temBox.Show();
                    _Strings.Add(temBox);                    

                    startLocation.Y += yLocationIncrement;
                }

                FillInStrings();
                SetPrevTuning();
            }
        }

        private void SavePrevTuning()
        {
            _PrevTuning.Clear();
            foreach (ComboBox box in _Strings)
            {
                _PrevTuning.Add(box.SelectedItem as string);
            }
        }

        private void SetPrevTuning()
        {
            int index = 0;
            foreach (ComboBox box in _Strings)
            {
                if (_PrevTuning.Count > index)
                    box.SelectedItem = _PrevTuning[index];
                ++index;
            }
        }

        private void lbxTunings_SelectedIndexChanged(object sender, EventArgs e)
        {           

            if(Enum.IsDefined(typeof(Base.Tuning),lbxTunings.SelectedItem as string))
            {
                _Tuning = (Base.Tuning)Enum.Parse(typeof(Base.Tuning), lbxTunings.SelectedItem as string, false);
                FillInStrings();
            }            
        }

        private void FillInStrings()
        {
            List<string> tune = G_Rules.GetTuning(_Tuning);

            int index = 0;
            foreach (ComboBox box in _Strings)
            {
                box.SelectedItem = tune[index];
                ++index;
            }
        }

        private void btnSetup_Click(object sender, EventArgs e)
        {
            if (_Strings.Count > 3 && _Strings.Count < 9)
            {
                List<string> keys = new List<string>();

                foreach (ComboBox box in _Strings)
                {
                    keys.Add(box.SelectedItem as string);
                }

                //keys.Reverse();

                VisualFretBoard.Instance.ConstructBoard(_Strings.Count, true);
                VisualFretBoard.Instance.UpdateStringIdentitys(keys);

                if (OnSetupCompleted != null)
                    OnSetupCompleted(this, new EventArgs());
            }
            else
            {
                MessageBox.Show("Failed to Setup the guitar", "Failed", System.Windows.Forms.MessageBoxButtons.OK);
            }

            Close();
        }
    }
}
