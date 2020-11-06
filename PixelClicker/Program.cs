using System.Windows.Forms;
using PixelClicker.Forms;

namespace PixelClicker
{
    public class Program
    {
        private static DashboardForm Dashboard;

        public static void Main(string[] arguments)
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            Dashboard = new DashboardForm();
            Application.Run(Dashboard);
        }
    }
}