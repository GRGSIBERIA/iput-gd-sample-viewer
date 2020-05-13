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
using System.Windows.Threading;

namespace WPFViewer.Navigations
{
    /// <summary>
    /// ListingImageUserControl.xaml の相互作用ロジック
    /// </summary>
    public partial class ListingImageUserControl : UserControl
    {
        private double gridWidth;
        private double gridHeight;

        private void GetActualSize()
        {
            gridWidth = baseGridWidgth.ActualWidth;
            gridHeight = baseGridHeight.ActualHeight;
        }

        public ListingImageUserControl()
        {
            InitializeComponent();

            Dispatcher.BeginInvoke(new Action(() => {
                GetActualSize();
            }), DispatcherPriority.Loaded);
        }

        private void Grid_SizeChanged(object sender, SizeChangedEventArgs e)
        {
            GetActualSize();
        }
    }
}
