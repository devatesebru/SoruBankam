using SoruBankam.Business.Abstract;
using SoruBankam.Entities;
using SoruBankam.Presentation.WindowsForms.Tools;

namespace SoruBankam.Presentation.WindowsForms.Views
{
    public partial class QuestionsForm : Form
    {
        private List<Question> questions;
        private IQuestionManager questionManager;
        private Question currentQuestion; //şuanki soru
        public QuestionsForm()
        {
            InitializeComponent();
            questions = new List<Question>();
        }

        private void QuestionsForm_Load(object sender, EventArgs e)
        {
            GetAllQuestions();
            currentQuestion = questions.First();
            DisplayQuestion(currentQuestion);
        }

        private void btnPrevious_Click(object sender, EventArgs e)
        {
            var indexOf = questions.IndexOf(currentQuestion);

            if (indexOf == 0)
                return;

            currentQuestion = questions[indexOf - 1];
        }

        private void btnNext_Click(object sender, EventArgs e)
        {
            var indexOf = questions.IndexOf(currentQuestion);

            if (indexOf > questions.Count)
                return;

            currentQuestion = questions[indexOf + 1];
        }

        private void btnSwitch_Click(object sender, EventArgs e)
        {
            if (btnSwitch.Text == "Cevap")
            {
                DisplayAnswer(currentQuestion.Answer);
            }
            else
            {
                DisplayQuestion(currentQuestion);
            }

        }

        private void pictureSwitch_Click(object sender, EventArgs e)
        {

        }

        private void GetAllQuestions()
        {
            questions = questionManager.GetAll();
        }

        private void DisplayQuestion(Question question)
        {
            pictureSwitch.Image = BitmapTool.ByteToImage(question.Photo);
            tbDescription.Text = question.Description;
            btnSwitch.Text = "Cevap";

        }

        private void DisplayAnswer(Answer answer)
        {
            pictureSwitch.Image = BitmapTool.ByteToImage(answer.Photo);
            btnSwitch.Text = "Soru";

        }
    }
}
