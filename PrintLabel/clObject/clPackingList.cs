using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Markup;

namespace PrintLabel.clObject
{
    public class clPackingList
    {
        //detail
        public string WO_No { get; set; }
        public string ID_No { get; set; }
        public string Item_No { get; set; }
        public string Rev_No { get; set; }
        public DateTime DateScan { get; set; }
        public int Qty {  get; set; }
        public string ThietBi_Detail { get; set; }
        public bool ResultScan { get; set; } // đánh dấu kq scan, nếu lỗi thì = 0
        public string ErrorScan { get; set; }
        public string AdminConfirm { get; set; }
        public string LyDoError { get; set; }
        public string strFull { get; set; }
        public bool ItemNew { get; set; }// đánh dấu có phải là item bổ sung hay không. Áp dụng từ tháng 04/26

        public string PL_OLD { get; set; }

        public clPackingList(string wO_No, string iD_No, string item_No, string rev_No, DateTime dateScan, 
            int qty, string thietBi_Detail, bool resultScan, string errorScan, string adminConfirm, 
            string lyDoError, string strFull, bool itemNew, string pl_old)
        {
            WO_No = wO_No;
            ID_No = iD_No;
            Item_No = item_No;
            Rev_No = rev_No;
            DateScan = dateScan;
            Qty = qty;
            ThietBi_Detail = thietBi_Detail;
            ResultScan = resultScan;
            ErrorScan = errorScan;
            AdminConfirm = adminConfirm;
            LyDoError = lyDoError;
            this.strFull = strFull;
            ItemNew = itemNew;
            PL_OLD = pl_old;
        }

        public clPackingList()
        {

        }
    }
}
