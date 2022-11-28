using CoffeShopManagement.DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoffeShopManagement.DAO
{
    public class BillInfoBelongToAdminDAO
    {
        private static BillInfoBelongToAdminDAO instance;

        public static BillInfoBelongToAdminDAO Instance
        {
            get
            {
                if(instance == null)
                    instance = new BillInfoBelongToAdminDAO();
                return instance;
            }
            set
            {
                instance = value;
            }
        }

        private BillInfoBelongToAdminDAO() { }

        /// <summary>
        /// this function use to get id of Bill to show BillInfo
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        //public List<BillInfo> ShowBillInfoByIdBill(int id)
        //{
        //    List<BillInfo> list = new List<BillInfo> ();
        //    string query = $"ShowBillInfo_ByIdBill @IdBill = {id}";

        //    DataTable data = DataProvider.Instance.ExcuteQuery(query);

        //    foreach (DataRow row in data.Rows)
        //    {
        //        BillInfo billinfo = new BillInfo(row);
        //        list.Add(billinfo);
        //    }

        //    return list;
        //}

        public void InsertBillInfo(int idBill, int idDish, int count)
        {
            string query = $"INSERT_BILLINFO_FRM_DISHMENU @IdBill = {idBill}, @IdDish = {idDish}, @Count = {count}";
            //DataProvider.Instance.ExcuteNonQuery("INSERT_BILL_FOR_FRM_DISHMENU @IdBill , @IdDish , @Count", new object[]{id});
            DataProvider.Instance.ExcuteNonQuery(query);
        }
        public void deletebillinfo(int id)
        {
            DataProvider.Instance.ExcuteNonQuery("DELETE FROM BillInfo WHERE IdBill = " + id);
        }
    }
}
