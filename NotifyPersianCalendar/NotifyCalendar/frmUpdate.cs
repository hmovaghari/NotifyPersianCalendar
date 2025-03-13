using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Common;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using NotifyPersianCalendar.Properties;

namespace NotifyPersianCalendar
{
    public partial class frmUpdate: Form
    {
        private static frmUpdate sForm;
        private static Settings defaultSettings = Settings.Default;
        private static string ItIsUpdate = "ItIsUpdate";
        private static string NoConnection = "NoConnection";

        private frmUpdate()
        {
            InitializeComponent();
        }

        public static frmUpdate GetInstance(bool isRunNewForm)
        {
            if (sForm == null || sForm.IsDisposed)
            {
                sForm = new frmUpdate();
            }

            sForm.Text = $"بررسی آپدیت نسخه {Resources.Version}";

            bool isOpenForm = CheckUpdate(isRunNewForm);

            if (!isOpenForm)
            {
                sForm = null;
            }

            return sForm;
        }

        private static bool CheckUpdate(bool isCallForm)
        {
            var isCheckUpdateYes = defaultSettings.IsCheckUpdateAtStart;
            var isNeedUpdate = IsNeedUpdate(Resources.Version);
            if (isNeedUpdate[0] == ItIsUpdate)
            {
                if (isCallForm)
                {
                    sForm.lblUpdated.Visible = true;
                    sForm.lblNeedUpdate.Visible = false;
                    sForm.lblNoConnection.Visible = false;
                    sForm.btnGetUpdate.Enabled = false;
                    return true;
                }
            }
            else if (isNeedUpdate[0] == NoConnection)
            {
                sForm.lblUpdated.Visible = false;
                sForm.lblNeedUpdate.Visible = false;
                sForm.lblNoConnection.Visible = true;
                sForm.btnGetUpdate.Enabled = false;
                return true;
            }
            else if ((isNeedUpdate?.Count ?? 0) >= 2)
            {
                if (isCheckUpdateYes || isCallForm)
                {
                    sForm.lblUpdated.Visible = false;
                    sForm.lblNeedUpdate.Visible = true;
                    sForm.lblNoConnection.Visible = false;
                    sForm.btnGetUpdate.Enabled = true;
                    sForm.btnGetUpdate.Click += delegate
                    {
                        System.Diagnostics.Process.Start(isNeedUpdate[1]);
                    };
                    return true;
                }
            }
            return false;
        }

        private static List<string> IsNeedUpdate(string version)
        {
            try
            {
                using (TimeOutWebClient client = new TimeOutWebClient())
                {
                    var contents = client.DownloadString("http://hmovaghari.github.io/root/NotifyPersianCalendar/FramworkApp.Update.txt").Split('\n').ToList();
                    if (version != contents[0])
                    {
                        return contents;
                    }
                }
            }
            catch (Exception ex)
            {
                return new List<string>() { NoConnection };
            }
            return new List<string>() { ItIsUpdate };
        }

        private void frmUpdate_Load(object sender, EventArgs e)
        {
            this.FixFormSize();
        }
    }
}
