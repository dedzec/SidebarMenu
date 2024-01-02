namespace SidebarMenu
{
    public partial class Form1 : Form
    {
        bool sidebarExpand;
        bool homeCollapsed;

        public Form1()
        {
            InitializeComponent();
        }

        private void SidebarTimer_Tick(object sender, EventArgs e)
        {
            //SET the Minimum and maximum size of sidebar Panel

            if (sidebarExpand)
            {
                //if sidebar is expand, minimaize
                sidebar.Width -= 10;
                if (sidebar.Width == sidebar.MinimumSize.Width)
                {
                    sidebarExpand = false;
                    SidebarTimer.Stop();
                }
            }
            else
            {
                sidebar.Width += 10;
                if (sidebar.Width == sidebar.MaximumSize.Width)
                {
                    sidebarExpand = true;
                    SidebarTimer.Stop();
                }
            }
        }

        private void menuButton_Click(object sender, EventArgs e)
        {
            //SET timer interval to lowest to make it smoother
            SidebarTimer.Start();
        }

        private void HomeTimer_Tick(object sender, EventArgs e)
        {
            //SET the Minimum and maximum size of HomeContainer Panel

            if (homeCollapsed)
            {
                HomeContainer.Height += 10;
                if (HomeContainer.Height == HomeContainer.MaximumSize.Height)
                {
                    homeCollapsed = false;
                    HomeTimer.Stop();
                }
            }
            else
            {
                HomeContainer.Height -= 10;
                if (HomeContainer.Height == HomeContainer.MinimumSize.Height)
                {
                    homeCollapsed = true;
                    HomeTimer.Stop();
                }
            }
        }

        private void btnHome_Click(object sender, EventArgs e)
        {
            //SET timer interval to lowest to make it smoother
            HomeTimer.Start();
        }
    }
}