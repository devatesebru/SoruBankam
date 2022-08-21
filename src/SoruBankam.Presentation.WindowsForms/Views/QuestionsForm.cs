using SoruBankam.Business.Abstract;
using SoruBankam.Business.Concrete;
using SoruBankam.DataAccessLayer.Concrete.EntityFramework;
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
            questionManager = Factory.CreateQuestionManager();
        }

        private void QuestionsForm_Load(object sender, EventArgs e)
        {
            questionManager.questionAdded += QuestionManager_QuestionAdded;

            GetAllQuestions();
            if(questions.Count == 0) { return; }
            currentQuestion = questions.First();
            DisplayQuestion(currentQuestion);
        }

        private void QuestionManager_QuestionAdded(Question question)
        {
            questions.Add(question);
        }

        private void btnPrevious_Click(object sender, EventArgs e)
        {
            var indexOf = questions.IndexOf(currentQuestion);

            if (indexOf == 0)
                return;

            currentQuestion = questions[indexOf - 1];

            DisplayQuestion(currentQuestion);
        }

        private void btnNext_Click(object sender, EventArgs e)
        {
            var indexOf = questions.IndexOf(currentQuestion);

            if (indexOf >= questions.Count-1)
                return;

            currentQuestion = questions[indexOf + 1];

            DisplayQuestion(currentQuestion);
        }

        private void btnSwitch_Click(object sender, EventArgs e)
        {
            if (btnSwitch.Text == "Cevap")
            {
                DisplayAnswer(currentQuestion.AnswerPhoto);
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

        private void DisplayAnswer(Byte[] answer)
        {
            pictureSwitch.Image = BitmapTool.ByteToImage(answer);
            btnSwitch.Text = "Soru";

        }

        private void btnSoruEkle_Click(object sender, EventArgs e)
        {
            AddQuestionForm addQuestionForm = new AddQuestionForm();
            addQuestionForm.ShowDialog();

        }
    }
}
