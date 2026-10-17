using System;

namespace Bai2_ngay_17_10_2026
{
    public class CheckoutRecord
    {
        public string Id { get; set; }
        public string StudentId { get; set; }
        public string StudentName { get; set; }
        public string Device { get; set; }
        public int Quantity { get; set; }
        public DateTime BorrowDate { get; set; }
        public DateTime DueDate { get; set; }
        public DateTime? ReturnDate { get; set; }

        public string Status
        {
            get
            {
                if (ReturnDate.HasValue) return "Đã trả";
                if (DueDate.Date < DateTime.Today) return "Quá hạn";
                return "Đang mượn";
            }
        }

        public string ToCsv()
        {
            return $"{Id},{StudentId},\"{StudentName}\",\"{Device}\",{Quantity},{BorrowDate:d},{DueDate:d},{(ReturnDate.HasValue?ReturnDate.Value.ToString("d"):string.Empty)},{Status}";
        }
    }
}
