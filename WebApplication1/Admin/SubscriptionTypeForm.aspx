<%@ Page Title="" Language="C#" MasterPageFile="~/Application.Master" AutoEventWireup="true" CodeBehind="SubscriptionTypeForm.aspx.cs" Inherits="WebApplication1.Admin.SubscriptionTypeForm" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <p></p>
    <asp:Label ID="Label1" runat="server" Text="Subscription Type Form" Font-Bold="True" Font-Names="Arial" Font-Size="Medium" EnableTheming="False" Style="z-index: 1; left: 15px; top: 140px; position: absolute"></asp:Label>
    <hr style="width: 100%; text-align: left; margin-left: 0; position: absolute; top: 160px; left: 0px;" />
        <p></p>
    <asp:Label ID="Label11" runat="server" Style="z-index: 1; left: 155px; top: 180px; position: absolute" Text="Label">Subscription Type ID</asp:Label>
    <asp:Label ID="Label12" runat="server" Style="z-index: 1; left: 155px; top: 220px; position: absolute" Text="Label">Subscription Type Name</asp:Label>
    <asp:Label ID="Label13" runat="server" Style="z-index: 1; left: 155px; top: 260px; position: absolute" Text="Label">Users (Nos)</asp:Label>
    <asp:Label ID="Label14" runat="server" Style="z-index: 1; left: 155px; top: 300px; position: absolute" Text="Label">Storage (GBs)</asp:Label>
    <asp:Label ID="Label15" runat="server" Style="z-index: 1; left: 155px; top: 340px; position: absolute" Text="Label">Bandwidth (MBs)</asp:Label>
    <asp:Label ID="Label16" runat="server" Style="z-index: 1; left: 155px; top: 380px; position: absolute" Text="Label">Duration</asp:Label>
    <p></p>
    <asp:RequiredFieldValidator ID="RequiredFieldValidator2" runat="server" ControlToValidate="TextBox1" ErrorMessage="*" Style="z-index: 1; left: 370px; top: 180px; position: absolute"></asp:RequiredFieldValidator>
    <asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" ControlToValidate="TextBox2" ErrorMessage="*" Style="z-index: 1; left: 370px; top: 220px; position: absolute"></asp:RequiredFieldValidator>
    <p></p>
    <asp:TextBox ID="TextBox1" runat="server" Style="z-index: 1; left: 390px; top: 180px; position: absolute" onkeyup="javascript:this.value = this.value.toUpperCase();" MaxLength="12"></asp:TextBox>
    <asp:TextBox ID="TextBox2" runat="server" Style="z-index: 1; left: 390px; top: 220px; position: absolute" MaxLength="50"></asp:TextBox>
    <asp:TextBox ID="TextBox3" runat="server" Style="z-index: 1; left: 390px; top: 260px; position: absolute" TextMode="Number"></asp:TextBox>
    <asp:TextBox ID="TextBox4" runat="server" Style="z-index: 1; left: 390px; top: 300px; position: absolute" TextMode="Number"></asp:TextBox>
    <asp:TextBox ID="TextBox5" runat="server" Style="z-index: 1; left: 390px; top: 340px; position: absolute" TextMode="Number"></asp:TextBox>
    <asp:DropDownList ID="DropDownList1" runat="server" Style="z-index: 1; left: 390px; top: 380px; position: absolute; height: 22px; width: 204px">
        <asp:ListItem Value="Monthly">Monthly</asp:ListItem>
        <asp:ListItem Value="Quarterly">Quarterly</asp:ListItem>
        <asp:ListItem Value="Half-Yearly">Half-Yearly</asp:ListItem>
        <asp:ListItem Value="Annually">Annually</asp:ListItem>
    </asp:DropDownList>
    <p></p>
    <asp:Label ID="Label21" runat="server" Font-Italic="True" Font-Names="Arial" Font-Size="Medium" ForeColor="#CC3300" Style="z-index: 1; left: 15px; top: 420px; position: absolute" Text="Error:" EnableTheming="False"></asp:Label>
    <hr style="width: 100%; text-align: left; margin-left: 0; position: absolute; top: 440px; left: 0px;" />
    <asp:Button ID="Button1" runat="server" Style="z-index: 1; left: 5px; top: 460px; position: absolute" Text="Submit Data" OnClick="Button1_Click" />
    <asp:Button ID="Button2" runat="server" Style="z-index: 1; left: 155px; top: 460px; position: absolute" Text="Cancel Data" CausesValidation="False" OnClick="Button2_Click" />
    <asp:Button ID="Button3" runat="server" Style="z-index: 1; left: 305px; top: 460px; position: absolute" Text="Refresh Data" CausesValidation="False" OnClick="Button3_Click" />
    <p></p>
    <asp:Panel ID="Panel1" runat="server" Style="z-index: 1; left: 15px; top: 500px; position: absolute; height: 170px; width: 900px" ScrollBars="Vertical">
        <asp:GridView ID="GridView1" runat="server" Style="z-index: 1; height: 0px; width: 700px">
            <Columns>
                <asp:CommandField ShowSelectButton="True" />
            </Columns>
        </asp:GridView>
    </asp:Panel>
    <asp:Button ID="Button4" runat="server" Style="z-index: 1; left: 15px; top: 680px; position: absolute; height: 29px;" Text="Delete Data" CausesValidation="False" OnClick="Button4_Click" />















</asp:Content>
