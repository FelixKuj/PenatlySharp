﻿using PenaltySharp.Controller;
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

            //mConnectionString = @"Data Source=(LocalDB)\v11.0;AttachDbFilename=|DataDirectory|\JBOTEDBA.mdf;Integrated Security=True";


            msqlConnection = new SqlConnection(mConnectionString);

            msqlConnection.Open();

            //CreateIfNotExists(); // Setup the database

            msqlConnection.Close();
        }


        public bool SaveAll()
        {
            msqlConnection.Open();
            msqlConnection.Close();
            return true;
        }

        private void CreateIfNotExists()
        {//Data Source=(localdb)\v11.0;Initial Catalog=C:\USERS\12KUJFEL\SOURCE\REPOS\PENATLYSHARP\PENALTYSHARP\BIN\DEBUG\JBOTEDBA.MDF;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False
            List<string> sqlList = new List<string>();
            //sqlList.Add("if not exists (select * from master.sys.databases where name = '[MOVIELIBRARY]') " +
            //             "CREATE DATABASE MOVIELIBRARY");
            //sqlList.Add(@"USE C:\USERS\12KUJFEL\SOURCE\REPOS\PENATLYSHARP\PENALTYSHARP\BIN\DEBUG\JBOTEDBA.MDF");
            sqlList.Add(@"USE JBote");
            sqlList.Add("CREATE TABLE [dbo].[Spelare] ([Spelare ID]INT NOT NULL,[Användarnamn] VARCHAR (50) NULL, [Lösenord]VARCHAR (50) NULL,[Admin] BIT NULL, [Namn] VARCHAR(50) NULL, PRIMARY KEY CLUSTERED ([Spelare ID] ASC));");
            sqlList.Add("CREATE TABLE [dbo].[Regler] ([Regler ID]INT NOT NULL,[Böter]INT NULL,[Regel Namn] VARCHAR(50) NULL, PRIMARY KEY CLUSTERED ([Regler ID] ASC));");
            sqlList.Add("CREATE TABLE [dbo].[Böter] ([Böter ID]INT NOT NULL,[Person ID]INT NULL,[Regler ID]INT NOT NULL,PRIMARY KEY CLUSTERED ([Böter ID] ASC));");
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



        /// <summary>
        /// Metod för att spara regler till databas.
        /// </summary>
        public void SaveRegel()
        {
            msqlConnection.Open();
            string sqlString;

            RegelController Regler = ServiceProvider.GetReglerService();
            SqlCommand cmd;
            sqlString = "delete from dbo.Regler;";
            try
            {
                cmd = new SqlCommand(sqlString, msqlConnection);
                cmd.ExecuteNonQuery();
            }
            catch
            {
                throw;
            }

            for (int i = 0; i < Regler.Count(); i++)
            {
                sqlString = "insert into Regler ([Regler ID],[Böter],[Regel Namn]) values(" +
                            Regler.Get(i).getId() + "," +
                            Regler.Get(i).getBöter() + ",'" +
                            Regler.Get(i).getNamn() + "');";
                try
                {
                    cmd = new SqlCommand(sqlString, msqlConnection);
                    cmd.ExecuteNonQuery();
                }
                catch
                {
                    throw;
                }
            }

            msqlConnection.Close();
        }

        /// <summary>
        /// Metod för att spara spelare till databas. Och leka lekar som inkluderar barbiedockor och eld.
        /// </summary>
        public void SaveSpelare()
        {
            msqlConnection.Open();
            string sqlString;

            SpelareController Spelare = ServiceProvider.GetSpelareService();
            SqlCommand cmd;
            sqlString = "delete from dbo.Spelare;";
            try
            {
                cmd = new SqlCommand(sqlString, msqlConnection);
                cmd.ExecuteNonQuery();
            }
            catch
            {
                throw;
            }

            for (int i = 0; i < Spelare.Antal(); i++)
            {
                sqlString = "insert into Spelare ([Spelare ID],[Användarnamn],[Lösenord],[Admin],[Namn]) values(" +
                            Spelare.Get(i).getId() + "," +
                            Spelare.Get(i).getAnvändarnamn() + ",'" +
                            Spelare.Get(i).getLösenord() + ",'" +
                            Spelare.Get(i).getAdmin() + ",'" +
                            Spelare.Get(i).getNamn() + "');";
                try
                {
                    cmd = new SqlCommand(sqlString, msqlConnection);
                    cmd.ExecuteNonQuery();
                }
                catch
                {
                    throw;
                }
            }
        }

        /// <summary>
        /// Metod för att spara böter till databas.
        /// </summary>
        public void SaveBöter()
        {
            msqlConnection.Open();
            string sqlString;

            BöterController Böter = ServiceProvider.GetBöterService();
            SqlCommand cmd;
            sqlString = "delete from dbo.Regler;";
            try
            {
                cmd = new SqlCommand(sqlString, msqlConnection);
                cmd.ExecuteNonQuery();
            }
            catch
            {
                throw;
            }

            for (int i = 0; i < Böter.Count(); i++)
            {
                sqlString = "insert into Böter ([Böter ID],[Person ID],[Regler ID],[Betald]) values(" +
                            //Böter.Get(i).getId() + "," +
                            Böter.Get(i).getPersonId() + ",'" +
                            Böter.Get(i).getRegelId() + ",'" +
                            Böter.Get(i).getBetald()+ "');";
                try
                {
                    cmd = new SqlCommand(sqlString, msqlConnection);
                    cmd.ExecuteNonQuery();
                }
                catch
                {
                    throw;
                }
            }

            msqlConnection.Close();
        }



    }
}
