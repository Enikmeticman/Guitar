using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using GTR_Logic;
using Base;

namespace GuitarMass_FRM
{
    public partial class ScaleGeneration_FRM : Form
    {       

        private string _Key = string.Empty;
        private Button _InvokedByButton = null;
        public EventHandler<ScaleGenerationEventArgs> OnGenerated = null;

        public ScaleGeneration_FRM(Button pInvokedByButton)
        {
            InitializeComponent();
            _InvokedByButton = pInvokedByButton;
            this.FormClosing += Closing;
        }

        private new void Closing(object sender, EventArgs e)
        {
            _InvokedByButton.Enabled = true;
        }

        private void cmbboxScaleKey_SelectedIndexChanged(object sender, EventArgs e)
        {
            ComboBox cbox = sender as ComboBox;
            _Key = cbox.SelectedItem as string;
        }

        private void btnGenerate_Click(object sender, EventArgs e)
        {
            if (_Key != string.Empty)
            {
                if(OnGenerated != null)
                    OnGenerated(this,new ScaleGenerationEventArgs(ScaleGenerator.Generate(_Key)));
                this.Close();
            }
            else
                MessageBox.Show("You need to fill in a key to generate the scale", "Param error", System.Windows.Forms.MessageBoxButtons.OK);  
        }
    }

    public class ScaleGenerationEventArgs : EventArgs
    {
        private ScaleInfo _Scale = null;
        public ScaleInfo Scale { get { return _Scale; } }

        public ScaleGenerationEventArgs(ScaleInfo pScale)
        {
            _Scale = pScale;
        }
    }
}
