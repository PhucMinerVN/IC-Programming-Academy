using Apitron.PDF.Rasterizer;
namespace App
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void flowLayoutPanel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
         private void button2_Click(object sender, EventArgs e)
        {
            FileStream fs = new FileStream("Documents/Python.pdf", FileMode.Open);
 Document document = new Document(fs);
pdfViewer1.Dock = DockStyle.Bottom;
pdfViewer1.Anchor = AnchorStyles.Right;
pdfViewer1.Document = document;
        }
    }
}