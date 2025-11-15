<?php
session_start();
?>

<!DOCTYPE html>
<html lang="en">
<head>
    <meta charset="UTF-8">
    <meta name="viewport" content="width=device-width, initial-scale=1.0">
    <title>INFORMATIOM</title>
    <link rel="icon" type="image/png" href="./img/icons8-book-48.png">
    <style>
                * {
            margin: 0;
            padding: 0;
            box-sizing: border-box;
            font-family: 'Poppins' , sans-serif;
        }
        body{
            display: flex;
            justify-content:center;
            align-items: center;
            min-height: 100vh;
            background: url('./img/login.jpg') no-repeat;
            background-size: cover;
            background-position: center;

        }
        .heade{
            position: fixed;
            top: 0;
            left: 0;
            width: 100%;
            padding: 20px 100px;
            display: flex;
            justify-content: space-between;
            align-items: center;
            z-index: 99;
        }
        .logo{
            font-size: 2em;
            color: #fff;
            user-select: none;
        }
        .navigation a{
            position: relative;
            font-size: 1.1em;
            color: #fff;
            text-decoration: none;
            font-weight: 500;
            margin-left: 40px;
        }
        .navigation a:after{
            content: '';
            position: absolute;
            width: 100%;
            height: 3px;
            left:0;
            bottom: -9px;
            background: white;
            border-radius: 5px;
            transform-origin: left;
            transform:scaleX(0) ;
            transition: transform .5s;
        }
        .navigation a:hover:after{
            transform-origin: right;
            transform:scaleX(1) ;
        }

        .navigation .btnlogin-popup{
            width: 130px;
            height: 50px;
            background: transparent;
            border: 2px solid #fff;
            outline: none;
            border-radius: 6px;
            cursor: pointer;
            font-size: 1.1em;
            color: #fff;
            font-weight: 500;
            margin-left: 40px;
            transition: .5s ;
        }
        .navigation .btnlogin-popup:hover{
            background: white;
            color: black;
}
.inf{
    position: relative;
    width: 400px;
    height: 490px;
    background: transparent;
    border: 2px solid rgba(225, 225, 225, .5);
    border-radius: 20px;
    backdrop-filter: blur(20px);
    box-shadow: 0 0 30px rgba(0,0,0,rgba(225, 225, 225, .5));
    display: flex;
    justify-content: center;
    align-items: center;
    overflow: hidden;
}
.inf .box-inf{
    width: 100%;
    padding: 40px;
}
.box-inf h2{
    font-size: 2em;
    text-align: center;
}
.input-box{
position: relative;
width: 100%;
height: 50px;
border-bottom: 2px solid black;
margin: 30px 0;
}
.input-box label{
    position: absolute;
    top: 10%;
    left: 5px;
    transform: translateY(-50%);
    font-size: 1em;
    font-weight: 500;
    pointer-events: none;
}
.input-box input{
    width: 100%;
    height: 100%;
    background: transparent;
    border: none;
    outline: none;
    font-size: 1em;
    font-weight: 600;
    padding: 0 35px 0 5px;
} 
.input-box .icon{
    position: absolute;
    right: 8px;
    font-size: 1.5em;
    line-height: 49px;

}
.input-box input:focus~label,
.input-box input:valid~label{
    top: -5px;
    transition: .5s;
}
.btn{
    width: 100%;
    height: 45px;
    background: #DDB488;
    border: none;
    outline: none;
    cursor:pointer;
    border-radius: 20px;
    font-weight: 500;
}
</style>
</head>
<body>
<div class="heade">
            <h2 class="logo">library</h2>
            <nav class="navigation">
            <a href="library.php">Home</a>
                <a href="register.php">Register</a>
                <button class="btnlogin-popup">Information</button>
            </nav>
        </div>

        <script>
            function P() {
             var a=window.confirm("ایا میخواهید اطلاعات خود را تغییر دهید؟");
                if (a==true) {
                 a=location.replace("register.php");
                }
                else {
                    window.alert("اطلاعات ثبت شد");
                }
            }
            </script>
                    <div class="inf">
        <div class="box-inf">
                <h2 >Information</h2><BR>
                <form  action="login.php" method="post">
            <?php
                   if(isset($_POST['une']) && !empty($_POST['une'])
                   && isset($_POST['emi']) && !empty($_POST['emi'])
                    && isset($_POST['pws']) && !empty($_POST['pws'])){
                     $username=$_POST['une'];
                      $email=$_POST['emi'];
                     $password=$_POST['pws'];
                    }else
                    exit("برخی فیلد ها خالی است");
                    if (filter_var($email,FILTER_VALIDATE_EMAIL)===false) {
                        exit("ایمیل درست نیست");
                    }
                    $link=mysqli_connect("localhost","root","","user");
                    if (mysqli_connect_errno()) {
                        exit(":خطا به شرح زیر است".mysqli_connect_error());
                    }
                    $q="INSERT INTO `users`(`username`, `email`, `password`) VALUES ('$username','$email','$password')";
                    if (mysqli_query($link,$q)) {
                        echo("<div class='input-box'>");
                        echo("<span CLASS='icon'><ion-icon name='person'></ion-icon></span>");
                       echo("<input type='text' value='$username' required readonly>");
                       echo("<label >USERNAME:</label>");
                    echo("</div>");
                    echo("<div class='input-box'>");
                    echo("<span CLASS='icon'><ion-icon name='mail' dir='rtl'></ion-icon></span>");
                    echo("<input type='text' value='$email' required readonly>");
                     echo("<label >EMAIL:</label>");
                    echo("</div>");       
                     echo("<div class='input-box'><br>");
                     echo("<span CLASS='icon'><ion-icon name='lock-closed'></ion-icon></span>");
                     echo("<input type='text' value='$password' required readonly>");
                     echo("<label >PASSWORD:</label>");
                     echo("</div><br>");
                    }
                    else{
                        echo("عضويت انجام نشد");
                    }
                    mysqli_close($link);
            ?>
                                <button type='submit' class='btn'>login</button><br>
                     </form><br>
        </div>
</body>
</html>