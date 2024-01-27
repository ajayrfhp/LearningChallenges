using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TodoListWindowsForm
{
    public class TodoModel : INotifyPropertyChanged
    {
        public int order;

        public string text;

        public bool isComplete = false;

        public TodoModel() { }

        public event PropertyChangedEventHandler? PropertyChanged;

        public override string ToString()
        {
            return order.ToString() + " - " + text;
        }
        private void NotifyPropertyChanged(string p)
        {
            if (PropertyChanged != null)
                PropertyChanged(this, new PropertyChangedEventArgs(p));
        }
    }
}
