namespace GuitarMass_FRM
{
    partial class GuitarSetup_FRM
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(GuitarSetup_FRM));
            this.dmUpDowStringCount = new System.Windows.Forms.DomainUpDown();
            this.btnSetup = new System.Windows.Forms.Button();
            this.lbxTunings = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // dmUpDowStringCount
            // 
            this.dmUpDowStringCount.Items.Add("4");
            this.dmUpDowStringCount.Items.Add("5");
            this.dmUpDowStringCount.Items.Add("6");
            this.dmUpDowStringCount.Items.Add("7");
            this.dmUpDowStringCount.Items.Add("8");
            this.dmUpDowStringCount.Location = new System.Drawing.Point(29, 29);
            this.dmUpDowStringCount.Name = "dmUpDowStringCount";
            this.dmUpDowStringCount.Size = new System.Drawing.Size(120, 22);
            this.dmUpDowStringCount.TabIndex = 0;
            this.dmUpDowStringCount.SelectedItemChanged += new System.EventHandler(this.dmUpDowStringCount_SelectedItemChanged);
            // 
            // btnSetup
            // 
            this.btnSetup.Location = new System.Drawing.Point(29, 330);
            this.btnSetup.Name = "btnSetup";
            this.btnSetup.Size = new System.Drawing.Size(120, 50);
            this.btnSetup.TabIndex = 1;
            this.btnSetup.Text = "Setup";
            this.btnSetup.UseVisualStyleBackColor = true;
            this.btnSetup.Click += new System.EventHandler(this.btnSetup_Click);
            // 
            // lbxTunings
            // 
            this.lbxTunings.FormattingEnabled = true;
            this.lbxTunings.ItemHeight = 16;
            this.lbxTunings.Location = new System.Drawing.Point(195, 29);
            this.lbxTunings.Name = "lbxTunings";
            this.lbxTunings.Size = new System.Drawing.Size(166, 308);
            this.lbxTunings.TabIndex = 2;
            this.lbxTunings.SelectedIndexChanged += new System.EventHandler(this.lbxTunings_SelectedIndexChanged);
            // 
            // GuitarSetup_FRM
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(373, 403);
            this.Controls.Add(this.lbxTunings);
            this.Controls.Add(this.btnSetup);
            this.Controls.Add(this.dmUpDowStringCount);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "GuitarSetup_FRM";
            this.Text = "GuitarMass";
            this.TopMost = true;
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DomainUpDown dmUpDowStringCount;
        private System.Windows.Forms.Button btnSetup;
        private System.Windows.Forms.ListBox lbxTunings;

    }
}