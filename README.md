# How to apply the row mouse hover effect in WPF DataGrid(SfDataGrid)?

## About the sample
This example illustrates how to apply the row mouse hover effect in WPF DataGrid(SfDataGrid)?

By default, SfDataGrid does not provide the direct support for change the background color when mouse hover. You can change the background color by using MouseMove event in SfDataGrid.

```C#
this.sfDataGrid.MouseMove += SfDataGrid_MouseMove;

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

```

![Row mouse hover effect in SfDataGrid](RowMouseOver.gif)

## Requirements to run the demo
Visual Studio 2015 and above versions

