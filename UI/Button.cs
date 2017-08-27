using System;
using System.Collections;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Windows.Forms;

namespace Direct2U.UI
{
	/// <summary>
	/// A Halo 1 style UI Button
	/// </summary>
	public class Button : System.Windows.Forms.UserControl
	{
		private System.Windows.Forms.PictureBox ButtonPicture;
		/// <summary> 
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.Container components = null;

		#region ImageOver
		protected Image ImageOver = null;
		string imageOverName = null;
		public string ImageOverName
		{
			get { return imageOverName; }
			set { imageOverName = value; }
		}
		#endregion

		#region ImageUp
		protected Image ImageUp = null;
		string imageUpName = null;
		public string ImageUpName
		{
			get { return imageUpName; }
			set { imageUpName = value; }
		}
		#endregion

		public event System.EventHandler ClickButton;

		public Button()
		{
			// This call is required by the Windows.Forms Form Designer.
			InitializeComponent();

			#region Load ImageOver
			if(ImageOverName == null || ImageOverName == "")
				return;
			ImageOver = Globals.LoadImage(ImageOverName + "Over.gif");

			if(ImageOver == null)
				return;
			#endregion

			#region Load ImageUpName
			if(ImageUpName == null || ImageUpName == "")
				return;
			ImageUp = Globals.LoadImage(ImageUpName + "Up.gif");

			if(ImageUp == null)
				return;

			ButtonPicture.Image = ImageUp;
			#endregion
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

		#region Component Designer generated code
		/// <summary> 
		/// Required method for Designer support - do not modify 
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			this.ButtonPicture = new System.Windows.Forms.PictureBox();
			this.SuspendLayout();
			// 
			// ButtonPicture
			// 
			this.ButtonPicture.Dock = System.Windows.Forms.DockStyle.Fill;
			this.ButtonPicture.Location = new System.Drawing.Point(0, 0);
			this.ButtonPicture.Name = "ButtonPicture";
			this.ButtonPicture.Size = new System.Drawing.Size(210, 40);
			this.ButtonPicture.TabIndex = 0;
			this.ButtonPicture.TabStop = false;
			this.ButtonPicture.Click += new System.EventHandler(this.OnButtonClick);
			this.ButtonPicture.MouseEnter += new System.EventHandler(this.OnButtonMouseEnter);
			this.ButtonPicture.MouseUp += new System.Windows.Forms.MouseEventHandler(this.OnButtonMouseUp);
			this.ButtonPicture.MouseLeave += new System.EventHandler(this.OnButtonMouseLeave);
			this.ButtonPicture.MouseDown += new System.Windows.Forms.MouseEventHandler(this.OnButtonMouseDown);
			// 
			// Button
			// 
			this.Controls.Add(this.ButtonPicture);
			this.Name = "Button";
			this.Size = new System.Drawing.Size(210, 40);
			this.ResumeLayout(false);

		}
		#endregion

		private void OnButtonClick(object sender, System.EventArgs e)
		{
			if(ClickButton != null)
				ClickButton(this, null);
		}

		private void OnButtonMouseEnter(object sender, System.EventArgs e)
		{
			ButtonPicture.Image = ImageOver;
		}

		private void OnButtonMouseLeave(object sender, System.EventArgs e)
		{
			ButtonPicture.Image = ImageUp;
		}

		private void OnButtonMouseUp(object sender, System.Windows.Forms.MouseEventArgs e)
		{
			ButtonPicture.Image = ImageOver;
		}

		private void OnButtonMouseDown(object sender, System.Windows.Forms.MouseEventArgs e)
		{
			ButtonPicture.Image = ImageUp;
		}
	}
}