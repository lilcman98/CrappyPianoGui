
namespace CrappyPianoGui
{
    partial class CrappyPiano
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CrappyPiano));
            this.soundTypes = new System.Windows.Forms.ComboBox();
            this.soundTypesLabel = new System.Windows.Forms.Label();
            this.reloadKeyboard = new System.Windows.Forms.Button();
            this.gainLabel = new System.Windows.Forms.Label();
            this.gain = new System.Windows.Forms.NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)(this.gain)).BeginInit();
            this.SuspendLayout();
            // 
            // soundTypes
            // 
            this.soundTypes.FormattingEnabled = true;
            this.soundTypes.Items.AddRange(new object[] {
            "Sawtooth",
            "Triangle",
            "Sine",
            "Square"});
            this.soundTypes.Location = new System.Drawing.Point(221, 64);
            this.soundTypes.Name = "soundTypes";
            this.soundTypes.Size = new System.Drawing.Size(121, 28);
            this.soundTypes.TabIndex = 0;
            this.soundTypes.SelectedIndexChanged += new System.EventHandler(this.soundTypes_SelectedIndexChanged);
            // 
            // soundTypesLabel
            // 
            this.soundTypesLabel.AutoSize = true;
            this.soundTypesLabel.Location = new System.Drawing.Point(230, 41);
            this.soundTypesLabel.Name = "soundTypesLabel";
            this.soundTypesLabel.Size = new System.Drawing.Size(102, 20);
            this.soundTypesLabel.TabIndex = 1;
            this.soundTypesLabel.Text = "Sound Types";
            this.soundTypesLabel.Click += new System.EventHandler(this.label1_Click);
            // 
            // reloadKeyboard
            // 
            this.reloadKeyboard.Location = new System.Drawing.Point(12, 130);
            this.reloadKeyboard.Name = "reloadKeyboard";
            this.reloadKeyboard.Size = new System.Drawing.Size(330, 71);
            this.reloadKeyboard.TabIndex = 2;
            this.reloadKeyboard.Text = "Reload Keyboard";
            this.reloadKeyboard.UseVisualStyleBackColor = true;
            this.reloadKeyboard.Click += new System.EventHandler(this.button1_Click);
            // 
            // gainLabel
            // 
            this.gainLabel.AutoSize = true;
            this.gainLabel.Location = new System.Drawing.Point(42, 41);
            this.gainLabel.Name = "gainLabel";
            this.gainLabel.Size = new System.Drawing.Size(43, 20);
            this.gainLabel.TabIndex = 3;
            this.gainLabel.Text = "Gain";
            this.gainLabel.Click += new System.EventHandler(this.label1_Click_1);
            // 
            // gain
            // 
            this.gain.Location = new System.Drawing.Point(12, 64);
            this.gain.Maximum = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.gain.Name = "gain";
            this.gain.Size = new System.Drawing.Size(120, 26);
            this.gain.TabIndex = 4;
            this.gain.Value = new decimal(new int[] {
            3,
            0,
            0,
            0});
            this.gain.ValueChanged += new System.EventHandler(this.numericUpDown1_ValueChanged);
            // 
            // CrappyPiano
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(354, 213);
            this.Controls.Add(this.gain);
            this.Controls.Add(this.gainLabel);
            this.Controls.Add(this.reloadKeyboard);
            this.Controls.Add(this.soundTypesLabel);
            this.Controls.Add(this.soundTypes);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "CrappyPiano";
            this.Text = "CrappyPiano";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gain)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox soundTypes;
        private System.Windows.Forms.Label soundTypesLabel;
        private System.Windows.Forms.Button reloadKeyboard;
        private System.Windows.Forms.Label gainLabel;
        private System.Windows.Forms.NumericUpDown gain;
    }
}

