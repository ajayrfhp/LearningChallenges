using System.Windows.Forms;

namespace TodoListWindowsForm
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string inputText = Microsoft.VisualBasic.Interaction.InputBox("enter text to add", "enter text to add");

            checkedListBox1.Items.Add(inputText);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (checkedListBox1.SelectedItem != null)
            {
                checkedListBox1.Items.Remove(checkedListBox1.SelectedItem);
            }

        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (checkedListBox1.SelectedItem != null)
            {
                string inputText = Microsoft.VisualBasic.Interaction.InputBox("enter text to edit", "enter text to edit");
                int index = checkedListBox1.SelectedIndex;
                checkedListBox1.Items.RemoveAt(index);
                checkedListBox1.Items.Insert(index, inputText);
            }
        }

        private void checkedListBox1_KeyDown(object sender, KeyEventArgs e)
        {
            if (checkedListBox1.SelectedItem != null)
            {
                int index = checkedListBox1.SelectedIndex;
                if (index < checkedListBox1.Items.Count -1)
                {
                    var t = checkedListBox1.Items[index];
                    checkedListBox1.Items.RemoveAt(index);
                    checkedListBox1.Items.Insert(index + 1, t);
                }

            }
        }

        private void checkedListBox1_KeyUp(object sender, KeyEventArgs e)
        {
            if (checkedListBox1.SelectedItem != null)
            {
                int index = checkedListBox1.SelectedIndex;
                if (index > 0)
                {
                    var t = checkedListBox1.Items[index];
                    checkedListBox1.Items.RemoveAt(index);
                    checkedListBox1.Items.Insert(index - 1, t);
                }

            }
        }
    }
}
