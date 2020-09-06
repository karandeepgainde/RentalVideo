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
    public partial class NewMovies : Form
    {
        Database VR_db = new Database();
        public NewMovies()
        {
            InitializeComponent();
        }

        private void txtCost_TextChanged(object sender, EventArgs e)
        {
            
        }
        public void GetVideos()
        {
            DataTable dt = new DataTable();

            dt = VR_db.GetVideos();
            gridViewVideo.DataSource = dt;
        }

        private void Movies_Load(object sender, EventArgs e)
        {
            GetVideos();
            btnAdd.Enabled = true;
            btnUpdate.Enabled = false;
            btnDelete.Enabled = false;
            if (ReleaseDate.Value.Date <= DateTime.Now.Date.AddYears(-5))
            {
                Cost.Text = "2";
            }
            else
            {
                Cost.Text = "5";
            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            bool valid = checkValidation();
            if (valid == true)
            {
                int success = VR_db.InsertVideo(Title.Text, ReleaseDate.Value.Date, Convert.ToDecimal(Cost.Text), Genre.Text, Plot.Text);
                if (success == 1)
                {
                    lblMovieId.Text = "";

                    ClearTextBoxes();
                    GetVideos();

                    MessageBox.Show("Successfully Add Movie");
                    btnAdd.Enabled = true;
                    btnUpdate.Enabled = false;
                    btnDelete.Enabled = false;
                    if (ReleaseDate.Value.Date <= DateTime.Now.Date.AddYears(-5))
                    {
                        Cost.Text = "2";
                    }
                    else
                    {
                        Cost.Text = "5";
                    }
                    MainForm mainform = new MainForm();
                    mainform.ddlfill_Movie();
                }
            }
            

        }
        public bool checkValidation()
        {
            if (string.IsNullOrEmpty(Title.Text))
            {
                MessageBox.Show("Video Title is required");
                return false;
            }
            else if (string.IsNullOrEmpty(Cost.Text))
            {
                MessageBox.Show("Rental Cost is required");
                return false;
            }

            return true;
        }
        private void ClearTextBoxes()
        {
            Action<Control.ControlCollection> func = null;

            func = (controls) =>
            {
                foreach (Control control in controls)
                    if (control is TextBox)
                        (control as TextBox).Clear();
                    else
                        func(control.Controls);
            };

            func(Controls);
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(lblMovieId.Text))
            {
                MessageBox.Show("Please Select the Video for Update");
                return;
            }

            int success = VR_db.UpdateVideo(Title.Text, ReleaseDate.Value.Date, Convert.ToDecimal(Cost.Text), Genre.Text, Plot.Text,Convert.ToInt32(lblMovieId.Text));
            if (success == 1)
            {
                lblMovieId.Text = "";

                ClearTextBoxes();
                GetVideos();

                MessageBox.Show("Successfully Update Movie");
                btnAdd.Enabled = true;
                btnUpdate.Enabled = false;
                btnDelete.Enabled = false;
                if (ReleaseDate.Value.Date <= DateTime.Now.Date.AddYears(-5))
                {
                    Cost.Text = "2";
                }
                else
                {
                    Cost.Text = "5";
                }
            }
           
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(lblMovieId.Text))
            {
                MessageBox.Show("Please Select the Video for Delete");
                return;
            }
            DialogResult dialogResult = MessageBox.Show("ARE YOU SURE YOU WANT TO DELETE THIS Video ??", "Record Delete", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                int success = VR_db.DeleteVideo(Convert.ToInt32(lblMovieId.Text));
                if (success == 1)
                {
                    lblMovieId.Text = "";

                    ClearTextBoxes();
                    GetVideos();

                    MessageBox.Show("Successfully Delete Movie");
                    btnAdd.Enabled = true;
                    btnUpdate.Enabled = false;
                    btnDelete.Enabled = false;
                    if (ReleaseDate.Value.Date <= DateTime.Now.Date.AddYears(-5))
                    {
                        Cost.Text = "2";
                    }
                    else
                    {
                        Cost.Text = "5";
                    }
                }
               
            }
            else if (dialogResult == DialogResult.No)
            {
                //do something else
            }
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

       

        private void dtpReleaseDate_ValueChanged(object sender, EventArgs e)
        {
            if (ReleaseDate.Value.Date <= DateTime.Now.Date.AddYears(-5))
            {
                Cost.Text = "2";
            }
            else
            {
                Cost.Text = "5";
            }
        }

        private void txtCost_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }

        private void gridViewVideo_Click(object sender, EventArgs e)
        {
            if (gridViewVideo.Rows.Count > 0)
            {
                lblMovieId.Text = gridViewVideo.CurrentRow.Cells[0].Value.ToString();
                Title.Text = gridViewVideo.CurrentRow.Cells[1].Value.ToString();
                ReleaseDate.Text = gridViewVideo.CurrentRow.Cells[2].Value.ToString();
                Cost.Text = gridViewVideo.CurrentRow.Cells[3].Value.ToString();
                Genre.Text = gridViewVideo.CurrentRow.Cells[4].Value.ToString();
                Plot.Text = gridViewVideo.CurrentRow.Cells[5].Value.ToString();
                btnAdd.Enabled = false;
                btnUpdate.Enabled = true;
                btnDelete.Enabled = true;

            }
        }
    }
}
