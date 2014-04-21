using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using GuitarMass_FRM.DirivedClasses;
using Base;

namespace GuitarMass_FRM
{
    public partial class GuitareMass_FRM : Form
    {
        DynamicControls _DynamicControls = new DynamicControls();

        public GuitareMass_FRM()
        {           
            InitializeComponent();
            Processor.Instace._MainForm = this;
            
            AppData.Instance.SetImages(Loader.LoadImagesFromResources(Deffines.ImageResourceNames));
            AppData.Instance.SetChordPanel(pnlChordDRawing);
        }

        #region Callbacks
        private void btnGenerateScale_Click(object sender, EventArgs e)
        {
            Processor.Instace.CalculateNewScale(btnGenerateScale);
            btnGenerateScale.Enabled = false;
        }

        private void guitarSetupToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Processor.Instace.SetUpGuitar();
        }

        #region RadioButtons
        private void rbtnMajor_CheckedChanged(object sender, EventArgs e)
        {
            if (!AppData.Instance.IsScaleCreated) return;
            Processor.Instace.OnlyShowInChord(AppData.Instance.MainScale.Mayor);
            
            AppData.Instance.InvalidateChordPanel();
        }

        private void rbtnMinor_CheckedChanged(object sender, EventArgs e)
        {
            if (!AppData.Instance.IsScaleCreated) return;
            Processor.Instace.OnlyShowInChord(AppData.Instance.MainScale.Minor);

            AppData.Instance.InvalidateChordPanel();
        }

        private void rbtnDiminished_CheckedChanged(object sender, EventArgs e)
        {
            if (!AppData.Instance.IsScaleCreated) return;
            Processor.Instace.OnlyShowInChord(AppData.Instance.MainScale.Diminished);

            AppData.Instance.InvalidateChordPanel();
        }

        private void rbtnAugmented_CheckedChanged(object sender, EventArgs e)
        {
            if (!AppData.Instance.IsScaleCreated) return;
            Processor.Instace.OnlyShowInChord(AppData.Instance.MainScale.Augmented);

            AppData.Instance.InvalidateChordPanel();
        }

        private void rbtnShowAll_CheckedChanged(object sender, EventArgs e)
        {
            if (!AppData.Instance.IsScaleCreated) return;
            Processor.Instace.ShowAllNotes();

            AppData.Instance.InvalidateChordPanel();
        }

        private void rbtnScale_CheckedChanged(object sender, EventArgs e)
        {
            if (!AppData.Instance.IsScaleCreated) return;
            Processor.Instace.OnlyShowInScale(AppData.Instance.MainScale.Scale);

            AppData.Instance.InvalidateChordPanel();
        }

        private void rbtnShape1_CheckedChanged_1(object sender, EventArgs e)
        {
            if (!AppData.Instance.IsScaleCreated) return;
            Processor.Instace.ShowShape(G_Rules.Shapes.One);

            AppData.Instance.InvalidateChordPanel();
        }

        private void rbtnShape2_CheckedChanged_1(object sender, EventArgs e)
        {
            if (!AppData.Instance.IsScaleCreated) return;
            Processor.Instace.ShowShape(G_Rules.Shapes.Two);

            AppData.Instance.InvalidateChordPanel();
        }

        private void rbtnShape3_CheckedChanged_1(object sender, EventArgs e)
        {
            if (!AppData.Instance.IsScaleCreated) return;
            Processor.Instace.ShowShape(G_Rules.Shapes.Three);

            AppData.Instance.InvalidateChordPanel();
        }

        private void rbtnShape4_CheckedChanged_1(object sender, EventArgs e)
        {
            if (!AppData.Instance.IsScaleCreated) return;
            Processor.Instace.ShowShape(G_Rules.Shapes.Four);

            AppData.Instance.InvalidateChordPanel();
        }


        private void rbtnShape5_CheckedChanged(object sender, EventArgs e)
        {
            if (!AppData.Instance.IsScaleCreated) return;
            Processor.Instace.ShowShape(G_Rules.Shapes.Five);

            AppData.Instance.InvalidateChordPanel();
        }

        private void rbtnShape6_CheckedChanged_1(object sender, EventArgs e)
        {
            if (!AppData.Instance.IsScaleCreated) return;
            Processor.Instace.ShowShape(G_Rules.Shapes.Six);

            AppData.Instance.InvalidateChordPanel();
        }

        private void rbtnShape7_CheckedChanged_1(object sender, EventArgs e)
        {
            if (!AppData.Instance.IsScaleCreated) return;
            Processor.Instace.ShowShape(G_Rules.Shapes.Seven);

            AppData.Instance.InvalidateChordPanel();
        }

       

        #endregion
        #endregion

        void RemoveControls<T>(List<T> pControls, Control.ControlCollection pControl)
        {
            foreach (T control in pControls)
            {
                pControl.Remove(control as Control);
            }            
        }

        public void ResetDisplayScale()
        {
            if (AppData.Instance.IsScaleCreated)
            {
                rbtnShowAll.Checked = true;
                rbtnScale.Checked = true;
            }
        }

        int imageBoxSize = 40;
        public void DisplayStringKeys(List<string> pKeys)
        {

            RemoveControls(_DynamicControls.StringKeys, pnlChords.Controls);

            System.Drawing.Size comboBoxSize = new System.Drawing.Size(imageBoxSize, imageBoxSize);
            System.Drawing.Point startLocation = new System.Drawing.Point(18, 105);

            btnGenerateScale.Enabled = true;

            int yDistance = 256;
            int yLocationIncrement = yDistance / (pKeys.Count) - 2;

            for (int i = 0; i < pKeys.Count; ++i)
            {
                PictureBox pBox = new PictureBox();

                pBox.Text = pKeys[i];
                pBox.Location = new Point(startLocation.X, startLocation.Y - (comboBoxSize.Width/2));
                pBox.Name = "pBoxKey" + i;
                pBox.Size = comboBoxSize;
                pBox.TabIndex = i + 1;

                Image img = null;
                if (AppData.Instance.GetImageByName(pKeys[i] + ".png", ref img))
                    pBox.Image = img;

                pBox.SizeMode = PictureBoxSizeMode.StretchImage;
                pnlChords.Controls.Add(pBox);
                pBox.Show();

                _DynamicControls.StringKeys.Add(pBox);

                startLocation.Y += yLocationIncrement;
            }
        }

        public void DisplayScaleKey(string pScaleKey)
        {
            picBoxScaleKey.SizeMode = PictureBoxSizeMode.StretchImage;

            Image img = null;
            if (AppData.Instance.GetImageByName(pScaleKey + ".png", ref img))
                picBoxScaleKey.Image = img;
        }

        public void EnableScaleControls()
        {
            gboxChords.Enabled = true;
            gBoxShapes.Enabled = true;
        }

        public void DisableScaleControls()
        {
            gboxChords.Enabled = false;
            gBoxShapes.Enabled = false;
        }

        private void pnlChordDRawing_Paint(object sender, PaintEventArgs e)
        {
            VisualFretBoard.Instance.Draw(e.Graphics);            
        }

        private void pnlChords_Paint(object sender, PaintEventArgs e)
        {

        }    
    }
}
