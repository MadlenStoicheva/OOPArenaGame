namespace ArenaGame.WindowsFormsApp
{
    partial class Form2
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
            this.label1 = new System.Windows.Forms.Label();
            this.button_PlayAgain = new System.Windows.Forms.Button();
            this.listBox_HeroesFight = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(298, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(244, 42);
            this.label1.TabIndex = 1;
            this.label1.Text = "Heroes Fight";
            // 
            // button_PlayAgain
            // 
            this.button_PlayAgain.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button_PlayAgain.Location = new System.Drawing.Point(256, 349);
            this.button_PlayAgain.Name = "button_PlayAgain";
            this.button_PlayAgain.Size = new System.Drawing.Size(325, 45);
            this.button_PlayAgain.TabIndex = 2;
            this.button_PlayAgain.Text = "PLAY AGAIN";
            this.button_PlayAgain.UseVisualStyleBackColor = true;
            this.button_PlayAgain.Click += new System.EventHandler(this.button_PlayAgain_Click);
            // 
            // listBox_HeroesFight
            // 
            this.listBox_HeroesFight.FormattingEnabled = true;
            this.listBox_HeroesFight.Location = new System.Drawing.Point(222, 72);
            this.listBox_HeroesFight.Name = "listBox_HeroesFight";
            this.listBox_HeroesFight.Size = new System.Drawing.Size(385, 251);
            this.listBox_HeroesFight.TabIndex = 3;
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.listBox_HeroesFight);
            this.Controls.Add(this.button_PlayAgain);
            this.Controls.Add(this.label1);
            this.Name = "Form2";
            this.Text = "Form2";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button_PlayAgain;
        private System.Windows.Forms.ListBox listBox_HeroesFight;
    }
}