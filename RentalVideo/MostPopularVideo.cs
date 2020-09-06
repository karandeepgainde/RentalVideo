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
    public partial class MostPopularVideo : Form
    {
        Database VR_db = new Database();
        public MostPopularVideo()
        {
            InitializeComponent();
        }

        private void PopularVideo_Load(object sender, EventArgs e)
        {
            GetPopularVideo();
        }
        private void GetPopularVideo()
        {
            DataTable dt = new DataTable();
            dt = VR_db.GetPopularVideo();

            gridViewPopularVideo.DataSource = dt;
        }

        private void label10_Click(object sender, EventArgs e)
        {

        }
    }
}
