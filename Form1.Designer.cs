namespace SixCards
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.pb_title = new System.Windows.Forms.PictureBox();
            this.pb_card1 = new System.Windows.Forms.PictureBox();
            this.pb_card2 = new System.Windows.Forms.PictureBox();
            this.pb_card3 = new System.Windows.Forms.PictureBox();
            this.pb_card4 = new System.Windows.Forms.PictureBox();
            this.pb_card5 = new System.Windows.Forms.PictureBox();
            this.pb_card6 = new System.Windows.Forms.PictureBox();
            this.b_dist = new System.Windows.Forms.Button();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.pb_title)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_card1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_card2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_card3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_card4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_card5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_card6)).BeginInit();
            this.SuspendLayout();
            // 
            // pb_title
            // 
            this.pb_title.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pb_title.BackgroundImage")));
            this.pb_title.Location = new System.Drawing.Point(13, 13);
            this.pb_title.Name = "pb_title";
            this.pb_title.Size = new System.Drawing.Size(60, 90);
            this.pb_title.TabIndex = 0;
            this.pb_title.TabStop = false;
            this.toolTip1.SetToolTip(this.pb_title, "При нажатие Заполнит недостоющие карты");
            this.pb_title.Click += new System.EventHandler(this.pb_title_Click);
            // 
            // pb_card1
            // 
            this.pb_card1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pb_card1.BackgroundImage")));
            this.pb_card1.Location = new System.Drawing.Point(148, 13);
            this.pb_card1.Name = "pb_card1";
            this.pb_card1.Size = new System.Drawing.Size(60, 90);
            this.pb_card1.TabIndex = 0;
            this.pb_card1.TabStop = false;
            this.toolTip1.SetToolTip(this.pb_card1, "При нажатие уберет карту");
            this.pb_card1.Click += new System.EventHandler(this.pb_card1_Click);
            // 
            // pb_card2
            // 
            this.pb_card2.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pb_card2.BackgroundImage")));
            this.pb_card2.Location = new System.Drawing.Point(214, 13);
            this.pb_card2.Name = "pb_card2";
            this.pb_card2.Size = new System.Drawing.Size(60, 90);
            this.pb_card2.TabIndex = 0;
            this.pb_card2.TabStop = false;
            this.toolTip1.SetToolTip(this.pb_card2, "При нажатие уберет карту");
            this.pb_card2.Click += new System.EventHandler(this.pb_card2_Click);
            // 
            // pb_card3
            // 
            this.pb_card3.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pb_card3.BackgroundImage")));
            this.pb_card3.Location = new System.Drawing.Point(280, 12);
            this.pb_card3.Name = "pb_card3";
            this.pb_card3.Size = new System.Drawing.Size(60, 90);
            this.pb_card3.TabIndex = 0;
            this.pb_card3.TabStop = false;
            this.toolTip1.SetToolTip(this.pb_card3, "При нажатие уберет карту");
            this.pb_card3.Click += new System.EventHandler(this.pb_card3_Click);
            // 
            // pb_card4
            // 
            this.pb_card4.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pb_card4.BackgroundImage")));
            this.pb_card4.Location = new System.Drawing.Point(346, 12);
            this.pb_card4.Name = "pb_card4";
            this.pb_card4.Size = new System.Drawing.Size(60, 90);
            this.pb_card4.TabIndex = 0;
            this.pb_card4.TabStop = false;
            this.toolTip1.SetToolTip(this.pb_card4, "При нажатие уберет карту");
            this.pb_card4.Click += new System.EventHandler(this.pb_card4_Click);
            // 
            // pb_card5
            // 
            this.pb_card5.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pb_card5.BackgroundImage")));
            this.pb_card5.Location = new System.Drawing.Point(412, 12);
            this.pb_card5.Name = "pb_card5";
            this.pb_card5.Size = new System.Drawing.Size(60, 90);
            this.pb_card5.TabIndex = 0;
            this.pb_card5.TabStop = false;
            this.toolTip1.SetToolTip(this.pb_card5, "При нажатие уберет карту");
            this.pb_card5.Click += new System.EventHandler(this.pb_card5_Click);
            // 
            // pb_card6
            // 
            this.pb_card6.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pb_card6.BackgroundImage")));
            this.pb_card6.Location = new System.Drawing.Point(478, 12);
            this.pb_card6.Name = "pb_card6";
            this.pb_card6.Size = new System.Drawing.Size(60, 90);
            this.pb_card6.TabIndex = 0;
            this.pb_card6.TabStop = false;
            this.toolTip1.SetToolTip(this.pb_card6, "При нажатие уберет карту");
            this.pb_card6.Click += new System.EventHandler(this.pb_card6_Click);
            // 
            // b_dist
            // 
            this.b_dist.Location = new System.Drawing.Point(13, 144);
            this.b_dist.Name = "b_dist";
            this.b_dist.Size = new System.Drawing.Size(87, 23);
            this.b_dist.TabIndex = 1;
            this.b_dist.Text = "Сдать карты";
            this.toolTip1.SetToolTip(this.b_dist, "Заполнить недостоющие карты");
            this.b_dist.UseVisualStyleBackColor = true;
            this.b_dist.Click += new System.EventHandler(this.b_dist_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(564, 257);
            this.Controls.Add(this.b_dist);
            this.Controls.Add(this.pb_card6);
            this.Controls.Add(this.pb_card5);
            this.Controls.Add(this.pb_card4);
            this.Controls.Add(this.pb_card3);
            this.Controls.Add(this.pb_card2);
            this.Controls.Add(this.pb_card1);
            this.Controls.Add(this.pb_title);
            this.Name = "Form1";
            this.Text = "\"Шесть карт\"";
            ((System.ComponentModel.ISupportInitialize)(this.pb_title)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_card1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_card2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_card3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_card4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_card5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_card6)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pb_title;
        private System.Windows.Forms.PictureBox pb_card1;
        private System.Windows.Forms.PictureBox pb_card2;
        private System.Windows.Forms.PictureBox pb_card3;
        private System.Windows.Forms.PictureBox pb_card4;
        private System.Windows.Forms.PictureBox pb_card5;
        private System.Windows.Forms.PictureBox pb_card6;
        private System.Windows.Forms.Button b_dist;
        private System.Windows.Forms.ToolTip toolTip1;
    }
}

