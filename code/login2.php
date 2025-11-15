<?php
session_start();
?>
<?php
if (isset($_POST['un']) && !empty($_POST['un'])&&
isset($_POST['pw']) && !empty($_POST['pw'])) {
    $username=$_POST['un'];
    $password=$_POST['pw'];
    $_SESSION['username']=$_POST['un'];
}
else {
    exit("برخی فیلد ها خالی است ");
}
$link=mysqli_connect("localhost","root","","user");
if (mysqli_connect_errno()) {
    exit("خطا به شرح زیر است :" .mysqli_connect_error());
}
$query = "SELECT * FROM users WHERE username='$username' AND password='$password'";
$r=mysqli_query($link,$query);
$row=mysqli_fetch_array($r);
if ($row) {
    $_SESSION["state_login"] = true;
    if ($row["type"]==0) {
        $_SESSION["user_type"]="public";
    }
    elseif ($row["type"]==1) {
        $_SESSION["user_type"]="admin";
    }
    header('Location:http://localhost/project/code/library.php');
}
else{
echo"کاربر وجود ندارد";
}
mysqli_close($link);
?>
<!DOCTYPE html>
<html lang="en">
<head>
    <meta charset="UTF-8">
    <meta name="viewport" content="width=device-width, initial-scale=1.0">
    <title>Document</title>
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
.log{
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
    /*overflow: hidden;*/
}
.log .box-login{
    width: 100%;
    padding: 40px;
}
.box-login h2{
    font-size: 2em;
    text-align: center;
}
.input-box{
position: relative;
width: 100%;
height: 50px;
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
.register{
    font-size: .9em;
    text-align: center;
    font-weight: 500;
    margin: 25px 0 10px;
}
.register p a{
    color: #DDB488;
    text-decoration: none;
    font-weight: 600;
}
.register p a:hover{
    text-decoration: underline;
}
        </style>
</head>
<body>

<?php
   if (isset($_SESSION["state_login"]) && $_SESSION["state_login"]===true) {
    ?>
    <script>
        location.replace("library.php");
        </script>  
        <?php
   }
   ?>
<div class="heade">
            <h2 class="logo">library</h2>
            <nav class="navigation">
                <a href="register.php">Register</a>
                <button class="btnlogin-popup">login</button>
            </nav>
        </div>
        <div class="log">
            <div class="box-login">
                <div class="input-box">
                    <div class="input-box">
                    <div class="register">
                        <p>you don't have an account<br><a href="register.php" class="register">Register</a></p>
                    </div>
                </form>

            </div>
        </div>
</body>
</html>