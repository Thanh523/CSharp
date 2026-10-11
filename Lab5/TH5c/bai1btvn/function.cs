namespace Bai1btvn
{
    public partial class Form1 : Form
    {
        private readonly Dictionary<string, string> englishToVietnamese = new(StringComparer.CurrentCultureIgnoreCase)
        {
            ["student"] = "Sinh viên, học sinh",
            ["teacher"] = "Giáo viên",
            ["worker"] = "Công nhân",
            ["hat"] = "Mũ, nón",
            ["head"] = "Đầu",
            ["mouse"] = "Chuột",
            ["cat"] = "Mèo",
            ["dog"] = "Chó",
            ["snake"] = "Con rắn",
            ["lamb"] = "Cừu non",
            ["loan"] = "Khoản vay",
            ["frog"] = "Con ếch",
            ["sheep"] = "Con cừu",
            ["apple"] = "Quả táo",
            ["book"] = "Quyển sách",
            ["computer"] = "Máy tính",
            ["friend"] = "Bạn bè",
            ["hello"] = "Xin chào",
            ["house"] = "Ngôi nhà",
            ["water"] = "Nước"
        };

        private readonly Dictionary<string, string> vietnameseToEnglish = new(StringComparer.CurrentCultureIgnoreCase);

        public Form1()
        {
            InitializeComponent();

            foreach (var entry in englishToVietnamese)
            {
                foreach (var meaning in entry.Value.Split(','))
                {
                    vietnameseToEnglish[meaning.Trim()] = entry.Key;
                }
            }

            PopulateDictionary(cboEnglishWord, lstEnglishWords, englishToVietnamese.Keys);
            PopulateDictionary(cboVietnameseWord, lstVietnameseWords, vietnameseToEnglish.Keys);

            cboEnglishWord.TextUpdate += (_, _) => SelectClosestWord(cboEnglishWord, lstEnglishWords);
            cboVietnameseWord.TextUpdate += (_, _) => SelectClosestWord(cboVietnameseWord, lstVietnameseWords);
            cboEnglishWord.SelectedIndexChanged += (_, _) => SelectClosestWord(cboEnglishWord, lstEnglishWords);
            cboVietnameseWord.SelectedIndexChanged += (_, _) => SelectClosestWord(cboVietnameseWord, lstVietnameseWords);
            cboEnglishWord.KeyDown += (_, e) => LookupOnEnter(e, cboEnglishWord, lstEnglishWords, txtVietnameseMeaning, englishToVietnamese);
            cboVietnameseWord.KeyDown += (_, e) => LookupOnEnter(e, cboVietnameseWord, lstVietnameseWords, txtEnglishMeaning, vietnameseToEnglish);
            btnLookupEnglish.Click += (_, _) => Lookup(cboEnglishWord, lstEnglishWords, txtVietnameseMeaning, englishToVietnamese);
            btnLookupVietnamese.Click += (_, _) => Lookup(cboVietnameseWord, lstVietnameseWords, txtEnglishMeaning, vietnameseToEnglish);
            lstEnglishWords.DoubleClick += (_, _) => LookupSelected(lstEnglishWords, cboEnglishWord, txtVietnameseMeaning, englishToVietnamese);
            lstVietnameseWords.DoubleClick += (_, _) => LookupSelected(lstVietnameseWords, cboVietnameseWord, txtEnglishMeaning, vietnameseToEnglish);
            btnExit.Click += (_, _) => Close();
            tabDictionary.SelectedIndexChanged += (_, _) => AcceptButton = tabDictionary.SelectedIndex == 0 ? btnLookupEnglish : btnLookupVietnamese;
        }

        private static void PopulateDictionary(ComboBox comboBox, ListBox listBox, IEnumerable<string> words)
        {
            var sortedWords = words.OrderBy(word => word, StringComparer.CurrentCultureIgnoreCase).ToArray();
            comboBox.Items.AddRange(sortedWords);
            listBox.Items.AddRange(sortedWords);
        }

        private static string? FindClosestWord(string input, ListBox listBox)
        {
            if (string.IsNullOrWhiteSpace(input))
            {
                return null;
            }

            var compareInfo = System.Globalization.CultureInfo.CurrentCulture.CompareInfo;
            const System.Globalization.CompareOptions options =
                System.Globalization.CompareOptions.IgnoreCase | System.Globalization.CompareOptions.IgnoreNonSpace;
            var words = listBox.Items.Cast<string>().ToArray();

            return words.FirstOrDefault(word => compareInfo.IsPrefix(word, input, options))
                ?? words.FirstOrDefault(word => compareInfo.IndexOf(word, input, options) >= 0);
        }

        private static void SelectClosestWord(ComboBox comboBox, ListBox listBox)
        {
            var closestWord = FindClosestWord(comboBox.Text.Trim(), listBox);
            listBox.SelectedItem = closestWord;
        }

        private static void LookupOnEnter(KeyEventArgs e, ComboBox comboBox, ListBox listBox, TextBox meaningBox, Dictionary<string, string> dictionary)
        {
            if (e.KeyCode == Keys.Enter)
            {
                e.SuppressKeyPress = true;
                Lookup(comboBox, listBox, meaningBox, dictionary);
            }
        }

        private static void Lookup(ComboBox comboBox, ListBox listBox, TextBox meaningBox, Dictionary<string, string> dictionary)
        {
            var word = FindClosestWord(comboBox.Text.Trim(), listBox);
            if (word is null)
            {
                meaningBox.Text = "Không tìm thấy từ phù hợp.";
                return;
            }

            comboBox.Text = word;
            listBox.SelectedItem = word;
            meaningBox.Text = dictionary[word];
        }

        private static void LookupSelected(ListBox listBox, ComboBox comboBox, TextBox meaningBox, Dictionary<string, string> dictionary)
        {
            if (listBox.SelectedItem is string word)
            {
                comboBox.Text = word;
                meaningBox.Text = dictionary[word];
            }
        }

        private void lstEnglishWords_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
