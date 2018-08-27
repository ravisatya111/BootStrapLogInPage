<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Registration.aspx.cs" Inherits="BootStrapLogInPage.Registration" %>
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
    <div class="top-content">
        <div class="inner-bg">
            <div class="container">
                <!-- ROW 1 -->
                <div class="row">
                    <div class="col-sm-8 col-sm-offset-2 text">
                        <h1>New user registration form</h1>
                        <div class="description">
                            <p><u><b><a href="UserLogIn.aspx">Login</a></b></u> to our website if you already have an account.</p>
                        </div>
                    </div>
                </div>
                <!-- ROW 2 -->
                <div class="row">
                    <div class="col-sm-6 col-sm-offset-3 form-box">
                        <div class="form-top">
                            <div class="form-top-left">
                                <h3>Registration</h3>
                                <asp:Label ID="lblMessage" runat="server"></asp:Label>
                            </div>
                            <div class="form-top-right">
                                <i class="fa fa-lock"></i>
                            </div>
                        </div>
                        <div class="form-bottom">
                            <form id="form1" runat="server" class="login-form">
                                <div class="form-group">
                                    <asp:Label ID="lblName" class="sr-only" runat="server" Text="Name"></asp:Label>
                                    <asp:TextBox ID="txtName" runat="server" class="form-username form-control" placeholder="Enter Name..."></asp:TextBox>
                                </div>
                                <div class="form-group">
                                    <asp:Label ID="lblMailID" class="sr-only" runat="server" Text="Email ID"></asp:Label>
                                    <asp:TextBox ID="txtMailID" runat="server" class="form-username form-control" placeholder="Enter Email ID..."></asp:TextBox>
                                </div>
                                <div class="form-group">
                                    <asp:Label ID="lblRoles" class="sr-only" runat="server" Text="Role"></asp:Label>
                                    <asp:DropDownList ID="ddlRoles" runat="server" class="form-password form-control" placeholder="select Role...">
                                        <asp:ListItem Value="0">Select role</asp:ListItem>
                                        <asp:ListItem Value="1">Administrator</asp:ListItem>
                                        <asp:ListItem Value="2">Basic User</asp:ListItem>
                                    </asp:DropDownList>
                                </div>
                                <div class="form-group">
                                    <asp:Label ID="lblUserName" class="sr-only" runat="server" Text="Username"></asp:Label>
                                    <asp:TextBox ID="txtUserName" runat="server" class="form-username form-control" placeholder="Enter Username..."></asp:TextBox>
                                </div>
                                <div class="form-group">
                                    <asp:Label ID="lblPassword" runat="server" Text="Password" class="sr-only"></asp:Label>
                                    <asp:TextBox ID="txtPassword" runat="server" placeholder="Enter Password..." class="form-password form-control" type="password"></asp:TextBox>
                                </div>
                                <button type="submit" class="btn" runat="server" onserverclick="Submit_Click">Register!</button>
                            </form>
                        </div>

                    </div>
                </div>
            </div>
        </div>
    </div>
</body>
</html>
