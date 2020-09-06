using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RentalVideo
{
    public partial class WhoMostBorrows : Form
    {
        Database VR_db = new Database();
        public WhoMostBorrows()
        {
            InitializeComponent();
        }

        private void MostBorrows_Load(object sender, EventArgs e)
        {
            TopCustomerList();
        }
        private void TopCustomerList()
        {
            DataTable dt = new DataTable();
            dt = VR_db.TopCustomerList();

            gridViewCustomerList.DataSource = dt;
        }
    }
}
