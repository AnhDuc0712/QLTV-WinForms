using Siticone.Desktop.UI.WinForms;
using Krypton.Toolkit;
using System;
using System.Drawing;
using System.Windows.Forms;

namespace Ngducanh
{
    partial class fEditCategory
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
            lblTitle = new KryptonLabel();
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
            // lblTitle
            // 
            lblTitle.StateCommon.ShortText.Color1 = Color.FromArgb(26, 26, 26); // #1A1A1A (Đen đậm)
            lblTitle.StateCommon.ShortText.Font = new Font("Segoe UI", 14F, FontStyle.Bold);
            lblTitle.Location = new Point(0, 10);
            lblTitle.Name = "lblTitle";
            lblTitle.Size = new Size(498, 30);
            lblTitle.TabIndex = 0;
            lblTitle.Values.Text = "Thêm / Sửa thể loại";
            lblTitle.StateCommon.ShortText.TextH = PaletteRelativeAlign.Center;
            // 
            // txtName
            // 
            txtName.BorderRadius = 12;
            txtName.DefaultText = "";
            txtName.FillColor = Color.FromArgb(232, 236, 239); // #E8ECEF (Xám bạc)
            txtName.Font = new Font("Segoe UI", 12F);
            txtName.ForeColor = Color.FromArgb(26, 26, 26); // #1A1A1A (Đen đậm)
            txtName.Location = new Point(55, 50);
            txtName.Margin = new Padding(3, 4, 3, 4);
            txtName.Name = "txtName";
            txtName.PasswordChar = '\0';
            txtName.PlaceholderText = "Nhập tên thể loại...";
            txtName.SelectedText = "";
            txtName.Size = new Size(400, 35);
            txtName.TabIndex = 1;
            // 
            // btnSave
            // 
            btnSave.BorderRadius = 12;
            btnSave.FillColor = Color.FromArgb(42, 46, 69); // #2A2E45 (Xanh đen sâu thẳm)
            btnSave.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            btnSave.ForeColor = Color.FromArgb(255, 215, 0); // #FFD700 (Vàng ánh kim)
            btnSave.HoverState.FillColor = Color.FromArgb(60, 64, 87); // Tối hơn #2A2E45 khi hover
            btnSave.Location = new Point(55, 100);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(100, 35);
            btnSave.TabIndex = 2;
            btnSave.Text = "💾 Lưu";
            // 
            // btnCancel
            // 
            btnCancel.BorderRadius = 12;
            btnCancel.FillColor = Color.FromArgb(232, 236, 239); // #E8ECEF (Xám bạc)
            btnCancel.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            btnCancel.ForeColor = Color.FromArgb(26, 26, 26); // #1A1A1A (Đen đậm)
            btnCancel.HoverState.FillColor = Color.FromArgb(200, 204, 207); // Tối hơn #E8ECEF khi hover
            btnCancel.Location = new Point(355, 100);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new Size(100, 35);
            btnCancel.TabIndex = 3;
            btnCancel.Text = "✖ Hủy";
            // 
            // toolTip1
            // 
            toolTip1.AutoPopDelay = 5000;
            toolTip1.InitialDelay = 100;
            toolTip1.ReshowDelay = 50;
            // 
            // fEditCategory
            // 
            AutoScaleMode = AutoScaleMode.None;
            BackColor = Color.FromArgb(247, 249, 251); // #F7F9FB (Trắng xám nhạt)
            ClientSize = new Size(498, 159);
            Controls.Add(btnCancel);
            Controls.Add(btnSave);
            Controls.Add(txtName);
            Controls.Add(lblTitle);
            Font = new Font("Segoe UI", 10F);
            FormBorderStyle = FormBorderStyle.None;
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "fEditCategory";
            StartPosition = FormStartPosition.CenterParent;
            Text = "Thêm / Sửa thể loại";
            Load += fEditCategory_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #region Windows Form Designer generated code
        private KryptonLabel lblTitle;
        private SiticoneTextBox txtName;
        private SiticoneButton btnSave;
        private SiticoneButton btnCancel;
        private ToolTip toolTip1;
        #endregion
    }
}