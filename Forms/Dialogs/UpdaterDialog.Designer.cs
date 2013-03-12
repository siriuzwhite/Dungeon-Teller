namespace Dungeon_Teller.Forms.Dialogs
{
	partial class UpdaterDialog
	{
		/// <summary>
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		/// Clean up any resources being used.
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
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			this.components = new System.ComponentModel.Container();
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UpdaterDialog));
			this.btn_no = new System.Windows.Forms.Button();
			this.panel1 = new System.Windows.Forms.Panel();
			this.lbl_desc = new System.Windows.Forms.Label();
			this.lbl_heading = new System.Windows.Forms.Label();
			this.pic_image = new System.Windows.Forms.PictureBox();
			this.btn_yes = new System.Windows.Forms.Button();
			this.link_rep = new System.Windows.Forms.LinkLabel();
			this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
			this.panel1.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.pic_image)).BeginInit();
			this.SuspendLayout();
			// 
			// btn_no
			// 
			this.btn_no.DialogResult = System.Windows.Forms.DialogResult.Cancel;
			this.btn_no.Location = new System.Drawing.Point(265, 91);
			this.btn_no.Name = "btn_no";
			this.btn_no.Size = new System.Drawing.Size(75, 23);
			this.btn_no.TabIndex = 1;
			this.btn_no.Text = "No";
			this.btn_no.UseVisualStyleBackColor = true;
			// 
			// panel1
			// 
			this.panel1.BackColor = System.Drawing.Color.White;
			this.panel1.Controls.Add(this.lbl_desc);
			this.panel1.Controls.Add(this.lbl_heading);
			this.panel1.Controls.Add(this.pic_image);
			this.panel1.Location = new System.Drawing.Point(0, 0);
			this.panel1.Name = "panel1";
			this.panel1.Size = new System.Drawing.Size(354, 85);
			this.panel1.TabIndex = 4;
			// 
			// lbl_desc
			// 
			this.lbl_desc.AutoSize = true;
			this.lbl_desc.Location = new System.Drawing.Point(84, 39);
			this.lbl_desc.MaximumSize = new System.Drawing.Size(250, 35);
			this.lbl_desc.Name = "lbl_desc";
			this.lbl_desc.Size = new System.Drawing.Size(238, 26);
			this.lbl_desc.TabIndex = 2;
			this.lbl_desc.Text = "New offsets for WoW 5.2.0.16683 are available, Do you want to download them?";
			this.lbl_desc.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// lbl_heading
			// 
			this.lbl_heading.AutoSize = true;
			this.lbl_heading.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
			this.lbl_heading.ForeColor = System.Drawing.SystemColors.Highlight;
			this.lbl_heading.Location = new System.Drawing.Point(82, 9);
			this.lbl_heading.Name = "lbl_heading";
			this.lbl_heading.Size = new System.Drawing.Size(174, 26);
			this.lbl_heading.TabIndex = 1;
			this.lbl_heading.Text = "Update available";
			this.lbl_heading.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// pic_image
			// 
			this.pic_image.Image = global::Dungeon_Teller.Properties.Resources.download;
			this.pic_image.Location = new System.Drawing.Point(12, 10);
			this.pic_image.Name = "pic_image";
			this.pic_image.Size = new System.Drawing.Size(64, 64);
			this.pic_image.TabIndex = 0;
			this.pic_image.TabStop = false;
			// 
			// btn_yes
			// 
			this.btn_yes.DialogResult = System.Windows.Forms.DialogResult.OK;
			this.btn_yes.Location = new System.Drawing.Point(181, 90);
			this.btn_yes.Name = "btn_yes";
			this.btn_yes.Size = new System.Drawing.Size(75, 23);
			this.btn_yes.TabIndex = 5;
			this.btn_yes.Text = "Yes";
			this.btn_yes.UseVisualStyleBackColor = true;
			// 
			// link_rep
			// 
			this.link_rep.AutoSize = true;
			this.link_rep.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.link_rep.Location = new System.Drawing.Point(12, 96);
			this.link_rep.Name = "link_rep";
			this.link_rep.RightToLeft = System.Windows.Forms.RightToLeft.No;
			this.link_rep.Size = new System.Drawing.Size(33, 13);
			this.link_rep.TabIndex = 73;
			this.link_rep.TabStop = true;
			this.link_rep.Text = "+Rep";
			this.toolTip1.SetToolTip(this.link_rep, "Add some Reputation on OwnedCore to me :-)");
			this.link_rep.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.link_rep_LinkClicked);
			// 
			// UpdaterDialog
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(352, 125);
			this.Controls.Add(this.link_rep);
			this.Controls.Add(this.btn_yes);
			this.Controls.Add(this.panel1);
			this.Controls.Add(this.btn_no);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.MaximizeBox = false;
			this.MinimizeBox = false;
			this.Name = "UpdaterDialog";
			this.ShowInTaskbar = false;
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Dungeon Teller - Updater";
			this.TopMost = true;
			this.panel1.ResumeLayout(false);
			this.panel1.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.pic_image)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Button btn_no;
		private System.Windows.Forms.Panel panel1;
		private System.Windows.Forms.Label lbl_desc;
		private System.Windows.Forms.Label lbl_heading;
		private System.Windows.Forms.PictureBox pic_image;
		private System.Windows.Forms.Button btn_yes;
		private System.Windows.Forms.LinkLabel link_rep;
		private System.Windows.Forms.ToolTip toolTip1;
	}
}