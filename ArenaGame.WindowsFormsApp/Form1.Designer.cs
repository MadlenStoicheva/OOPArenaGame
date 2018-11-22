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
            this.radioHeroOneKnight = new System.Windows.Forms.RadioButton();
            this.radioHeroOneAssassian = new System.Windows.Forms.RadioButton();
            this.radioHeroOneDwarf = new System.Windows.Forms.RadioButton();
            this.radioHeroOneMonk = new System.Windows.Forms.RadioButton();
            this.radioHeroOneWarrior = new System.Windows.Forms.RadioButton();
            this.radioHeroTwoWarrior = new System.Windows.Forms.RadioButton();
            this.radioHeroTwoMonk = new System.Windows.Forms.RadioButton();
            this.radioHeroTwoDwarf = new System.Windows.Forms.RadioButton();
            this.radioHeroTwoAssassian = new System.Windows.Forms.RadioButton();
            this.radioHeroTwoKnight = new System.Windows.Forms.RadioButton();
            this.groupBoxHeroTwo = new System.Windows.Forms.GroupBox();
            this.groupBoxHeroOne = new System.Windows.Forms.GroupBox();
            this.groupBoxHeroTwo.SuspendLayout();
            this.groupBoxHeroOne.SuspendLayout();
            this.SuspendLayout();
            // 
            // lbHeader
            // 
            this.lbHeader.AutoSize = true;
            this.lbHeader.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lbHeader.Location = new System.Drawing.Point(262, 41);
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
            this.button_Play.Location = new System.Drawing.Point(296, 315);
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
            this.lbChooseHeroTwo.Location = new System.Drawing.Point(542, 114);
            this.lbChooseHeroTwo.Name = "lbChooseHeroTwo";
            this.lbChooseHeroTwo.Size = new System.Drawing.Size(174, 25);
            this.lbChooseHeroTwo.TabIndex = 2;
            this.lbChooseHeroTwo.Text = "Choose hero two";
            // 
            // lbChooseHeroOne
            // 
            this.lbChooseHeroOne.AutoSize = true;
            this.lbChooseHeroOne.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lbChooseHeroOne.Location = new System.Drawing.Point(118, 112);
            this.lbChooseHeroOne.Name = "lbChooseHeroOne";
            this.lbChooseHeroOne.Size = new System.Drawing.Size(177, 25);
            this.lbChooseHeroOne.TabIndex = 3;
            this.lbChooseHeroOne.Text = "Choose hero one";
            // 
            // radioHeroOneKnight
            // 
            this.radioHeroOneKnight.AccessibleName = "Knight";
            this.radioHeroOneKnight.AutoSize = true;
            this.radioHeroOneKnight.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.radioHeroOneKnight.Location = new System.Drawing.Point(32, 19);
            this.radioHeroOneKnight.Name = "radioHeroOneKnight";
            this.radioHeroOneKnight.Size = new System.Drawing.Size(68, 20);
            this.radioHeroOneKnight.TabIndex = 4;
            this.radioHeroOneKnight.TabStop = true;
            this.radioHeroOneKnight.Text = "Knight";
            this.radioHeroOneKnight.UseVisualStyleBackColor = true;
            // 
            // radioHeroOneAssassian
            // 
            this.radioHeroOneAssassian.AccessibleName = "Assassian";
            this.radioHeroOneAssassian.AutoSize = true;
            this.radioHeroOneAssassian.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.radioHeroOneAssassian.Location = new System.Drawing.Point(32, 45);
            this.radioHeroOneAssassian.Name = "radioHeroOneAssassian";
            this.radioHeroOneAssassian.Size = new System.Drawing.Size(98, 20);
            this.radioHeroOneAssassian.TabIndex = 5;
            this.radioHeroOneAssassian.TabStop = true;
            this.radioHeroOneAssassian.Text = "Assassian";
            this.radioHeroOneAssassian.UseVisualStyleBackColor = true;
            // 
            // radioHeroOneDwarf
            // 
            this.radioHeroOneDwarf.AccessibleName = "Dwarf";
            this.radioHeroOneDwarf.AutoSize = true;
            this.radioHeroOneDwarf.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.radioHeroOneDwarf.Location = new System.Drawing.Point(32, 71);
            this.radioHeroOneDwarf.Name = "radioHeroOneDwarf";
            this.radioHeroOneDwarf.Size = new System.Drawing.Size(65, 20);
            this.radioHeroOneDwarf.TabIndex = 6;
            this.radioHeroOneDwarf.TabStop = true;
            this.radioHeroOneDwarf.Text = "Dwarf";
            this.radioHeroOneDwarf.UseVisualStyleBackColor = true;
            // 
            // radioHeroOneMonk
            // 
            this.radioHeroOneMonk.AccessibleName = "Monk";
            this.radioHeroOneMonk.AutoSize = true;
            this.radioHeroOneMonk.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.radioHeroOneMonk.Location = new System.Drawing.Point(32, 97);
            this.radioHeroOneMonk.Name = "radioHeroOneMonk";
            this.radioHeroOneMonk.Size = new System.Drawing.Size(63, 20);
            this.radioHeroOneMonk.TabIndex = 7;
            this.radioHeroOneMonk.TabStop = true;
            this.radioHeroOneMonk.Text = "Monk";
            this.radioHeroOneMonk.UseVisualStyleBackColor = true;
            // 
            // radioHeroOneWarrior
            // 
            this.radioHeroOneWarrior.AccessibleName = "Warrior";
            this.radioHeroOneWarrior.AutoSize = true;
            this.radioHeroOneWarrior.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.radioHeroOneWarrior.Location = new System.Drawing.Point(32, 123);
            this.radioHeroOneWarrior.Name = "radioHeroOneWarrior";
            this.radioHeroOneWarrior.Size = new System.Drawing.Size(77, 20);
            this.radioHeroOneWarrior.TabIndex = 8;
            this.radioHeroOneWarrior.TabStop = true;
            this.radioHeroOneWarrior.Text = "Warrior";
            this.radioHeroOneWarrior.UseVisualStyleBackColor = true;
            // 
            // radioHeroTwoWarrior
            // 
            this.radioHeroTwoWarrior.AccessibleName = "Warrior";
            this.radioHeroTwoWarrior.AutoSize = true;
            this.radioHeroTwoWarrior.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.radioHeroTwoWarrior.Location = new System.Drawing.Point(38, 123);
            this.radioHeroTwoWarrior.Name = "radioHeroTwoWarrior";
            this.radioHeroTwoWarrior.Size = new System.Drawing.Size(77, 20);
            this.radioHeroTwoWarrior.TabIndex = 13;
            this.radioHeroTwoWarrior.TabStop = true;
            this.radioHeroTwoWarrior.Text = "Warrior";
            this.radioHeroTwoWarrior.UseVisualStyleBackColor = true;
            // 
            // radioHeroTwoMonk
            // 
            this.radioHeroTwoMonk.AccessibleName = "Monk";
            this.radioHeroTwoMonk.AutoSize = true;
            this.radioHeroTwoMonk.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.radioHeroTwoMonk.Location = new System.Drawing.Point(38, 97);
            this.radioHeroTwoMonk.Name = "radioHeroTwoMonk";
            this.radioHeroTwoMonk.Size = new System.Drawing.Size(63, 20);
            this.radioHeroTwoMonk.TabIndex = 12;
            this.radioHeroTwoMonk.TabStop = true;
            this.radioHeroTwoMonk.Text = "Monk";
            this.radioHeroTwoMonk.UseVisualStyleBackColor = true;
            // 
            // radioHeroTwoDwarf
            // 
            this.radioHeroTwoDwarf.AccessibleName = "Dwarf";
            this.radioHeroTwoDwarf.AutoSize = true;
            this.radioHeroTwoDwarf.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.radioHeroTwoDwarf.Location = new System.Drawing.Point(38, 71);
            this.radioHeroTwoDwarf.Name = "radioHeroTwoDwarf";
            this.radioHeroTwoDwarf.Size = new System.Drawing.Size(65, 20);
            this.radioHeroTwoDwarf.TabIndex = 11;
            this.radioHeroTwoDwarf.TabStop = true;
            this.radioHeroTwoDwarf.Text = "Dwarf";
            this.radioHeroTwoDwarf.UseVisualStyleBackColor = true;
            // 
            // radioHeroTwoAssassian
            // 
            this.radioHeroTwoAssassian.AccessibleName = "Assassian";
            this.radioHeroTwoAssassian.AutoSize = true;
            this.radioHeroTwoAssassian.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.radioHeroTwoAssassian.Location = new System.Drawing.Point(38, 45);
            this.radioHeroTwoAssassian.Name = "radioHeroTwoAssassian";
            this.radioHeroTwoAssassian.Size = new System.Drawing.Size(98, 20);
            this.radioHeroTwoAssassian.TabIndex = 10;
            this.radioHeroTwoAssassian.TabStop = true;
            this.radioHeroTwoAssassian.Text = "Assassian";
            this.radioHeroTwoAssassian.UseVisualStyleBackColor = true;
            // 
            // radioHeroTwoKnight
            // 
            this.radioHeroTwoKnight.AccessibleName = "Knight";
            this.radioHeroTwoKnight.AutoSize = true;
            this.radioHeroTwoKnight.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.radioHeroTwoKnight.Location = new System.Drawing.Point(38, 19);
            this.radioHeroTwoKnight.Name = "radioHeroTwoKnight";
            this.radioHeroTwoKnight.Size = new System.Drawing.Size(68, 20);
            this.radioHeroTwoKnight.TabIndex = 9;
            this.radioHeroTwoKnight.TabStop = true;
            this.radioHeroTwoKnight.Text = "Knight";
            this.radioHeroTwoKnight.UseVisualStyleBackColor = true;
            // 
            // groupBoxHeroTwo
            // 
            this.groupBoxHeroTwo.Controls.Add(this.radioHeroTwoWarrior);
            this.groupBoxHeroTwo.Controls.Add(this.radioHeroTwoMonk);
            this.groupBoxHeroTwo.Controls.Add(this.radioHeroTwoDwarf);
            this.groupBoxHeroTwo.Controls.Add(this.radioHeroTwoAssassian);
            this.groupBoxHeroTwo.Controls.Add(this.radioHeroTwoKnight);
            this.groupBoxHeroTwo.Location = new System.Drawing.Point(547, 142);
            this.groupBoxHeroTwo.Name = "groupBoxHeroTwo";
            this.groupBoxHeroTwo.Size = new System.Drawing.Size(153, 167);
            this.groupBoxHeroTwo.TabIndex = 14;
            this.groupBoxHeroTwo.TabStop = false;
            this.groupBoxHeroTwo.Text = "Hero Two";
            // 
            // groupBoxHeroOne
            // 
            this.groupBoxHeroOne.Controls.Add(this.radioHeroOneWarrior);
            this.groupBoxHeroOne.Controls.Add(this.radioHeroOneMonk);
            this.groupBoxHeroOne.Controls.Add(this.radioHeroOneDwarf);
            this.groupBoxHeroOne.Controls.Add(this.radioHeroOneAssassian);
            this.groupBoxHeroOne.Controls.Add(this.radioHeroOneKnight);
            this.groupBoxHeroOne.Location = new System.Drawing.Point(123, 142);
            this.groupBoxHeroOne.Name = "groupBoxHeroOne";
            this.groupBoxHeroOne.Size = new System.Drawing.Size(146, 166);
            this.groupBoxHeroOne.TabIndex = 15;
            this.groupBoxHeroOne.TabStop = false;
            this.groupBoxHeroOne.Text = "Hero One";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.groupBoxHeroOne);
            this.Controls.Add(this.groupBoxHeroTwo);
            this.Controls.Add(this.lbChooseHeroOne);
            this.Controls.Add(this.lbChooseHeroTwo);
            this.Controls.Add(this.button_Play);
            this.Controls.Add(this.lbHeader);
            this.Name = "Form1";
            this.Text = "Form1";
            this.groupBoxHeroTwo.ResumeLayout(false);
            this.groupBoxHeroTwo.PerformLayout();
            this.groupBoxHeroOne.ResumeLayout(false);
            this.groupBoxHeroOne.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbHeader;
        private System.Windows.Forms.Button button_Play;
        private System.Windows.Forms.Label lbChooseHeroTwo;
        private System.Windows.Forms.Label lbChooseHeroOne;
        private System.Windows.Forms.RadioButton radioHeroOneKnight;
        private System.Windows.Forms.RadioButton radioHeroOneAssassian;
        private System.Windows.Forms.RadioButton radioHeroOneDwarf;
        private System.Windows.Forms.RadioButton radioHeroOneMonk;
        private System.Windows.Forms.RadioButton radioHeroOneWarrior;
        private System.Windows.Forms.RadioButton radioHeroTwoWarrior;
        private System.Windows.Forms.RadioButton radioHeroTwoMonk;
        private System.Windows.Forms.RadioButton radioHeroTwoDwarf;
        private System.Windows.Forms.RadioButton radioHeroTwoAssassian;
        private System.Windows.Forms.RadioButton radioHeroTwoKnight;
        private System.Windows.Forms.GroupBox groupBoxHeroTwo;
        private System.Windows.Forms.GroupBox groupBoxHeroOne;
    }
}

