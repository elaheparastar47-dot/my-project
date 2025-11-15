<?php
session_start();
if (isset($_SESSION['count'])) {
    $_SESSION['count']+=1;
}
else {
    $_SESSION['count']=1;
}
?>

<!DOCTYPE html>
<html lang="en">

<head>
    <meta charset="UTF-8">
    <meta name="viewport" content="width=device-width, initial-scale=1.0">
    <title>ILBRARY</title>
    <link rel="icon" type="image/png" href="./img/icons8-book-48.png">
    <style>
        * {
            margin: 0;
            padding: 0;
            box-sizing: border-box;
            font-family: 'Poppins', sans-serif;
        }

        body {
            display: flex;
            justify-content: left;
            align-items: left;
            min-height: 100vh;
            background: url('./img/library.jpg') no-repeat;
            background-size: cover;
            background-position: center;
            margin: 0;
        }

        .heade {
            position: fixed;
            top: 0;
            left: 0;
            width: 1471px;
            padding: 20px 100px;
            display: flex;
            justify-content: space-between;
            align-items: center;
            z-index: 99;
            display: flex;
            background: url('./img/login.jpg') no-repeat;
            background-size: cover;
            background-position: center;
            border: 5px solid #A58475;

        }

        .logo {
            font-size: 2em;
            color: #fff;
            user-select: none;
            font-family: system-ui, -apple-system, BlinkMacSystemFont, 'Segoe UI', Roboto, Oxygen, Ubuntu, Cantarell, 'Open Sans', 'Helvetica Neue', sans-serif;
        }

        .navigation a {
            position: relative;
            font-size: 1.1em;
            color: #fff;
            text-decoration: none;
            font-weight: 500;
            margin-left: 40px;
        }

        .navigation a:after {
            content: '';
            position: absolute;
            width: 100%;
            height: 3px;
            left: 0;
            bottom: -9px;
            background: white;
            border-radius: 5px;
            transform-origin: left;
            transform: scaleX(0);
            transition: transform .5s;
        }

        .navigation a:hover:after {
            transform-origin: right;
            transform: scaleX(1);
        }

        .navigation .btnlogin-popup {
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
            transition: .5s;
        }
        .navigation .btnlogin-popu {
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
            transition: .5s;
        }
        .navigation .btnlogin-popup:hover {
            background: white;
            color: black;
        }

        .navigation .btnlogin-popu:hover {
            color: white;
        }

        .D {
            width: 490px;
            height: 100px;
            position: relative;
            display: flex;
            justify-content: center;
            align-items: baseline;
            perspective: 2500px;
        }

        .cover-image {
            width: 100%;
            height: 100%;
            object-fit: cover;
            right: 0;
            left: 100%;
            top: 100%;
        }

        .w {
            display: inline;
            transition: all 0.5s;
            position: absolute;
            width: 100px;
            z-index: -1;
        }

        .D:hover .w {
            transform: perspective(900px) translateY(-5%) rotateX(25deg) translateZ(0);
            box-shadow: 2px 35px 32px -8px rgba(0, 0, 0, 0.75);
            -webkit-box-shadow: 2px 35px 32px -8px rgba(0, 0, 0, 0.75);
            -moz-box-shadow: 2px 35px 32px -8px rgba(0, 0, 0, 0.75);
        }

        .w::before,
        .w::after {
            content: "";
            opacity: 0;
            width: 100px;
            height: 80px;
            transition: all 0.5s;
            position: absolute;
            left: 0;
        }

        .w::before {
            top: 0;
            height: 100%;
            background-image: linear-gradient(to top,
                    transparent 46%,
                    rgba(12, 13, 19, 0.5) 68%,
                    rgba(12, 13, 19) 97%);
        }

        .w::after {
            bottom: 0;
            opacity: 1;
            background-image: linear-gradient(to bottom,
                    transparent 46%,
                    rgba(12, 13, 19, 0.5) 68%,
                    rgba(12, 13, 19) 97%);
        }

        .D:hover .w::before,
        .w::after {
            opacity: 1;
        }

        .D:hover .w::after {
            height: 150px;
        }

        .character {
            width: 100%;
            opacity: 0;
            transition: all 0.5s;
            position: absolute;
            z-index: -1;
            left: 1em;
            top: 1em;
        }

        .D:hover .character {
            opacity: 1;
            transform: translate3d(0%, -30%, 100px);
            left: 1em;
            top: 1em;
        }

        .ONE {
            border: 5px solid #A58475;
            width: 1471px;
            height: 290px;
            top: -10em;
            backdrop-filter: blur(20px);
        }

        .D2 {
            width: 500px;
            height: 100px;
            position: relative;
            display: flex;
            justify-content: center;
            align-items: baseline;
            perspective: 2500px;
        }

        .cover-image {
            width: 100%;
            height: 100%;
            object-fit: cover;
            right: 0;
            left: 100%;
            top: 100%;
        }

        .w2 {
            display: inline;
            transition: all 0.5s;
            position: absolute;
            width: 100px;
            z-index: -1;
        }

        .D2:hover .w2 {
            transform: perspective(900px) translateY(-5%) rotateX(25deg) translateZ(0);
            box-shadow: 2px 35px 32px -8px rgba(0, 0, 0, 0.75);
            -webkit-box-shadow: 2px 35px 32px -8px rgba(0, 0, 0, 0.75);
            -moz-box-shadow: 2px 35px 32px -8px rgba(0, 0, 0, 0.75);
        }

        .w2::before,
        .w2::after {
            content: "";
            opacity: 0;
            width: 100px;
            height: 80px;
            transition: all 0.5s;
            position: absolute;
            left: 0;
        }

        .w2::before {
            top: 0;
            height: 100%;
            background-image: linear-gradient(to top,
                    transparent 46%,
                    rgba(12, 13, 19, 0.5) 68%,
                    rgba(12, 13, 19) 97%);
        }

        .w2::after {
            bottom: 0;
            opacity: 1;
            background-image: linear-gradient(to bottom,
                    transparent 46%,
                    rgba(12, 13, 19, 0.5) 68%,
                    rgba(12, 13, 19) 97%);
        }

        .D2:hover .w2::before,
        .w2::after {
            opacity: 1;
        }

        .D2:hover .w2::after {
            height: 150px;
        }

        .character {
            width: 100%;
            opacity: 0;
            transition: all 0.5s;
            position: absolute;
            z-index: -1;
            left: 1em;
            top: 1em;
        }

        .D2:hover .character {
            opacity: 1;
            transform: translate3d(0%, -30%, 100px);
            left: 1em;
            top: 1em;
        }

        .ONE2 {
            border: 5px solid #A58475;
            width: 1471px;
            height: 250px;
            top: -5em;
            backdrop-filter: blur(20px);
        }

        .D2 .lable {
            text-align: right;
            left: -100px;

        }
        .D3 {
            width: 500px;
            height: 100px;
            position: relative;
            display: flex;
            justify-content: center;
            align-items: baseline;
            perspective: 2500px;
        }

        .cover-image {
            width: 100%;
            height: 100%;
            object-fit: cover;
            right: 0;
            left: 100%;
            top: 100%;
        }

        .w3 {
            display: inline;
            transition: all 0.5s;
            position: absolute;
            width: 100px;
            z-index: -1;
        }

        .D3:hover .w3 {
            transform: perspective(900px) translateY(-5%) rotateX(25deg) translateZ(0);
            box-shadow: 2px 35px 32px -8px rgba(0, 0, 0, 0.75);
            -webkit-box-shadow: 2px 35px 32px -8px rgba(0, 0, 0, 0.75);
            -moz-box-shadow: 2px 35px 32px -8px rgba(0, 0, 0, 0.75);
        }

        .w3::before,
        .w3::after {
            content: "";
            opacity: 0;
            width: 100px;
            height: 80px;
            transition: all 0.5s;
            position: absolute;
            left: 0;
        }

        .w3::before {
            top: 0;
            height: 100%;
            background-image: linear-gradient(to top,
                    transparent 46%,
                    rgba(12, 13, 19, 0.5) 68%,
                    rgba(12, 13, 19) 97%);
        }

        .w3::after {
            bottom: 0;
            opacity: 1;
            background-image: linear-gradient(to bottom,
                    transparent 46%,
                    rgba(12, 13, 19, 0.5) 68%,
                    rgba(12, 13, 19) 97%);
        }

        .D3:hover .w3::before,
        .w3::after {
            opacity: 1;
        }

        .D3:hover .w3::after {
            height: 150px;
        }

        .character {
            width: 100%;
            opacity: 0;
            transition: all 0.5s;
            position: absolute;
            z-index: -1;
            left: 1em;
            top: 1em;
        }

        .D3:hover .character {
            opacity: 1;
            transform: translate3d(0%, -30%, 100px);
            left: 1em;
            top: 1em;
        }

        .ONE3 {
            border: 5px solid #A58475;
            width: 1471px;
            height: 250px;
            top: -5em;
            backdrop-filter: blur(20px);
        }
        .lable1,.lable2,.lable3{
            font-size: 20px;
            color: white;
            
        }
        .a{
            display: block;
        }
        .logo_img{
            width: 1.5cm;
            height: 1.5cm;
        }

    </style>
