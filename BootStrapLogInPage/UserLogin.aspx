<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="UserLogin.aspx.cs" Inherits="BootStrapLogInPage.UserLogin" %>

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
        <!-- Login page -->
        <div class="inner-bg">
            <div class="container">
                <!-- ROW 1 -->
                <div class="row">
                    <div class="col-sm-8 col-sm-offset-2 text">
                        <h1>Login to our site</h1>
                        <div class="description">
                            <p>Use the form below to login to our website if you have an account.</p>
                        </div>
                    </div>
                </div>
                <!-- ROW 2 -->
                <div class="row">
                    <div class="col-sm-6 col-sm-offset-3 form-box">
                        <div class="form-top">
                            <div class="form-top-left">
                                <h3>Sign in</h3>
                                <p>Enter your username and password to log on:</p>
                                <asp:Label ID="lblMessage" runat="server" ></asp:Label>
                            </div>
                            <div class="form-top-right">
                                <i class="fa fa-lock"></i>
                            </div>
                        </div>
                        <div class="form-bottom">
                            <form id="form1" runat="server" class="login-form">
                                <div class="form-group">
                                    <asp:Label ID="lblUserName" class="sr-only" runat="server" Text="Username"></asp:Label>
                                    <asp:TextBox ID="txtUserName" runat="server" class="form-username form-control" placeholder="Username..."></asp:TextBox>
                                </div>
                                <div class="form-group">
                                    <asp:Label ID="lblPassword" runat="server" Text="Password" class="sr-only"></asp:Label>
                                    <asp:TextBox ID="txtPassword" runat="server" placeholder="Password..." class="form-password form-control" type="password"></asp:TextBox>
                                </div>
                                <button type="submit" class="btn" runat ="server" onserverclick="Submit_Click">Sign in!</button>
                            </form>
                        </div>
                    </div>
                </div>
            </div>
        </div>
    </div>
</body>
</html>
