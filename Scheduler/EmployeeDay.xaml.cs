﻿using System;
using System.Collections.Generic;
using System.Globalization;
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
    /// Interaction logic for EmployeeDay.xaml
    /// </summary>
    public partial class EmployeeDay : UserControl
    {

        private List<TaskView> taskViewList;

        public EmployeeDay()
        {

            taskViewList = new List<TaskView>();

            InitializeComponent();
        }

        public void AddTask(WorkTask task)
        {
            taskViewList.Add(new TaskView(task));
        }

    }
}
