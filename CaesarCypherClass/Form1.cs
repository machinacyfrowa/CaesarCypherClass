using System.Reflection.Metadata;

namespace CaesarCypherClass
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private void Encrypt(object sender, EventArgs e)
        {
            outputTextBox.Text = Caesar.EncryptV1(inputTextBox.Text);
        }
        private void EncryptV2(object sender, EventArgs e)
        {
            outputTextBox.Text = Caesar.EncryptV2(inputTextBox.Text);
        }
    }
}