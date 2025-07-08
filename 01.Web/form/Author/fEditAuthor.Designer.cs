using Siticone.Desktop.UI.WinForms;
using System;
using System.Drawing;
using System.Windows.Forms;

namespace Ngducanh
{
    partial class fEditAuthor
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
            txtName.FillColor = Color.FromArgb(232, 236, 239); // #E8ECEF (Xám bạc)
            txtName.Font = new Font("Segoe UI", 10F);
            txtName.ForeColor = Color.FromArgb(26, 26, 26); // #1A1A1A (Đen đậm)
            txtName.Location = new Point(40, 13);
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
            btnSave.FillColor = Color.FromArgb(42, 46, 69); // #2A2E45 (Xanh đen sâu thẳm)
            btnSave.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            btnSave.ForeColor = Color.FromArgb(255, 215, 0); // #FFD700 (Vàng ánh kim)
            btnSave.HoverState.FillColor = Color.FromArgb(60, 64, 87); // Tối hơn #2A2E45 khi hover
            btnSave.Location = new Point(40, 60);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(100, 36);
            btnSave.TabIndex = 2;
            btnSave.Text = "💾 Lưu";
            btnSave.Click += btnSave_Click;
            // 
            // btnCancel
            // 
            btnCancel.BorderRadius = 10;
            btnCancel.FillColor = Color.FromArgb(232, 236, 239); // #E8ECEF (Xám bạc)
            btnCancel.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            btnCancel.ForeColor = Color.FromArgb(26, 26, 26); // #1A1A1A (Đen đậm)
            btnCancel.HoverState.FillColor = Color.FromArgb(200, 204, 207); // Tối hơn #E8ECEF khi hover
            btnCancel.Location = new Point(240, 60);
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
            // fEditAuthor
            // 
            BackColor = Color.FromArgb(247, 249, 251); // #F7F9FB (Trắng xám nhạt)
            ClientSize = new Size(377, 111);
            Controls.Add(txtName);
            Controls.Add(btnSave);
            Controls.Add(btnCancel);
            FormBorderStyle = FormBorderStyle.None;
            MaximizeBox = false;
            Name = "fEditAuthor";
            StartPosition = FormStartPosition.CenterParent;
            Text = "Chỉnh sửa tác giả";
            Load += fEditAuthor_Load;
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