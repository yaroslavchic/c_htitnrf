namespace WindowsFormsApplication1
{
    partial class Geroy
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
            this.dislike = new System.Windows.Forms.PictureBox();
            this.like = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.likeLabel = new System.Windows.Forms.Label();
            this.Dislikelabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dislike)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.like)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // dislike
            // 
            this.dislike.Image = global::WindowsFormsApplication1.Properties.Resources.Дизлайк;
            this.dislike.InitialImage = null;
            this.dislike.Location = new System.Drawing.Point(13, 199);
            this.dislike.Name = "dislike";
            this.dislike.Size = new System.Drawing.Size(100, 50);
            this.dislike.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.dislike.TabIndex = 2;
            this.dislike.TabStop = false;
            this.dislike.Click += new System.EventHandler(this.Dislike_Click);
            // 
            // like
            // 
            this.like.Image = global::WindowsFormsApplication1.Properties.Resources.Лайк;
            this.like.InitialImage = null;
            this.like.Location = new System.Drawing.Point(162, 199);
            this.like.Name = "like";
            this.like.Size = new System.Drawing.Size(66, 50);
            this.like.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.like.TabIndex = 0;
            this.like.TabStop = false;
            this.like.Click += new System.EventHandler(this.Like_Click);
            // 
            // pictureBox2
            // 
            this.pictureBox2.Location = new System.Drawing.Point(13, 13);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(259, 180);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 3;
            this.pictureBox2.TabStop = false;
            // 
            // likeLabel
            // 
            this.likeLabel.AutoSize = true;
            this.likeLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 18.25F);
            this.likeLabel.Location = new System.Drawing.Point(224, 220);
            this.likeLabel.Name = "likeLabel";
            this.likeLabel.Size = new System.Drawing.Size(27, 29);
            this.likeLabel.TabIndex = 4;
            this.likeLabel.Text = "0";
            // 
            // Dislikelabel
            // 
            this.Dislikelabel.AutoSize = true;
            this.Dislikelabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 18.25F);
            this.Dislikelabel.Location = new System.Drawing.Point(86, 220);
            this.Dislikelabel.Name = "Dislikelabel";
            this.Dislikelabel.Size = new System.Drawing.Size(27, 29);
            this.Dislikelabel.TabIndex = 5;
            this.Dislikelabel.Text = "0";
            // 
            // Geroy
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.Dislikelabel);
            this.Controls.Add(this.likeLabel);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.dislike);
            this.Controls.Add(this.like);
            this.Name = "Geroy";
            this.Text = "Geroy";
            this.Load += new System.EventHandler(this.Geroy_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dislike)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.like)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox like;
        private System.Windows.Forms.PictureBox dislike;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Label likeLabel;
        private System.Windows.Forms.Label Dislikelabel;
    }
}