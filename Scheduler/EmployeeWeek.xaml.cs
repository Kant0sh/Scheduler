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
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace Scheduler
{
    /// <summary>
    /// Interaction logic for EmployeeWeek.xaml
    /// </summary>
    public partial class EmployeeWeek : UserControl
    {

        private EmployeeDay[] days;

        private int dayCount;
        private int startDay;

        public EmployeeWeek(int dayCount, int startDay)
        {

            this.dayCount = dayCount;
            this.startDay = startDay;

            days = new EmployeeDay[dayCount];

            for(int i = 0; i < days.Length; i++)
            {
                days[i] = new EmployeeDay();
            }

            InitializeComponent();
        }
    }
}
