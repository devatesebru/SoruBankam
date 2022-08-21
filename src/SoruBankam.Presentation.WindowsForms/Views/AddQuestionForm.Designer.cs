namespace SoruBankam.Presentation.WindowsForms.Views
{
    partial class AddQuestionForm
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
            this.tbDescription = new System.Windows.Forms.TextBox();
            this.picQuestionPhoto = new System.Windows.Forms.PictureBox();
            this.picAnswerPhoto = new System.Windows.Forms.PictureBox();
            this.btnQuestionAdd = new System.Windows.Forms.Button();
            this.btnAnswerAdd = new System.Windows.Forms.Button();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.BtnSave = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.picQuestionPhoto)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picAnswerPhoto)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 327);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(56, 15);
            this.label1.TabIndex = 16;
            this.label1.Text = "Açıklama";
            // 
            // tbDescription
            // 
            this.tbDescription.Location = new System.Drawing.Point(12, 345);
            this.tbDescription.Multiline = true;
            this.tbDescription.Name = "tbDescription";
            this.tbDescription.Size = new System.Drawing.Size(398, 74);
            this.tbDescription.TabIndex = 15;
            this.tbDescription.TextChanged += new System.EventHandler(this.tbDescription_TextChanged);
            // 
            // picQuestionPhoto
            // 
            this.picQuestionPhoto.Location = new System.Drawing.Point(12, 12);
            this.picQuestionPhoto.Name = "picQuestionPhoto";
            this.picQuestionPhoto.Size = new System.Drawing.Size(206, 267);
            this.picQuestionPhoto.TabIndex = 13;
            this.picQuestionPhoto.TabStop = false;
            // 
            // picAnswerPhoto
            // 
            this.picAnswerPhoto.Location = new System.Drawing.Point(224, 12);
            this.picAnswerPhoto.Name = "picAnswerPhoto";
            this.picAnswerPhoto.Size = new System.Drawing.Size(186, 267);
            this.picAnswerPhoto.TabIndex = 17;
            this.picAnswerPhoto.TabStop = false;
            // 
            // btnQuestionAdd
            // 
            this.btnQuestionAdd.Location = new System.Drawing.Point(56, 285);
            this.btnQuestionAdd.Name = "btnQuestionAdd";
            this.btnQuestionAdd.Size = new System.Drawing.Size(75, 23);
            this.btnQuestionAdd.TabIndex = 18;
            this.btnQuestionAdd.Text = "Soru Ekle";
            this.btnQuestionAdd.UseVisualStyleBackColor = true;
            this.btnQuestionAdd.Click += new System.EventHandler(this.btnQuestionAdd_Click);
            // 
            // btnAnswerAdd
            // 
            this.btnAnswerAdd.Location = new System.Drawing.Point(279, 285);
            this.btnAnswerAdd.Name = "btnAnswerAdd";
            this.btnAnswerAdd.Size = new System.Drawing.Size(75, 23);
            this.btnAnswerAdd.TabIndex = 19;
            this.btnAnswerAdd.Text = "Cevap Ekle";
            this.btnAnswerAdd.UseVisualStyleBackColor = true;
            this.btnAnswerAdd.Click += new System.EventHandler(this.btnAnswerAdd_Click);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // BtnSave
            // 
            this.BtnSave.Location = new System.Drawing.Point(175, 433);
            this.BtnSave.Name = "BtnSave";
            this.BtnSave.Size = new System.Drawing.Size(75, 23);
            this.BtnSave.TabIndex = 20;
            this.BtnSave.Text = "Kaydet";
            this.BtnSave.UseVisualStyleBackColor = true;
            this.BtnSave.Click += new System.EventHandler(this.BtnSave_Click);
            // 
            // AddQuestionForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(427, 468);
            this.Controls.Add(this.BtnSave);
            this.Controls.Add(this.btnAnswerAdd);
            this.Controls.Add(this.btnQuestionAdd);
            this.Controls.Add(this.picAnswerPhoto);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tbDescription);
            this.Controls.Add(this.picQuestionPhoto);
            this.Name = "AddQuestionForm";
            this.Text = "AddQuestionForm";
            this.Load += new System.EventHandler(this.AddQuestionForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.picQuestionPhoto)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picAnswerPhoto)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label label1;
        private TextBox tbDescription;
        private PictureBox picQuestionPhoto;
        private PictureBox picAnswerPhoto;
        private Button btnQuestionAdd;
        private Button btnAnswerAdd;
        private OpenFileDialog openFileDialog1;
        private Button BtnSave;
    }
}