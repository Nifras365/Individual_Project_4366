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

namespace Student_management_system_4366
{
    public partial class ListviewWindow : Window
    {
        public ListviewWindow()
        {
            DataContext = new ListviewWindowVM();
            InitializeComponent();
        }
    }
}
