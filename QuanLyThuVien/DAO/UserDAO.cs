using System;
using System.Collections.Generic;
using System.Data.Linq;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DAO
{
    public class UserDAO
    {
        private static UserDAO instance;
      
        public static UserDAO Instance
        {
            get 
            {
                if (instance == null)
                {
                    instance = new UserDAO();
                }    
                return instance;
            }
        }
       
        private UserDAO() { }

        #region Xem data

        public List<NHANVIEN> getNHANVIENs()
        {
            List<NHANVIEN> ds = new List<NHANVIEN>();

            using (QLThuViendbDataContext db =  new QLThuViendbDataContext()) 
            {
                ds = db.NHANVIENs.Select(p => p).ToList();
            }
                return ds;
        }

        public List<DOCGIA> getDOCGIAs()
        {
            List<DOCGIA> ds = new List<DOCGIA>();

            using (QLThuViendbDataContext db = new QLThuViendbDataContext())
            {
                ds = db.DOCGIAs.Select(p => p).ToList();
            }
            return ds;
        }


        public List<SACH> getSACHs()
        {
            List<SACH> ds = new List<SACH>();

            using (QLThuViendbDataContext db = new QLThuViendbDataContext())
            {
                ds = db.SACHes.Select(p => p).ToList();
            }
            return ds;
        }

        #endregion

        #region Sua data
        #endregion

        #region Xoa data
        #endregion
    }
}
