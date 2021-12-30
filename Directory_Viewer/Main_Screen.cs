using System;



namespace Directory_Viewer
{
    public partial class Main_Screen : Form
    {



        public Main_Screen()
        {
            InitializeComponent();
            try
            {
                // ** Post header **            
                string[] versionArray = System.Reflection.Assembly.GetExecutingAssembly().GetName().Version.ToString().Split('.');
                this.Text = "Directory Viewer";
                this.Text += " | " + "v" + versionArray[0] + "." + versionArray[1] + "." + versionArray[2];
                //log.Info(".......................................................................GENERATOR SCREEN STARTED.......................................................................");


            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        #region ** BUTTON FUNCTIONS **

        private void btnExit_Click(object sender, EventArgs e)
        {
            Dispose();
        }

        #endregion



    }
}