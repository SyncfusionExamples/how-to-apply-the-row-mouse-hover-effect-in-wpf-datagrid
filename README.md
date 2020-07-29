# How to apply the row mouse hover effect in WPF DataGrid(SfDataGrid)?

## About the sample
This example illustrates how to apply the row mouse hover effect in WPF DataGrid(SfDataGrid)?

By default, SfDataGrid provide the direct support for change the background color when mouse hover. You can achieve this by enabling the AllowRowHoverHighlighting property and set the color by using RowHoverHighlightingBrush property in SfDataGrid.

```XML
<syncfusion:SfDataGrid x:Name="sfDataGrid"
                               AllowRowHoverHighlighting="True"
                               RowHoverHighlightingBrush="Yellow"
                               AllowResizingColumns="True"
                               ColumnSizer="Star"                              
                               ItemsSource="{Binding Orders}"                                                             
                               AutoGenerateColumns="False">
           <syncfusion:SfDataGrid.Columns>
                <syncfusion:GridTextColumn HeaderText="Order ID" MappingName="OrderID"/>
                <syncfusion:GridTextColumn HeaderText="Customer ID" MappingName="CustomerID" />
                <syncfusion:GridTextColumn HeaderText="Customer Name" MappingName="CustomerName" />
                <syncfusion:GridTextColumn HeaderText="Country" MappingName="Country" />
                <syncfusion:GridTextColumn HeaderText="Unit Price" MappingName="UnitPrice" TextAlignment="Right"/>
            </syncfusion:SfDataGrid.Columns>
</syncfusion:SfDataGrid>

```

![Row mouse hover effect in SfDataGrid](RowMouseOver.gif)

## Requirements to run the demo
Visual Studio 2015 and above versions

