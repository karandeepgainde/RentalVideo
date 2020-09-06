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
    public partial class MainForm : Form
    {
        Database VR_db = new Database();
        public MainForm()
        {
            InitializeComponent();
        }

        private void btnCustomer_Click(object sender, EventArgs e)
        {
            NewCustomer obj = new NewCustomer();
            obj.Show();
        }

        private void buttonVideo_Click(object sender, EventArgs e)
        {
            NewMovies obj = new NewMovies();
            obj.Show();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            ddlfill_Customer();
            ddlfill_Movie();
            RentedmovieGridData();
        }
        private void ddlfill_Customer()
        {

            DataTable dt = new DataTable();

            dt = VR_db.CustomerList();
           
                //Insert the Default Item to DataTable.
                DataRow row = dt.NewRow();
                row[0] = 0;
                row[1] = "-- Select Customer --";
                dt.Rows.InsertAt(row, 0);
                cmbCustomer.DataSource = dt;
                cmbCustomer.ValueMember = "CustId";
                cmbCustomer.DisplayMember = "FirstName";

          
        }
        public void ddlfill_Movie()
        {

            DataTable dtVideo = new DataTable();

            dtVideo = VR_db.VideoInStock();
           
                //Insert the Default Item to DataTable.
                DataRow row = dtVideo.NewRow();
                row[0] = 0;
                row[1] = "-- Select Video --";
                dtVideo.Rows.InsertAt(row, 0);
                cmbVideo.DataSource = dtVideo;
                cmbVideo.ValueMember = "MovieId";
                cmbVideo.DisplayMember = "Title";

           
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if(cmbCustomer.SelectedIndex==0)
            {
                MessageBox.Show("Please Select Customer");
                return;
            }
            if (cmbVideo.SelectedIndex == 0)
            {
                MessageBox.Show("Please Select Video");
                return;
            }
            if (string.IsNullOrEmpty(cmbCustomer.SelectedValue.ToString()) || string.IsNullOrEmpty(cmbVideo.SelectedValue.ToString()))
            {
                MessageBox.Show("Please Select the Customer and Movie for rental");
                return;
            }


            int success = VR_db.AddNewRentalVideo(Convert.ToInt32(cmbVideo.SelectedValue.ToString()), Convert.ToInt32(cmbCustomer.SelectedValue.ToString()), dtpRentedDate.Value.Date);

            if (success == 1)
            {
                int chngeStatus = VR_db.AvailableStatusChange(Convert.ToInt32(cmbVideo.SelectedValue.ToString()), "No");
                MessageBox.Show("Movie Rented successfully");
                ddlfill_Customer();
                ddlfill_Movie();
                RentedmovieGridData();

            }
           
        }
        private void RentedmovieGridData()
        {
            DataTable dt = new DataTable();

            dt = VR_db.rentedOutVideo();

            //custGrid.AutoGenerateColumns = false;
            gridRentedMovie.DataSource = dt;
        }

        private void btnRentalVideo_Click(object sender, EventArgs e)
        {
            AllRentalVideo obj = new AllRentalVideo();
            obj.Show();
        }

        private void btnReturnVideo_Click(object sender, EventArgs e)
        {
            if (gridRentedMovie.Rows.Count > 0)
            {
                DialogResult dialogResult = MessageBox.Show("ARE YOU SURE YOU WANT TO Return This Selected Video ??", "Return Video", MessageBoxButtons.YesNo);
                if (dialogResult == DialogResult.Yes)
                {
                    string IssueId = "", MovieId = "";
                    if (gridRentedMovie.Rows.Count > 0)
                    {
                        IssueId = gridRentedMovie.CurrentRow.Cells["RMID"].Value.ToString();

                        MovieId = gridRentedMovie.CurrentRow.Cells["MovieId"].Value.ToString();
                    }
                    if (string.IsNullOrEmpty(IssueId))
                    {
                        MessageBox.Show("Please Select the Rented Movie");
                        return;
                    }



                    int Success = VR_db.ReturnedMovie(Convert.ToInt32(IssueId));
                    if (Success == 1)
                    {
                        int chngeStatus = VR_db.AvailableStatusChange(Convert.ToInt32(MovieId), "Yes");
                        MessageBox.Show("Movie Returned successfully");

                        RentedmovieGridData();
                        ddlfill_Customer();
                        ddlfill_Movie();
                    }
                    else
                    {

                    }


                }
                else if (dialogResult == DialogResult.No)
                {

                }
            }
            else
            {
                MessageBox.Show("Not any video on rented");
            }
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            MostPopularVideo obj = new MostPopularVideo();
            obj.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            WhoMostBorrows obj = new WhoMostBorrows();
            obj.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void cmbVideo_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        private void btnVideoRefresh_Click(object sender, EventArgs e)
        {
            ddlfill_Movie();
        }

        private void btn_CustomerRefresh_Click(object sender, EventArgs e)
        {
            ddlfill_Customer();
        }
    }
}
