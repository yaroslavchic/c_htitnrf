namespace WindowsFormsApplication1
{
    partial class filtr
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
            this.button1 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.vozrastTextBox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.polComboBox = new System.Windows.Forms.ComboBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.SWYAZ = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(318, 18);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(166, 63);
            this.button1.TabIndex = 0;
            this.button1.Text = "Посмотреть";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(4, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(64, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Возраст до";
            // 
            // vozrastTextBox
            // 
            this.vozrastTextBox.Location = new System.Drawing.Point(74, 21);
            this.vozrastTextBox.Name = "vozrastTextBox";
            this.vozrastTextBox.Size = new System.Drawing.Size(100, 20);
            this.vozrastTextBox.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(21, 63);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(27, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Пол";
            // 
            // polComboBox
            // 
            this.polComboBox.FormattingEnabled = true;
            this.polComboBox.Items.AddRange(new object[] {
            "мне по фигу",
            "женский",
            "мужской"});
            this.polComboBox.Location = new System.Drawing.Point(74, 60);
            this.polComboBox.Name = "polComboBox";
            this.polComboBox.Size = new System.Drawing.Size(100, 21);
            this.polComboBox.TabIndex = 6;
            // 
            // panel2
            // 
            this.panel2.AutoScroll = true;
            this.panel2.Location = new System.Drawing.Point(-6, 101);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(641, 164);
            this.panel2.TabIndex = 8;
            this.panel2.Paint += new System.Windows.Forms.PaintEventHandler(this.panel2_Paint);
            // 
            // SWYAZ
            // 
            this.SWYAZ.Location = new System.Drawing.Point(516, 12);
            this.SWYAZ.Name = "SWYAZ";
            this.SWYAZ.Size = new System.Drawing.Size(75, 23);
            this.SWYAZ.TabIndex = 9;
            this.SWYAZ.Text = "button2";
            this.SWYAZ.UseVisualStyleBackColor = true;
            this.SWYAZ.Click += new System.EventHandler(this.SWYAZ_Click);
            // 
            // filtr
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(631, 261);
            this.Controls.Add(this.SWYAZ);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.polComboBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.vozrastTextBox);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button1);
            this.Name = "filtr";
            this.Text = "Фильтр";
            this.Load += new System.EventHandler(this.Form2_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox vozrastTextBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox polComboBox;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button SWYAZ;
    }
}