using DAO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BUS
{
    public class userBUS
    {
        private static userBUS instance;

        public static userBUS Instance
        {
            get
            {
                if (instance == null)
                {
                    instance = new userBUS();
                }
                return instance;
            }
        }

        private userBUS() { }

        public void getNhanViens(DataGridView data)
        {
            data.DataSource = UserDAO.Instance.getNHANVIENs();
        }
        public void getDocGias(DataGridView data)
        {
            data.DataSource = UserDAO.Instance.getDOCGIAs();
        }
        public void getSachs(DataGridView data)
        {
            data.DataSource = UserDAO.Instance.getSACHs();
        }

        public void Alert(String s ) 
        {
            MessageBox.Show(s.ToUpper());
        }
    }
}
