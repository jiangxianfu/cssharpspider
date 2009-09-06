using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using System.Windows.Forms;
using System.Threading;

namespace Spider
{
	/// <summary>
	/// Provide a form to test the spider with.
	/// 
	/// This spider is copyright 2003 by Jeff Heaton. However, it is
	/// released under a Limited GNU Public License (LGPL). You may 
	/// use it freely in your own programs. For the latest version visit
	/// http://www.jeffheaton.com.

	/// </summary>
	public class SpiderForm : System.Windows.Forms.Form
	{
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.TextBox targetURL;
		private System.Windows.Forms.TextBox threadCount;
		private System.Windows.Forms.Button begin;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Panel panel1;
		private System.Windows.Forms.Label currentURL;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.Label label6;
		private System.Windows.Forms.Label processedURLs;
		private System.Windows.Forms.Label elapsed;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.TextBox outputDir;

		private Spider m_spider;

		/// <summary>
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.Container components = null;

		public SpiderForm()
		{
			//
			// Required for Windows Form Designer support
			//
			InitializeComponent();

			//
			// TODO: Add any constructor code after InitializeComponent call
			//
		}

		/// <summary>
		/// Clean up any resources being used.
		/// </summary>
		protected override void Dispose( bool disposing )
		{
			if( disposing )
			{
				if(components != null)
				{
					components.Dispose();
				}
			}
			base.Dispose( disposing );
		}

