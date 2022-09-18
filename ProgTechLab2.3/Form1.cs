using System.Linq;

namespace ProgTechLab2._3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            txtSentenceIn.Text = Properties.Settings.Default.yourSentence.ToString();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string yourSentence = this.txtSentenceIn.Text;

            try
            {
                yourSentence = this.txtSentenceIn.Text;
            }
            catch
            {
                return;
            }

            Properties.Settings.Default.yourSentence = yourSentence;
            Properties.Settings.Default.Save();

            MessageBox.Show(Logic.Sort(yourSentence));
        }
    }

    public class Logic
    {
        public static string Sort(string Sentense)
        {
            string[] wordsArray = Sentense.Split(' ', ',', '.');
            int[] wordsLenghtArray = new int[wordsArray.Length];
            for (int i = 0; i < wordsLenghtArray.Length; i++)
            {
                wordsLenghtArray[i] = wordsArray[i].Length;
            }

            Array.Sort(wordsLenghtArray, wordsArray);
            Array.Reverse(wordsArray);

            string finalLine = String.Join(' ', wordsArray);

            return finalLine;
        }
    }
}