namespace ArenaGame.WindowsFormsApp
{
    partial class Form1
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
            this.lbHeader = new System.Windows.Forms.Label();
            this.button_Play = new System.Windows.Forms.Button();
            this.lbChooseHeroTwo = new System.Windows.Forms.Label();
            this.lbChooseHeroOne = new System.Windows.Forms.Label();
            this.comboBoxHeroTwo = new System.Windows.Forms.ComboBox();
            this.comboBoxHeroOne = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // lbHeader
            // 
            this.lbHeader.AutoSize = true;
            this.lbHeader.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lbHeader.Location = new System.Drawing.Point(246, 42);
            this.lbHeader.Name = "lbHeader";
            this.lbHeader.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.lbHeader.Size = new System.Drawing.Size(321, 39);
            this.lbHeader.TabIndex = 0;
            this.lbHeader.Text = "Hello to the Arena!";
            this.lbHeader.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // button_Play
            // 
            this.button_Play.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button_Play.Location = new System.Drawing.Point(291, 313);
            this.button_Play.Name = "button_Play";
            this.button_Play.Size = new System.Drawing.Size(209, 57);
            this.button_Play.TabIndex = 1;
            this.button_Play.Text = "PLAY";
            this.button_Play.UseVisualStyleBackColor = true;
            this.button_Play.Click += new System.EventHandler(this.button_Play_Click);
            // 
            // lbChooseHeroTwo
            // 
            this.lbChooseHeroTwo.AutoSize = true;
            this.lbChooseHeroTwo.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lbChooseHeroTwo.Location = new System.Drawing.Point(523, 136);
            this.lbChooseHeroTwo.Name = "lbChooseHeroTwo";
            this.lbChooseHeroTwo.Size = new System.Drawing.Size(174, 25);
            this.lbChooseHeroTwo.TabIndex = 2;
            this.lbChooseHeroTwo.Text = "Choose hero two";
            // 
            // lbChooseHeroOne
            // 
            this.lbChooseHeroOne.AutoSize = true;
            this.lbChooseHeroOne.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lbChooseHeroOne.Location = new System.Drawing.Point(116, 136);
            this.lbChooseHeroOne.Name = "lbChooseHeroOne";
            this.lbChooseHeroOne.Size = new System.Drawing.Size(177, 25);
            this.lbChooseHeroOne.TabIndex = 3;
            this.lbChooseHeroOne.Text = "Choose hero one";
            // 
            // comboBoxHeroTwo
            // 
            this.comboBoxHeroTwo.FormattingEnabled = true;
            this.comboBoxHeroTwo.Location = new System.Drawing.Point(531, 182);
            this.comboBoxHeroTwo.Name = "comboBoxHeroTwo";
            this.comboBoxHeroTwo.Size = new System.Drawing.Size(166, 21);
            this.comboBoxHeroTwo.TabIndex = 16;
            // 
            // comboBoxHeroOne
            // 
            this.comboBoxHeroOne.FormattingEnabled = true;
            this.comboBoxHeroOne.Location = new System.Drawing.Point(121, 182);
            this.comboBoxHeroOne.Name = "comboBoxHeroOne";
            this.comboBoxHeroOne.Size = new System.Drawing.Size(166, 21);
            this.comboBoxHeroOne.TabIndex = 17;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.comboBoxHeroOne);
            this.Controls.Add(this.comboBoxHeroTwo);
            this.Controls.Add(this.lbChooseHeroOne);
            this.Controls.Add(this.lbChooseHeroTwo);
            this.Controls.Add(this.button_Play);
            this.Controls.Add(this.lbHeader);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbHeader;
        private System.Windows.Forms.Button button_Play;
        private System.Windows.Forms.Label lbChooseHeroTwo;
        private System.Windows.Forms.Label lbChooseHeroOne;
        private System.Windows.Forms.ComboBox comboBoxHeroTwo;
        private System.Windows.Forms.ComboBox comboBoxHeroOne;
    }
}

