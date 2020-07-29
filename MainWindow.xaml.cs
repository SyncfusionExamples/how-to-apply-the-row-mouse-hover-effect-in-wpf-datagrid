using System;
using Syncfusion.Data;
using Syncfusion.UI.Xaml.Grid;
using Syncfusion.UI.Xaml.Grid.Helpers;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Globalization;
using System.Windows.Media;

namespace SfDataGridDemo
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            this.sfDataGrid.MouseMove += SfDataGrid_MouseMove;
        }

        private void SfDataGrid_MouseMove(object sender, System.Windows.Input.MouseEventArgs e)
        {
            //With the help of VisualContainer ,you can get the row and column index based on the mouse move pointer position
            var visualcontainer = this.sfDataGrid.GetVisualContainer();
            // Gets the exact position where the mouse pointer is moved 
            var point = e.GetPosition(visualcontainer);
            //Here you can get the row and column index based on the pointer position by using PointToCellRowColumnIndex() method
            var rowColumnIndex = visualcontainer.PointToCellRowColumnIndex(point);
            if (!rowColumnIndex.IsEmpty)
            {
                sfDataGrid.AllowRowHoverHighlighting = true;
                sfDataGrid.RowHoverHighlightingBrush = Brushes.Yellow;
            }
        }
    }  
}

         
   

