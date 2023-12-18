
namespace To_Do_List
{
    partial class HelloPage
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
            this.StartButton = new System.Windows.Forms.Button();
            this.HelloLabel = new System.Windows.Forms.Label();
            this.pictureText = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureText)).BeginInit();
            this.SuspendLayout();
            // 
            // StartButton
            // 
            this.StartButton.BackColor = System.Drawing.Color.SeaShell;
            this.StartButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.StartButton.Font = new System.Drawing.Font("Arial Narrow", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.StartButton.ForeColor = System.Drawing.Color.Maroon;
            this.StartButton.Location = new System.Drawing.Point(273, 245);
            this.StartButton.Name = "StartButton";
            this.StartButton.Size = new System.Drawing.Size(256, 58);
            this.StartButton.TabIndex = 0;
            this.StartButton.Text = "НАЧНИ ПЛАНИРОВАТЬ";
            this.StartButton.UseVisualStyleBackColor = false;
            this.StartButton.Click += new System.EventHandler(this.button1_Click);
            // 
            // HelloLabel
            // 
            this.HelloLabel.Font = new System.Drawing.Font("Arial Black", 72F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.HelloLabel.ForeColor = System.Drawing.Color.Maroon;
            this.HelloLabel.Location = new System.Drawing.Point(2, 67);
            this.HelloLabel.Name = "HelloLabel";
            this.HelloLabel.Size = new System.Drawing.Size(834, 137);
            this.HelloLabel.TabIndex = 1;
            this.HelloLabel.Text = "DAILY TASKS";
            this.HelloLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pictureText
            // 
            this.pictureText.Image = global::To_Do_List.Properties.Resources.text;
            this.pictureText.Location = new System.Drawing.Point(283, 335);
            this.pictureText.Name = "pictureText";
            this.pictureText.Size = new System.Drawing.Size(246, 205);
            this.pictureText.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureText.TabIndex = 2;
            this.pictureText.TabStop = false;
            // 
            // HelloPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.PeachPuff;
            this.ClientSize = new System.Drawing.Size(834, 701);
            this.Controls.Add(this.pictureText);
            this.Controls.Add(this.HelloLabel);
            this.Controls.Add(this.StartButton);
            this.Name = "HelloPage";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Daily Panner";
            ((System.ComponentModel.ISupportInitialize)(this.pictureText)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button StartButton;
        private System.Windows.Forms.Label HelloLabel;
        private System.Windows.Forms.PictureBox pictureText;
    }
}