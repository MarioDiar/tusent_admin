using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using System.Windows.Forms;
using System.Data;
using System.IO;

namespace tusent_admin
{
	/// <summary>
	/// Summary description for Form1.
	/// </summary>
	public class Form1 : System.Windows.Forms.Form
	{
		// Settings path
		public static string settingsPath = Environment.GetFolderPath(Environment.SpecialFolder.Desktop) + @"\scanner_type.txt";

		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Button buttonMicrImage;
		private System.Windows.Forms.Button buttonImageSafe;
		/// <summary>
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.Container components = null;

		public Form1()
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
				if (components != null) 
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
			this.buttonMicrImage = new System.Windows.Forms.Button();
			this.buttonImageSafe = new System.Windows.Forms.Button();
			this.label1 = new System.Windows.Forms.Label();
			this.SuspendLayout();
			// 
			// buttonMicrImage
			// 
			this.buttonMicrImage.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.buttonMicrImage.Location = new System.Drawing.Point(160, 136);
			this.buttonMicrImage.Name = "buttonMicrImage";
			this.buttonMicrImage.Size = new System.Drawing.Size(128, 48);
			this.buttonMicrImage.TabIndex = 0;
			this.buttonMicrImage.Text = "MicrImage";
			this.buttonMicrImage.Click += new System.EventHandler(this.buttonMicrImage_Click);
			// 
			// buttonImageSafe
			// 
			this.buttonImageSafe.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.buttonImageSafe.Location = new System.Drawing.Point(312, 136);
			this.buttonImageSafe.Name = "buttonImageSafe";
			this.buttonImageSafe.Size = new System.Drawing.Size(120, 48);
			this.buttonImageSafe.TabIndex = 1;
			this.buttonImageSafe.Text = "ImageSafe";
			this.buttonImageSafe.Click += new System.EventHandler(this.buttonImageSafe_Click);
			// 
			// label1
			// 
			this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.label1.Location = new System.Drawing.Point(232, 80);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(136, 23);
			this.label1.TabIndex = 2;
			this.label1.Text = "Scanners ADMIN Select the scanner type that will be used in this computer.";
			this.label1.Click += new System.EventHandler(this.label1_Click);
			// 
			// Form1
			// 
			this.AutoScaleBaseSize = new System.Drawing.Size(5, 13);
			this.ClientSize = new System.Drawing.Size(608, 346);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.buttonImageSafe);
			this.Controls.Add(this.buttonMicrImage);
			this.Name = "Form1";
			this.Text = "Form1";
			this.ResumeLayout(false);

		}
		#endregion

		/// <summary>
		/// The main entry point for the application.
		/// </summary>
		[STAThread]
		static void Main() 
		{
			Application.Run(new Form1());
		}

		// Saving the settings file
		private static void Save_Settings(string scannerType)
		{
			using (StreamWriter sw = new StreamWriter(settingsPath))
			{
				if (Validate_Scanner_Type(scannerType))
				{
					sw.WriteLine(scannerType);
					savedScannerType = scannerType;
				}
			}
		}

		private static bool Validate_Scanner_Type(string scannerType)
		{
			return (scannerType == "MicrImage" || scannerType == "ImageSafe");
		}


		private void label1_Click(object sender, System.EventArgs e)
		{
		
		}

		private void buttonMicrImage_Click(object sender, System.EventArgs e)
		{
			Save_Settings("MicrImage");		
		}

		private void buttonImageSafe_Click(object sender, System.EventArgs e)
		{
			Save_Settings("ImageSafe");
		}
	}
}
