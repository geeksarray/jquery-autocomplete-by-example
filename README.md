# jQuery Autocomplete by example

This article helps you to create an AutoComplete textbox using jQuery library. This will also give you details about jQuery AutoComplete UI, CSS, and select event.

In this example, you will create a ASP.NET Web Form application that will connect to the Northwind database. If you do not have the Northwind database you can download from 
[here](https://github.com/geeksarray/SQLSampleDatabase/blob/master/Northwind.sql). The AutoComplete TextBox's change event will call PageMethod written in WebForm code behind file. This method will get country names from the Customer table and return as a suggestion for AutoComplete TextBox.

## Files

1. [Default.aspx](https://github.com/geeksarray/jquery-autocomplete-by-example/blob/master/jQueryAutocomplete/jQueryAutocomplete/Default.aspx) - includes Customer HTML table to update its content on after changing conent in Country text box.
1. [Default.aspx.cs](https://github.com/geeksarray/jquery-autocomplete-by-example/blob/master/jQueryAutocomplete/jQueryAutocomplete/Default.aspx.cs) - code behind file for default.aspx having web methods.
1. [Customer Entity](https://github.com/geeksarray/jquery-autocomplete-by-example/blob/master/jQueryAutocomplete/jQueryAutocomplete/Default.aspx.cs) - customer model used for creating list of customers.

After implementation your page will be like

![jQuery UI Autocomplete](http://dotnetmentors.com/Images/jquery%20autocomplete%20in%20asp.net.png)

For more details visit - https://geeksarray.com/blog/jquery-autocomplete-by-example
