<!-- default file list -->
*Files to look at*:

* [MainPage.xaml](./CS/DataFromXML/MainPage.xaml) (VB: [MainPage.xaml](./VB/DataFromXML/MainPage.xaml))
* [MainPage.xaml.cs](./CS/DataFromXML/MainPage.xaml.cs) (VB: [MainPage.xaml.vb](./VB/DataFromXML/MainPage.xaml.vb))
<!-- default file list end -->
# How to display data from an XML file


<p>This example demonstrates how to read data from an XML file and display it using the DXGrid control.</p><p>The DataSet and DataTable classes are not supported in Silverlight. That is why in this example LINQ to XML approach is used to get data from an XML file. After data items have been selected from XDocument that contains the XML source file, they are gathered into a collection, which is then used as a data source for DXGrid.<br />
</p>

<br/>


