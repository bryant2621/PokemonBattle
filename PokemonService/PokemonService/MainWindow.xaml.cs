using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceModel.Web;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace PokemonService
{
    /// <summary>
    /// MainWindow.xaml 的交互逻辑
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();

            try
            {
                WebServiceHost RestHost = new WebServiceHost(typeof(TestService.RestTestService));
                RestHost.Open();
                msg.Text += "\n 服务开启成功";
            }
            catch (Exception ex)
            {
                msg.Text += "\n 服务开启失败：" + ex.ToString();
            }
        }
    }
}
