﻿using System.Windows.Forms;
using System.IO;
using System.DirectoryServices;
using Apitron.PDF.Rasterizer;

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
            flowLayoutPanel3 = new FlowLayoutPanel();
            bai1 = new Button();
            flowLayoutPanel2 = new FlowLayoutPanel();
            button1 = new Button();
            button2 = new Button();
            pdfViewer1 = new Apitron.PDF.Controls.PDFViewer();
            bai2 = new Button();
            bai3 = new Button();
            bai4 = new Button();
            bai5 = new Button();
            bai6 = new Button();
            bai7 = new Button();
            bai8 = new Button();
            bai9 = new Button();
            bai10 = new Button();
            bai11 = new Button();
            bai12 = new Button();
            flowLayoutPanel1.SuspendLayout();
            flowLayoutPanel3.SuspendLayout();
            flowLayoutPanel2.SuspendLayout();
            SuspendLayout();
            // 
            // flowLayoutPanel1
            // 
            flowLayoutPanel1.BackColor = Color.FromArgb(21, 23, 31);
            flowLayoutPanel1.Controls.Add(flowLayoutPanel3);
            resources.ApplyResources(flowLayoutPanel1, "flowLayoutPanel1");
            flowLayoutPanel1.Name = "flowLayoutPanel1";
            // 
            // flowLayoutPanel3
            // 
            flowLayoutPanel3.Controls.Add(bai1);
            flowLayoutPanel3.Controls.Add(bai2);
            flowLayoutPanel3.Controls.Add(bai3);
            flowLayoutPanel3.Controls.Add(bai4);
            flowLayoutPanel3.Controls.Add(bai5);
            flowLayoutPanel3.Controls.Add(bai6);
            flowLayoutPanel3.Controls.Add(bai7);
            flowLayoutPanel3.Controls.Add(bai8);
            flowLayoutPanel3.Controls.Add(bai9);
            flowLayoutPanel3.Controls.Add(bai10);
            flowLayoutPanel3.Controls.Add(bai11);
            flowLayoutPanel3.Controls.Add(bai12);
            resources.ApplyResources(flowLayoutPanel3, "flowLayoutPanel3");
            flowLayoutPanel3.Name = "flowLayoutPanel3";
            // 
            // button3
            // 
            resources.ApplyResources(bai1, "button3");
            bai1.ForeColor = SystemColors.ButtonFace;
            bai1.Name = "button3";
            bai1.UseVisualStyleBackColor = false;
            bai1.Click += bai1f;
            // 
            // flowLayoutPanel2
            // 
            flowLayoutPanel2.BackColor = Color.FromArgb(21, 23, 31);
            flowLayoutPanel2.Controls.Add(button1);
            flowLayoutPanel2.Controls.Add(button2);
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
            button1.Click += button1_Click;
            // 
            // button2
            // 
            resources.ApplyResources(button2, "button2");
            button2.ForeColor = SystemColors.ButtonFace;
            button2.Name = "button2";
            button2.UseVisualStyleBackColor = false;
            button2.Click += button2_Click;
            // 
            // pdfViewer1
            // 
            resources.ApplyResources(pdfViewer1, "pdfViewer1");
            pdfViewer1.Document = null;
            pdfViewer1.EnableSearch = true;
            pdfViewer1.Name = "pdfViewer1";
            pdfViewer1.Dock=DockStyle.Bottom;
            pdfViewer1.Anchor=AnchorStyles.Top|AnchorStyles.Bottom|AnchorStyles.Left|AnchorStyles.Right;
            pdfViewer1.RenderingQuality = Apitron.PDF.Controls.RenderingQuality.High;
            pdfViewer1.SearchHighlightColor = Color.FromArgb(128, 255, 255, 0);
            
            // 
            // button4
            // 
            resources.ApplyResources(bai2, "button4");
            bai2.ForeColor = SystemColors.ButtonFace;
            bai2.Name = "button4";
            bai2.UseVisualStyleBackColor = false;
            bai2.Click += bai2f;
            // 
            // button5
            // 
            resources.ApplyResources(bai3, "button5");
            bai3.ForeColor = SystemColors.ButtonFace;
            bai3.Name = "button5";
            bai3.UseVisualStyleBackColor = false;
            bai3.Click += bai3f;
            // 
            // button6
            // 
            resources.ApplyResources(bai4, "button6");
            bai4.ForeColor = SystemColors.ButtonFace;
            bai4.Name = "button6";
            bai4.UseVisualStyleBackColor = false;
            bai4.Click += bai4f;
            // 
            // button7
            // 
            resources.ApplyResources(bai5, "button7");
            bai5.ForeColor = SystemColors.ButtonFace;
            bai5.Name = "button7";
            bai5.UseVisualStyleBackColor = false;
            bai5.Click += bai5f;
            // 
            // button8
            // 
            resources.ApplyResources(bai6, "button8");
            bai6.ForeColor = SystemColors.ButtonFace;
            bai6.Name = "button8";
            bai6.UseVisualStyleBackColor = false;
            bai6.Click += bai6f;
            // 
            // button9
            // 
            resources.ApplyResources(bai7, "button9");
            bai7.ForeColor = SystemColors.ButtonFace;
            bai7.Name = "button9";
            bai7.UseVisualStyleBackColor = false;
            bai7.Click += bai7f;
            // 
            // button10
            // 
            resources.ApplyResources(bai8, "button10");
            bai8.ForeColor = SystemColors.ButtonFace;
            bai8.Name = "button10";
            bai8.UseVisualStyleBackColor = false;
            bai8.Click += bai8f;
            // 
            // button11
            // 
            resources.ApplyResources(bai9, "button11");
            bai9.ForeColor = SystemColors.ButtonFace;
            bai9.Name = "button11";
            bai9.UseVisualStyleBackColor = false;
            bai9.Click += bai9f;
            // 
            // button12
            // 
            resources.ApplyResources(bai10, "button12");
            bai10.ForeColor = SystemColors.ButtonFace;
            bai10.Name = "button12";
            bai10.UseVisualStyleBackColor = false;
            bai10.Click += bai10f;
            // 
            // button13
            // 
            resources.ApplyResources(bai11, "button13");
            bai11.ForeColor = SystemColors.ButtonFace;
            bai11.Name = "button13";
            bai11.UseVisualStyleBackColor = false;
            bai11.Click += bai11f;
            // 
            // button14
            // 
            resources.ApplyResources(bai12, "button14");
            bai12.ForeColor = SystemColors.ButtonFace;
            bai12.Name = "button14";
            bai12.UseVisualStyleBackColor = false;
            bai12.Click += bai12f;

            bai1.Visible=false;
            bai2.Visible=false;
            bai3.Visible=false;
            bai4.Visible=false;
            bai5.Visible=false;
            bai6.Visible=false;
            bai7.Visible=false;
            bai8.Visible=false;
            bai9.Visible=false;
            bai10.Visible=false;
            bai11.Visible=false;
            bai12.Visible=false;

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
            Load += Form1_Load;
            flowLayoutPanel1.ResumeLayout(false);
            flowLayoutPanel3.ResumeLayout(false);
            flowLayoutPanel2.ResumeLayout(false);
            ResumeLayout(false);
        }

        private void Button3_Click(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        #endregion
        private FlowLayoutPanel flowLayoutPanel1;
        private FlowLayoutPanel flowLayoutPanel2;
        private Button button1;
        private Button button2;
        private Apitron.PDF.Controls.PDFViewer pdfViewer1;
        private FlowLayoutPanel flowLayoutPanel3;
        private Button bai1;
        private Button bai2;
        private Button bai3;
        private Button bai4;
        private Button bai5;
        private Button bai6;
        private Button bai7;
        private Button bai8;
        private Button bai9;
        private Button bai10;
        private Button bai11;
        private Button bai12;
    }
}