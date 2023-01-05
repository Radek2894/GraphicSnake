namespace GraphicSnake
{
    partial class NazwaGracza_Form
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
            this.label4 = new System.Windows.Forms.Label();
            this.playButton = new System.Windows.Forms.Button();
            this.nazwa = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Impact", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.Color.Green;
            this.label1.Location = new System.Drawing.Point(141, 108);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(583, 59);
            this.label1.TabIndex = 1;
            this.label1.Text = "Proszę podać nazwę gracza:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Black;
            this.label4.Font = new System.Drawing.Font("Impact", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label4.ForeColor = System.Drawing.Color.Green;
            this.label4.Location = new System.Drawing.Point(161, 249);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(182, 34);
            this.label4.TabIndex = 5;
            this.label4.Text = "Nazwa gracza:";
            // 
            // playButton
            // 
            this.playButton.BackColor = System.Drawing.Color.Green;
            this.playButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.playButton.Location = new System.Drawing.Point(304, 377);
            this.playButton.Name = "playButton";
            this.playButton.Size = new System.Drawing.Size(231, 50);
            this.playButton.TabIndex = 7;
            this.playButton.Text = "Graj";
            this.playButton.UseVisualStyleBackColor = false;
            this.playButton.Click += new System.EventHandler(this.playButton_Click);
            // 
            // nazwa
            // 
            this.nazwa.Location = new System.Drawing.Point(522, 256);
            this.nazwa.Name = "nazwa";
            this.nazwa.Size = new System.Drawing.Size(168, 27);
            this.nazwa.TabIndex = 8;
            this.nazwa.Tag = "nazwa";
            // 
            // NazwaGracza_Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(879, 863);
            this.Controls.Add(this.nazwa);
            this.Controls.Add(this.playButton);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label1);
            this.Name = "NazwaGracza_Form";
            this.Text = "NazwaGracza_Form";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label label1;
        private Label label4;
        private Button playButton;
        private TextBox nazwa;
    }
}