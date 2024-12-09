using System.Globalization;
using WinFormsAppColor.BookModels;

namespace WinFormsAppColor
{
    public partial class Form1 : Form
    {
        FunnyDatabaseContext context = new FunnyDatabaseContext();
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            colorsAndMeaningBindingSource.DataSource = context.ColorsAndMeanings.ToList();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            colorsAndMeaningBindingSource.RemoveCurrent();
            FormDelete fd = new FormDelete();
            fd.Show();
            context.SaveChanges();
        }

        private void button2_Click(object sender, EventArgs e)
        {
        }
    }
}
