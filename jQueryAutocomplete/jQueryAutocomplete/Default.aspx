<%@ Page Title="Home Page" Language="C#" MasterPageFile="~/Site.master" AutoEventWireup="true"
    CodeBehind="Default.aspx.cs" Inherits="jQueryAutocomplete._Default" %>

<asp:Content ID="HeaderContent" runat="server" ContentPlaceHolderID="HeadContent">
</asp:Content>
<asp:Content ID="BodyContent" runat="server" ContentPlaceHolderID="MainContent">
     <div>
       Enter Country Name: &nbsp; &nbsp; <asp:TextBox ID="txtCountry" runat="server"></asp:TextBox>
     </div>
     <br />
     <div>
        <table id="tblCustomers" class="tblCustomers" >            
            <thead>
                <tr>
                    <th align="left" class="customerth">CustomerID</th>    
                    <th align="left" class="customerth">CompanyName</th>    
                    <th align="left" class="customerth">ContactName</th>    
                    <th align="left" class="customerth">ContactTitle</th> 
                    <th align="left" class="customerth">City</th>
                    <th align="left" class="customerth">Phone</th>  
                </tr>
            </thead> 
            <tbody>
            
            </tbody> 
        </table>        
     </div>
</asp:Content>
