namespace GraphicSnake
{
    partial class Ustawienia_Form
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
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.snakeColor = new System.Windows.Forms.ComboBox();
            this.poziomTrudnosci = new System.Windows.Forms.ComboBox();
            this.volume = new System.Windows.Forms.TrackBar();
            this.saveButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.volume)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Impact", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.Color.Green;
            this.label1.Location = new System.Drawing.Point(169, 223);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(149, 34);
            this.label1.TabIndex = 0;
            this.label1.Text = "Kolor węża:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Impact", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label2.ForeColor = System.Drawing.Color.Green;
            this.label2.Location = new System.Drawing.Point(146, 319);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(228, 34);
            this.label2.TabIndex = 1;
            this.label2.Text = "Poziom trudności:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Impact", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label3.ForeColor = System.Drawing.Color.Green;
            this.label3.Location = new System.Drawing.Point(186, 402);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(132, 34);
            this.label3.TabIndex = 2;
            this.label3.Text = "Głośność:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Impact", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label4.ForeColor = System.Drawing.Color.Green;
            this.label4.Location = new System.Drawing.Point(277, 101);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(251, 59);
            this.label4.TabIndex = 3;
            this.label4.Text = "Ustawienia";
            // 
            // snakeColor
            // 
            this.snakeColor.FormattingEnabled = true;
            this.snakeColor.Items.AddRange(new object[] {
            "Zielony",
            "Czerwony",
            "Fioletowy"});
            this.snakeColor.Location = new System.Drawing.Point(558, 232);
            this.snakeColor.Name = "snakeColor";
            this.snakeColor.Size = new System.Drawing.Size(180, 28);
            this.snakeColor.TabIndex = 4;
            // 
            // poziomTrudnosci
            // 
            this.poziomTrudnosci.FormattingEnabled = true;
            this.poziomTrudnosci.Items.AddRange(new object[] {
            "Łatwy",
            "Średni",
            "Trudny"});
            this.poziomTrudnosci.Location = new System.Drawing.Point(558, 328);
            this.poziomTrudnosci.Name = "poziomTrudnosci";
            this.poziomTrudnosci.Size = new System.Drawing.Size(180, 28);
            this.poziomTrudnosci.TabIndex = 5;
            this.poziomTrudnosci.UseWaitCursor = true;
            // 
            // volume
            // 
            this.volume.Location = new System.Drawing.Point(594, 411);
            this.volume.Name = "volume";
            this.volume.Size = new System.Drawing.Size(130, 56);
            this.volume.TabIndex = 6;
            // 
            // saveButton
            // 
            this.saveButton.BackColor = System.Drawing.Color.Green;
            this.saveButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.saveButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.saveButton.ForeColor = System.Drawing.SystemColors.ControlText;
            this.saveButton.Location = new System.Drawing.Point(312, 549);
            this.saveButton.Name = "saveButton";
            this.saveButton.Size = new System.Drawing.Size(231, 50);
            this.saveButton.TabIndex = 10;
            this.saveButton.Text = "Zapisz";
            this.saveButton.UseVisualStyleBackColor = false;
            this.saveButton.Click += new System.EventHandler(this.saveButton_Click_1);
            // 
            // Ustawienia_Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(879, 863);
            this.Controls.Add(this.saveButton);
            this.Controls.Add(this.volume);
            this.Controls.Add(this.poziomTrudnosci);
            this.Controls.Add(this.snakeColor);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Ustawienia_Form";
            this.Text = "Ustawienia_Form";
            ((System.ComponentModel.ISupportInitialize)(this.volume)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private ComboBox snakeColor;
        private ComboBox poziomTrudnosci;
        private TrackBar volume;
        private Button saveButton;
    }
}