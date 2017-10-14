using System;
using System.IO;

namespace SASigner
{
    internal class Defaults
    {
        #region Variables

        private string mFolder = string.Empty;

        #endregion Variables

        #region Properties

        internal string SignToolPath { get; set; } = string.Empty;
        internal string CertificateFilePath { get; set; } = string.Empty;
        internal bool DoTimeStamp { get; set; } = true;
        internal int TimeStampServer { get; set; } = 0;
        internal bool DoDetailedOutput { get; set; } = true;

        private string DefaultsFilename => Path.Combine(mFolder, "defaults.ini");
        internal string ErrorMessage { get; private set; } = string.Empty;

        #endregion Properties

        #region Constructor

        internal Defaults(string folder)
        {
            mFolder = folder;
        }

        #endregion Constructor

        #region Methods

        internal bool Load()
        {
            ErrorMessage = string.Empty;
            if (!File.Exists(DefaultsFilename)) Save();
            try
            {
                using (TextReader tr = new StreamReader(DefaultsFilename))
                {
                    SignToolPath = tr.ReadLine();
                    CertificateFilePath = tr.ReadLine();
                    DoTimeStamp = Convert.ToBoolean(tr.ReadLine());
                    TimeStampServer = Convert.ToInt32(tr.ReadLine());
                    DoDetailedOutput = Convert.ToBoolean(tr.ReadLine());

                    tr.Close();
                }

                return true;
            }
            catch (Exception ex)
            {
                ErrorMessage = ex.Message;
                return false;
            }
        }

        internal bool Save()
        {
            ErrorMessage = string.Empty;
            try
            {
                if (File.Exists(DefaultsFilename)) File.Delete(DefaultsFilename);

                using (TextWriter tw = new StreamWriter(DefaultsFilename))
                {
                    tw.WriteLine(SignToolPath);
                    tw.WriteLine(CertificateFilePath);
                    tw.WriteLine(Convert.ToString(DoTimeStamp));
                    tw.WriteLine(TimeStampServer);
                    tw.WriteLine(Convert.ToString(DoDetailedOutput));

                    tw.Close();
                }

                return true;
            }
            catch (Exception ex)
            {
                ErrorMessage = ex.Message;
                return false;
            }
        }

        #endregion Methods
    }
}