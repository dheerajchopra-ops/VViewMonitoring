using VViewMonitoring.SystemReaders;

namespace VViewMonitoring
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            LoadStatus();
            refreshTimer.Tick += RefreshTimer_Tick;
            refreshTimer.Start();
        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void LoadStatus()
        {
            dgvServices.DataSource = null;
            dgvServices.DataSource = WindowsServiceReader.GetServices();

            dgvIisSites.DataSource = null;
            dgvIisSites.DataSource = IisStatusReader.GetSites();

            lblLastUpdated.Text = "Last Updated: " + DateTime.Now.ToString("HH:mm:ss");
        }
        private void RefreshTimer_Tick(object sender, EventArgs e)
        {
            LoadStatus();
        }

    }
}
