namespace SoruBankam.Presentation.WindowsForms.Views
{
    partial class QuestionsForm
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
            this.btnNext = new System.Windows.Forms.Button();
            this.btnPrevious = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.tbDescription = new System.Windows.Forms.TextBox();
            this.btnSwitch = new System.Windows.Forms.Button();
            this.pictureSwitch = new System.Windows.Forms.PictureBox();
            this.btnSoruEkle = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureSwitch)).BeginInit();
            this.SuspendLayout();
            // 
            // btnNext
            // 
            this.btnNext.Location = new System.Drawing.Point(201, 305);
            this.btnNext.Name = "btnNext";
            this.btnNext.Size = new System.Drawing.Size(118, 39);
            this.btnNext.TabIndex = 11;
            this.btnNext.Text = "Sonraki Soru ->";
            this.btnNext.UseVisualStyleBackColor = true;
            this.btnNext.Click += new System.EventHandler(this.btnNext_Click);
            // 
            // btnPrevious
            // 
            this.btnPrevious.Location = new System.Drawing.Point(77, 305);
            this.btnPrevious.Name = "btnPrevious";
            this.btnPrevious.Size = new System.Drawing.Size(118, 39);
            this.btnPrevious.TabIndex = 10;
            this.btnPrevious.Text = "<- Önceki Soru";
            this.btnPrevious.UseVisualStyleBackColor = true;
            this.btnPrevious.Click += new System.EventHandler(this.btnPrevious_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 346);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(56, 15);
            this.label1.TabIndex = 9;
            this.label1.Text = "Açıklama";
            // 
            // tbDescription
            // 
            this.tbDescription.Location = new System.Drawing.Point(12, 364);
            this.tbDescription.Multiline = true;
            this.tbDescription.Name = "tbDescription";
            this.tbDescription.Size = new System.Drawing.Size(398, 74);
            this.tbDescription.TabIndex = 8;
            // 
            // btnSwitch
            // 
            this.btnSwitch.Location = new System.Drawing.Point(325, 305);
            this.btnSwitch.Name = "btnSwitch";
            this.btnSwitch.Size = new System.Drawing.Size(85, 39);
            this.btnSwitch.TabIndex = 7;
            this.btnSwitch.Text = "Cevap";
            this.btnSwitch.UseVisualStyleBackColor = true;
            this.btnSwitch.Click += new System.EventHandler(this.btnSwitch_Click);
            // 
            // pictureSwitch
            // 
            this.pictureSwitch.Location = new System.Drawing.Point(12, 12);
            this.pictureSwitch.Name = "pictureSwitch";
            this.pictureSwitch.Size = new System.Drawing.Size(398, 276);
            this.pictureSwitch.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureSwitch.TabIndex = 6;
            this.pictureSwitch.TabStop = false;
            this.pictureSwitch.Click += new System.EventHandler(this.pictureSwitch_Click);
            // 
            // btnSoruEkle
            // 
            this.btnSoruEkle.Location = new System.Drawing.Point(12, 305);
            this.btnSoruEkle.Name = "btnSoruEkle";
            this.btnSoruEkle.Size = new System.Drawing.Size(56, 39);
            this.btnSoruEkle.TabIndex = 12;
            this.btnSoruEkle.Text = "Soru Ekle";
            this.btnSoruEkle.UseVisualStyleBackColor = true;
            this.btnSoruEkle.Click += new System.EventHandler(this.btnSoruEkle_Click);
            // 
            // QuestionsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(423, 448);
            this.Controls.Add(this.btnSoruEkle);
            this.Controls.Add(this.btnNext);
            this.Controls.Add(this.btnPrevious);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tbDescription);
            this.Controls.Add(this.btnSwitch);
            this.Controls.Add(this.pictureSwitch);
            this.Name = "QuestionsForm";
            this.Text = "QuestionsForm";
            this.Load += new System.EventHandler(this.QuestionsForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureSwitch)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button btnNext;
        private Button btnPrevious;
        private Label label1;
        private TextBox tbDescription;
        private Button btnSwitch;
        private PictureBox pictureSwitch;
        private Button btnSoruEkle;
    }
}