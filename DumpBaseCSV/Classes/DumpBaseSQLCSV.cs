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
        protected SqlConnection mConnection = null;
        protected SqlCommand mCommand = null;

        private string mConnectionString = "";
        private string mConfigCSV= "";
        #endregion

        #region Properties
        // Connection string properties.
        public string mServer = "";
        public string mDatabase = "";
        public string mUsername = "";
        public string mPassword = "";

        // CSV File properties
        public string mExportCSVFile = "";
        public string mExportCSVDir = "";

        // Target export properties.
        private string mTableName="";
        private string mServerPath="";
        private string mCsvDirectory = "";

        private string mExportTable = "";
        private string mExportAsCsvOrText = "";

        private bool mSaveFile = false;

        FileInfo mInformation;
        #endregion

        #region Class Constructor
        private void GetConfigSettings(string server, string database, string username, string password)
        {
            // Read data from windows form.
            mConnectionString = "server=" + server +";database=" + database + ";Trusted_Connection=false;uid=" 
                                          + username + ";pwd=" + password;
            mConfigCSV = "Provider=Microsoft.Jet.OLEDB.4.0;Extended Properties='text;HDR=Yes;FMT=Delimited';Data Source=";
        }

        public DumpBaseSQLCSV()
        {
            GetConfigSettings(mServer, mDatabase, mUsername, mPassword);
        }
        #endregion

        #region Export Functionality
        /// <summary>
        /// Opens database connection.
        /// </summary>
        private void OpenConnection()
        {
            mConnection = new SqlConnection(mConnectionString);
            
            if (mConnection.State != ConnectionState.Open)
            {
                mConnection.Open();
            }
        }

        /// <summary>
        /// Closes database connection.
        /// </summary>
        private void CloseConnection()
        {
            if (mConnection != null)
            {
                mConnection.Close();
                mConnection = null;
            }
        }

        /// <summary>
        /// Connect to database table.
        /// </summary>
        /// <param name="FileTable"></param>
        /// <returns></returns>
        public DataSet ConnectSQLTable(string fileTable)
        {
            DataSet dsAccess = new DataSet();

            try
            {
                string sqlSelect;
                SqlDataAdapter objSqlDa;

                OpenConnection();

                sqlSelect = "Select * from [" + fileTable + "]";
                objSqlDa = new SqlDataAdapter(sqlSelect, mConnection);
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

        /// <summary>
        /// Generates CSV file
        /// </summary>
        /// <param name="Properties"></param>
        /// <returns></returns>
        public string GenerateCSVFile(DumpBaseProperties Properties)
        {
            string Result = "";

            //
            mExportCSVFile      = Properties.ExportCSVasName;
            mExportTable        = Properties.ExportTableName;
            mExportCSVDir       = Properties.ExportCSVDirOnServer;
            mExportAsCsvOrText  = Properties.ExportAsCsvOrText;

            //
            DataSet dsSQL = new DataSet();
            dsSQL = ConnectSQLTable(mExportTable);

            DataColumnCollection tableColumns = dsSQL.Tables[0].Columns;
            DataRowCollection tableRows = dsSQL.Tables[0].Rows;

            // Create and write into the exported CSV.
            string Path = CreateCSVFile(mExportCSVDir, mExportCSVFile);
            Result = WriteInExportedFile(Path, tableColumns, tableRows);

            return Result;
        }

        /// <summary>
        /// Create a CSV empty file at a given location.
        /// </summary>
        /// <param name="ExportCSVDir">Target directory where the file is created.</param>
        /// <param name="ExportCSVFile">File name to be generated.</param>
        /// <returns></returns>
        public string CreateCSVFile(string ExportCSVDir, string ExportCSVFile)
        {
            string strFilename = "";

            if (!Directory.Exists(ExportCSVDir))
                Directory.CreateDirectory(ExportCSVDir);

            strFilename = ExportCSVDir + "/" + ExportCSVFile + ".csv";

            FileStream newFile = new FileStream(strFilename, FileMode.Create, FileAccess.ReadWrite);
            newFile.Close();

            return strFilename;   
        }

        /// <summary>
        /// Writes CSV informations
        /// </summary>
        /// <param name="ExportCSVFile"></param>
        /// <param name="tableColumns"></param>
        /// <param name="tableRows"></param>
        /// <returns></returns>
        public string WriteInExportedFile(string ExportCSVFile, DataColumnCollection tableColumns, DataRowCollection tableRows)
        {

            string Result = "";
            StreamWriter File = new StreamWriter(ExportCSVFile);

            int rowsCreated = 0;
            string sqlinsert = "";

            try
            { 
                // Loop through columns of table to generate first row of CSV file
                int ctrColumn = 0;
                foreach (DataColumn column in tableColumns)
                {
                    if (ctrColumn < tableColumns.Count - 1)
                    {
                        sqlinsert += column.ColumnName.ToString() + ",";
                    }
                    else
                    {
                        sqlinsert += column.ColumnName.ToString();
                    }
                }
                File.WriteLine(sqlinsert);

                // Loop through the rows
                foreach (DataRow row in tableRows)
                { 
                
                }
            }
            catch
            { 
                // Log errors here.
            }
            finally
            {
                File.Close();
            }

            return Result;         
        }
        #endregion

        #region Database Manipulation
        /// <summary>
        /// 
        /// </summary>
        /// <param name="tableColumns"></param>
        /// <param name="tableRows"></param>
        /// <returns></returns>
        private string InsertRecords(DataColumnCollection tableColumns, DataRowCollection tableRows)
        {
            string result   = "";

            OpenConnection();

            try
            {
                foreach (DataRow row in tableRows)
                { 
                    // do stuff.

                    foreach (DataColumn column in tableColumns)
                    { 
                        // do other stuff.
                    }
                }
            }
            catch (SqlException ex)
            { 
                // Log errors
            }
            finally
            {
                CloseConnection();
            }

            return result;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="tableColumns"></param>
        /// <param name="tableName"></param>
        private void CreateTable(DataColumnCollection tableColumns, string tableName)
        {
            OpenConnection();

            string sqlcreate = "CREATE TABLE " + tableName + " (";
            foreach (DataColumn dc in tableColumns)
            {
                // TBT: Each column's type is to be viewed distinctly.
                sqlcreate += "[" + dc.ColumnName.ToString() + "]" + " varchar(255), ";
            }

            sqlcreate  = sqlcreate.Substring(0, sqlcreate.Length - 2);
            sqlcreate += ")";

            mCommand = new SqlCommand(sqlcreate, mConnection);

            try
            {
                mCommand.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                // Log something.
            }
            finally
            {
                CloseConnection();
            }

        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="tableName"></param>
        private void DropTable(string tableName)
        {
            OpenConnection();

            string sqldrop = "DROP TABLE " + tableName;
            mCommand = new SqlCommand(sqldrop, mConnection);

            try
            {
                mCommand.ExecuteNonQuery();
            }
            catch(Exception ex)
            { 
                // Log something.
            }
            finally
            {
                CloseConnection();
            }
        }
        #endregion
    }
}
