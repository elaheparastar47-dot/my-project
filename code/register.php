<?php
session_start();
?>
<!DOCTYPE html>
<html lang="en">
<head>
    <meta charset="UTF-8">
    <meta name="viewport" content="width=device-width, initial-scale=1.0">
    <title>REGISTER</title>
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
.reg{
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
.reg .box-reg{
    width: 100%;
    padding: 40px;
}
.box-reg h2{
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
    top: 50%;
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
.box-login{
    font-size: .9em;
    text-align: center;
    font-weight: 500;
    margin: 25px 0 10px;
}
.login{
    font-size: .9em;
    text-align: center;
    font-weight: 500;
    margin: 25px 0 10px;
}
.login p a{
    color: #DDB488;
    text-decoration: none;
    font-weight: 600;
}
.login p a:hover{
    text-decoration: underline;
}
</style>
</head>
<body>
<body>
    <?php
   if (isset($_SESSION["state_login"]) && $_SESSION["state_login"] ===true) {
    ?>
    <script>
        location.replace("library.php");
        window.alert("کاربر عزیز شما قبلا ثبت نام کردید و نیاز به ثبت نام مجدد نیست");
    </script>
        <?php
   }
   ?>
<div class="heade">
            <h2 class="logo">library</h2>
            <nav class="navigation">
                <a href="login.php">login</a>
                <button class="btnlogin-popup">Register</button>
            </nav>
        </div>
        <div class="reg">
        <div class="box-reg">
                <h2 >REGISTER</h2><BR>
                <form action="Information.php" method="post">
                    <div class="input-box">
                        <span CLASS="icon"><ion-icon name="person"></ion-icon></span>
                       <input type="text" name="une" id="une" required>
                       <label >USERNAME:</label>
                    </div>
                    <div class="input-box">
                        <span CLASS="icon"><ion-icon name="mail" dir="rtl"></ion-icon></span>
                       <input type="email" name="emi" id="emi" required>
                       <label >EMAIL:</label>
                    </div>       
                     <div class="input-box"><br>
                        <span CLASS="icon"><ion-icon name="lock-closed"></ion-icon></span>
                       <input type="password" name="pws" id="pws" required>
                       <label >PASSWORD:</label>
                    </div><br>
                    <button type="submit" class="btn">REGISTER</button>
                    <div class="login"><br>
                        <p>login<a href="login.php" class="login2"> login</a></p>
                    </div>
                </form>

            </div>

            <script type="module" src="https://unpkg.com/ionicons@7.1.0/dist/ionicons/ionicons.esm.js"></script>
<script nomodule src="https://unpkg.com/ionicons@7.1.0/dist/ionicons/ionicons.js"></script>

</body>
</html>