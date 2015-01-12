namespace DumpBaseCSV.Classes
{
    using System;
    using System.Collections.Generic;
    using System.Collections.Specialized;
    using System.Configuration;
    using System.Data;
    using System.Data.SqlClient;
    using System.IO;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    public class DumpBaseSQLCSV
    {
        #region SQL Connection Attributes
        protected SqlConnection mSqlConnection = null;
        protected SqlCommand mSqlCommand = null;

        private string mConnectionSQL = "";
        private string mConnectionCSV = "";
        #endregion

        #region DumpBase Properties
        private string mTableName="";
        private string mServerPath="";
        private string mCsvDirectory = "";

        private string mExportCSV = "";
        private string mExportCSVDir = "";
        private string mExportTable = "";
        private string mExportAsCsvOrText = "";

        private bool mDropExistingTable = false;
        private bool mSaveFileOnServer = false;

        FileInfo mInformation;
        #endregion

        #region Class Constructor
        private void GetConfigSettings()
        {
            // This is obsolete, find a better way to retrieve these.
            NameValueCollection config = (NameValueCollection) ConfigurationSettings.GetConfig("appSettings");
            mConnectionSQL = config["connSQL"];
            mConnectionCSV = config["connSQL"];
        }

        public DumpBaseSQLCSV()
        {
            GetConfigSettings();
        }
        #endregion

        #region Export Functionality
        /// <summary>
        /// Opens database connection.
        /// </summary>
        private void OpenConnection()
        {
            mSqlConnection = new SqlConnection(mConnectionSQL);
            
            if (mSqlConnection.State != ConnectionState.Open)
            {
                mSqlConnection.Open();
            }
        }

        /// <summary>
        /// Closes database connection.
        /// </summary>
        private void CloseConnection()
        {
            if (mSqlConnection != null)
            {
                mSqlConnection.Close();
                mSqlConnection = null;
            }
        }

        /// <summary>
        /// Connect to database table.
        /// </summary>
        /// <param name="FileTable"></param>
        /// <returns></returns>
        public DataSet ConnectSQLTable(string FileTable)
        {
            DataSet dsAccess = new DataSet();

            try
            {
                string sqlSelect;
                SqlDataAdapter objSqlDa;

                OpenConnection();

                sqlSelect = "Select * from [" + FileTable + "]";
                objSqlDa = new SqlDataAdapter(sqlSelect, mSqlConnection);
                objSqlDa.Fill(dsAccess);
            }
            catch (Exception e)
            { }
            finally
            {
                CloseConnection();
            }

            return dsAccess;
        }

        public string GenerateCSVFile(DumpBaseProperties Properties)
        {
            string Result = "";

            //
            mExportCSV   = Properties.ExportCSVasName;
            mExportTable = Properties.ExportTableName;
            mExportCSVDir = Properties.ExportCSVDirOnServer;
            mExportAsCsvOrText = Properties.ExportAsCsvOrText;

            //
            DataSet dsSQL = new DataSet();
            dsSQL = ConnectSQLTable(mExportTable);

            DataColumnCollection tableColumns = dsSQL.Tables[0].Columns;
            DataRowCollection tableRows = dsSQL.Tables[0].Rows;

            //
            string Path = CreateCSVFile();
            Result = WriteInExportedFile(Path, tableColumns, tableRows);

            return Result;
        }

        public string CreateCSVFile()
        { 
        
        }

        #endregion

        #region Import Functionality
        #endregion

    }
}
