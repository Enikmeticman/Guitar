namespace GuitarMass_FRM
{
    partial class GuitareMass_FRM
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(GuitareMass_FRM));
            this.tabCtrlMain = new System.Windows.Forms.TabControl();
            this.tabPgChords = new System.Windows.Forms.TabPage();
            this.pnlChords = new System.Windows.Forms.Panel();
            this.gBoxShapes = new System.Windows.Forms.GroupBox();
            this.rbtnShape7 = new System.Windows.Forms.RadioButton();
            this.rbtnShape6 = new System.Windows.Forms.RadioButton();
            this.rbtnShape5 = new System.Windows.Forms.RadioButton();
            this.rbtnShape4 = new System.Windows.Forms.RadioButton();
            this.rbtnShape3 = new System.Windows.Forms.RadioButton();
            this.rbtnShape2 = new System.Windows.Forms.RadioButton();
            this.rbtnShape1 = new System.Windows.Forms.RadioButton();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this._lavel = new System.Windows.Forms.Label();
            this.picBoxScaleKey = new System.Windows.Forms.PictureBox();
            this.btnGenerateScale = new System.Windows.Forms.Button();
            this.gboxChords = new System.Windows.Forms.GroupBox();
            this.rbtnScale = new System.Windows.Forms.RadioButton();
            this.rbtnShowAll = new System.Windows.Forms.RadioButton();
            this.rbtnMinor = new System.Windows.Forms.RadioButton();
            this.rbtnAugmented = new System.Windows.Forms.RadioButton();
            this.rbtnMajor = new System.Windows.Forms.RadioButton();
            this.rbtnDiminished = new System.Windows.Forms.RadioButton();
            this.pnlChordDRawing = new GuitarMass_FRM.DirivedClasses.DoubleBufferPanel();
            this.ttipChord = new System.Windows.Forms.ToolStrip();
            this.toolStripDropDownButton1 = new System.Windows.Forms.ToolStripDropDownButton();
            this.guitarSetupToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.imgLImages = new System.Windows.Forms.ImageList(this.components);
            this.tabCtrlMain.SuspendLayout();
            this.tabPgChords.SuspendLayout();
            this.pnlChords.SuspendLayout();
            this.gBoxShapes.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picBoxScaleKey)).BeginInit();
            this.gboxChords.SuspendLayout();
            this.ttipChord.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabCtrlMain
            // 
            this.tabCtrlMain.Controls.Add(this.tabPgChords);
            this.tabCtrlMain.Controls.Add(this.tabPage2);
            this.tabCtrlMain.Location = new System.Drawing.Point(29, 11);
            this.tabCtrlMain.Margin = new System.Windows.Forms.Padding(2);
            this.tabCtrlMain.Name = "tabCtrlMain";
            this.tabCtrlMain.SelectedIndex = 0;
            this.tabCtrlMain.Size = new System.Drawing.Size(1428, 574);
            this.tabCtrlMain.TabIndex = 0;
            // 
            // tabPgChords
            // 
            this.tabPgChords.Controls.Add(this.pnlChords);
            this.tabPgChords.Controls.Add(this.ttipChord);
            this.tabPgChords.Location = new System.Drawing.Point(4, 22);
            this.tabPgChords.Margin = new System.Windows.Forms.Padding(2);
            this.tabPgChords.Name = "tabPgChords";
            this.tabPgChords.Padding = new System.Windows.Forms.Padding(2);
            this.tabPgChords.Size = new System.Drawing.Size(1420, 548);
            this.tabPgChords.TabIndex = 0;
            this.tabPgChords.Text = "Chords";
            this.tabPgChords.UseVisualStyleBackColor = true;
            // 
            // pnlChords
            // 
            this.pnlChords.BackgroundImage = global::GuitarMass_FRM.Properties.Resources.ChordPannel;
            this.pnlChords.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pnlChords.Controls.Add(this.gBoxShapes);
            this.pnlChords.Controls.Add(this.label5);
            this.pnlChords.Controls.Add(this.label4);
            this.pnlChords.Controls.Add(this.label3);
            this.pnlChords.Controls.Add(this.label2);
            this.pnlChords.Controls.Add(this.label1);
            this.pnlChords.Controls.Add(this._lavel);
            this.pnlChords.Controls.Add(this.picBoxScaleKey);
            this.pnlChords.Controls.Add(this.btnGenerateScale);
            this.pnlChords.Controls.Add(this.gboxChords);
            this.pnlChords.Controls.Add(this.pnlChordDRawing);
            this.pnlChords.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlChords.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pnlChords.Location = new System.Drawing.Point(2, 27);
            this.pnlChords.Margin = new System.Windows.Forms.Padding(2);
            this.pnlChords.Name = "pnlChords";
            this.pnlChords.Size = new System.Drawing.Size(1416, 519);
            this.pnlChords.TabIndex = 12;
            this.pnlChords.Paint += new System.Windows.Forms.PaintEventHandler(this.pnlChords_Paint);
            // 
            // gBoxShapes
            // 
            this.gBoxShapes.Controls.Add(this.rbtnShape7);
            this.gBoxShapes.Controls.Add(this.rbtnShape6);
            this.gBoxShapes.Controls.Add(this.rbtnShape5);
            this.gBoxShapes.Controls.Add(this.rbtnShape4);
            this.gBoxShapes.Controls.Add(this.rbtnShape3);
            this.gBoxShapes.Controls.Add(this.rbtnShape2);
            this.gBoxShapes.Controls.Add(this.rbtnShape1);
            this.gBoxShapes.Enabled = false;
            this.gBoxShapes.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.gBoxShapes.Location = new System.Drawing.Point(421, 367);
            this.gBoxShapes.Name = "gBoxShapes";
            this.gBoxShapes.Size = new System.Drawing.Size(182, 126);
            this.gBoxShapes.TabIndex = 22;
            this.gBoxShapes.TabStop = false;
            this.gBoxShapes.Text = "Shapes";
            // 
            // rbtnShape7
            // 
            this.rbtnShape7.AutoSize = true;
            this.rbtnShape7.Font = new System.Drawing.Font("Microsoft JhengHei", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbtnShape7.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.rbtnShape7.Location = new System.Drawing.Point(92, 77);
            this.rbtnShape7.Name = "rbtnShape7";
            this.rbtnShape7.Size = new System.Drawing.Size(66, 19);
            this.rbtnShape7.TabIndex = 6;
            this.rbtnShape7.TabStop = true;
            this.rbtnShape7.Text = "Shape 7";
            this.rbtnShape7.UseVisualStyleBackColor = true;
            this.rbtnShape7.CheckedChanged += new System.EventHandler(this.rbtnShape7_CheckedChanged_1);
            // 
            // rbtnShape6
            // 
            this.rbtnShape6.AutoSize = true;
            this.rbtnShape6.Font = new System.Drawing.Font("Microsoft JhengHei", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbtnShape6.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.rbtnShape6.Location = new System.Drawing.Point(92, 54);
            this.rbtnShape6.Name = "rbtnShape6";
            this.rbtnShape6.Size = new System.Drawing.Size(66, 19);
            this.rbtnShape6.TabIndex = 5;
            this.rbtnShape6.TabStop = true;
            this.rbtnShape6.Text = "Shape 6";
            this.rbtnShape6.UseVisualStyleBackColor = true;
            this.rbtnShape6.CheckedChanged += new System.EventHandler(this.rbtnShape6_CheckedChanged_1);
            // 
            // rbtnShape5
            // 
            this.rbtnShape5.AutoSize = true;
            this.rbtnShape5.Font = new System.Drawing.Font("Microsoft JhengHei", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbtnShape5.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.rbtnShape5.Location = new System.Drawing.Point(92, 31);
            this.rbtnShape5.Name = "rbtnShape5";
            this.rbtnShape5.Size = new System.Drawing.Size(66, 19);
            this.rbtnShape5.TabIndex = 4;
            this.rbtnShape5.TabStop = true;
            this.rbtnShape5.Text = "Shape 5";
            this.rbtnShape5.UseVisualStyleBackColor = true;
            this.rbtnShape5.CheckedChanged += new System.EventHandler(this.rbtnShape5_CheckedChanged);
            // 
            // rbtnShape4
            // 
            this.rbtnShape4.AutoSize = true;
            this.rbtnShape4.Font = new System.Drawing.Font("Microsoft JhengHei", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbtnShape4.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.rbtnShape4.Location = new System.Drawing.Point(20, 95);
            this.rbtnShape4.Name = "rbtnShape4";
            this.rbtnShape4.Size = new System.Drawing.Size(66, 19);
            this.rbtnShape4.TabIndex = 3;
            this.rbtnShape4.TabStop = true;
            this.rbtnShape4.Text = "Shape 4";
            this.rbtnShape4.UseVisualStyleBackColor = true;
            this.rbtnShape4.CheckedChanged += new System.EventHandler(this.rbtnShape4_CheckedChanged_1);
            // 
            // rbtnShape3
            // 
            this.rbtnShape3.AutoSize = true;
            this.rbtnShape3.Font = new System.Drawing.Font("Microsoft JhengHei", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbtnShape3.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.rbtnShape3.Location = new System.Drawing.Point(20, 72);
            this.rbtnShape3.Name = "rbtnShape3";
            this.rbtnShape3.Size = new System.Drawing.Size(66, 19);
            this.rbtnShape3.TabIndex = 2;
            this.rbtnShape3.TabStop = true;
            this.rbtnShape3.Text = "Shape 3";
            this.rbtnShape3.UseVisualStyleBackColor = true;
            this.rbtnShape3.CheckedChanged += new System.EventHandler(this.rbtnShape3_CheckedChanged_1);
            // 
            // rbtnShape2
            // 
            this.rbtnShape2.AutoSize = true;
            this.rbtnShape2.Font = new System.Drawing.Font("Microsoft JhengHei", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbtnShape2.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.rbtnShape2.Location = new System.Drawing.Point(20, 49);
            this.rbtnShape2.Name = "rbtnShape2";
            this.rbtnShape2.Size = new System.Drawing.Size(66, 19);
            this.rbtnShape2.TabIndex = 1;
            this.rbtnShape2.TabStop = true;
            this.rbtnShape2.Text = "Shape 2";
            this.rbtnShape2.UseVisualStyleBackColor = true;
            this.rbtnShape2.CheckedChanged += new System.EventHandler(this.rbtnShape2_CheckedChanged_1);
            // 
            // rbtnShape1
            // 
            this.rbtnShape1.AutoSize = true;
            this.rbtnShape1.Font = new System.Drawing.Font("Microsoft JhengHei", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbtnShape1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.rbtnShape1.Location = new System.Drawing.Point(20, 26);
            this.rbtnShape1.Name = "rbtnShape1";
            this.rbtnShape1.Size = new System.Drawing.Size(66, 19);
            this.rbtnShape1.TabIndex = 0;
            this.rbtnShape1.TabStop = true;
            this.rbtnShape1.Text = "Shape 1";
            this.rbtnShape1.UseVisualStyleBackColor = true;
            this.rbtnShape1.CheckedChanged += new System.EventHandler(this.rbtnShape1_CheckedChanged_1);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label5.Location = new System.Drawing.Point(1307, 57);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(39, 26);
            this.label5.TabIndex = 21;
            this.label5.Text = "XII";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label4.Location = new System.Drawing.Point(546, 57);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(27, 26);
            this.label4.TabIndex = 20;
            this.label4.Text = "V";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label3.Location = new System.Drawing.Point(975, 57);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(33, 26);
            this.label3.TabIndex = 19;
            this.label3.Text = "IX";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label2.Location = new System.Drawing.Point(750, 57);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(39, 26);
            this.label2.TabIndex = 18;
            this.label2.Text = "VII";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label1.Location = new System.Drawing.Point(328, 57);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(30, 26);
            this.label1.TabIndex = 17;
            this.label1.Text = "III";
            // 
            // _lavel
            // 
            this._lavel.AutoSize = true;
            this._lavel.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this._lavel.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this._lavel.Location = new System.Drawing.Point(113, 47);
            this._lavel.Name = "_lavel";
            this._lavel.Size = new System.Drawing.Size(18, 26);
            this._lavel.TabIndex = 16;
            this._lavel.Text = "I";
            // 
            // picBoxScaleKey
            // 
            this.picBoxScaleKey.Location = new System.Drawing.Point(333, 367);
            this.picBoxScaleKey.Margin = new System.Windows.Forms.Padding(2);
            this.picBoxScaleKey.Name = "picBoxScaleKey";
            this.picBoxScaleKey.Size = new System.Drawing.Size(45, 43);
            this.picBoxScaleKey.TabIndex = 15;
            this.picBoxScaleKey.TabStop = false;
            // 
            // btnGenerateScale
            // 
            this.btnGenerateScale.Enabled = false;
            this.btnGenerateScale.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGenerateScale.Location = new System.Drawing.Point(57, 367);
            this.btnGenerateScale.Margin = new System.Windows.Forms.Padding(2);
            this.btnGenerateScale.Name = "btnGenerateScale";
            this.btnGenerateScale.Size = new System.Drawing.Size(203, 41);
            this.btnGenerateScale.TabIndex = 14;
            this.btnGenerateScale.Text = "Generate Scale";
            this.btnGenerateScale.UseVisualStyleBackColor = true;
            this.btnGenerateScale.Click += new System.EventHandler(this.btnGenerateScale_Click);
            // 
            // gboxChords
            // 
            this.gboxChords.Controls.Add(this.rbtnScale);
            this.gboxChords.Controls.Add(this.rbtnShowAll);
            this.gboxChords.Controls.Add(this.rbtnMinor);
            this.gboxChords.Controls.Add(this.rbtnAugmented);
            this.gboxChords.Controls.Add(this.rbtnMajor);
            this.gboxChords.Controls.Add(this.rbtnDiminished);
            this.gboxChords.Enabled = false;
            this.gboxChords.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.gboxChords.Location = new System.Drawing.Point(57, 414);
            this.gboxChords.Margin = new System.Windows.Forms.Padding(2);
            this.gboxChords.Name = "gboxChords";
            this.gboxChords.Padding = new System.Windows.Forms.Padding(2);
            this.gboxChords.Size = new System.Drawing.Size(324, 79);
            this.gboxChords.TabIndex = 13;
            this.gboxChords.TabStop = false;
            this.gboxChords.Text = "Chords";
            // 
            // rbtnScale
            // 
            this.rbtnScale.AutoSize = true;
            this.rbtnScale.Font = new System.Drawing.Font("Microsoft JhengHei", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbtnScale.Location = new System.Drawing.Point(231, 25);
            this.rbtnScale.Margin = new System.Windows.Forms.Padding(2);
            this.rbtnScale.Name = "rbtnScale";
            this.rbtnScale.Size = new System.Drawing.Size(51, 19);
            this.rbtnScale.TabIndex = 8;
            this.rbtnScale.TabStop = true;
            this.rbtnScale.Text = "Scale";
            this.rbtnScale.UseVisualStyleBackColor = true;
            this.rbtnScale.CheckedChanged += new System.EventHandler(this.rbtnScale_CheckedChanged);
            // 
            // rbtnShowAll
            // 
            this.rbtnShowAll.AutoSize = true;
            this.rbtnShowAll.Font = new System.Drawing.Font("Microsoft JhengHei", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbtnShowAll.Location = new System.Drawing.Point(231, 47);
            this.rbtnShowAll.Margin = new System.Windows.Forms.Padding(2);
            this.rbtnShowAll.Name = "rbtnShowAll";
            this.rbtnShowAll.Size = new System.Drawing.Size(68, 19);
            this.rbtnShowAll.TabIndex = 7;
            this.rbtnShowAll.TabStop = true;
            this.rbtnShowAll.Text = "ShowAll";
            this.rbtnShowAll.UseVisualStyleBackColor = true;
            this.rbtnShowAll.CheckedChanged += new System.EventHandler(this.rbtnShowAll_CheckedChanged);
            // 
            // rbtnMinor
            // 
            this.rbtnMinor.AutoSize = true;
            this.rbtnMinor.Font = new System.Drawing.Font("Microsoft JhengHei", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbtnMinor.Location = new System.Drawing.Point(118, 25);
            this.rbtnMinor.Margin = new System.Windows.Forms.Padding(2);
            this.rbtnMinor.Name = "rbtnMinor";
            this.rbtnMinor.Size = new System.Drawing.Size(57, 19);
            this.rbtnMinor.TabIndex = 4;
            this.rbtnMinor.TabStop = true;
            this.rbtnMinor.Text = "Minor";
            this.rbtnMinor.UseVisualStyleBackColor = true;
            this.rbtnMinor.CheckedChanged += new System.EventHandler(this.rbtnMinor_CheckedChanged);
            // 
            // rbtnAugmented
            // 
            this.rbtnAugmented.AutoSize = true;
            this.rbtnAugmented.Font = new System.Drawing.Font("Microsoft JhengHei", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbtnAugmented.Location = new System.Drawing.Point(118, 47);
            this.rbtnAugmented.Margin = new System.Windows.Forms.Padding(2);
            this.rbtnAugmented.Name = "rbtnAugmented";
            this.rbtnAugmented.Size = new System.Drawing.Size(87, 19);
            this.rbtnAugmented.TabIndex = 6;
            this.rbtnAugmented.TabStop = true;
            this.rbtnAugmented.Text = "Augmented";
            this.rbtnAugmented.UseVisualStyleBackColor = true;
            this.rbtnAugmented.CheckedChanged += new System.EventHandler(this.rbtnAugmented_CheckedChanged);
            // 
            // rbtnMajor
            // 
            this.rbtnMajor.AutoSize = true;
            this.rbtnMajor.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.rbtnMajor.Font = new System.Drawing.Font("Microsoft JhengHei", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbtnMajor.Location = new System.Drawing.Point(18, 29);
            this.rbtnMajor.Margin = new System.Windows.Forms.Padding(2);
            this.rbtnMajor.Name = "rbtnMajor";
            this.rbtnMajor.Size = new System.Drawing.Size(56, 19);
            this.rbtnMajor.TabIndex = 3;
            this.rbtnMajor.TabStop = true;
            this.rbtnMajor.Text = "Major";
            this.rbtnMajor.UseVisualStyleBackColor = true;
            this.rbtnMajor.CheckedChanged += new System.EventHandler(this.rbtnMajor_CheckedChanged);
            // 
            // rbtnDiminished
            // 
            this.rbtnDiminished.AutoSize = true;
            this.rbtnDiminished.Font = new System.Drawing.Font("Microsoft JhengHei", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbtnDiminished.Location = new System.Drawing.Point(18, 51);
            this.rbtnDiminished.Margin = new System.Windows.Forms.Padding(2);
            this.rbtnDiminished.Name = "rbtnDiminished";
            this.rbtnDiminished.Size = new System.Drawing.Size(84, 19);
            this.rbtnDiminished.TabIndex = 5;
            this.rbtnDiminished.TabStop = true;
            this.rbtnDiminished.Text = "Diminished";
            this.rbtnDiminished.UseVisualStyleBackColor = true;
            this.rbtnDiminished.CheckedChanged += new System.EventHandler(this.rbtnDiminished_CheckedChanged);
            // 
            // pnlChordDRawing
            // 
            this.pnlChordDRawing.AllowDrop = true;
            this.pnlChordDRawing.BackgroundImage = global::GuitarMass_FRM.Properties.Resources.FretBoard_nek_;
            this.pnlChordDRawing.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pnlChordDRawing.Location = new System.Drawing.Point(57, 84);
            this.pnlChordDRawing.Margin = new System.Windows.Forms.Padding(2);
            this.pnlChordDRawing.Name = "pnlChordDRawing";
            this.pnlChordDRawing.Size = new System.Drawing.Size(1314, 256);
            this.pnlChordDRawing.TabIndex = 12;
            this.pnlChordDRawing.Paint += new System.Windows.Forms.PaintEventHandler(this.pnlChordDRawing_Paint);
            // 
            // ttipChord
            // 
            this.ttipChord.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripDropDownButton1});
            this.ttipChord.Location = new System.Drawing.Point(2, 2);
            this.ttipChord.Name = "ttipChord";
            this.ttipChord.Size = new System.Drawing.Size(1416, 25);
            this.ttipChord.TabIndex = 9;
            this.ttipChord.Text = "Params";
            // 
            // toolStripDropDownButton1
            // 
            this.toolStripDropDownButton1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripDropDownButton1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.guitarSetupToolStripMenuItem});
            this.toolStripDropDownButton1.Image = global::GuitarMass_FRM.Properties.Resources.GuitareMassIcon;
            this.toolStripDropDownButton1.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripDropDownButton1.Name = "toolStripDropDownButton1";
            this.toolStripDropDownButton1.Size = new System.Drawing.Size(29, 22);
            this.toolStripDropDownButton1.Text = "Setup";
            // 
            // guitarSetupToolStripMenuItem
            // 
            this.guitarSetupToolStripMenuItem.Name = "guitarSetupToolStripMenuItem";
            this.guitarSetupToolStripMenuItem.Size = new System.Drawing.Size(139, 22);
            this.guitarSetupToolStripMenuItem.Text = "Guitar Setup";
            this.guitarSetupToolStripMenuItem.Click += new System.EventHandler(this.guitarSetupToolStripMenuItem_Click);
            // 
            // tabPage2
            // 
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Margin = new System.Windows.Forms.Padding(2);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(2);
            this.tabPage2.Size = new System.Drawing.Size(1420, 548);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "tabPage2";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // imgLImages
            // 
            this.imgLImages.ColorDepth = System.Windows.Forms.ColorDepth.Depth8Bit;
            this.imgLImages.ImageSize = new System.Drawing.Size(16, 16);
            this.imgLImages.TransparentColor = System.Drawing.Color.Transparent;
            // 
            // GuitareMass_FRM
            // 
            this.AllowDrop = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::GuitarMass_FRM.Properties.Resources.ChordPannel;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1491, 617);
            this.Controls.Add(this.tabCtrlMain);
            this.DoubleBuffered = true;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "GuitareMass_FRM";
            this.Text = "GuitareMass";
            this.tabCtrlMain.ResumeLayout(false);
            this.tabPgChords.ResumeLayout(false);
            this.tabPgChords.PerformLayout();
            this.pnlChords.ResumeLayout(false);
            this.pnlChords.PerformLayout();
            this.gBoxShapes.ResumeLayout(false);
            this.gBoxShapes.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picBoxScaleKey)).EndInit();
            this.gboxChords.ResumeLayout(false);
            this.gboxChords.PerformLayout();
            this.ttipChord.ResumeLayout(false);
            this.ttipChord.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabCtrlMain;
        private System.Windows.Forms.TabPage tabPgChords;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Panel pnlChords;
        private System.Windows.Forms.Button btnGenerateScale;
        private System.Windows.Forms.GroupBox gboxChords;
        private System.Windows.Forms.RadioButton rbtnMinor;
        private System.Windows.Forms.RadioButton rbtnAugmented;
        private System.Windows.Forms.RadioButton rbtnMajor;
        private System.Windows.Forms.RadioButton rbtnDiminished;
        private GuitarMass_FRM.DirivedClasses.DoubleBufferPanel pnlChordDRawing;
        private System.Windows.Forms.ToolStrip ttipChord;
        private System.Windows.Forms.ToolStripDropDownButton toolStripDropDownButton1;
        private System.Windows.Forms.ToolStripMenuItem guitarSetupToolStripMenuItem;
        private System.Windows.Forms.ImageList imgLImages;
        private System.Windows.Forms.RadioButton rbtnShowAll;
        private System.Windows.Forms.RadioButton rbtnScale;
        private System.Windows.Forms.PictureBox picBoxScaleKey;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label _lavel;
        private System.Windows.Forms.GroupBox gBoxShapes;
        private System.Windows.Forms.RadioButton rbtnShape7;
        private System.Windows.Forms.RadioButton rbtnShape6;
        private System.Windows.Forms.RadioButton rbtnShape5;
        private System.Windows.Forms.RadioButton rbtnShape4;
        private System.Windows.Forms.RadioButton rbtnShape3;
        private System.Windows.Forms.RadioButton rbtnShape2;
        private System.Windows.Forms.RadioButton rbtnShape1;

    }
}

