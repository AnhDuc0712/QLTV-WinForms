using Siticone.Desktop.UI.WinForms;
using System;
using System.Drawing;
using System.Windows.Forms;

namespace Ngducanh
{
    partial class fNewAuthor
    {
        private System.ComponentModel.IContainer components = null;
        private SiticoneShadowForm shadowForm;
        private SiticoneElipse siticoneElipse1;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            shadowForm = new SiticoneShadowForm(components);
            siticoneElipse1 = new SiticoneElipse(components);
            txtName = new SiticoneTextBox();
            btnSave = new SiticoneButton();
            btnCancel = new SiticoneButton();
            toolTip1 = new ToolTip(components);
            SuspendLayout();
            // 
            // shadowForm
            // 
            shadowForm.TargetForm = this;
            // 
            // siticoneElipse1
            // 
            siticoneElipse1.TargetControl = this;
            // 
            // txtName
            // 
            txtName.BorderRadius = 10;
            txtName.DefaultText = "";
            txtName.FillColor = Color.FromArgb(28, 31, 38);
            txtName.Font = new Font("Segoe UI", 10F);
            txtName.ForeColor = Color.WhiteSmoke;
            txtName.Location = new Point(73, 13);
            txtName.Margin = new Padding(3, 4, 3, 4);
            txtName.Name = "txtName";
            txtName.PasswordChar = '\0';
            txtName.PlaceholderText = "Nhập tên tác giả...";
            txtName.SelectedText = "";
            txtName.Size = new Size(300, 30);
            txtName.TabIndex = 1;
            // 
            // btnSave
            // 
            btnSave.BorderRadius = 10;
            btnSave.FillColor = Color.FromArgb(41, 121, 255);
            btnSave.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            btnSave.ForeColor = Color.White;
            btnSave.HoverState.FillColor = Color.FromArgb(30, 100, 200);
            btnSave.Location = new Point(24, 60);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(100, 36);
            btnSave.TabIndex = 2;
            btnSave.Text = "💾 Lưu";
            btnSave.Click += btnSave_Click;
            // 
            // btnCancel
            // 
            btnCancel.BorderRadius = 10;
            btnCancel.FillColor = Color.FromArgb(192, 0, 0);
            btnCancel.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            btnCancel.ForeColor = Color.White;
            btnCancel.HoverState.FillColor = Color.FromArgb(160, 0, 0);
            btnCancel.Location = new Point(298, 60);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new Size(100, 36);
            btnCancel.TabIndex = 3;
            btnCancel.Text = "✖ Huỷ";
            btnCancel.Click += btnCancel_Click;
            // 
            // toolTip1
            // 
            toolTip1.AutoPopDelay = 5000;
            toolTip1.InitialDelay = 100;
            toolTip1.ReshowDelay = 50;
            // 
            // fNewAuthor
            // 
            BackColor = Color.FromArgb(13, 17, 23);
            ClientSize = new Size(423, 124);
            Controls.Add(txtName);
            Controls.Add(btnSave);
            Controls.Add(btnCancel);
            FormBorderStyle = FormBorderStyle.None;
            MaximizeBox = false;
            Name = "fNewAuthor";
            StartPosition = FormStartPosition.CenterParent;
            Text = "Thêm tác giả";
            Load += fNewAuthor_Load;
            ResumeLayout(false);
        }

        #region Windows Form Designer generated code
        private SiticoneTextBox txtName;
        private SiticoneButton btnSave;
        private SiticoneButton btnCancel;
        private ToolTip toolTip1;
        #endregion
    }
}