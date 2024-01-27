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
            this.SetOrder();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (checkedListBox1.SelectedItem != null)
            {
                checkedListBox1.Items.Remove(checkedListBox1.SelectedItem);
            }
            this.SetOrder();

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
            this.SetOrder();
        }

        private void checkedListBox1_KeyDown(object sender, KeyEventArgs e)
        {
            if (checkedListBox1.SelectedItem != null)
            {
                int index = checkedListBox1.SelectedIndex;
                if (index < checkedListBox1.Items.Count - 1)
                {
                    var t = checkedListBox1.Items[index];
                    checkedListBox1.Items.RemoveAt(index);
                    checkedListBox1.Items.Insert(index + 1, t);
                }

            }
            this.SetOrder();
        }

        private void checkedListBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if(checkedListBox1.SelectedItem != null)
            {
                int index = checkedListBox1.SelectedIndex;
                if (e.KeyChar == 'w' && index > 0)
                {
                    var t = checkedListBox1.Items[index - 1];
                    checkedListBox1.Items.RemoveAt(index - 1);
                    checkedListBox1.Items.Insert(index, t);
                }

                else if(e.KeyChar == 's' && index < checkedListBox1.Items.Count - 1)
                {
                    var t = checkedListBox1.Items[index];
                    checkedListBox1.Items.RemoveAt(index);
                    checkedListBox1.Items.Insert(index + 1, t);
                }
            }
            this.SetOrder();
        }

        private void SetOrder()
        {
            for(int i = 0; i < checkedListBox1.Items.Count; i ++)
            {
                if (checkedListBox1.Items[i].ToString().Contains("-"))
                {
                    string[] a = checkedListBox1.Items[i].ToString().Split("-");
                    checkedListBox1.Items[i] = string.Format("{0}-{1}", i, a[1]);
                }
                else
                {
                    checkedListBox1.Items[i] = string.Format("{0}-{1}", i, checkedListBox1.Items[i]);
                }
                
            }
        }
    }
}
