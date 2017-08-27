using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using System.Windows.Forms;
using System.IO;

namespace Direct2U
{
	/// <summary>
	/// Summary description for HaloSettings.
	/// </summary>
	public class HaloSettings : System.Windows.Forms.Form
	{
		private Direct2U.UI.Button Save;
		private Direct2U.UI.Button Cancel;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.ComboBox Using;
		private System.Windows.Forms.CheckedListBox Flags;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.Label label6;
		private System.Windows.Forms.Label label7;
		private System.Windows.Forms.TextBox Adapter;
		private System.Windows.Forms.TextBox RefreshRate;
		private System.Windows.Forms.TextBox FXFile;
		private System.Windows.Forms.TextBox IP;
		private System.Windows.Forms.TextBox CPort;
		/// <summary>
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.Container components = null;

		public HaloSettings()
		{
			//
			// Required for Windows Form Designer support
			//
			InitializeComponent();
		}

		/// <summary>
		/// Clean up any resources being used.
		/// </summary>
		protected override void Dispose( bool disposing )
		{
			if( disposing )
			{
				if(components != null)
					components.Dispose();
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
			System.Resources.ResourceManager resources = new System.Resources.ResourceManager(typeof(HaloSettings));
			this.Save = new Direct2U.UI.Button();
			this.Cancel = new Direct2U.UI.Button();
			this.label1 = new System.Windows.Forms.Label();
			this.Using = new System.Windows.Forms.ComboBox();
			this.Flags = new System.Windows.Forms.CheckedListBox();
			this.label2 = new System.Windows.Forms.Label();
			this.label3 = new System.Windows.Forms.Label();
			this.label4 = new System.Windows.Forms.Label();
			this.label5 = new System.Windows.Forms.Label();
			this.label6 = new System.Windows.Forms.Label();
			this.label7 = new System.Windows.Forms.Label();
			this.Adapter = new System.Windows.Forms.TextBox();
			this.RefreshRate = new System.Windows.Forms.TextBox();
			this.FXFile = new System.Windows.Forms.TextBox();
			this.IP = new System.Windows.Forms.TextBox();
			this.CPort = new System.Windows.Forms.TextBox();
			this.SuspendLayout();
			// 
			// Save
			// 
			this.Save.ImageOverName = "OK";
			this.Save.ImageUpName = "OK";
			this.Save.Location = new System.Drawing.Point(8, 280);
			this.Save.Name = "Save";
			this.Save.Size = new System.Drawing.Size(210, 40);
			this.Save.TabIndex = 0;
			// 
			// Cancel
			// 
			this.Cancel.ImageOverName = "Cancel";
			this.Cancel.ImageUpName = "Cancel";
			this.Cancel.Location = new System.Drawing.Point(288, 280);
			this.Cancel.Name = "Cancel";
			this.Cancel.Size = new System.Drawing.Size(210, 40);
			this.Cancel.TabIndex = 1;
			// 
			// label1
			// 
			this.label1.BackColor = System.Drawing.Color.Transparent;
			this.label1.ForeColor = System.Drawing.SystemColors.Window;
			this.label1.Location = new System.Drawing.Point(8, 16);
			this.label1.Name = "label1";
			this.label1.TabIndex = 2;
			this.label1.Text = "Use Shader:";
			this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// Using
			// 
			this.Using.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.Using.Items.AddRange(new object[] {
													   "useref",
													   "fixed function",
													   "0",
													   "1.1",
													   "1.4",
													   "2.0",
													   "2.0a"});
			this.Using.Location = new System.Drawing.Point(120, 16);
			this.Using.Name = "Using";
			this.Using.Size = new System.Drawing.Size(136, 21);
			this.Using.TabIndex = 3;
			// 
			// Flags
			// 
			this.Flags.BorderStyle = System.Windows.Forms.BorderStyle.None;
			this.Flags.CheckOnClick = true;
			this.Flags.Items.AddRange(new object[] {
													   "Console",
													   "Devmode",
													   "Safe Mode",
													   "Screenshots",
													   "No Sound",
													   "No Video",
													   "Window Mode",
													   "No Joystick",
													   "Use FX File",
													   "Override Adapter",
													   "Override Refresh Rate",
													   "Override IP",
													   "Override CPort"});
			this.Flags.Location = new System.Drawing.Point(120, 40);
			this.Flags.Name = "Flags";
			this.Flags.Size = new System.Drawing.Size(136, 195);
			this.Flags.TabIndex = 4;
			this.Flags.ThreeDCheckBoxes = true;
			this.Flags.ItemCheck += new System.Windows.Forms.ItemCheckEventHandler(this.OnItemCheck);
			// 
			// label2
			// 
			this.label2.BackColor = System.Drawing.Color.Transparent;
			this.label2.ForeColor = System.Drawing.SystemColors.Window;
			this.label2.Location = new System.Drawing.Point(8, 40);
			this.label2.Name = "label2";
			this.label2.TabIndex = 5;
			this.label2.Text = "Flags:";
			this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// label3
			// 
			this.label3.BackColor = System.Drawing.Color.Transparent;
			this.label3.ForeColor = System.Drawing.SystemColors.Window;
			this.label3.Location = new System.Drawing.Point(264, 16);
			this.label3.Name = "label3";
			this.label3.TabIndex = 6;
			this.label3.Text = "Adapter:";
			this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// label4
			// 
			this.label4.BackColor = System.Drawing.Color.Transparent;
			this.label4.ForeColor = System.Drawing.SystemColors.Window;
			this.label4.Location = new System.Drawing.Point(264, 40);
			this.label4.Name = "label4";
			this.label4.TabIndex = 7;
			this.label4.Text = "Refresh Rate:";
			this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// label5
			// 
			this.label5.BackColor = System.Drawing.Color.Transparent;
			this.label5.ForeColor = System.Drawing.SystemColors.Window;
			this.label5.Location = new System.Drawing.Point(264, 64);
			this.label5.Name = "label5";
			this.label5.TabIndex = 8;
			this.label5.Text = "FX File:";
			this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// label6
			// 
			this.label6.BackColor = System.Drawing.Color.Transparent;
			this.label6.ForeColor = System.Drawing.SystemColors.Window;
			this.label6.Location = new System.Drawing.Point(264, 88);
			this.label6.Name = "label6";
			this.label6.TabIndex = 9;
			this.label6.Text = "IP:";
			this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// label7
			// 
			this.label7.BackColor = System.Drawing.Color.Transparent;
			this.label7.ForeColor = System.Drawing.SystemColors.Window;
			this.label7.Location = new System.Drawing.Point(264, 112);
			this.label7.Name = "label7";
			this.label7.TabIndex = 10;
			this.label7.Text = "CPort:";
			this.label7.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// Adapter
			// 
			this.Adapter.Location = new System.Drawing.Point(368, 16);
			this.Adapter.Name = "Adapter";
			this.Adapter.Size = new System.Drawing.Size(136, 20);
			this.Adapter.TabIndex = 11;
			this.Adapter.Text = "";
			// 
			// RefreshRate
			// 
			this.RefreshRate.Location = new System.Drawing.Point(368, 40);
			this.RefreshRate.Name = "RefreshRate";
			this.RefreshRate.Size = new System.Drawing.Size(136, 20);
			this.RefreshRate.TabIndex = 12;
			this.RefreshRate.Text = "";
			// 
			// FXFile
			// 
			this.FXFile.Location = new System.Drawing.Point(368, 64);
			this.FXFile.Name = "FXFile";
			this.FXFile.Size = new System.Drawing.Size(136, 20);
			this.FXFile.TabIndex = 13;
			this.FXFile.Text = "";
			// 
			// IP
			// 
			this.IP.Location = new System.Drawing.Point(368, 88);
			this.IP.Name = "IP";
			this.IP.Size = new System.Drawing.Size(136, 20);
			this.IP.TabIndex = 14;
			this.IP.Text = "";
			// 
			// CPort
			// 
			this.CPort.Location = new System.Drawing.Point(368, 112);
			this.CPort.Name = "CPort";
			this.CPort.Size = new System.Drawing.Size(136, 20);
			this.CPort.TabIndex = 15;
			this.CPort.Text = "";
			// 
			// HaloSettings
			// 
			this.AutoScaleBaseSize = new System.Drawing.Size(5, 13);
			this.ClientSize = new System.Drawing.Size(512, 328);
			this.Controls.Add(this.CPort);
			this.Controls.Add(this.IP);
			this.Controls.Add(this.FXFile);
			this.Controls.Add(this.RefreshRate);
			this.Controls.Add(this.Adapter);
			this.Controls.Add(this.label7);
			this.Controls.Add(this.label6);
			this.Controls.Add(this.label5);
			this.Controls.Add(this.label4);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.Flags);
			this.Controls.Add(this.Using);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.Cancel);
			this.Controls.Add(this.Save);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.MaximizeBox = false;
			this.MinimizeBox = false;
			this.Name = "HaloSettings";
			this.ShowInTaskbar = false;
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
			this.Text = "HaloSettings";
			this.ResumeLayout(false);

		}
		#endregion

		private void OnItemCheck(object sender, System.Windows.Forms.ItemCheckEventArgs e)
		{
		}
	};

	public class HaloParameters
	{
		public enum UseShader : byte
		{
			UseRef,
			UseFF,
			Use00,
			Use11,
			Use14,
			Use20,
			Use2A,
		};
		public UseShader Using = UseShader.Use14;

		[Flags()]
		public enum Flags : short
		{
			Console = 1,
			Devmode = 2,
			SafeMode = 4,
			ScreenShot = 8,
			NoSound = 16,
			NoVideo = 32,
			Window = 64,
			NoJoyStick = 128,
			UseFXFile = 256,
			Adapter = 512,
			Refresh = 1024,
			IP = 2048,
			CPort = 4096,
		};
		Flags ParamFlags;

		public string FXFile = "";

		public string Adapter = "";

		public string Refresh = "";

		public string IP = "";

		public string CPort = "";

		public void Load(string file)
		{
			BinaryReader br = new BinaryReader(new StreamReader(file));
			ParamFlags = (Flags)br.ReadInt16();

			if(Globals.HasFlag(ParamFlags, Flags.Adapter))
				Adapter = br.ReadString();
		}

		public void Save(string file)
		{
		}
	};
}