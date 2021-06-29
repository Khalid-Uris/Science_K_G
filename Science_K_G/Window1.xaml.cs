using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;
using System.Data.SqlClient;


namespace Science_K_G
{
    /// <summary>
    /// Interaction logic for Window1.xaml
    /// </summary>
    public partial class Window1 : Window
    {
        SqlConnection conn = new SqlConnection("Data Source=DESKTOP-153RETS;Initial Catalog=Science_G_K;Integrated Security=True");
        SqlCommand cmd;
        //SqlDataAdapter adpt;
        public Window1()
        {
            InitializeComponent();
        }

        private void Add_Click(object sender, RoutedEventArgs e)
        {
            conn.Open();
            cmd = new SqlCommand("insert into Animal values('" + Conservationstatus.Text + "','" + Kingdom.Text + "','" + Class.Text + "','" + Order.Text + "','" + Family.Text + "')", conn);
            cmd.ExecuteNonQuery();
            MessageBox.Show("Your data has been saved in the database");
            conn.Close();
        }
    }
}
