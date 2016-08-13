<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="SignUpPage.aspx.cs" Inherits="WebApplicationNew.SignUpPage" %>

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
        .auto-style2 {
            height: 31px;
        }
    </style>
    <script type="text/javascript">
    function validate() 
    {
	var Firstname = document.getElementById('<%=txtfirstname.ClientID %>').value;
    var LastName = document.getElementById('<%=txtlastname.ClientID %>').value;
        var Userid = document.getElementById('<%=txtuserid.ClientID %>').value;
        var Password = document.getElementById('<%=txtpassword.ClientID %>').value;
        var ConfirmPassword = document.getElementById('<%=txtrepassword.ClientID %>').value;
         var Email = document.getElementById('<%=txtemail.ClientID %>').value;
        var Month = document.getElementById('<%=dropdownmonth.ClientID %>').value;
        var Day = document.getElementById('<%=dropdownday.ClientID %>').value;
        var Year = document.getElementById('<%=dropdownyear.ClientID %>').value;
         var Gender = document.getElementById('<%=txtgender.ClientID %>').value;
        var Addr1 = document.getElementById('<%=txtaddr1.ClientID %>').value;
        var Street   = document.getElementById('<%=txtstreet.ClientID %>').value;
        var City = document.getElementById('<%=txtcity.ClientID %>').value;
        var State = document.getElementById('<%=txtpassword.ClientID %>').value;
        var ZipCode = document.getElementById('<%=txtpassword.ClientID %>').value;
        var MobileNumber = document.getElementById('<%=txtpassword.ClientID %>').value;
        if (Firstname == "") {
            alert("Enter First Name");
            return false;
        }
        if (LastName == "") {
            alert("Enter Last Name");
            return false;
        }

        if (Userid == "") {
            alert("Enter Userid");
            return false;
        }
        if (Password == "") {
            alert("Enter Userid");
            return false;
        }
        if (Password != ConfirmPassword) {
            alert("Passwords do not match.");
            return false;
        }
        if (Email == "") {
            alert("Enter Email");
            return false;
        }
        var emailPat = /^(\".*\"|[A-Za-z]\w*)@(\[\d{1,3}(\.\d{1,3}){3}]|[A-Za-z]\w*(\.[A-Za-z]\w*)+)$/
        var EmailmatchArray = Email.match(emailPat);
        if (EmailmatchArray == null) {
            alert("Your email address seems incorrect. Please try again.");
            return false;
        }
        if (Month == "--Select Month--") {
            alert("Select Month");
            return false;
        }
        if (Day == "--Select Day--") {
            alert("Select Day");
            return false;
        }
        if (Year == "--Select Year--") {
            alert("Select Year");
            return false;
        }
    
        return true;

        if (Addr1 == "") {
            alert("Enter Userid");
            return false;
        }
        if (Street == "") {
            alert("Enter Userid");
            return false;
        }
        if (City == "") {
            alert("Enter Userid");
            return false;
        }
        if (State == "") {
            alert("Enter Userid");
            return false;
        }
        if (ZipCode == "") {
            alert("Enter Userid");
            return false;
        }
        if (MobileNumber == "") {
            alert("Enter Userid");
            return false;
        }
    }
        function validatepassword()
        {
            var PasswordTextBox = document.getElementById('<%=txtpassword.ClientID %>');
            var Password = PasswordTextBox.value;
        var SpecialCharacters = "!@#$%^&*~_?";
        var passwordscore = 0;
        for (var i = 0; i < Password.length; i++)
        {
            if(SpecialCharacters.indexOf(Password.charAt(i)) > -1)
            {
                passwordscore += 20;
            }
        }
        if (/[a-z]/.test(Password)) {
            passwordscore += 20;
        }
        if (/[A-Z]/.test(Password))
        {
            passwordscore += 20;
        }
        if (/[\d]/.test(Password)) {
            passwordscore += 20;
        }
        if (Password.length >= 8)
        {
            passwordscore += 20;
        }
        var strength = "";
        var backgroundcolor = "";
        if (passwordscore >= 100)
        {
            strength = "Strong";
            backgroundcolor = "green";
        }
       else  if (passwordscore >= 80) {
            strength = "Medium";
            backgroundcolor = "gray";
        }
       else  if (passwordscore >= 60) {
            strength = "Weak";
            backgroundcolor = "maroon";
        }
       else {
            strength = "Very Weak";
            backgroundcolor = "red";
        }
        document.getElementById("lblpassword").innerHTML = strength;
        PasswordTextBox.style.backgroundcolor = backgroundcolor;
        }

        function ValidateRadioButtonList() {
                       var isChecked = false;
                       var rblImageFormat = document.getElementById("<%=txtgender.ClientID%>");
                       var radioButtons = rblImageFormat.getElementsByTagName("input");
                       for (var i = 0; i < radioButtons.length; i++) {
                               if (radioButtons[i].checked) {
                                       isChecked = true;
                                       break;
                               }
                       }

                       if (!isChecked) {
                               alert("Please Select Gender");
                       }

                       return isChecked;
               }
</script>
  
</head>
<body>
    <form id="form1" runat="server">
    <div>
    
        <table class="auto-style1">
            <tr>
                <td class="auto-style2"><h4>Sign Up</h4></td>
                <td class="auto-style2"></td>
                <td class="auto-style2"></td>
            </tr>
            <tr>
                <td>
                   First Name&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; <asp:TextBox ID="txtfirstname" runat="server" ToolTip="Enter your First Name"></asp:TextBox>
                <%--    <asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" ControlToValidate="txtfirstname" ErrorMessage="Enter firstname" ForeColor="Red"></asp:RequiredFieldValidator>--%>
                    </br>
                   Last Name&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; <asp:TextBox ID="txtlastname" runat="server" ToolTip="Enter your First Name"></asp:TextBox><%--<asp:RequiredFieldValidator ID="RequiredFieldValidator2" runat="server" ForeColor="Red" ControlToValidate="txtlastname" ErrorMessage="Enter lastname"></asp:RequiredFieldValidator>--%>
                    <br />
                    Userid&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; <asp:TextBox ID="txtuserid" runat="server"></asp:TextBox><%--<asp:RequiredFieldValidator ID="RequiredFieldValidator3" runat="server" ControlToValidate="txtuserid" ForeColor="Red" ErrorMessage="Enter user id"></asp:RequiredFieldValidator>--%>
                         <%-- <asp:RegularExpressionValidator runat=server display=dynamic
            controltovalidate="txtuserid" 
            errormessage="ID must be 6-10 letters." 
            validationexpression="[a-zA-Z]{6,10}" />
--%>
                    <%-- <asp:CustomValidator runat=server
            controltovalidate="txtuserid" 
            errormessage="ID is already in use." 
            OnServerValidate="CheckID" />--%>
                    <br />
                    Password&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; <asp:TextBox ID="txtpassword" runat="server" placeholder="Enter Password" TextMode="Password" OnKeyUP="validatepassword()"></asp:TextBox>
                    <%--<asp:RequiredFieldValidator ID="RequiredFieldValidator4" runat="server" ControlToValidate="txtpassword" ForeColor="Red" ErrorMessage="Enter password"></asp:RequiredFieldValidator>--%>
                  <%-- <asp:RegularExpressionValidator runat=server display=dynamic
            controltovalidate="txtpassword" 
            errormessage="Password must contain one of @#$%^&*/."
            validationexpression=".*[@#$%^&*/].*" />
      <asp:RegularExpressionValidator runat=server display=dynamic
            controltovalidate="txtpassword" 
            errormessage="Password must be 8-12 nonblank characters." 
            validationexpression="[^\s]{8,12}"/>--%>
                    <asp:Label ID="lblpassword" runat="server"></asp:Label>
                    <br />
                    Confirm Password<asp:TextBox ID="txtrepassword" runat="server" placeholder="ReEnter Password" TextMode="Password"></asp:TextBox><%--<asp:CompareValidator ID="CompareValidator2" runat="server" ErrorMessage="Re-Enter correct password" ForeColor="Red" ControlToValidate="txtrepassword" ControlToCompare="txtpassword"></asp:CompareValidator>--%>
                    <br/>
                   Email&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; <asp:TextBox ID="txtemail" runat="server" ToolTip="Enter your First Name"></asp:TextBox></br/><%--<asp:RegularExpressionValidator runat="server" Display="Dynamic" ValidationExpression="\w+([-+.']\w+)*@\w+([-.]\w+)*\.\w+([-.]\w+)*"
                ControlToValidate="txtemail" ForeColor="Red" ErrorMessage="Invalid email address." />--%></br>
                    Re-Enter Email&nbsp;&nbsp;&nbsp;&nbsp; <asp:TextBox ID="txtreemail" runat="server"></asp:TextBox>
                    <asp:CompareValidator ID="CompareValidator1" runat="server" ForeColor="Red" ErrorMessage="Re-Enter correct email" ControlToValidate="txtreemail" ControlToCompare="txtemail"></asp:CompareValidator>
                    <br />
                    Birthday

                    <br />
                    Month<asp:DropDownList ID="dropdownmonth" runat="server">
                        <asp:ListItem>--Select Month--</asp:ListItem>
                        <asp:ListItem Value="01">Jan</asp:ListItem>
                        <asp:ListItem Value="02">Feb</asp:ListItem>
                        <asp:ListItem Value="03">Mar</asp:ListItem>
                        <asp:ListItem Value="04">Apr</asp:ListItem>
                        <asp:ListItem Value="05">May</asp:ListItem>
                        <asp:ListItem Value="06">Jun</asp:ListItem>
                        <asp:ListItem Value="07">Jul</asp:ListItem>
                        <asp:ListItem Value="08">Aug</asp:ListItem>
                        <asp:ListItem Value="09">Sep</asp:ListItem>
                        <asp:ListItem Value="10">Oct</asp:ListItem>
                        <asp:ListItem Value="11">Nov</asp:ListItem>
                        <asp:ListItem Value="12">Dec</asp:ListItem>
                    </asp:DropDownList>
&nbsp;&nbsp;&nbsp;
                    Day<asp:DropDownList ID="dropdownday" runat="server">
                        <asp:ListItem>--Select Day--</asp:ListItem>
                        <asp:ListItem>01</asp:ListItem>
                        <asp:ListItem>02</asp:ListItem>
                        <asp:ListItem>03</asp:ListItem>
                        <asp:ListItem>04</asp:ListItem>
                        <asp:ListItem>05</asp:ListItem>
                        <asp:ListItem>06</asp:ListItem>
                        <asp:ListItem>07</asp:ListItem>
                        <asp:ListItem>08</asp:ListItem>
                        <asp:ListItem>09</asp:ListItem>
                        <asp:ListItem>10</asp:ListItem>
                        <asp:ListItem>11</asp:ListItem>
                        <asp:ListItem>12</asp:ListItem>
                        <asp:ListItem>13</asp:ListItem>
                        <asp:ListItem>14</asp:ListItem>
                        <asp:ListItem>15</asp:ListItem>
                        <asp:ListItem>16</asp:ListItem>
                        <asp:ListItem>17</asp:ListItem>
                        <asp:ListItem>18</asp:ListItem>
                        <asp:ListItem>19</asp:ListItem>
                        <asp:ListItem>20</asp:ListItem>
                        <asp:ListItem>21</asp:ListItem>
                        <asp:ListItem>22</asp:ListItem>
                        <asp:ListItem>23</asp:ListItem>
                        <asp:ListItem>24</asp:ListItem>
                        <asp:ListItem>25</asp:ListItem>
                        <asp:ListItem>26</asp:ListItem>
                        <asp:ListItem>27</asp:ListItem>
                        <asp:ListItem>28</asp:ListItem>
                        <asp:ListItem>29</asp:ListItem>
                        <asp:ListItem>30</asp:ListItem>
                        <asp:ListItem>31</asp:ListItem>
                    </asp:DropDownList>
&nbsp;&nbsp;&nbsp;
                    Year<asp:DropDownList ID="dropdownyear" runat="server">
                        <asp:ListItem>--Select Year--</asp:ListItem>
                        <asp:ListItem>1990</asp:ListItem>
                        <asp:ListItem>1991</asp:ListItem>
                        <asp:ListItem>1992</asp:ListItem>
                        <asp:ListItem>1993</asp:ListItem>
                        <asp:ListItem>1994</asp:ListItem>
                        <asp:ListItem>1995</asp:ListItem>
                    </asp:DropDownList>

                    

                    <br />
                   <!-- Gender<br />
                    Male<asp:RadioButton ID="radiomale" runat="server" />
&nbsp;&nbsp;&nbsp;
                    Female<asp:RadioButton ID="radiofemale" runat="server" />-->

                   Gender: <asp:RadioButtonList ID="txtgender" runat="server" ItemType="" OnKeyUp="ValidateRadioButtonList()">
                       <asp:ListItem Value="Male">Male</asp:ListItem>
                        <asp:ListItem Value="Female">Female</asp:ListItem>
                    </asp:RadioButtonList>

                    <br />
                    Address:<br />
                    Addr1&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; <asp:TextBox ID="txtaddr1" runat="server"></asp:TextBox><asp:RequiredFieldValidator ID="RequiredFieldValidator5" runat="server" ControlToValidate="txtaddr1" ErrorMessage="Enter address line1" ForeColor="Red"></asp:RequiredFieldValidator>
                    <br />
                    Addr2&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; <asp:TextBox ID="txtaddr2" runat="server"></asp:TextBox>
                    <br />
                    Street&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; <asp:TextBox ID="txtstreet" runat="server"></asp:TextBox>
                    <br />
                    City&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; <asp:TextBox ID="txtcity" runat="server"></asp:TextBox>
                    <asp:RequiredFieldValidator ID="RequiredFieldValidator6" runat="server" ControlToValidate="txtcity" ErrorMessage="Enter City" ForeColor="Red"></asp:RequiredFieldValidator>
                    <br />
                    State&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; <asp:TextBox ID="txtstate" runat="server"></asp:TextBox><asp:RequiredFieldValidator ID="RequiredFieldValidator7" runat="server" ControlToValidate="txtstate" ErrorMessage="Enter State" ForeColor="Red"></asp:RequiredFieldValidator>
                    <br />
                    Zipcode&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; <asp:TextBox ID="txtzip" runat="server"></asp:TextBox><asp:RequiredFieldValidator ID="RequiredFieldValidator8" runat="server" ControlToValidate="txtzip" ErrorMessage="Enter Zipcode" ForeColor="Red"></asp:RequiredFieldValidator>
                    <br />
                    Mobile Number&nbsp; <asp:TextBox ID="txtmobile" runat="server" TextMode="Phone"></asp:TextBox><asp:RequiredFieldValidator ID="RequiredFieldValidator9" runat="server" ControlToValidate="txtmobile" ErrorMessage="Enter mobile number" ForeColor="Red"></asp:RequiredFieldValidator>

                </td>
                <td>&nbsp;</td>
                <td>&nbsp;</td>
            </tr>
            <tr>
                <td>
                    <asp:Button ID="Button1" runat="server" Text="Submit" OnClientClick="return validate();" onclick="Button1_Click" />
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; </td>
                <td>&nbsp;</td>
                <td>&nbsp;</td>
            </tr>
        </table>
    
    </div>

    </form>
</body>
</html>
