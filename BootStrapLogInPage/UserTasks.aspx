<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="UserTasks.aspx.cs" Inherits="BootStrapLogInPage.UserTasks" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Lucas Tecnologia Services</title>
    <meta charset="utf-8" />
    <meta http-equiv="X-UA-Compatible" content="IE=edge" />
    <meta name="viewport" content="width=device-width, initial-scale=1" />

    <!-- Latest compiled and minified CSS -->
    <link rel="stylesheet" href="https://maxcdn.bootstrapcdn.com/bootstrap/3.3.7/css/bootstrap.min.css" />
    <!-- jQuery library -->
    <script src="https://ajax.googleapis.com/ajax/libs/jquery/3.3.1/jquery.min.js"></script>
    <!-- Latest compiled JavaScript -->
    <script src="https://maxcdn.bootstrapcdn.com/bootstrap/3.3.7/js/bootstrap.min.js"></script>

    <!-- CSS -->
    <link rel="stylesheet" href="assets/css/form-elements.css"  />
    <link rel="stylesheet" href="assets/bootstrap/css/bootstrap.min.css" />
    <link rel="stylesheet" href="assets/font-awesome/css/font-awesome.min.css" />
    <link rel="stylesheet" href="assets/elegant-font/code/style.css" />
    <link rel="stylesheet" href="assets/css/animate.css" />
    <link rel="stylesheet" href="assets/css/magnific-popup.css" />
    <link rel="stylesheet" href="assets/css/awesome-bootstrap-checkbox.css" />
    <link rel="stylesheet" href="assets/css/style.css" />
    <link rel="stylesheet" href="assets/css/media-queries.css" />

    <!-- Javascript -->
    <script src="assets/js/jquery-3.2.1.min.js"></script>
    <script src="assets/js/jquery-migrate-3.0.0.min.js"></script>
    <script src="assets/bootstrap/js/bootstrap.min.js"></script>
    <script src="assets/js/jquery.backstretch.min.js"></script>
    <script src="assets/js/wow.min.js"></script>
    <script src="assets/js/retina-1.1.0.min.js"></script>
    <script src="assets/js/jquery.magnific-popup.min.js"></script>
    <script src="assets/js/waypoints.min.js"></script>
    <script src="assets/js/jquery.countTo.js"></script>
    <script src="assets/js/masonry.pkgd.min.js"></script>
    <script src="assets/js/scripts.js"></script>
</head>
<body>
    <div class ="LoginDiv">
        <asp:Label ID="lblLogin" runat="server"></asp:Label>
    </div>
    <div class="top-content">
        <!-- Login page -->
        <div class="inner-bg">
            <div class="container">
                <!-- ROW 1 -->
           
                <div class="row">
                    <div class="col-sm-6 col-sm-offset-3 form-box">
                        <div class="form-top">
                            <div class="form-top-left">
                                <h3>Task Menu</h3>
                                <asp:Label ID="lblMessage" runat="server" ></asp:Label>
                            </div>
                        </div>
                        <div class="form-bottom">
                            <form id="form1" runat="server" class="login-form">
                                <div class="form-group">
                                    <asp:Label ID="lblTaskTitle" class="sr-only" runat="server" Text="Task title"></asp:Label>
                                    <asp:TextBox ID="txtTaskTitle" runat="server" class="form-username form-control" placeholder="Task title..."></asp:TextBox>
                                </div>

                                <button type="submit" class="btn" runat ="server" onserverclick ="Submit_Click">Add task!</button>
                                <br /><br />
                                <asp:GridView ID="GVTasks" runat="server" BackColor="White" BorderColor="#999999" BorderStyle="Solid" 
                                    BorderWidth="1px" CellPadding="3" AutoGenerateColumns="False" DataKeyNames="TaskID"
                                    OnPageIndexChanging="GVTasks_PageIndexChanging" OnRowCancelingEdit="GVTasks_RowCancelingEdit" 
                                    OnRowDeleting="GVTasks_RowDeleting" OnRowEditing="GVTasks_RowEditing" OnRowUpdating="GVTasks_RowUpdating">
                                    <AlternatingRowStyle BackColor="#DCDCDC" />
                                    <Columns>
                                        <asp:BoundField HeaderText="Task title" DataField="title" />
                                        <asp:CheckBoxField HeaderText="IsCompleted" DataField="IsCompleted" />
                                        <asp:CommandField ShowEditButton="True" />  
                                        <asp:CommandField ShowDeleteButton="True" />
                                    </Columns>
                                    <FooterStyle BackColor="#CCCCCC" ForeColor="Black" />
                                    <HeaderStyle BackColor="#4aaf51" Font-Bold="True" ForeColor="White" />
                                    <PagerStyle BackColor="#999999" ForeColor="Black" HorizontalAlign="Center" />
                                    <RowStyle BackColor="#EEEEEE" ForeColor="Black" BorderStyle="Solid" />
                                    <SelectedRowStyle BackColor="#008A8C" Font-Bold="True" ForeColor="White" />
                                    <SortedAscendingCellStyle BackColor="#F1F1F1" />
                                    <SortedAscendingHeaderStyle BackColor="#0000A9" />
                                    <SortedDescendingCellStyle BackColor="#CAC9C9" />
                                    <SortedDescendingHeaderStyle BackColor="#000065" />
                                </asp:GridView>
                            </form>
                        </div>

                    </div>
                </div>
            </div>
        </div>
    </div>
</body>
</html>
