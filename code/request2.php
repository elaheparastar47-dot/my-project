<?php
session_start();
?>

<!DOCTYPE html>
<html lang="en">
<head>
    <meta charset="UTF-8">
    <meta name="viewport" content="width=device-width, initial-scale=1.0">
    <title>Document</title>
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
            border: solid #DDB488 1mm;
            border-radius: 10px;
            box-shadow: 0 0 30px rgba(0,0,0,rgba(225, 225, 225, .5));
            backdrop-filter: blur(20px);



        }
        .logo{

            font-size: 2em;
            color: #fff;
            user-select: none;
            font-family: system-ui, -apple-system, BlinkMacSystemFont, 'Segoe UI', Roboto, Oxygen, Ubuntu, Cantarell, 'Open Sans', 'Helvetica Neue', sans-serif;
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
.logo_img{
            width: 1.5cm;
            height: 1.5cm;
        }
        .h3{
            text-align: center;
        }
        .i{
            display: block;
            margin-left: auto;
            margin-right: auto;
        }
        </style>
</head>
<body>
<div class="heade">
        <img src="img/logo.png" alt="" CLASS="logo_img">
        <h2 class="logo">سفری خیالی در بین صفحات کاغذی</h2>
        <nav class="navigation">
            <a href="library.php">library</a>
        </nav>
    </div>
    <div class="inf">
        <div class="box-inf">
    <?php
    if (isset($_GET['username'])) {
        $username=$_GET['username'];
        
            $link =mysqli_connect("localhost","root","","user");
    if (mysqli_connect_errno()) {
        echo("خطا: ". mysqli_connect_error());
    }
        $q="SELECT * FROM `users` where username='$username'";
        $result=mysqli_query($link,$q);
       if( $row=mysqli_fetch_array($result)){
        ?>
        <img class="i" src="upload/<?php echo($row['img']); ?>" with="700px" height="300px" alt="">
        <h3  class="h3">name of book: <?php echo($row['img']); ?></h3>
        <h3 class="h3">username: <?php echo($row['username']);?></h3>
        <h3  class="h3">email: <?php echo($row['email']); ?></h3>
        <a href="delete.php?username=<?php echo( $row['username']);?>">DELETE</a>
        <?php

       }
    }
?>
</div>
</div>


</body>
</html>