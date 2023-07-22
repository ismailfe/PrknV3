using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Linq;
using System.Windows.Forms;
using DevExpress.XtraBars;

using DevExpress.XtraScheduler;
using Google.Apis.Auth.OAuth2;
using Google.Apis.Calendar.v3;
using Google.Apis.Services;
using Google.Apis.Util.Store;
using System.IO;


using Google.Apis.Calendar.v3.Data;
using DevExpress.XtraScheduler.GoogleCalendar;
using DevExpress.XtraEditors;

namespace Emikon.Parkon.UI.Win.Forms.User
{
    public partial class UserScheduleForm : DevExpress.XtraBars.Ribbon.RibbonForm
    {
        UserCredential credential;
        CalendarService service;
        bool allowEventLoad;
        CalendarList calendarList;
        string activeCalendarId;

        public UserScheduleForm()
        {
            InitializeComponent();
            Yukle();
        }

        void Yukle()
        {
            btnSync.ItemClick += BtnSync_ItemClick;
            btnSignOut.ItemClick += BtnSignOut_ItemClick;
            txtCalendar.SelectedIndexChanged += RicbCalendarList_SelectedIndexChanged;
        }

        private void BtnSignOut_ItemClick(object sender, ItemClickEventArgs e)
        {
            SignOutGoogle();
        }


        #region Authorization
        async protected override void OnLoad(EventArgs e)
        {
            base.OnLoad(e);
            try
            {
                this.credential = await AuthorizeToGoogle();
                this.service = new CalendarService(new BaseClientService.Initializer()
                {
                    HttpClientInitializer = this.credential,
                    ApplicationName = "GoogleCalendarSyncSample"
                });
                this.dxGoogleCalendarSync1.CalendarService = this.service;
                this.allowEventLoad = true;

                await UpdateCalendarListUI();
                this.allowEventLoad = true;
                UpdateBbiAvailability();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            //DevExpress.XtraScheduler.SchedulerStorage schedulerStorage1 = new DevExpress.XtraScheduler.SchedulerStorage(this.components);
            this.dxGoogleCalendarSync1.Storage = schedulerDataStorage1;
        }

        async Task<UserCredential> AuthorizeToGoogle()
        {
            using (FileStream stream = new FileStream("credentials.json", FileMode.Open, FileAccess.Read))
            {
                string credPath = Environment.GetFolderPath(
                    Environment.SpecialFolder.Personal);
                credPath = Path.Combine(credPath, ".credentials/GoogleSchedulerSync.json");
                return await GoogleWebAuthorizationBroker.AuthorizeAsync(
                    GoogleClientSecrets.Load(stream).Secrets,
                    new String[] { CalendarService.Scope.Calendar },
                    "user",
                    CancellationToken.None,
                    new FileDataStore(credPath, true));
            }
        }
        #endregion

        async System.Threading.Tasks.Task SignOutGoogle()
        {
            DialogResult r = MessageBox.Show("Bağlı olan Google hesabı kaldırılsın mı?", "Google Hesabı kaldırılıyor", MessageBoxButtons.YesNo);
            if (r == DialogResult.Yes)
            {
                CancellationToken ct;
                //ct. = true;
                await credential.RevokeTokenAsync(ct);
                MessageBox.Show("Hesapla ilişki kesildiği için sayfa kapatılacak", "Hesap kaldırıldı.");
                this.Close();
            }
        }

        private void BtnSync_ItemClick(object sender, ItemClickEventArgs e)
        {
            this.dxGoogleCalendarSync1.Synchronize();
        }

        async System.Threading.Tasks.Task UpdateCalendarListUI()
        {
            CalendarListResource.ListRequest listRequest = this.service.CalendarList.List();
            this.calendarList = await listRequest.ExecuteAsync();
            this.txtCalendar.Items.Clear();
            foreach (CalendarListEntry item in this.calendarList.Items)
                this.txtCalendar.Items.Add(item.Summary);
            if (!String.IsNullOrEmpty(this.activeCalendarId))
            {
                CalendarListEntry itemToSelect = this.calendarList.Items.FirstOrDefault(x => x.Id == this.activeCalendarId);
                this.dxGoogleCalendarSync1.CalendarId = this.activeCalendarId;
                if (this.txtCalendar.Items.Contains(itemToSelect.Summary))
                {
                    this.lbls.EditValue = itemToSelect.Summary;
                }
                else
                    this.activeCalendarId = String.Empty;
            }
            UpdateBbiAvailability();
        }

        void UpdateBbiAvailability()
        {
            this.btnSync.Enabled = !String.IsNullOrEmpty(this.activeCalendarId) && this.allowEventLoad;
        }

        private void RicbCalendarList_SelectedIndexChanged(object sender, EventArgs e)
        {
            ComboBoxEdit edit = (ComboBoxEdit)sender;
            string selectedCalendarSummary = (string)edit.SelectedItem;
            CalendarListEntry selectedCalendar = this.calendarList.Items.FirstOrDefault(x => x.Summary == selectedCalendarSummary);
            this.activeCalendarId = selectedCalendar.Id;
            this.dxGoogleCalendarSync1.CalendarId = selectedCalendar.Id;
            UpdateBbiAvailability();
        }


        private void GcSyncComponent_FilterAppointments(object sender, FilterAppointmentsEventArgs e)
        {
            if (e.Appointment != null && e.Appointment.Description.Contains("test"))
                e.Cancel = true;
            if (e.Event != null && e.Event.Status == "tentative")
                e.Cancel = true;
        }

        private void dxGoogleCalendarSync1_ConflictDetected(object sender, ConflictDetectedEventArgs e)
        {
            //if (
            //    //implement your condition here
            //    //you can read the e.Appointment and e.Event parameters to compare conflicting objects
            //    )
            //{
            //    e.GoogleEventIsValid = false;
            //}
        }

    }
}