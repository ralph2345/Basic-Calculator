namespace CashierWindowQueueForm
{
    public partial class Form1 : Form
    {

        public Form1()
        {
            InitializeComponent();

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        public void DisplayCashierQueue(IEnumerable CashierList)
        {
            listCashierView.Items.Clear();
            foreach (Object obj in CashierList)
            {
                listCashierView.Items.Add(obj.ToString());
            }
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            DisplayCashierQueue(CashierClass.CashierQueue);
        }
    }
}