namespace Bai2_ngay_17_10_2026
{
    partial class Form1
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
        private System.Windows.Forms.GroupBox groupBoxInput;
        private System.Windows.Forms.Label lblId;
        private System.Windows.Forms.Label lblStudentId;
        private System.Windows.Forms.Label lblStudentName;
        private System.Windows.Forms.Label lblDevice;
        private System.Windows.Forms.Label lblQuantity;
        private System.Windows.Forms.Label lblBorrowDate;
        private System.Windows.Forms.Label lblDueDate;
        private System.Windows.Forms.Label lblReturnDate;
        private System.Windows.Forms.TextBox txtId;
        private System.Windows.Forms.TextBox txtStudentId;
        private System.Windows.Forms.TextBox txtStudentName;
        private System.Windows.Forms.ComboBox cboDevice;
        private System.Windows.Forms.NumericUpDown nudQuantity;
        private System.Windows.Forms.DateTimePicker dtpBorrow;
        private System.Windows.Forms.DateTimePicker dtpDue;
        private System.Windows.Forms.DateTimePicker dtpReturn;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnMarkReturned;
        private System.Windows.Forms.Button btnExport;
        private System.Windows.Forms.DataGridView dgv;
        private System.Windows.Forms.BindingSource bindingSource1;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabelTotal;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabelOverdue;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.TextBox txtSearch;
        private System.Windows.Forms.ComboBox cboFilter;
        private System.Windows.Forms.Label lblSearch;

        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.groupBoxInput = new System.Windows.Forms.GroupBox();
            this.lblId = new System.Windows.Forms.Label();
            this.lblStudentId = new System.Windows.Forms.Label();
            this.lblStudentName = new System.Windows.Forms.Label();
            this.lblDevice = new System.Windows.Forms.Label();
            this.lblQuantity = new System.Windows.Forms.Label();
            this.lblBorrowDate = new System.Windows.Forms.Label();
            this.lblDueDate = new System.Windows.Forms.Label();
            this.lblReturnDate = new System.Windows.Forms.Label();
            this.txtId = new System.Windows.Forms.TextBox();
            this.txtStudentId = new System.Windows.Forms.TextBox();
            this.txtStudentName = new System.Windows.Forms.TextBox();
            this.cboDevice = new System.Windows.Forms.ComboBox();
            this.nudQuantity = new System.Windows.Forms.NumericUpDown();
            this.dtpBorrow = new System.Windows.Forms.DateTimePicker();
            this.dtpDue = new System.Windows.Forms.DateTimePicker();
            this.dtpReturn = new System.Windows.Forms.DateTimePicker();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnMarkReturned = new System.Windows.Forms.Button();
            this.btnExport = new System.Windows.Forms.Button();
            this.dgv = new System.Windows.Forms.DataGridView();
            this.bindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabelTotal = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripStatusLabelOverdue = new System.Windows.Forms.ToolStripStatusLabel();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.txtSearch = new System.Windows.Forms.TextBox();
            this.cboFilter = new System.Windows.Forms.ComboBox();
            this.lblSearch = new System.Windows.Forms.Label();
            this.groupBoxInput.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudQuantity)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgv)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).BeginInit();
            this.statusStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBoxInput
            // 
            this.groupBoxInput.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
            | System.Windows.Forms.AnchorStyles.Right))));
            this.groupBoxInput.Controls.Add(this.lblId);
            this.groupBoxInput.Controls.Add(this.txtId);
            this.groupBoxInput.Controls.Add(this.lblStudentId);
            this.groupBoxInput.Controls.Add(this.txtStudentId);
            this.groupBoxInput.Controls.Add(this.lblStudentName);
            this.groupBoxInput.Controls.Add(this.txtStudentName);
            this.groupBoxInput.Controls.Add(this.lblDevice);
            this.groupBoxInput.Controls.Add(this.cboDevice);
            this.groupBoxInput.Controls.Add(this.lblQuantity);
            this.groupBoxInput.Controls.Add(this.nudQuantity);
            this.groupBoxInput.Controls.Add(this.lblBorrowDate);
            this.groupBoxInput.Controls.Add(this.dtpBorrow);
            this.groupBoxInput.Controls.Add(this.lblDueDate);
            this.groupBoxInput.Controls.Add(this.dtpDue);
            this.groupBoxInput.Controls.Add(this.lblReturnDate);
            this.groupBoxInput.Controls.Add(this.dtpReturn);
            this.groupBoxInput.Controls.Add(this.btnAdd);
            this.groupBoxInput.Controls.Add(this.btnUpdate);
            this.groupBoxInput.Controls.Add(this.btnDelete);
            this.groupBoxInput.Controls.Add(this.btnMarkReturned);
            this.groupBoxInput.Controls.Add(this.btnExport);
            this.groupBoxInput.Location = new System.Drawing.Point(12, 12);
            this.groupBoxInput.Name = "groupBoxInput";
            this.groupBoxInput.Size = new System.Drawing.Size(776, 170);
            this.groupBoxInput.TabIndex = 0;
            this.groupBoxInput.TabStop = false;
            this.groupBoxInput.Text = "Phiếu mượn";
            // 
            // lblId
            // 
            this.lblId.AutoSize = true;
            this.lblId.Location = new System.Drawing.Point(12, 26);
            this.lblId.Name = "lblId";
            this.lblId.Size = new System.Drawing.Size(54, 13);
            this.lblId.TabIndex = 0;
            this.lblId.Text = "Mã phiếu";
            // 
            // txtId
            // 
            this.txtId.Location = new System.Drawing.Point(90, 23);
            this.txtId.Name = "txtId";
            this.txtId.Size = new System.Drawing.Size(150, 20);
            this.txtId.TabIndex = 1;
            // 
            // lblStudentId
            // 
            this.lblStudentId.AutoSize = true;
            this.lblStudentId.Location = new System.Drawing.Point(260, 26);
            this.lblStudentId.Name = "lblStudentId";
            this.lblStudentId.Size = new System.Drawing.Size(62, 13);
            this.lblStudentId.TabIndex = 0;
            this.lblStudentId.Text = "Mã sinh viên";
            // 
            // txtStudentId
            // 
            this.txtStudentId.Location = new System.Drawing.Point(340, 23);
            this.txtStudentId.Name = "txtStudentId";
            this.txtStudentId.Size = new System.Drawing.Size(150, 20);
            this.txtStudentId.TabIndex = 2;
            // 
            // lblStudentName
            // 
            this.lblStudentName.AutoSize = true;
            this.lblStudentName.Location = new System.Drawing.Point(510, 26);
            this.lblStudentName.Name = "lblStudentName";
            this.lblStudentName.Size = new System.Drawing.Size(63, 13);
            this.lblStudentName.TabIndex = 0;
            this.lblStudentName.Text = "Họ tên SV";
            // 
            // txtStudentName
            // 
            this.txtStudentName.Location = new System.Drawing.Point(590, 23);
            this.txtStudentName.Name = "txtStudentName";
            this.txtStudentName.Size = new System.Drawing.Size(170, 20);
            this.txtStudentName.TabIndex = 3;
            // 
            // lblDevice
            // 
            this.lblDevice.AutoSize = true;
            this.lblDevice.Location = new System.Drawing.Point(12, 60);
            this.lblDevice.Name = "lblDevice";
            this.lblDevice.Size = new System.Drawing.Size(44, 13);
            this.lblDevice.TabIndex = 0;
            this.lblDevice.Text = "Thiết bị";
            // 
            // cboDevice
            // 
            this.cboDevice.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboDevice.Location = new System.Drawing.Point(90, 57);
            this.cboDevice.Name = "cboDevice";
            this.cboDevice.Size = new System.Drawing.Size(150, 21);
            this.cboDevice.TabIndex = 4;
            // 
            // lblQuantity
            // 
            this.lblQuantity.AutoSize = true;
            this.lblQuantity.Location = new System.Drawing.Point(260, 60);
            this.lblQuantity.Name = "lblQuantity";
            this.lblQuantity.Size = new System.Drawing.Size(41, 13);
            this.lblQuantity.TabIndex = 0;
            this.lblQuantity.Text = "Số lượng";
            // 
            // nudQuantity
            // 
            this.nudQuantity.Location = new System.Drawing.Point(340, 58);
            this.nudQuantity.Minimum = new decimal(new int[] {1,0,0,0});
            this.nudQuantity.Name = "nudQuantity";
            this.nudQuantity.Size = new System.Drawing.Size(60, 20);
            this.nudQuantity.TabIndex = 5;
            this.nudQuantity.Value = new decimal(new int[] {1,0,0,0});
            // 
            // lblBorrowDate
            // 
            this.lblBorrowDate.AutoSize = true;
            this.lblBorrowDate.Location = new System.Drawing.Point(420, 60);
            this.lblBorrowDate.Name = "lblBorrowDate";
            this.lblBorrowDate.Size = new System.Drawing.Size(52, 13);
            this.lblBorrowDate.TabIndex = 0;
            this.lblBorrowDate.Text = "Ngày mượn";
            // 
            // dtpBorrow
            // 
            this.dtpBorrow.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpBorrow.Location = new System.Drawing.Point(490, 57);
            this.dtpBorrow.Name = "dtpBorrow";
            this.dtpBorrow.Size = new System.Drawing.Size(100, 20);
            this.dtpBorrow.TabIndex = 6;
            // 
            // lblDueDate
            // 
            this.lblDueDate.AutoSize = true;
            this.lblDueDate.Location = new System.Drawing.Point(600, 60);
            this.lblDueDate.Name = "lblDueDate";
            this.lblDueDate.Size = new System.Drawing.Size(48, 13);
            this.lblDueDate.TabIndex = 0;
            this.lblDueDate.Text = "Hạn trả";
            // 
            // dtpDue
            // 
            this.dtpDue.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpDue.Location = new System.Drawing.Point(660, 57);
            this.dtpDue.Name = "dtpDue";
            this.dtpDue.Size = new System.Drawing.Size(100, 20);
            this.dtpDue.TabIndex = 7;
            // 
            // lblReturnDate
            // 
            this.lblReturnDate.AutoSize = true;
            this.lblReturnDate.Location = new System.Drawing.Point(12, 96);
            this.lblReturnDate.Name = "lblReturnDate";
            this.lblReturnDate.Size = new System.Drawing.Size(72, 13);
            this.lblReturnDate.TabIndex = 0;
            this.lblReturnDate.Text = "Ngày trả thực tế";
            // 
            // dtpReturn
            // 
            this.dtpReturn.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpReturn.Location = new System.Drawing.Point(90, 92);
            this.dtpReturn.Name = "dtpReturn";
            this.dtpReturn.Size = new System.Drawing.Size(100, 20);
            this.dtpReturn.TabIndex = 8;
            this.dtpReturn.ShowCheckBox = true;
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(210, 90);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(75, 23);
            this.btnAdd.TabIndex = 9;
            this.btnAdd.Text = "Thêm";
            this.btnAdd.UseVisualStyleBackColor = true;
            // 
            // btnUpdate
            // 
            this.btnUpdate.Location = new System.Drawing.Point(295, 90);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(75, 23);
            this.btnUpdate.TabIndex = 10;
            this.btnUpdate.Text = "Cập nhật";
            this.btnUpdate.UseVisualStyleBackColor = true;
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(380, 90);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(75, 23);
            this.btnDelete.TabIndex = 11;
            this.btnDelete.Text = "Xóa";
            this.btnDelete.UseVisualStyleBackColor = true;
            // 
            // btnMarkReturned
            // 
            this.btnMarkReturned.Location = new System.Drawing.Point(465, 90);
            this.btnMarkReturned.Name = "btnMarkReturned";
            this.btnMarkReturned.Size = new System.Drawing.Size(110, 23);
            this.btnMarkReturned.TabIndex = 12;
            this.btnMarkReturned.Text = "Đánh dấu đã trả";
            this.btnMarkReturned.UseVisualStyleBackColor = true;
            // 
            // btnExport
            // 
            this.btnExport.Location = new System.Drawing.Point(585, 90);
            this.btnExport.Name = "btnExport";
            this.btnExport.Size = new System.Drawing.Size(75, 23);
            this.btnExport.TabIndex = 13;
            this.btnExport.Text = "Xuất CSV";
            this.btnExport.UseVisualStyleBackColor = true;
            // 
            // dgv
            // 
            this.dgv.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
            | System.Windows.Forms.AnchorStyles.Left)
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgv.Location = new System.Drawing.Point(12, 210);
            this.dgv.Name = "dgv";
            this.dgv.Size = new System.Drawing.Size(776, 200);
            this.dgv.TabIndex = 1;
            this.dgv.AutoGenerateColumns = false;
            this.dgv.ReadOnly = true;
            this.dgv.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgv.MultiSelect = false;
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabelTotal,
            this.toolStripStatusLabelOverdue});
            this.statusStrip1.Location = new System.Drawing.Point(0, 422);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(800, 28);
            this.statusStrip1.TabIndex = 2;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // toolStripStatusLabelTotal
            // 
            this.toolStripStatusLabelTotal.Name = "toolStripStatusLabelTotal";
            this.toolStripStatusLabelTotal.Size = new System.Drawing.Size(118, 23);
            this.toolStripStatusLabelTotal.Text = "Tổng phiếu: 0";
            // 
            // toolStripStatusLabelOverdue
            // 
            this.toolStripStatusLabelOverdue.Name = "toolStripStatusLabelOverdue";
            this.toolStripStatusLabelOverdue.Size = new System.Drawing.Size(118, 23);
            this.toolStripStatusLabelOverdue.Text = "Quá hạn: 0";
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // txtSearch
            // 
            this.txtSearch.Location = new System.Drawing.Point(90, 188);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(200, 20);
            this.txtSearch.TabIndex = 14;
            // 
            // lblSearch
            // 
            this.lblSearch.AutoSize = true;
            this.lblSearch.Location = new System.Drawing.Point(12, 191);
            this.lblSearch.Name = "lblSearch";
            this.lblSearch.Size = new System.Drawing.Size(72, 13);
            this.lblSearch.TabIndex = 15;
            this.lblSearch.Text = "Tìm (MãSV/Thiết bị)";
            // 
            // cboFilter
            // 
            this.cboFilter.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboFilter.Location = new System.Drawing.Point(310, 187);
            this.cboFilter.Name = "cboFilter";
            this.cboFilter.Size = new System.Drawing.Size(150, 21);
            this.cboFilter.TabIndex = 16;
            // 
            // Form1
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.cboFilter);
            this.Controls.Add(this.lblSearch);
            this.Controls.Add(this.txtSearch);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.dgv);
            this.Controls.Add(this.groupBoxInput);
            this.Name = "Form1";
            this.Text = "Lab Equipment Checkout";
            this.groupBoxInput.ResumeLayout(false);
            this.groupBoxInput.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudQuantity)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgv)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).EndInit();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        #endregion
    }
}

