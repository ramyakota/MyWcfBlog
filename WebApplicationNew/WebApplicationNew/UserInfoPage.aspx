<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="UserInfoPage.aspx.cs" Inherits="WebApplicationNew.UserInfoPage" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
     <style type="text/css">
         body{
           background-image:url(background.jpg); 
           background-size: cover;
           background-repeat: no-repeat;
       }
        .auto-style1 {
            width: 100%;
        }
        </style> <style type="text/css">
         body{
           background-image:url(background.jpg); 
           background-size: cover;
           background-repeat: no-repeat;
       }
        .auto-style1 {
            width: 100%;
        }
        </style>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    
        <table class="auto-style1">
            <tr>
                <td>
                    Userid&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; <asp:TextBox ID="txtuserid" runat="server"></asp:TextBox>                         <%-- <asp:RegularExpressionValidator runat=server display=dynamic
            controltovalidate="txtuserid" 
            errormessage="ID must be 6-10 letters." 
            validationexpression="[a-zA-Z]{6,10}" />
--%>                    <%-- <asp:CustomValidator runat=server
            controltovalidate="txtuserid" 
            errormessage="ID is already in use." 
            OnServerValidate="CheckID" />--%>
                    <br />
                   First Name&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; <asp:TextBox ID="txtfirstname" runat="server" ToolTip="Enter your First Name"></asp:TextBox>
                    </br>
                   Last Name&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; <asp:TextBox ID="txtlastname" runat="server" ToolTip="Enter your Last Name"></asp:TextBox>
                    <br />
                   Email&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; <asp:TextBox ID="txtemail" runat="server" ToolTip="Enter your Valid Email Address"></asp:TextBox>

                    <br />
                    Address:<br />
                    Addr1&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; <asp:TextBox ID="txtaddr1" runat="server"></asp:TextBox>
                    <br />
                    Addr2&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; <asp:TextBox ID="txtaddr2" runat="server"></asp:TextBox>
                    <br />
                    Street&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; <asp:TextBox ID="txtstreet" runat="server"></asp:TextBox>
                    <br />
                    City&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; <asp:TextBox ID="txtcity" runat="server"></asp:TextBox>
                    <br />
                    State&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; <asp:TextBox ID="txtstate" runat="server"></asp:TextBox>
                    <br />
                    Zipcode&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; <asp:TextBox ID="txtzip" runat="server"></asp:TextBox>
                    <br />
                    Mobile Number&nbsp; <asp:TextBox ID="txtmobile" runat="server" TextMode="Phone"></asp:TextBox>

                </td>
            </tr>
            <tr>
                <td>
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; &nbsp;&nbsp;<asp:Button ID="btnedit" runat="server" Text="Edit&Save" OnClick="btnedit_Click" />
                    &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; 
                    </td>
            </tr>
        </table>
    
    </div>
    </form>
</body>
</html>
