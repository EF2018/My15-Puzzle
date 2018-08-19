<%@ Page Title="Home Page" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="My15_Puzzle.Default" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">
    <style type="text/css">
        .auto-style1 {
            width: 374px;
        }
    </style>

    </br>
    <asp:Label ID="Label1" runat="server" Text="Congratulate! You win!" ForeColor="Red" Visible="False"></asp:Label></br>
    <asp:Label ID="Label2" runat="server" Text="Enter your user name:" Visible="False"></asp:Label>
    <asp:TextBox ID="TextBox1" runat="server" value="" Visible="False" Width="91px"></asp:TextBox>
    <asp:Button ID="SaveRecord" runat="server" Text="Save your record" Visible="False" Width="118px" OnClick="SaveRecord_Click" /></br>
    <asp:Label ID="Label3" runat="server" Text="Your step №:"></asp:Label></br>
           <div class="auto-style1" id="GameBox" runat="server">
           <asp:Button ID="Button0" runat="server" Height="90px" Text="1" Width="90px" OnClick="Button1_Click" BackColor="SteelBlue" />
           <asp:Button ID="Button1" runat="server" Height="90px" Text="2" Width="90px" OnClick="Button1_Click" BackColor="SteelBlue" />
           <asp:Button ID="Button2" runat="server" Height="90px" Text="3" Width="90px" OnClick="Button1_Click" BackColor="SteelBlue" />
           <asp:Button ID="Button3" runat="server" Height="90px" Text="4" Width="90px" OnClick="Button1_Click" BackColor="SteelBlue" />
           <asp:Button ID="Button4" runat="server" Height="90px" Text="5" Width="90px" OnClick="Button1_Click" BackColor="SteelBlue" />
           <asp:Button ID="Button5" runat="server" Height="90px" Text="6" Width="90px" OnClick="Button1_Click" BackColor="SteelBlue" />
           <asp:Button ID="Button6" runat="server" Height="90px" Text="7" Width="90px" OnClick="Button1_Click" BackColor="SteelBlue" />
           <asp:Button ID="Button7" runat="server" Height="90px" Text="8" Width="90px" OnClick="Button1_Click" BackColor="SteelBlue" />
           <asp:Button ID="Button8" runat="server" Height="90px" Text="9" Width="90px" OnClick="Button1_Click" BackColor="SteelBlue" />
           <asp:Button ID="Button9" runat="server" Height="90px" Text="10" Width="90px" OnClick="Button1_Click" BackColor="SteelBlue" />
           <asp:Button ID="Button10" runat="server" Height="90px" Text="11" Width="90px" OnClick="Button1_Click" BackColor="SteelBlue" />
           <asp:Button ID="Button11" runat="server" Height="90px" Text="12" Width="90px" OnClick="Button1_Click" BackColor="SteelBlue" />
           <asp:Button ID="Button12" runat="server" Height="90px" Text="13" Width="90px" OnClick="Button1_Click" BackColor="SteelBlue" />
           <asp:Button ID="Button13" runat="server" Height="90px" Text="14" Width="90px" OnClick="Button1_Click" BackColor="SteelBlue" />
           <asp:Button ID="Button14" runat="server" Height="90px" Text="15" Width="90px" OnClick="Button1_Click" BackColor="SteelBlue" />
           <asp:Button ID="Button15" runat="server" Height="90px" Width="90px" OnClick="Button1_Click" BackColor="White" BorderColor="White" BorderStyle="None"/>
          </div>
</asp:Content>
