<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Index.aspx.cs" Inherits="WebApplication1.WebForm1" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style type="text/css">
        .auto-style1 {
            width: 595px;
            height: 75px;
        }

        .auto-style2 {
            width: 123px;
            height: 123px;
        }
    </style>
</head>
<body style="margin-left: 5px; margin-top: 5px; background-color: white">
    <form id="form1" runat="server">
        <div>
            <b><font style="font-family: Arial Black; color: black; font-size: 48px">Cloud Management Services</font></b>
            <br />
            <asp:Label ID="Label1" runat="server" Font-Italic="True" Font-Names="Arial" Font-Size="Small" Style="z-index: 1; left: 12px; top: 84px; position: absolute" Text="Powered by" EnableTheming="False"></asp:Label>
            <br />
            <img alt="Weblink" class="auto-style1" src="Images/ws-company.png" style="z-index: 1; left: 2px; top: 100px; position: absolute" />
            <br />
            <asp:TextBox ID="TextBox1" runat="server" Style="z-index: 1; left: 390px; top: 275px; position: absolute" onkeyup="javascript:this.value = this.value.toUpperCase();" MaxLength="12"></asp:TextBox>
            <asp:TextBox ID="TextBox2" runat="server" Style="z-index: 1; left: 390px; top: 315px; position: absolute" MaxLength="12"></asp:TextBox>
            <asp:TextBox ID="TextBox3" runat="server" Style="z-index: 1; left: 390px; top: 355px; position: absolute" TextMode="Password" MaxLength="50"></asp:TextBox>
            <br />
            <asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" ControlToValidate="TextBox1" ErrorMessage="*" Style="z-index: 1; left: 370px; top: 275px; position: absolute"></asp:RequiredFieldValidator>
            <asp:RequiredFieldValidator ID="RequiredFieldValidator2" runat="server" ControlToValidate="TextBox2" ErrorMessage="*" Style="z-index: 1; left: 370px; top: 315px; position: absolute"></asp:RequiredFieldValidator>
            <asp:RequiredFieldValidator ID="RequiredFieldValidator3" runat="server" ControlToValidate="TextBox3" ErrorMessage="*" Style="z-index: 1; left: 370px; top: 355px; position: absolute"></asp:RequiredFieldValidator>
            <br />
            <asp:Label ID="Label2" runat="server" Font-Names="Arial" Font-Size="Medium" Style="z-index: 1; left: 150px; top: 275px; position: absolute; width: 155px" Text="Organisation" EnableTheming="False"></asp:Label>
            <asp:Label ID="Label3" runat="server" Font-Names="Arial" Font-Size="Medium" Style="z-index: 1; left: 150px; top: 315px; position: absolute; width: 155px" Text="User ID" EnableTheming="False"></asp:Label>
            <asp:Label ID="Label4" runat="server" Font-Names="Arial" Font-Size="Medium" Style="z-index: 1; left: 150px; top: 355px; position: absolute; width: 155px" Text="Password" EnableTheming="False"></asp:Label>
            <br />
            <hr style="width: 100%; text-align: left; margin-left: 0; position: absolute; top: 225px; left: 0px;" />
            <hr style="width: 100%; text-align: left; margin-left: 0; position: absolute; top: 430px; left: 0px;" />
            <br />
            <asp:Button ID="Button1" runat="server" Style="z-index: 1; left: 5px; top: 450px; position: absolute" Text="Submit Data" OnClick="Button1_Click" />
            <asp:Button ID="Button2" runat="server" Style="z-index: 1; left: 145px; top: 450px; position: absolute" Text="Cancel Data" CausesValidation="False" OnClick="Button2_Click" />

            <img alt="Security" class="auto-style2" src="Images/security.jpg" style="position: absolute; top: 270px; left: 5px;" />
        </div>
        <asp:Label ID="Label5" runat="server" Font-Italic="True" Font-Names="Arial" Font-Size="Medium" ForeColor="#CC3300" style="z-index: 1; left: 15px; top: 410px; position: absolute" EnableTheming="False"></asp:Label>
        <asp:Label ID="Label6" runat="server" EnableTheming="False" Font-Names="Arial" Font-Size="Small" Font-Underline="True" style="z-index: 1; left: 765px; top: 40px; position: absolute" Text="Ver 1.1"></asp:Label>
        <asp:Button ID="Button3" runat="server" style="z-index: 1; left: 5px; top: 500px; position: absolute" Text="Tennat (Admin)" OnClick="Button3_Click" CausesValidation="False" />
        <asp:Button ID="Button4" runat="server" style="z-index: 1; left: 5px; top: 550px; position: absolute" Text="Tenant (User)" OnClick="Button4_Click" CausesValidation="False" />
    </form>
</body>
</html>
