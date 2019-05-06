using System;
using System.Collections.Generic;
using System.Data;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace SASigner
{
    public partial class frmSigner : Form
    {
        #region Variables

        private Defaults mDefaults = new Defaults(Application.StartupPath);
        private bool hasLoaded = false;
        private Dictionary<int, TimeStampServer> mTimeStampServers = new Dictionary<int, TimeStampServer>();
        private int mSelectedFileIndex = -1;

        #endregion Variables

        #region Constructor

        public frmSigner()
        {
            InitializeComponent();
            btnFileRemove.Enabled = false;
            btnFileClear.Enabled = false;

            LoadTimeStampServers();
            PopulateTimeStampServerCombo();

            if (!mDefaults.Load()) DisplayMessage($"Error loading defaults: {mDefaults.ErrorMessage}");
            else SetUI();

            hasLoaded = true;
        }

        #endregion Constructor

        #region Process UI

        private void cmbTimeStampServer_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (!hasLoaded) return;
            SaveDefaults();
        }

        private void btnSignToolPath_Click(object sender, EventArgs e)
        {
            List<FileExtensions> tExtensions = new List<FileExtensions>();
            tExtensions.Add(new FileExtensions { Description = "Sign Tool", Extension = "signtool.exe" });
            List<string> tList = GetPath(tExtensions);
            if (tList.Any())
            {
                lblSignToolPath.Text = tList[0];
                SaveDefaults();
            }
            CanSign();
        }

        private void btnCertificate_Click(object sender, EventArgs e)
        {
            List<FileExtensions> tExtensions = new List<FileExtensions>();
            tExtensions.Add(new FileExtensions { Description = "Certificate", Extension = "*.p12; *.pfx" });
            List<string> tList = GetPath(tExtensions);
            if (tList.Any())
            {
                lblCertificatePath.Text = tList[0];
                SaveDefaults();
            }
            CanSign();
        }

        private void btnFileAdd_Click(object sender, EventArgs e)
        {
            List<FileExtensions> tExtensions = new List<FileExtensions>();
            tExtensions.Add(new FileExtensions { Description = "Executables", Extension = "*.exe" });
            tExtensions.Add(new FileExtensions { Description = "Installers", Extension = "*.msi" });
            tExtensions.Add(new FileExtensions { Description = "Libraries", Extension = "*.dll" });
            tExtensions.Add(new FileExtensions { Description = "Cabinets", Extension = "*.cab" });
            List<string> tList = GetPath(tExtensions, true);
            if (tList.Any())
            {
                foreach (var item in tList) lstFiles.Items.Add(item);
            }
            CanSign();
        }

        private void btnFileClear_Click(object sender, EventArgs e)
        {
            ClearFilesList();
            CanSign();
        }

        private void btnFileRemove_Click(object sender, EventArgs e)
        {
            btnFileRemove.Enabled = false;
            if (mSelectedFileIndex < 0) return;
            lstFiles.Items.RemoveAt(mSelectedFileIndex);
            CanSign();
        }

        private void lstFiles_Click(object sender, EventArgs e)
        {
            mSelectedFileIndex = -1;
            try
            {
                mSelectedFileIndex = lstFiles.SelectedIndex;
                btnFileRemove.Enabled = true;
            }
            catch
            {
                btnFileRemove.Enabled = false;
            }
        }

        private void txtCertificatePassword_TextChanged(object sender, EventArgs e)
        {
            CanSign();
        }

        private void btnSign_Click(object sender, EventArgs e)
        {
            Sign();
        }

        private void chkTimeStamping_CheckedChanged(object sender, EventArgs e)
        {
            cmbTimeStampServer.Enabled = chkTimeStamping.Checked;
            SaveDefaults();
        }

        private void chkDetailOutput_CheckedChanged(object sender, EventArgs e)
        {
            SaveDefaults();
        }

        private void btnAbout_Click(object sender, EventArgs e)
        {
            frmAbout frm = new frmAbout();
            frm.ShowDialog(this);
        }

        #endregion Process UI

        #region Methods

        private void PopulateTimeStampServerCombo()
        {
            cmbTimeStampServer.Items.Clear();
            foreach (var item in mTimeStampServers) cmbTimeStampServer.Items.Add(item.Value.ServerName);
        }

        private void SetUI()
        {
            Text = $"SASigner - {Application.ProductVersion}";

            DisplayMessage(string.Empty);
            lblCertificatePath.Text = mDefaults.CertificateFilePath;
            lblSignToolPath.Text = mDefaults.SignToolPath;
            chkDetailOutput.Checked = mDefaults.DoDetailedOutput;
            chkTimeStamping.Checked = mDefaults.DoTimeStamp;
            cmbTimeStampServer.SelectedIndex = mDefaults.TimeStampServer;
            ClearFilesList();
            CanSign();
        }

        private List<string> GetPath(List<FileExtensions> extensionFilters, bool multiSelect = false)
        {
            ofDialog.Multiselect = multiSelect;

            string tFilter = string.Empty;
            for (int i = 0; i < extensionFilters.Count; i++)
            {
                tFilter += i == 0 ? $"{extensionFilters[i].Description} ({extensionFilters[i].Extension})|{extensionFilters[i].Extension}" : $"|{extensionFilters[i].Description} ({extensionFilters[i].Extension})|{extensionFilters[i].Extension}";
            }
            ofDialog.Filter = tFilter;
            ofDialog.CheckFileExists = true;
            ofDialog.CheckPathExists = true;
            ofDialog.FileName = string.Empty;

            var userClicked = ofDialog.ShowDialog();

            if (userClicked == DialogResult.OK && ofDialog.FileNames.Length > 0)
            {
                List<string> tList = new List<string>();
                foreach (var item in ofDialog.FileNames) tList.Add(item);
                return tList;
            }

            return new List<string>();
        }

        private void ClearFilesList()
        {
            lstFiles.Items.Clear();
        }

        private void CanSign()
        {
            DisplayMessage(string.Empty);
            btnFileClear.Enabled = lstFiles.Items.Count > 0;
            try
            {
                if (string.IsNullOrEmpty(lblSignToolPath.Text.Trim())) throw new Exception("Select sign tool");

                if (string.IsNullOrEmpty(lblCertificatePath.Text.Trim())) throw new Exception("Select certificate file");

                if (string.IsNullOrEmpty(txtCertificatePassword.Text.Trim())) throw new Exception("Set certificate password");

                if (lstFiles.Items.Count == 0) throw new Exception("Select at least 1 file");

                btnSign.Enabled = true;
            }
            catch (Exception ex)
            {
                DisplayMessage(ex.Message);
                btnSign.Enabled = false;
            }
        }

        private void Sign()
        {
            var counter = 0;

            btnSign.Enabled = false;
            SetEnabledStatus(false);
            lstOutput.Items.Clear();

            Application.DoEvents();

            using (var proc = new Process())
            {
                proc.StartInfo = GetStartInfo(lstFiles.Items.Cast<string>().ToList());
                proc.Start();

                proc.WaitForExit();

                var output = proc.StandardOutput.ReadToEnd();
                if (!string.IsNullOrEmpty(output)) lstOutput.Items.Add(output);

                if (proc.ExitCode == 1)
                {
                    lstOutput.Items.Add("There was an error");
                }
            };

            counter++;

            Application.DoEvents();

            SetEnabledStatus();
            btnSign.Enabled = true;
        }

        private ProcessStartInfo GetStartInfo(List<string> fileNames)
        {
            StringBuilder arg = new StringBuilder("sign");

            //If verbose
            if (!chkDetailOutput.Checked) arg.Append(@" /v");

            //Add licence
            arg.Append($" /f \"{lblCertificatePath.Text.Trim()}\"").Append(@" /p").Append($" {txtCertificatePassword.Text}");

            //Time stamping
            if (chkTimeStamping.Checked) arg.Append(@" /tr").Append($" {mTimeStampServers[mDefaults.TimeStampServer].ServerURL}");

            arg.Append(@" /td SHA256");
            arg.Append($" {GetFilenameArgument(fileNames)}");

            return new ProcessStartInfo
            {
                FileName = $"\"{lblSignToolPath.Text}\"",
                Arguments = arg.ToString(),
                UseShellExecute = false,
                RedirectStandardOutput = true,
                CreateNoWindow = true
            };
        }

        private string GetFilenameArgument(List<string> fileNames)
        {
            StringBuilder fileArg = new StringBuilder();
            foreach (string fName in fileNames) fileArg.Append($" \"{fName}\"");
            return fileArg.ToString();
        }

        private void SetEnabledStatus(bool isEnabled = true)
        {
            gbSign.Enabled = isEnabled;
            gbTimeStamp.Enabled = isEnabled;
            gbCertificate.Enabled = isEnabled;
            gbFiles.Enabled = isEnabled;
        }

        private void DisplayMessage(string message)
        {
            lblMessage.Text = message;
        }

        private void SaveDefaults()
        {
            if (!hasLoaded) return;

            mDefaults.SignToolPath = lblSignToolPath.Text.Trim();
            mDefaults.CertificateFilePath = lblCertificatePath.Text.Trim();
            mDefaults.DoTimeStamp = chkTimeStamping.Checked;
            mDefaults.TimeStampServer = cmbTimeStampServer.SelectedIndex;
            mDefaults.DoDetailedOutput = chkDetailOutput.Checked;

            if (!mDefaults.Save()) DisplayMessage($"Error saving defualts: {mDefaults.ErrorMessage}");
        }

        private void LoadTimeStampServers()
        {
            mTimeStampServers.Add(0, new TimeStampServer { ServerName = "Comodo", ServerURL = @"http://timestamp.comodoca.com/rfc3161" });
            mTimeStampServers.Add(1, new TimeStampServer { ServerName = "Verisign", ServerURL = @"http://timestamp.verisign.com/scripts/timstamp.dll" });
        }

        private void ReportOnOutcome(int processExitCode, string message)
        {
            switch (processExitCode)
            {
                case 1:  // Error
                    lstOutput.Items.Add($"Error: {message}");
                    break;

                case 2:  // Warnings
                    lstOutput.Items.Add($"Warning: {message}");
                    break;

                default:
                    return;
            }
        }

        #endregion Methods
    }

    internal struct TimeStampServer
    {
        public string ServerName { get; set; }
        public string ServerURL { get; set; }
    }

    internal struct FileExtensions
    {
        public string Description { get; set; }
        public string Extension { get; set; }
    }
}