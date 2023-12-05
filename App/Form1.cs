using Apitron.PDF.Rasterizer;
using App.Properties;
using System.Resources;
namespace App
{
    public partial class Form1 : Form
    {
        public string current_doc = "";
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
        private void button1_Click(object sender, EventArgs e)
        {
            FileStream fs = new FileStream("Documents/C++/bai1.pdf", FileMode.Open);
            Document document = new Document(fs);
            pdfViewer1.Document = document;
            current_doc="C++";
            bai1.Visible=true;
            bai2.Visible=true;
            bai3.Visible=true;
            bai4.Visible=true;
            bai5.Visible=true;
            bai6.Visible=true;
            bai7.Visible=true;
            bai8.Visible=true;
            bai9.Visible=true;
            bai10.Visible=false;
            bai11.Visible=false;
            bai12.Visible=false;
        }
        private void button2_Click(object sender, EventArgs e)
        {
            FileStream fs = new FileStream("Documents/Python/bai1.pdf", FileMode.Open);
            Document document = new Document(fs);
            pdfViewer1.Document = document;
            current_doc="Python";
            bai1.Visible=true;
            bai2.Visible=true;
            bai3.Visible=true;
            bai4.Visible=true;
            bai5.Visible=true;
            bai6.Visible=true;
            bai7.Visible=true;
            bai8.Visible=true;
            bai9.Visible=true;
            bai10.Visible=true;
            bai11.Visible=true;
            bai12.Visible=true;
        }

        private void bai1f(object sender, EventArgs e)
        {
            FileStream fs = new FileStream($"Documents/{current_doc}/bai1.pdf", FileMode.Open);
            Document document = new Document(fs);
            pdfViewer1.Document = document;
        }
        private void bai2f(object sender, EventArgs e)
        {
            FileStream fs = new FileStream($"Documents/{current_doc}/bai2.pdf", FileMode.Open);
            Document document = new Document(fs);
            pdfViewer1.Document = document;
        }
        private void bai3f(object sender, EventArgs e)
        {
            FileStream fs = new FileStream($"Documents/{current_doc}/bai3.pdf", FileMode.Open);
            Document document = new Document(fs);
            pdfViewer1.Document = document;
        }
        private void bai4f(object sender, EventArgs e)
        {
            FileStream fs = new FileStream($"Documents/{current_doc}/bai4.pdf", FileMode.Open);
            Document document = new Document(fs);
            pdfViewer1.Document = document;
        }
        private void bai5f(object sender, EventArgs e)
        {
            FileStream fs = new FileStream($"Documents/{current_doc}/bai5.pdf", FileMode.Open);
            Document document = new Document(fs);
            pdfViewer1.Document = document;
        }
        private void bai6f(object sender, EventArgs e)
        {
            FileStream fs = new FileStream($"Documents/{current_doc}/bai6.pdf", FileMode.Open);
            Document document = new Document(fs);
            pdfViewer1.Document = document;
        }
        private void bai7f(object sender, EventArgs e)
        {
            FileStream fs = new FileStream($"Documents/{current_doc}/bai7.pdf", FileMode.Open);
            Document document = new Document(fs);
            pdfViewer1.Document = document;
        }
        private void bai8f(object sender, EventArgs e)
        {
            FileStream fs = new FileStream($"Documents/{current_doc}/bai8.pdf", FileMode.Open);
            Document document = new Document(fs);
            pdfViewer1.Document = document;
        }
        private void bai9f(object sender, EventArgs e)
        {
            FileStream fs = new FileStream($"Documents/{current_doc}/bai9.pdf", FileMode.Open);
            Document document = new Document(fs);
            pdfViewer1.Document = document;
        }
        private void bai10f(object sender, EventArgs e)
        {
            FileStream fs = new FileStream($"Documents/{current_doc}/bai10.pdf", FileMode.Open);
            Document document = new Document(fs);
            pdfViewer1.Document = document;
        }
        private void bai11f(object sender, EventArgs e)
        {
            FileStream fs = new FileStream($"Documents/{current_doc}/bai11.pdf", FileMode.Open);
            Document document = new Document(fs);
            pdfViewer1.Document = document;
        }
        private void bai12f(object sender, EventArgs e)
        {
            FileStream fs = new FileStream($"Documents/{current_doc}/bai12.pdf", FileMode.Open);
            Document document = new Document(fs);
            pdfViewer1.Document = document;
        }
    }
}