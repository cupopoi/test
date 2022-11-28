using CoffeShopManagement.DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CoffeShopManagement.DAO
{
    public class BillBelongToAdminDAO
    {
        private static BillBelongToAdminDAO instance;

        public static BillBelongToAdminDAO Instance
        {
            get
            {
                if (instance == null)
                    instance = new BillBelongToAdminDAO();
                return instance;
            }
            set
            {
                instance = value;
            }
        }

        private BillBelongToAdminDAO() { }

        public List<Bill> ShowBill()
        {
            List<Bill> list = new List<Bill>();
            string query = "SHOW_Bill";

            DataTable data = DataProvider.Instance.ExcuteQuery(query);

            foreach (DataRow row in data.Rows)
            {
                Bill bill = new Bill(row);
                list.Add(bill);
            }


            return list;
        }

        /// <summary>
        /// this function use to get id of TablNumber to show Bill
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public int ShowBillByTableId(int id)
        {
            string query = $"ShowBill_ByIdTableNumber @IdTableNumber = {id}";
            DataTable data = DataProvider.Instance.ExcuteQuery(query);
            if (data.Rows.Count > 0)
            {
                Bill bill = new Bill(data.Rows[0]);
                return bill.Id;
            }
            return -1; //Did not find.
        }

        public void InsertBill(int id)
        {
            string query = $"INSERT_BILL_FOR_FRM_DISHMENU @IdTableNumber = {id}";
            //DataProvider.Instance.ExcuteNonQuery("INSERT_BILL_FOR_FRM_DISHMENU @IdTableNumber", new object[]{id});
            DataProvider.Instance.ExcuteNonQuery(query);
        }

        public int ShowLastIdBill()
        {
            try
            {
                string query = "SELECT MAX(Id) FROM Bill";
                return (int)DataProvider.Instance.ExcuteScalar(query);
            }
            catch (Exception ex)
            {
                return -1;
            }
        }

        //Check Pay
        public void CheckBill(int id)
        {
            string query = $"CHECK_PAY @IdBill = {id}";
            DataProvider.Instance.ExcuteNonQuery(query);
        }
        public void deletebill(int id)
        {
            DataProvider.Instance.ExcuteNonQuery("DELETE FROM Bill WHERE Id = " + id );
        }

    }
}
