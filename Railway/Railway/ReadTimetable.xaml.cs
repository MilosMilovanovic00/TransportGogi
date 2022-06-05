using Railway.Model;
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

namespace Railway
{
    /// <summary>
    /// Interaction logic for ReadTimetable.xaml
    /// </summary>
    public partial class ReadTimetable : Page
    {
        private Frame managerContentFrame;
        public ReadTimetable(Frame managerContentFrame)
        {
            InitializeComponent();
            this.managerContentFrame = managerContentFrame;


            int timetableIndex = 1;

            foreach (Trainline trainline in Data.GetTrainLines())
            {
                foreach (Timetable timetable in trainline.Timetables)
                {
                    OneTimetable oneTimetable = new OneTimetable(managerContentFrame, timetable);
                    addRowPixels(ReadTimetableGrid, oneTimetable.getHeight());
                    Grid.SetRow(oneTimetable, timetableIndex);

                    ReadTimetableGrid.Children.Add(oneTimetable);
                    timetableIndex++;
                }


            }

        }

        private void addRowPixels(Grid grid, double height)
        {
            var rd = new RowDefinition();
            rd.Height = new GridLength(height);
            grid.RowDefinitions.Add(rd);
        }

        private void AddNewTimetable_Click(object sender, RoutedEventArgs e)
        {

        }
    }
}
