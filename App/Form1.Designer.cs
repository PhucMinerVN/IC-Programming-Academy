using System.Windows.Forms;
using System.IO;

namespace App
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            flowLayoutPanel1 = new FlowLayoutPanel();
            flowLayoutPanel2 = new FlowLayoutPanel();
            button1 = new Button();
            button2 = new Button();
            button3 = new Button();
            pdfViewer1 = new Apitron.PDF.Controls.PDFViewer();
            flowLayoutPanel2.SuspendLayout();
            SuspendLayout();
            // 
            // flowLayoutPanel1
            // 
            flowLayoutPanel1.BackColor = Color.FromArgb(21, 23, 31);
            resources.ApplyResources(flowLayoutPanel1, "flowLayoutPanel1");
            flowLayoutPanel1.Name = "flowLayoutPanel1";
            // 
            // flowLayoutPanel2
            // 
            flowLayoutPanel2.BackColor = Color.FromArgb(21, 23, 31);
            flowLayoutPanel2.Controls.Add(button1);
            flowLayoutPanel2.Controls.Add(button2);
            flowLayoutPanel2.Controls.Add(button3);
            resources.ApplyResources(flowLayoutPanel2, "flowLayoutPanel2");
            flowLayoutPanel2.Name = "flowLayoutPanel2";
            flowLayoutPanel2.Paint += flowLayoutPanel2_Paint;
            // 
            // button1
            // 
            resources.ApplyResources(button1, "button1");
            button1.ForeColor = SystemColors.Control;
            button1.Name = "button1";
            button1.UseVisualStyleBackColor = false;
            // 
            // button2
            // 
            resources.ApplyResources(button2, "button2");
            button2.ForeColor = SystemColors.ButtonFace;
            button2.Name = "button2";
            button2.UseVisualStyleBackColor = false;
            // 
            // button3
            // 
            resources.ApplyResources(button3, "button3");
            button3.ForeColor = SystemColors.ButtonFace;
            button3.Name = "button3";
            button3.UseVisualStyleBackColor = false;
            // 
            // pdfViewer1
            // 
            resources.ApplyResources(pdfViewer1, "pdfViewer1");
            FileStream fs = new FileStream("D:\\ICLab\\IPA\\Python.pdf", FileMode.Open);
            pdfViewer1.Document = new Apitron.PDF.Rasterizer.Document(fs);
            pdfViewer1.EnableSearch = true;
            pdfViewer1.Name = "pdfViewer1";
            pdfViewer1.RenderingQuality = Apitron.PDF.Controls.RenderingQuality.High;
            pdfViewer1.SearchHighlightColor = Color.FromArgb(128, 255, 255, 0);
            // 
            // Form1
            // 
            resources.ApplyResources(this, "$this");
            AutoScaleMode = AutoScaleMode.Font;
            AutoValidate = AutoValidate.EnablePreventFocusChange;
            Controls.Add(flowLayoutPanel2);
            Controls.Add(flowLayoutPanel1);
            Controls.Add(pdfViewer1);
            Name = "Form1";
            WindowState = FormWindowState.Maximized;
            flowLayoutPanel2.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private FlowLayoutPanel flowLayoutPanel1;
        private FlowLayoutPanel flowLayoutPanel2;
        private Button button1;
        private Button button2;
        private Button button3;
        private Apitron.PDF.Controls.PDFViewer pdfViewer1;
    }
}