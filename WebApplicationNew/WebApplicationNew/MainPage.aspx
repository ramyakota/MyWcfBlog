<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="MainPage.aspx.cs" Inherits="WebApplicationNew.MainPage" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
     <style type="text/css">
        #header {
    background-color:none;
    color:green;
    text-align:center;
    padding:5px;
}
#footer {
    background-color:none;
    color:blue;
    clear:both;
    text-align:center;
    padding:5px;
}

       body{
           background-image:url(background.jpg); 
           background-size: cover;
           background-repeat: no-repeat;
       }
        .auto-style1 {
            width: 100%;
        }
        .auto-style2 {
            width: 230px;
        }
        .auto-style3 {
            width: 432px;
        }
        .auto-style4 {
            width: 446px;
        }
        .auto-style5 {
            width: 230px;
            height: 30px;
        }
        .auto-style6 {
            width: 446px;
            height: 30px;
        }
        .auto-style7 {
            width: 432px;
            height: 30px;
        }
        .auto-style8 {
            height: 30px;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
    <div id="header">
<h1>MY Blog</h1>
</div>


        <table class="auto-style1">
            
            <tr>
                <td class="auto-style5"></td>
                <td class="auto-style6">
                    <asp:Label ID="lblmsg" runat="server"></asp:Label>
                </td>
                <td class="auto-style7"></td>
               
                <td class="auto-style8"></td>
               
            </tr>
            <tr>
                
                <td class="auto-style2">
                    <h5 style="font:bold;font-size:larger">&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; Explore</h5>
                    <asp:TreeView ID="TreeView1" runat="server">
                        <Nodes>
                            <asp:TreeNode NavigateUrl="MainPage.aspx" Text="Home" Value="Home"></asp:TreeNode>
                            <asp:TreeNode NavigateUrl="CustRegistration.aspx" Text="Registration" Value="Registration"></asp:TreeNode>
                            <asp:TreeNode Text="AbouUS" Value="AbouUS"></asp:TreeNode>
                            <asp:TreeNode Text="ContactUs" Value="ContactUs"></asp:TreeNode>
                        </Nodes>
                    </asp:TreeView>
                </td>
                   
                <td class="auto-style4"  ><h5>&nbsp;</h5>
                    <h5 style="font:bold;font-size:larger" >SignIn here now</h5>
                 UserName&nbsp;<asp:TextBox ID="txtUn" runat="server"></asp:TextBox> 
                    <asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" ErrorMessage="Please Enter UserName" ForeColor="Red" ControlToValidate="txtUn" ValidationGroup="SignIn"></asp:RequiredFieldValidator>
                    <br/>
                    <br/>
                 Password&nbsp;&nbsp; <asp:TextBox ID="txtPwd" runat="server" TextMode="Password"></asp:TextBox>
                    <asp:RequiredFieldValidator ID="RequiredFieldValidator2" runat="server" ErrorMessage="Please enter password" ForeColor="Red" ControlToValidate="txtPwd" ValidationGroup="SignIn"></asp:RequiredFieldValidator>
                    <br/>
                    <br/>
                       &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; &nbsp;&nbsp;<asp:Button ID="btnSignIn" runat="server" Text="SignIn" OnClick="btnSignIn_Click" Width="140" BackColor="Aquamarine" ValidationGroup="SignIn"/>
                    &nbsp;
                    &nbsp;&nbsp;&nbsp;&nbsp;
                    <br />
                    <br />
                    <asp:LinkButton ID="LinkButton1" runat="server" OnClick="LinkButton1_Click">Forgot Password?</asp:LinkButton>
                </td>
                <td class="auto-style3"><h5 style="font:bold;font-size:larger">New Customer/Signup here now</h5>
                 First Name&nbsp; <asp:TextBox ID="txtFName" runat="server"></asp:TextBox><asp:RequiredFieldValidator ErrorMessage="Enter FirstName" Display="Dynamic" ForeColor="Red"
                ControlToValidate="txtFName" runat="server" ValidationGroup="SignUp" /><br/><br/>
                 Email&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; <asp:TextBox ID="txtEmail" runat="server"></asp:TextBox><asp:RegularExpressionValidator runat="server" Display="Dynamic" ValidationExpression="\w+([-+.']\w+)*@\w+([-.]\w+)*\.\w+([-.]\w+)*"
                ControlToValidate="txtEmail" ForeColor="Red" ErrorMessage="Invalid email address." ValidationGroup="SignUp" /><asp:RequiredFieldValidator ErrorMessage="Enter Email address" Display="Dynamic" ForeColor="Red"
                ControlToValidate="txtEmail" runat="server" ValidationGroup="SignUp" /><br/><br/>
                                    &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; &nbsp;
                    <asp:Button ID="btnSignUp"  runat="server" Text="SignUp" OnClick="btnSignUp_Click" ValidationGroup="SignUp" Width="140" BackColor="Aquamarine"  />
                    
                                    </td>
               
                <td>&nbsp;</td>
               
            </tr>
            <tr>
                <td class="auto-style2">&nbsp;</td>
                <td class="auto-style4">&nbsp;</td>
                <td class="auto-style3">&nbsp;</td>
                
                <td>&nbsp;</td>
                
            </tr>
          
        </table>
        <div id="footer">
            Copyright © Amit & Ramya
        </div>
   
            </form>
</body>
</html>
