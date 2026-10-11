using System.Globalization;
using System.Text;

namespace bai3btvn
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            InitializeAlphabetTree();
        }

        private void InitializeAlphabetTree()
        {
            for (char letter = 'A'; letter <= 'Z'; letter++)
            {
                treeViewNames.Nodes.Add(letter.ToString());
            }

            treeViewNames.ExpandAll();
        }

        private void buttonAdd_Click(object? sender, EventArgs e)
        {
            string firstName = textBoxFirstName.Text.Trim();
            string lastName = textBoxLastName.Text.Trim();

            if (firstName.Length == 0 || lastName.Length == 0)
            {
                MessageBox.Show("Please enter both first name and last name.", "Missing information",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            string normalizedFirstName = RemoveDiacritics(firstName).Replace('đ', 'd').Replace('Đ', 'D');
            char initial = char.ToUpperInvariant(normalizedFirstName[0]);
            if (initial < 'A' || initial > 'Z')
            {
                MessageBox.Show("The first name must start with a letter from A to Z.", "Invalid first name",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                textBoxFirstName.Focus();
                return;
            }

            TreeNode parentNode = treeViewNames.Nodes[initial - 'A']!;
            TreeNode contactNode = parentNode.Nodes.Add($"{firstName}, {lastName}");
            parentNode.Expand();
            treeViewNames.SelectedNode = contactNode;
            contactNode.EnsureVisible();

            textBoxFirstName.Clear();
            textBoxLastName.Clear();
            textBoxFirstName.Focus();
        }

        private void buttonExit_Click(object? sender, EventArgs e)
        {
            Close();
        }

        private static string RemoveDiacritics(string value)
        {
            string normalized = value.Normalize(NormalizationForm.FormD);
            var result = new StringBuilder(normalized.Length);

            foreach (char character in normalized)
            {
                if (CharUnicodeInfo.GetUnicodeCategory(character) != UnicodeCategory.NonSpacingMark)
                {
                    result.Append(character);
                }
            }

            return result.ToString().Normalize(NormalizationForm.FormC);
        }
    }
}
