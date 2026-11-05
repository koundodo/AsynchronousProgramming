using System.Text.RegularExpressions;

namespace AsynchronousProgramming
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnBrowse1_Click(object sender, EventArgs e)
        {
            DialogResult result = openFileDialog1.ShowDialog();

            if (result == DialogResult.OK)
            {
                txtBook1.Text = openFileDialog1.FileName;
            }
        }

        private void btnBrowse2_Click(object sender, EventArgs e)
        {
            DialogResult result = openFileDialog2.ShowDialog();

            if (result == DialogResult.OK)
            {
                txtBook2.Text = openFileDialog2.FileName;
            }
        }

        // Dado Koundoul
        private async Task ReadBook(string filename, ListBox outputListBox)
        {
            var lines = await File.ReadAllLinesAsync(filename);

            var arrayLinesCleaned = lines.Where(x => x != string.Empty)
                .AsParallel()
                .Select(x => x.ToLower()
                .Trim().Replace(",", "")
                .Replace("'", "")
                .Replace("{", ""));

            var arrayOfWords = arrayLinesCleaned.SelectMany(x => x.Split(" "));

            Dictionary<string, int> wordDic = new Dictionary<string, int>();

            arrayOfWords.ToList().ForEach(x =>
            {
                if (wordDic.ContainsKey(x))
                {
                    wordDic[x]++;
                }
                else
                {
                    wordDic.Add(x, 1);
                }

            });

            var top10 = wordDic.Where(x => !string.IsNullOrWhiteSpace(x.Key))
                    .OrderByDescending(x => x.Value)
                    .Take(10);

            foreach (var word in top10)
            {
                outputListBox.Items.Add(word.Key + " - " + word.Value);
            }
        }

        // Dado Koundoul
        private async void btnSubmit_Click(object sender, EventArgs e)
        {
            lstBox1.Items.Clear();
            lstBox2.Items.Clear();

            List<Task> tasks = new List<Task>();

            var file1 = txtBook1.Text;
            var file2 = txtBook2.Text;
            var wordTask1 = ReadBook(file1, lstBox1);
            var wordTask2 = ReadBook(file2, lstBox2);

            tasks.Add(wordTask1);
            tasks.Add(wordTask2);

            await Task.WhenAll(tasks);
        }

        

        private void btnExit_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}

