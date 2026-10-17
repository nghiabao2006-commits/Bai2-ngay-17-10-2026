using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Bai2_ngay_17_10_2026
{
    public partial class Form1 : Form
    {
        private System.ComponentModel.BindingList<CheckoutRecord> list;
        private System.Windows.Forms.BindingSource bs;

        public Form1()
        {
            InitializeComponent();
            InitializeApp();
        }

        private void InitializeApp()
        {
            // sample devices
            cboDevice.Items.AddRange(new object[] { "Multimeter", "Oscilloscope", "Power Supply", "Arduino", "Raspberry Pi" });
            if (cboDevice.Items.Count > 0) cboDevice.SelectedIndex = 0;

            list = new System.ComponentModel.BindingList<CheckoutRecord>();
            bs = new System.Windows.Forms.BindingSource();
            bs.DataSource = list;

            // configure DataGridView columns
            dgv.AutoGenerateColumns = false;
            dgv.Columns.Clear();
            dgv.Columns.Add(new DataGridViewTextBoxColumn() { DataPropertyName = "Id", HeaderText = "Mã phiếu" });
            dgv.Columns.Add(new DataGridViewTextBoxColumn() { DataPropertyName = "StudentId", HeaderText = "Mã SV" });
            dgv.Columns.Add(new DataGridViewTextBoxColumn() { DataPropertyName = "StudentName", HeaderText = "Họ tên" });
            dgv.Columns.Add(new DataGridViewTextBoxColumn() { DataPropertyName = "Device", HeaderText = "Thiết bị" });
            dgv.Columns.Add(new DataGridViewTextBoxColumn() { DataPropertyName = "Quantity", HeaderText = "Số lượng" });
            dgv.Columns.Add(new DataGridViewTextBoxColumn() { DataPropertyName = "BorrowDate", HeaderText = "Ngày mượn" });
            dgv.Columns.Add(new DataGridViewTextBoxColumn() { DataPropertyName = "DueDate", HeaderText = "Hạn trả" });
            dgv.Columns.Add(new DataGridViewTextBoxColumn() { DataPropertyName = "ReturnDate", HeaderText = "Ngày trả" });
            dgv.Columns.Add(new DataGridViewTextBoxColumn() { DataPropertyName = "Status", HeaderText = "Tình trạng" });

            dgv.DataSource = bs;

            // events
            btnAdd.Click += BtnAdd_Click;
            btnUpdate.Click += BtnUpdate_Click;
            btnDelete.Click += BtnDelete_Click;
            btnMarkReturned.Click += BtnMarkReturned_Click;
            btnExport.Click += BtnExport_Click;
            dgv.SelectionChanged += Dgv_SelectionChanged;
            txtSearch.TextChanged += TxtSearch_TextChanged;
            cboFilter.Items.AddRange(new object[] { "Tất cả", "Đang mượn", "Đã trả", "Quá hạn" });
            cboFilter.SelectedIndex = 0;
            cboFilter.SelectedIndexChanged += CboFilter_SelectedIndexChanged;

            UpdateStatus();
        }

        private void CboFilter_SelectedIndexChanged(object sender, EventArgs e)
        {
            ApplyFilter();
        }

        private void TxtSearch_TextChanged(object sender, EventArgs e)
        {
            ApplyFilter();
        }

        private void ApplyFilter()
        {
            string q = txtSearch.Text.Trim().ToLower();
            string filter = cboFilter.SelectedItem?.ToString();

            var filtered = list.Where(r =>
                (string.IsNullOrEmpty(q) || r.StudentId.ToLower().Contains(q) || r.Device.ToLower().Contains(q))
                && (filter == "Tất cả" || r.Status == filter)
            ).ToList();
            bs.DataSource = new System.ComponentModel.BindingList<CheckoutRecord>(filtered);
            dgv.DataSource = bs;
            UpdateStatus();
        }

        private void Dgv_SelectionChanged(object sender, EventArgs e)
        {
            if (dgv.SelectedRows.Count == 0) return;
            var rec = dgv.SelectedRows[0].DataBoundItem as CheckoutRecord;
            if (rec == null) return;
            txtId.Text = rec.Id;
            txtStudentId.Text = rec.StudentId;
            txtStudentName.Text = rec.StudentName;
            cboDevice.SelectedItem = rec.Device;
            nudQuantity.Value = rec.Quantity;
            dtpBorrow.Value = rec.BorrowDate;
            dtpDue.Value = rec.DueDate;
            if (rec.ReturnDate.HasValue)
            {
                dtpReturn.Value = rec.ReturnDate.Value;
                dtpReturn.Checked = true;
            }
            else
            {
                dtpReturn.Checked = false;
            }
        }

        private void BtnAdd_Click(object sender, EventArgs e)
        {
            errorProvider1.Clear();
            if (!ValidateInput(out var rec)) return;
            // check unique id
            if (list.Any(x => x.Id == rec.Id))
            {
                errorProvider1.SetError(txtId, "Mã phiếu đã tồn tại");
                return;
            }
            list.Add(rec);
            RefreshBinding();
        }

        private void BtnUpdate_Click(object sender, EventArgs e)
        {
            errorProvider1.Clear();
            if (!ValidateInput(out var rec)) return;
            var existing = list.FirstOrDefault(x => x.Id == rec.Id);
            if (existing == null) { MessageBox.Show("Không tìm thấy mã phiếu để cập nhật"); return; }
            existing.StudentId = rec.StudentId;
            existing.StudentName = rec.StudentName;
            existing.Device = rec.Device;
            existing.Quantity = rec.Quantity;
            existing.BorrowDate = rec.BorrowDate;
            existing.DueDate = rec.DueDate;
            existing.ReturnDate = rec.ReturnDate;
            RefreshBinding();
        }

        private void BtnDelete_Click(object sender, EventArgs e)
        {
            if (dgv.SelectedRows.Count == 0) return;
            var rec = dgv.SelectedRows[0].DataBoundItem as CheckoutRecord;
            if (rec == null) return;
            if (MessageBox.Show("Xóa phiếu?", "Xác nhận", MessageBoxButtons.YesNo) != DialogResult.Yes) return;
            list.Remove(rec);
            RefreshBinding();
        }

        private void BtnMarkReturned_Click(object sender, EventArgs e)
        {
            if (dgv.SelectedRows.Count == 0) return;
            var rec = dgv.SelectedRows[0].DataBoundItem as CheckoutRecord;
            if (rec == null) return;
            rec.ReturnDate = DateTime.Now.Date;
            RefreshBinding();
        }

        private void BtnExport_Click(object sender, EventArgs e)
        {
            using (var sfd = new SaveFileDialog())
            {
                sfd.Filter = "CSV files (*.csv)|*.csv|All files (*.*)|*.*";
                if (sfd.ShowDialog() != DialogResult.OK) return;
                var lines = new List<string>();
                lines.Add("Id,StudentId,StudentName,Device,Quantity,BorrowDate,DueDate,ReturnDate,Status");
                foreach (CheckoutRecord r in (bs.DataSource as System.ComponentModel.BindingList<CheckoutRecord>))
                {
                    lines.Add(r.ToCsv());
                }
                System.IO.File.WriteAllLines(sfd.FileName, lines);
                MessageBox.Show("Exported");
            }
        }

        private bool ValidateInput(out CheckoutRecord rec)
        {
            rec = null;
            bool ok = true;
            if (string.IsNullOrWhiteSpace(txtId.Text)) { errorProvider1.SetError(txtId, "Mã phiếu không được để trống"); ok = false; }
            if (string.IsNullOrWhiteSpace(txtStudentId.Text)) { errorProvider1.SetError(txtStudentId, "Mã sinh viên không được để trống"); ok = false; }
            if (cboDevice.SelectedItem == null) { errorProvider1.SetError(cboDevice, "Chọn thiết bị"); ok = false; }
            if (nudQuantity.Value <= 0) { errorProvider1.SetError(nudQuantity, "Số lượng phải > 0"); ok = false; }
            if (dtpDue.Value.Date < dtpBorrow.Value.Date) { errorProvider1.SetError(dtpDue, "Hạn trả không được trước ngày mượn"); ok = false; }
            if (dtpReturn.Checked && dtpReturn.Value.Date < dtpBorrow.Value.Date) { errorProvider1.SetError(dtpReturn, "Ngày trả không được trước ngày mượn"); ok = false; }
            if (!ok) return false;
            rec = new CheckoutRecord
            {
                Id = txtId.Text.Trim(),
                StudentId = txtStudentId.Text.Trim(),
                StudentName = txtStudentName.Text.Trim(),
                Device = cboDevice.SelectedItem?.ToString(),
                Quantity = (int)nudQuantity.Value,
                BorrowDate = dtpBorrow.Value.Date,
                DueDate = dtpDue.Value.Date,
                ReturnDate = dtpReturn.Checked ? dtpReturn.Value.Date : (DateTime?)null
            };
            return true;
        }

        private void RefreshBinding()
        {
            // refresh binding source to show computed Status updated
            foreach (var r in list) { /* no-op to keep list reference */ }
            ApplyFilter();
            UpdateStatus();
        }

        private void UpdateStatus()
        {
            int total = list.Count;
            int overdue = list.Count(r => r.Status == "Quá hạn");
            toolStripStatusLabelTotal.Text = $"Tổng phiếu: {total}";
            toolStripStatusLabelOverdue.Text = $"Quá hạn: {overdue}";
        }
    }
}
