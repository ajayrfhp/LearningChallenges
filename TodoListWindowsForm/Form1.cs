using System.ComponentModel;
using System.Windows.Forms;

namespace TodoListWindowsForm
{
    public partial class Form1 : Form
    {
        public BindingList<TodoModel> TodoList { get; set; }
        public Form1()
        {
            this.TodoList = new BindingList<TodoModel>(); 
            InitializeComponent();
            checkbox.DataSource = this.TodoList;
        }

        public void AddTodo(string item)
        {
            TodoModel todoItem = new TodoModel { isComplete = false, text = item, order = this.TodoList.Count };
            this.TodoList.Add(todoItem);
        }

        public void ReorderTodo()
        {
            for(int i = 0; i < this.TodoList.Count; i ++)
            {
                this.TodoList[i].order = i;
            }
        }

        public void RemoveItem(TodoModel item)
        {
            this.TodoList.Remove(item);
            this.ReorderTodo();
        }

        public void EditItem(ref TodoModel selectedItem, string item)
        {
            selectedItem.text = item;
            this.ReorderTodo();
        }

        public void Complete(TodoModel item) 
        {
            item.isComplete = true;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string inputText = Microsoft.VisualBasic.Interaction.InputBox("enter text to add", "enter text to add");
            this.AddTodo(inputText);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if(checkbox.SelectedItem != null)
            {
                this.RemoveItem((TodoModel)checkbox.SelectedItem);
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            string inputText = Microsoft.VisualBasic.Interaction.InputBox("enter text to add", "enter text to add");
            if (checkbox.SelectedItem != null)
            {
                var item = (TodoModel)checkbox.SelectedItem;
                this.EditItem(ref item, inputText);
                checkbox.Refresh();
            }  
            
        }

        private void checkedListBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if(checkbox.SelectedItem != null)
            {
                int index = checkbox.SelectedIndex;
                if(e.KeyChar == 'w' && index > 0)
                {
                    var t = this.TodoList[index - 1];
                    this.TodoList[index - 1] = this.TodoList[index];
                    this.TodoList[index] = t;
                    this.ReorderTodo();
                }

                else if(e.KeyChar == 's' && index < this.TodoList.Count - 1)
                {
                    var t = this.TodoList[index + 1];
                    this.TodoList[index + 1] = this.TodoList[index];
                    this.TodoList[index] = t;
                    this.ReorderTodo();
                }
                checkbox.Refresh();
            }
        }
    }
}
