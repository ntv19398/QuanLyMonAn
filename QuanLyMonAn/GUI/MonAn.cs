using QuanLyMonAn.DAO;
using QuanLyMonAn.DTO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLyMonAn.GUI
{
    public partial class MonAn : Form
    {
        private ConnectionDataSQL conn = new ConnectionDataSQL();
        public MonAn()
        {

            InitializeComponent();
            MonAnDAO monan = new MonAnDAO();
            List<MonAnDTO> lst = monan.getAllMonAn();
        }


    }
}
