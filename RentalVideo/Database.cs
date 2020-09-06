using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RentalVideo
{
   public  class Database
    {
        SqlConnection connection = new SqlConnection(ConfigurationManager.ConnectionStrings["VR_Db"].ConnectionString);

        public DataTable TopCustomerList()
        {
            DataTable dt = new DataTable();
            try
            {
                SqlCommand cmd = new SqlCommand("select CustId,FirstName,LastName,Address,Phone,Count(*) as 'Total Borrows' from ViewRentedMovies group by CustId,FirstName,LastName,Address,Phone order by 'Total Borrows' desc", connection);
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                da.Fill(dt);
                return dt;
            }
            catch
            {
                return dt;
            }
        }
        public DataTable CustomerList()
        {
            DataTable dt = new DataTable();
            try
            {
                SqlCommand cmd = new SqlCommand("spGetAllCustomer", connection);
                cmd.CommandType = CommandType.StoredProcedure;
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                 da.Fill(dt);
                return dt;
            }
            catch
            {
                return dt;
            }
        }
        public DataTable AllRentedViewData()
        {
            DataTable dt = new DataTable();
            try
            {
                SqlCommand cmd = new SqlCommand("select * from ViewRentedMovies", connection);
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                da.Fill(dt);
                return dt;
            }
            catch
            {
                return dt;
            }
        }
        public DataTable GetVideos()
        {
            DataTable dt = new DataTable();
            try
            {
                SqlCommand cmd = new SqlCommand("select * from Movie", connection);
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                da.Fill(dt);

                return dt;
            }
            catch
            {
                return dt;
            }
        }
        public int NewCustomer(string name, string lastname, string fullAddress,string phone_no)
        {
          
            try
            {
                connection.Open();
                SqlCommand cmd = new SqlCommand("insert into Customer(FirstName,LastName,Address,Phone)" +
                    "values(@FirstName,@LastName,@Address,@Phone)", connection);
                
                    cmd.Parameters.AddWithValue("@FirstName", name);
                    cmd.Parameters.AddWithValue("@LastName", lastname);
                    cmd.Parameters.AddWithValue("@Address", fullAddress);
                    cmd.Parameters.AddWithValue("@Phone", phone_no);

                    cmd.ExecuteNonQuery();
                    
                
                connection.Close();
                return 1;
            }
            catch
            {
                return 0;
            }
        }
       
        public int DeleteCustomer(int id)
        {

            try
            {
                connection.Open();
                SqlCommand cmd = new SqlCommand("delete from Customer where CustId=@CustId", connection);
                    cmd.Parameters.AddWithValue("@CustId", id);
                   
                    cmd.ExecuteNonQuery();
                connection.Close();
                return 1;
            }
            catch
            {
                return 0;
            }
        }

       
        public int InsertVideo(string video_name, DateTime dated, decimal rental_cost, string video_genre,string plot_name)
        {

            try
            {
                connection.Open();
                SqlCommand cmd = new SqlCommand("insert into Movie(Title,ReleaseDate,RentalCost,Genre,Plot,Available)values(@Title,@ReleaseDate,@RentalCost,@Genre,@Plot,@Available)", connection);
                
                    cmd.Parameters.AddWithValue("@Title", video_name);
                    cmd.Parameters.AddWithValue("@ReleaseDate", dated);
                    cmd.Parameters.AddWithValue("@RentalCost", rental_cost);
                    cmd.Parameters.AddWithValue("@Genre", video_genre);
                    cmd.Parameters.AddWithValue("@Plot", plot_name);
                    cmd.Parameters.AddWithValue("@Available", "Yes");
                    cmd.ExecuteNonQuery();

                
                connection.Close();
                return 1;
            }
            catch
            {
                return 0;
            }
        }
        public int UpdateVideo(string video_name, DateTime dated, decimal rental_cost, string video_genre, string plot_name, int movieId)
        {

            try
            {
                connection.Open();
                SqlCommand cmd = new SqlCommand("update Movie set Title=@Title,ReleaseDate=@ReleaseDate,RentalCost=@RentalCost,Genre=@Genre,Plot=@Plot where MovieId=@MovieId", connection);
                    cmd.Parameters.AddWithValue("@MovieId", movieId);
                    cmd.Parameters.AddWithValue("@Title", video_name);
                    cmd.Parameters.AddWithValue("@ReleaseDate", dated);
                    cmd.Parameters.AddWithValue("@RentalCost", rental_cost);
                    cmd.Parameters.AddWithValue("@Genre", video_genre);
                    cmd.Parameters.AddWithValue("@Plot", plot_name);
                    cmd.ExecuteNonQuery();
                connection.Close();
                return 1;
            }
            catch
            {
                return 0;
            }
        }
        public int DeleteVideo(int id)
        {

            try
            {
                connection.Open();
                SqlCommand cmd = new SqlCommand("delete from Movie where MovieId=@MovieId", connection);
                    cmd.Parameters.AddWithValue("@MovieId", id);
                    cmd.ExecuteNonQuery();
                connection.Close();
                return 1;
            }
            catch
            {
                return 0;
            }
        }
        public DataTable VideoInStock()
        {
            DataTable dt = new DataTable();
            try
            {

                SqlCommand cmd = new SqlCommand("select * from Movie where Available='Yes'", connection);
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                da.Fill(dt);
                return dt;
            }
            catch
            {
                return dt;
            }
        }
        public int AddNewRentalVideo(int id, int cust_id, DateTime rentedDate)
        {

            try
            {
                connection.Open();
                SqlCommand cmd = new SqlCommand("insert into RentedMovies(MovieId,CustId,DateRented)values(@MovieId,@CustId,@DateRented)", connection);
                cmd.Parameters.AddWithValue("@MovieId", id);
                cmd.Parameters.AddWithValue("@CustId", cust_id);
                cmd.Parameters.AddWithValue("@DateRented", rentedDate);
                cmd.ExecuteNonQuery();
                connection.Close();
                return 1;
            }
            catch
            {
                return 0;
            }
        }
       
        public int AvailableStatusChange(int videoId, string status)
        {

            try
            {
                connection.Open();
                SqlCommand cmd = new SqlCommand("update Movie set Available=@Available where MovieId=@MovieId", connection);
                cmd.Parameters.AddWithValue("@MovieId", videoId);
                cmd.Parameters.AddWithValue("@Available", status);
                cmd.ExecuteNonQuery();
                connection.Close();
                return 1;
            }
            catch
            {
                return 0;
            }
        }
        public DataTable rentedOutVideo()
        {
            DataTable dt = new DataTable();
            try
            {
                SqlCommand cmd = new SqlCommand("select * from ViewRentedMovies where DateReturned is Null", connection);
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                da.Fill(dt);
                return dt;
            }
            catch
            {
                return dt;
            }
        }
        public int ReturnedMovie(int rmid)
        {

            try
            {
                connection.Open();
                SqlCommand cmd = new SqlCommand("update RentedMovies set DateReturned=@DateReturned where RentedMovieId=@RentedMovieId", connection);
                cmd.Parameters.AddWithValue("@RentedMovieId", rmid);
                cmd.Parameters.AddWithValue("@DateReturned", DateTime.Now);
                 cmd.ExecuteNonQuery();
                connection.Close();
                return 1;
            }
            catch
            {
                return 0;
            }
        }
        public int UpdateCustomer(string name, string lastname, string fullAddress, string phone_no, int id)
        {

            try
            {
                connection.Open();
                SqlCommand cmd = new SqlCommand("update Customer set FirstName=@FirstName,LastName=@LastName,Address=@Address,Phone=@Phone  where CustId=@CustId", connection);

                cmd.Parameters.AddWithValue("@FirstName", name);
                cmd.Parameters.AddWithValue("@LastName", lastname);
                cmd.Parameters.AddWithValue("@Address", fullAddress);
                cmd.Parameters.AddWithValue("@Phone", phone_no);
                cmd.Parameters.AddWithValue("@CustId", id);

                cmd.ExecuteNonQuery();


                connection.Close();
                return 1;
            }
            catch
            {
                return 0;
            }
        }
        public DataTable GetPopularVideo()
        {
            DataTable dt = new DataTable();
            try
            {
                SqlCommand cmd = new SqlCommand("select MovieId,Title,ReleaseDate,RentalCost,Genre,Count(*) as 'Total Rented' from ViewRentedMovies group by MovieId,Title,ReleaseDate,RentalCost,Genre order by 'Total Rented' desc", connection);
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                 da.Fill(dt);
                return dt;
            }
            catch
            {
                return dt;
            }
        }
    }
}