		#region Windows Form Designer generated code
		/// <summary>
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			this.label1 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.targetURL = new System.Windows.Forms.TextBox();
			this.threadCount = new System.Windows.Forms.TextBox();
			this.begin = new System.Windows.Forms.Button();
			this.label3 = new System.Windows.Forms.Label();
			this.panel1 = new System.Windows.Forms.Panel();
			this.elapsed = new System.Windows.Forms.Label();
			this.processedURLs = new System.Windows.Forms.Label();
			this.label6 = new System.Windows.Forms.Label();
			this.label5 = new System.Windows.Forms.Label();
			this.currentURL = new System.Windows.Forms.Label();
			this.outputDir = new System.Windows.Forms.TextBox();
			this.label4 = new System.Windows.Forms.Label();
			this.panel1.SuspendLayout();
			this.SuspendLayout();
			// 
			// label1
			// 
			this.label1.Font = new System.Drawing.Font("����", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(134)));
			this.label1.Location = new System.Drawing.Point(8, 9);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(120, 24);
			this.label1.TabIndex = 0;
			this.label1.Text = "Ҫ���ص�URL��";
			this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// label2
			// 
			this.label2.Font = new System.Drawing.Font("����", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(134)));
			this.label2.Location = new System.Drawing.Point(8, 52);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(120, 24);
			this.label2.TabIndex = 1;
			this.label2.Text = "�߳�������";
			this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// targetURL
			// 
			this.targetURL.Font = new System.Drawing.Font("����", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(134)));
			this.targetURL.Location = new System.Drawing.Point(136, 9);
			this.targetURL.Name = "targetURL";
			this.targetURL.Size = new System.Drawing.Size(264, 22);
			this.targetURL.TabIndex = 2;
			this.targetURL.Text = "http://www.wwf.org.hk/chi/index.html";
			// 
			// threadCount
			// 
			this.threadCount.Font = new System.Drawing.Font("����", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(134)));
			this.threadCount.Location = new System.Drawing.Point(136, 43);
			this.threadCount.Name = "threadCount";
			this.threadCount.Size = new System.Drawing.Size(264, 22);
			this.threadCount.TabIndex = 3;
			this.threadCount.Text = "20";
			// 
			// begin
			// 
			this.begin.Font = new System.Drawing.Font("����", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(134)));
			this.begin.Location = new System.Drawing.Point(224, 112);
			this.begin.Name = "begin";
			this.begin.Size = new System.Drawing.Size(90, 25);
			this.begin.TabIndex = 4;
			this.begin.Text = "Begin";
			this.begin.Click += new System.EventHandler(this.begin_Click);
			// 
			// label3
			// 
			this.label3.Font = new System.Drawing.Font("����", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(134)));
			this.label3.Location = new System.Drawing.Point(16, 9);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(112, 17);
			this.label3.TabIndex = 5;
			this.label3.Text = "��ǰ�����URL��";
			this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// panel1
			// 
			this.panel1.Controls.Add(this.elapsed);
			this.panel1.Controls.Add(this.processedURLs);
			this.panel1.Controls.Add(this.label6);
			this.panel1.Controls.Add(this.label5);
			this.panel1.Controls.Add(this.currentURL);
			this.panel1.Controls.Add(this.label3);
			this.panel1.Font = new System.Drawing.Font("����", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(134)));
			this.panel1.Location = new System.Drawing.Point(8, 146);
			this.panel1.Name = "panel1";
			this.panel1.Size = new System.Drawing.Size(400, 130);
			this.panel1.TabIndex = 6;
			// 
			// elapsed
			// 
			this.elapsed.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.elapsed.Font = new System.Drawing.Font("����", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(134)));
			this.elapsed.Location = new System.Drawing.Point(144, 86);
			this.elapsed.Name = "elapsed";
			this.elapsed.Size = new System.Drawing.Size(248, 17);
			this.elapsed.TabIndex = 10;
			this.elapsed.Text = "...";
			// 
			// processedURLs
			// 
			this.processedURLs.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.processedURLs.Font = new System.Drawing.Font("����", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(134)));
			this.processedURLs.Location = new System.Drawing.Point(144, 52);
			this.processedURLs.Name = "processedURLs";
			this.processedURLs.Size = new System.Drawing.Size(248, 17);
			this.processedURLs.TabIndex = 9;
			this.processedURLs.Text = "...";
			// 
			// label6
			// 
			this.label6.Font = new System.Drawing.Font("����", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(134)));
			this.label6.Location = new System.Drawing.Point(10, 86);
			this.label6.Name = "label6";
			this.label6.Size = new System.Drawing.Size(124, 17);
			this.label6.TabIndex = 8;
			this.label6.Text = "����ʱ�䣺";
			this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// label5
			// 
			this.label5.Font = new System.Drawing.Font("����", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(134)));
			this.label5.Location = new System.Drawing.Point(10, 47);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(124, 18);
			this.label5.TabIndex = 7;
			this.label5.Text = "�Ѵ����URL��";
			this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// currentURL
			// 
			this.currentURL.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.currentURL.Font = new System.Drawing.Font("����", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(134)));
			this.currentURL.Location = new System.Drawing.Point(144, 9);
			this.currentURL.Name = "currentURL";
			this.currentURL.Size = new System.Drawing.Size(248, 17);
			this.currentURL.TabIndex = 6;
			this.currentURL.Text = "...";
			// 
			// outputDir
			// 
			this.outputDir.Font = new System.Drawing.Font("����", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(134)));
			this.outputDir.Location = new System.Drawing.Point(136, 78);
			this.outputDir.Name = "outputDir";
			this.outputDir.Size = new System.Drawing.Size(264, 22);
			this.outputDir.TabIndex = 8;
			this.outputDir.Text = "c:\\temp\\";
			// 
			// label4
			// 
			this.label4.Font = new System.Drawing.Font("����", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(134)));
			this.label4.Location = new System.Drawing.Point(8, 86);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(120, 25);
			this.label4.TabIndex = 7;
			this.label4.Text = "���Ŀ¼��";
			this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// SpiderForm
			// 
			this.AutoScaleBaseSize = new System.Drawing.Size(6, 14);
			this.ClientSize = new System.Drawing.Size(416, 290);
			this.Controls.Add(this.outputDir);
			this.Controls.Add(this.threadCount);
			this.Controls.Add(this.targetURL);
			this.Controls.Add(this.label4);
			this.Controls.Add(this.panel1);
			this.Controls.Add(this.begin);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.label1);
			this.Name = "SpiderForm";
			this.Text = "Internet֩�� 1.0";
			this.Closing += new System.ComponentModel.CancelEventHandler(this.SpiderForm_Close);
			this.Load += new System.EventHandler(this.SpiderForm_Load);
			this.panel1.ResumeLayout(false);
			this.ResumeLayout(false);

		}
		#endregion

		private void begin_Click(object sender, System.EventArgs e)
		{
			ThreadStart starter = new ThreadStart(this.SpiderThread);
			Thread spider = new Thread(starter);
			spider.Start();
		}

		public void SpiderThread()
		{
			if( begin.Text.Equals("Cancel") )
			{
				m_spider.Quit = true;
				begin.Enabled = false;
			}
			else
			{
				begin.Text = "Cancel";
				targetURL.Enabled = false;
				threadCount.Enabled = false;
				outputDir.Enabled = false;

				m_spider = new Spider();
				m_spider.ReportTo = this;
				m_spider.OutputPath = outputDir.Text;
				int threads = int.Parse( threadCount.Text);
				if(threads<1)
					threads = 1;
				threadCount.Text = ""+threads;
				try
				{
					m_spider.Start(new Uri(this.targetURL.Text),threads);
				}
				catch( UriFormatException ex)
				{
					System.Windows.Forms.MessageBox.Show( ex.Message );
					return;
				}

				begin.Text = "Begin";
				targetURL.Enabled = true;
				threadCount.Enabled = true;
				outputDir.Enabled = true;
				begin.Enabled = true;
			}

		}

		public void SetLastURL(string str)
		{
			currentURL.Text = str;
		}

		public void SetElapsedTime(string str)
		{
			elapsed.Text = str;
		}

		public void SetProcessedCount(string str)
		{
			processedURLs.Text = str;
		}

		private void SpiderForm_Close(object sender, CancelEventArgs e)
		{
			Application.Exit();
		}

		private void SpiderForm_Load(object sender, System.EventArgs e)
		{
		
		}



	}
}
