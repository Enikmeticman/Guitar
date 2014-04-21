namespace GuitarMass_FRM
{
    partial class ScaleGeneration_FRM
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ScaleGeneration_FRM));
            this.cmbboxScaleKey = new System.Windows.Forms.ComboBox();
            this.lblScaleKey = new System.Windows.Forms.Label();
            this.btnGenerate = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // cmbboxScaleKey
            // 
            this.cmbboxScaleKey.FormattingEnabled = true;
            this.cmbboxScaleKey.Items.AddRange(new object[] {
            "A",
            "A#",
            "B",
            "C",
            "C#",
            "D",
            "D#",
            "E",
            "F",
            "F#",
            "G",
            "G#"});
            this.cmbboxScaleKey.Location = new System.Drawing.Point(90, 36);
            this.cmbboxScaleKey.Name = "cmbboxScaleKey";
            this.cmbboxScaleKey.Size = new System.Drawing.Size(121, 24);
            this.cmbboxScaleKey.TabIndex = 0;
            this.cmbboxScaleKey.SelectedIndexChanged += new System.EventHandler(this.cmbboxScaleKey_SelectedIndexChanged);
            // 
            // lblScaleKey
            // 
            this.lblScaleKey.AutoSize = true;
            this.lblScaleKey.Location = new System.Drawing.Point(13, 36);
            this.lblScaleKey.Name = "lblScaleKey";
            this.lblScaleKey.Size = new System.Drawing.Size(71, 17);
            this.lblScaleKey.TabIndex = 1;
            this.lblScaleKey.Text = "Scale Key";
            // 
            // btnGenerate
            // 
            this.btnGenerate.Location = new System.Drawing.Point(90, 83);
            this.btnGenerate.Name = "btnGenerate";
            this.btnGenerate.Size = new System.Drawing.Size(121, 56);
            this.btnGenerate.TabIndex = 2;
            this.btnGenerate.Text = "Generate";
            this.btnGenerate.UseVisualStyleBackColor = true;
            this.btnGenerate.Click += new System.EventHandler(this.btnGenerate_Click);
            // 
            // ScaleGeneration_FRM
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(233, 153);
            this.Controls.Add(this.btnGenerate);
            this.Controls.Add(this.lblScaleKey);
            this.Controls.Add(this.cmbboxScaleKey);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "ScaleGeneration_FRM";
            this.Text = "GuitarMass";
            this.TopMost = true;
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cmbboxScaleKey;
        private System.Windows.Forms.Label lblScaleKey;
        private System.Windows.Forms.Button btnGenerate;
    }
}