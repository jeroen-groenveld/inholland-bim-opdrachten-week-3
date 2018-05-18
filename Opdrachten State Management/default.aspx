<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="default.aspx.cs" Inherits="Opdrachten_State_Management._default" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <asp:Label ID="Label1" runat="server" Text="Kies view: "></asp:Label>
        <asp:DropDownList ID="DropDownList1" runat="server" OnSelectedIndexChanged="DropDownList1_SelectedIndexChanged" AutoPostBack="true">
            <asp:ListItem>HyperLink</asp:ListItem>
            <asp:ListItem>Post Back URL</asp:ListItem>
            <asp:ListItem>Query String</asp:ListItem>
            <asp:ListItem>Cookie</asp:ListItem>
            <asp:ListItem>Session State</asp:ListItem>
        </asp:DropDownList>
        <asp:MultiView ID="MultiView1" runat="server" ActiveViewIndex="0">
            <asp:View ID="View1" runat="server">
                <div style="padding: 15px 0;">
                    <asp:HyperLink ID="hl_Hyperlink" runat="server" NavigateUrl="~/result_hyperlink.aspx">HyperLink</asp:HyperLink>
                </div>              
            </asp:View>
            <asp:View ID="View2" runat="server">
                                <div style="padding: 15px 0;">
                <asp:Button ID="btn_PostBackURL" runat="server" Text="Post Back URL" PostBackUrl="~/result_postbackurl.aspx"/>
                                    </div>
            </asp:View>
            <asp:View ID="View3" runat="server">
                                <div style="padding: 15px 0;">
                <asp:Button ID="btn_QueryString" runat="server" Text="Query String" OnClick="btn_QueryString_Click" />
                                    </div>
            </asp:View>
            <asp:View ID="View4" runat="server">
                                <div style="padding: 15px 0;">
                <asp:Button ID="btn_Cookie" runat="server" Text="Cookie" OnClick="btn_Cookie_Click" />
                                    </div>
            </asp:View>
            <asp:View ID="View5" runat="server">
                                <div style="padding: 15px 0;">
                <asp:Button ID="btn_Session" runat="server" Text="Session State" OnClick="btn_Session_Click" />
                                    </div>
            </asp:View>
        </asp:MultiView>
        <br />
        <div>
            <asp:TextBox ID="txt_Input" runat="server"></asp:TextBox>
            <%-- Opdracht 12 - Met deze validator wordt het input veld Required. Door middel van "ControlToValidate" kan je selecteren welk control je wilt valideren. --%>
            <asp:RequiredFieldValidator
                runat="server"
                ID="rfv_Input"
                ControlToValidate="txt_Input"
                ErrorMessage="Vul iets in..."
                ForeColor="Red"
                Display="Dynamic"
                >
            </asp:RequiredFieldValidator>
        </div>
        <br />
        <br />
    </form>
</body>
</html>
