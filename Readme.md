<!-- default file list -->
*Files to look at*:

* [Default.aspx](./CS/Default.aspx) (VB: [Default.aspx](./VB/Default.aspx))
* [Default.aspx.cs](./CS/Default.aspx.cs) (VB: [Default.aspx.vb](./VB/Default.aspx.vb))
<!-- default file list end -->
# ASPxComboBox - How to "autogenerate" columns
<!-- run online -->
**[[Run Online]](https://codecentral.devexpress.com/e4873/)**
<!-- run online end -->


<p>The example shows how to make ASPxComboBox "autogenerate" columns. You have not included them in the markup of the page. It uses SqlDataSource to bind ASPxComboBox to a database. If you are using another datasource, the implementation may differ.</p><p>On ASPxComboBox initialization, it selects data. This data is then used for adding columns to ASPxComboBox. Each column is provided with a user-friendly caption that contains whitespaces before capital letters. It is done with the help of two regular expressions.</p>


<h3>Description</h3>

<p><br />
</p>

<br/>


