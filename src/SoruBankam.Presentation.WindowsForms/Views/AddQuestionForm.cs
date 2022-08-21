using SoruBankam.Business.Abstract;
using SoruBankam.Business.Concrete;
using SoruBankam.DataAccessLayer.Concrete.EntityFramework;
using SoruBankam.Entities;
using SoruBankam.Presentation.WindowsForms.Tools;

namespace SoruBankam.Presentation.WindowsForms.Views
{
    public partial class AddQuestionForm : Form
    {
        IQuestionManager questionManager;
        public AddQuestionForm()
        {
            InitializeComponent();
        }


        private void AddQuestionForm_Load(object sender, EventArgs e)
        {
            this.questionManager = new QuestionManager(new QuestionRepository());
        }

        private void btnQuestionAdd_Click(object sender, EventArgs e)
        {
            picQuestionPhoto.SizeMode = PictureBoxSizeMode.StretchImage;
            openFileDialog1.ShowDialog();
            picQuestionPhoto.ImageLocation = openFileDialog1.FileName;
        }

        private void btnAnswerAdd_Click(object sender, EventArgs e)
        {
            picAnswerPhoto.SizeMode = PictureBoxSizeMode.StretchImage;
            openFileDialog1.ShowDialog();
            picAnswerPhoto.ImageLocation = openFileDialog1.FileName;
        }

        private void tbDescription_TextChanged(object sender, EventArgs e)
        {
        }

        private void BtnSave_Click(object sender, EventArgs e)
        {
            var question = new Question();
            question.Description = tbDescription.Text;
            question.Photo = BitmapTool.ImageToByte(new Bitmap(picQuestionPhoto.Image));
            question.AnswerPhoto = BitmapTool.ImageToByte(new Bitmap(picAnswerPhoto.Image));

            questionManager.Add(question);

            MessageBox.Show("Soru Kaydedildi");

            this.Close();
        }
    }
}
