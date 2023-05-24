namespace CipherApp
{
    public partial class Form1 : Form
    {
        SimpleCipher cipher = new SimpleCipher();
        public Form1()
        {
            InitializeComponent();
        }

        private void EncryptMessageButton_Click(object sender, EventArgs e)
        {
            OutputEncryptedTextBox.ReadOnly = false;
            OutputEncryptedTextBox.Text = cipher.encrypt(InputTextBox.Text);
            OutputEncryptedTextBox.ReadOnly = true;
        }

        private void CopyEncryptionButton_Click(object sender, EventArgs e)
        {
            Clipboard.SetText(OutputEncryptedTextBox.Text);
        }

        private void DecryptButton_Click(object sender, EventArgs e)
        {
            OutputDecryptedTextbox.ReadOnly = false;
            OutputDecryptedTextbox.Text = cipher.decrypt(InputDecryptBox.Text);
            OutputDecryptedTextbox.ReadOnly = true;
        }

        private void PasteTextButton_Click(object sender, EventArgs e)
        {
            InputDecryptBox.Text = Clipboard.GetText();
        }
    }

    public class SimpleCipher
    {
        Dictionary<char, char> cipherDict = new Dictionary<char, char>
        {
            { 'a', '○' }, { 'A', '•' },
            { 'b', '╚' }, { 'B', '₲' },
            { 'c', '┐' }, { 'C', '₽'},
            { 'd', 'ß' }, { 'D','⌂'},
            { 'e', '╣' }, { 'E','┼'},
            { 'f', '║' }, { 'F','‰'},
            { 'g', '☼' }, { 'G','₿'},
            { 'h', '[' }, { 'H','ῷ'},
            { 'i', '⅝' }, { 'I','∑'},
            { 'j', '0' }, { 'J','2'},
            { 'k', '!' }, { 'K','3'},
            { 'l', 'ʑ' }, { 'L','4'},
            { 'm', '#' }, { 'M','ꭥ'},
            { 'n', '$' }, { 'N','Ꝯ'},
            { 'o', '%' }, { 'O','ﬔ'},
            { 'p', '^' }, { 'P','יִ'},
            { 'q', '@' }, { 'Q','6'},
            { 'r', '*' }, { 'R','1'},
            { 's', ':' }, { 'S','ꭖ'},
            { 't', ';' }, { 'T','ꭚ'},
            { 'u', '֏' }, { 'U','ꭞ'},
            { 'v', '>' }, { 'V','ﬀ'},
            { 'w', '<' }, { 'W','™'},
            { 'x', ',' }, { 'X','☻'},
            { 'y', '?' }, { 'Y','▀'},
            { 'z', '=' }, { 'Z','☺'},
            { ' ', '|' }
        };

        public string encrypt(string input)
        {
            string? outputMessage = "";
            foreach (char x in input)
            {
                foreach (var key in cipherDict.Keys)
                {
                    if (x == key)
                    {
                        outputMessage += cipherDict[key];
                    }
                }
            }
            return outputMessage;
        }

        public string decrypt(string input)
        {
            string? outputMessage = "";
            foreach (char x in input)
            {
                foreach (var key in cipherDict.Keys)
                {
                    if (x == cipherDict[key])
                    {
                        outputMessage += key;
                    }
                }
            }
            return outputMessage;
        }

    }
}