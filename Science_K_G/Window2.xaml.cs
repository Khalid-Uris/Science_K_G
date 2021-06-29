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
    /// Interaction logic for Window2.xaml
    /// </summary>
    public partial class Window2 : Window
    {
        SqlConnection con = new SqlConnection("Data Source=DESKTOP-153RETS;Initial Catalog=Science_G_K;Integrated Security=True");
        SqlCommand cmd;
        public Window2()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            con.Open();
            cmd = new SqlCommand("insert into Planet values('" + textbox1.Text + "','" + textbox2.Text + "','" + textbox3.Text + "','" + textbox4.Text + "','"+textbox5.Text+"','"+textbox6.Text+"','"+textbox7.Text+"')", con);
            cmd.ExecuteNonQuery();
            MessageBox.Show("Your data has been saved in the database ");

            con.Close();

        }
    }
}
