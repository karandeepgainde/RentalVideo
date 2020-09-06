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
    public partial class AllRentalVideo : Form
    {
        Database VR_db = new Database();
        public AllRentalVideo()
        {
            InitializeComponent();
        }

        private void RentalVideo_Load(object sender, EventArgs e)
        {

            AllRentedViewData();
        }
      

       
        private void AllRentedViewData()
        {
            DataTable dt = new DataTable();

            dt = VR_db.AllRentedViewData();
            gridViewRentedMovie.DataSource = dt;
        }

       
    }
}
