namespace HealthCareApp
{
    public partial class MainPage : Form
    {
        
        public MainPage(String name)
        {
            InitializeComponent();

            this.userInfo.Text = name;
        }
    }
}
