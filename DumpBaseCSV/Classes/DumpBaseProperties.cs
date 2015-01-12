namespace DumpBaseCSV.Classes
{
    using System;
    using System.Collections.Generic;
    using System.IO;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    public class DumpBaseProperties
    {
        #region Attributes
        FileInfo mFileInformation;

        private string mTableName = "";
        private string mCsvDirectory = "";

        private string mExportCSVasName = "";
        private string mExportTableName = "";
        private string mExportCSVDirOnServer = "";
        private string mExportAsCsvOrText = "";

        private bool mDropExistingTable = false;
        private bool mSaveFileOnServer = false;
        #endregion

        #region Accessors and Mutators
        public FileInfo FileInformation { get { return mFileInformation; } set { mFileInformation = value; } }

        public string TableName { get { return mTableName; } set { mTableName = value; } }
        public string CsvDirecotory { get { return mCsvDirectory; } set { mCsvDirectory = value; } }

        public string ExportCSVasName { get { return mExportCSVasName; } set { mExportCSVasName = value; } }
        public string ExportTableName { get { return mExportTableName; } set { mExportTableName = value; } }
        public string ExportCSVDirOnServer { get { return mExportCSVDirOnServer; } set { mExportCSVDirOnServer = value; } }
        public string ExportAsCsvOrText { get { return mExportAsCsvOrText; } set { mExportAsCsvOrText = value; } }

        public bool DropExistingTable { get { return mDropExistingTable; } set { mDropExistingTable = value; } }
        public bool SaveFileOnServer { get { return mSaveFileOnServer; } set { mSaveFileOnServer = value; } }
        #endregion
    }
}
