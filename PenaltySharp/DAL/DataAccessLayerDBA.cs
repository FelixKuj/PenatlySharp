using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PenaltySharp.DAL
{
    class DataAccessLayerDBA
    {
        private SqlConnection msqlConnection;
        private SqlDataAdapter mMoviesAdapter;
        private DataSet mDataSet;
        private String mConnectionString;

        public DataAccessLayerDBA()
        {

            mConnectionString = @"Data Source=RUBAND-SQLSERVE\RUBIRAMSSQLSERVE;Initial Catalog=JBote;User ID=JBote;Password=JBote";
            //mConnectionString = MovieLibrary.Properties.Settings.Default.MovieLibraryConnectionString;

            msqlConnection = new SqlConnection(mConnectionString);

            msqlConnection.Open();

            CreateIfNotExists(); // Setup the database

            msqlConnection.Close();
        }


        public bool SaveAll()
        {
            msqlConnection.Open();
            msqlConnection.Close();
            return true;
        }

        private void CreateIfNotExists()
        {
            List<string> sqlList = new List<string>();
            //sqlList.Add("if not exists (select * from master.sys.databases where name = '[MOVIELIBRARY]') " +
            //             "CREATE DATABASE MOVIELIBRARY");
            sqlList.Add("USE JBote");
            sqlList.Add("CREATE TABLE [dbo].[Spelare] ([Spelare ID]INT NOT NULL,[Användarnamn] VARCHAR (50) NULL, [Lösenord]VARCHAR (50) NULL,[Admin] BIT NULL, [Namn] VARCHAR(50) NULL, PRIMARY KEY CLUSTERED ([Id] ASC));");
            sqlList.Add("CREATE TABLE [dbo].[Regler] ([Regler ID]INT NOT NULL,[Böter]INT NULL,[Regel Namn] VARCHAR(50) NULL, PRIMARY KEY CLUSTERED ([Id] ASC));");
            sqlList.Add("CREATE TABLE [dbo].[Böter] ([Böter ID]INT NOT NULL,[Person ID]INT NULL,PRIMARY KEY CLUSTERED ([Id] ASC));");
            SqlCommand cmd;
            foreach (var sql in sqlList)
            {
                try
                {
                    cmd = new SqlCommand(sql, msqlConnection);
                    cmd.ExecuteNonQuery();
                }
                catch
                {
                    throw;
                }
            }
        }



    }
}
