namespace TodoWinformApp
{
    public partial class Form1 : Form
    {
        public List<bool> Items { get; set; }

        public Form1()
        {
            InitializeComponent();
            Items = Enumerable.Repeat(false, 5).ToList();
        }

        public void PrintItems()
        {
            int i = 0;
            foreach (var item in Items) 
            { 
                Console.WriteLine("Status of Item {0} is {1}", i, item.ToString());
                i ++;
            }
        }

        private void checkBox_MouseClick(object sender, MouseEventArgs e)
        {
            Items[1] = true;
            PrintItems();
        }

        
    }
}