</head>

<body>


    <div class="heade">
    <?php
        if ($_SESSION["user_type"]=="public") {
?>
    <script>
        window.alert("لطفا قبل از ثبت درخواست خود سایت رو چک کنید که مطمئن شوید درخواست شما موجود نیست");
    </script>
    <?php
        }
        ?>
        <img src="img/logo.png" alt="" CLASS="logo_img">
        <h2 class="logo">سفری خیالی در بین صفحات کاغذی</h2>
        <nav class="navigation">
        <a href="register.php">Register</a>
        <?php 
    if (isset($_SESSION["state_login"]) && $_SESSION["state_login"]===true) {
        echo("<a href='out.php'>logout</a>");
    }
        else {
        
        ?>
            <a href=login.php>login</a> 
            <?php
        }
        ?>
        <?php
        if ($_SESSION["user_type"]=="public") {
            ?>
           <a href=request.php>you're request</a> 
           <?php
        }
        ?>
         <?php
        if ($_SESSION["user_type"]=="admin") {
            ?>
           <a href=requests.php>request</a> 
           <?php
        }
        ?>
        
               <button class="btnlogin-popup">Home</button>
               <?php
              echo("<button class='btnlogin-popu'>".$_SESSION['count']."</button>");
               ?>
        </nav>
    </div>
    <div>
        <a href="darbar.php"><br>
            <div CLASS="ONE">
                <div class="D" style="top: 6em;">
                    <div class="w" style="left:1em;">
                        <img src="./img/درباری از خار و رز.jpg" alt="درباری از خار و رز" class="cover-image"
                            style="width:130px; height:160px">
                    </div>
                    <img src="./img/دربار1.png" alt="درباری از خار و رز" class="character"
                        style="width:130px; height:160px">
                </div><br>
                </a>
                <h4 dir="rtl" class="lable1">کتاب «درباری از خار و رز» رمانی نوشته ی «سارا جی. ماس» است که نخستین بار در
                    سال 2015 انتشار یافت. وقتی دختری نوزده ساله به نام «فیرا»، گرگی را در جنگل میان دنیای انسان ها <br>و
                    قلمرو پریان می کشد،
                    به شکل ناخواسته باعث در هم شکستن یک پیمان آتش بس می شود و باید تاوان این قتل را با جانش بپردازد.
                    «تاملین»، یکی از پریانی که برای گرفتن جان «فیرا» <br>از راه می رسد، راهی را برای خروج از این مخمصه به او
                    پیشنهاد می کند:
                    سپری کردن باقی روزهای عمرش در سرزمین پریان. «فیرا» به ناچار می پذیرد و خانواده اش را پشت درهای
                    جهان پریان <br>رها می کند. همزمان با این که «فیرا» به محیط جدید خود عادت می کند و حتی از آن لذت می برد،
                   <br> درمی یابد که جهان پریان با تهدیدی بزرگ رو به رو است؛ تهدیدی که قدرت های جادویی افرادی مانند
                    «تاملین» را بی اثر می سازد و به هیولاها اجازه می دهد که آزادانه در جهان پریان پرسه بزنند.</h4>
            </div><br>
        <br>
        <a href="naghme.php"><br>
            <div CLASS="ONE2">
                <div class="D2" style="top: 2.5em;">
                    <div class="w2" style="left:1em;">
                        <img src="./img/1نغمه.jpg" alt="درباری از خار و رز" class="cover-image"
                            style="width:130px; height:160px">
                    </div>
                    <img src="./img/1 نغمه.png" alt=" نغمه اشیل" class="character" style="width:130px; height:160px">
                </div>
                </a>
                <h4 dir="rtl" class="lable2">
                    نغمه آشیل – مادلین میلر

                    این رمان رابطه پاتروکلوس با آشیل را از ملاقات اولیه تا سوء استفاده های آنها در طول جنگ تروا با تمرکز
                    بر رابطه عاشقانه آنها دنبال می کند.
                    این کتاب توسط پاتروکلوس،<br> پسر پادشاه منوتیوس روایت شده است. او به عنوان خواستگار بالقوه هلن تروی
                    معرفی می شود. سپس او موظف است در دفاع از ازدواج او با منلائوس سوگند خون بگیرد. پس از اینکه پاتروکلوس
                    به<br> طور تصادفی پسر یکی از اشراف پدرش را می‌کشد، به فتیا تبعید می‌شود و در آنجا با آشیل، پسر
                    <br>پلئوس،پادشاه فتیا و تتیس، پوره دریایی آشنا می‌شود. آنها دوستان صمیمی می شوند .
                </h4>
            </div>
        <br>
        <a href="osyangaran.php" CLASS="a"><br>
            <div CLASS="ONE3">
                <div class="D3" style="top: 2.5em;">
                    <div class="w3" style="left:1em;">
                        <img src="./img/3.jpg" alt="درباری از خار و رز" class="cover-image"
                            style="width:130px; height:160px">
                    </div>
                    <img src="./img/3s.png" alt="درباری از خار و رز" class="character"
                        style="width:130px; height:160px">
                </div><br>
                </a>
                <h4 dir="rtl" class="lable3" style="top:0">
                عصیانگران<br> پس از هرج و مرج عصر آشوب زمانی که تعدادی از انسان ها، ابرقدرت های خود را کشف کردند و آن را برای نابودی جهان به کار گرفتند گروهی از ابرقهرمانان به قدرت رسیدند. آن ها که خود را <br>عصیانگران می‌نامند، نظم و قانون را در جهانی آشوبناک برقرار ساخته اند.

                </h4>
            </div>
    </div>

</body>

</html>