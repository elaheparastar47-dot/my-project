<!DOCTYPE html>
<html lang="en">
<head>
    <meta charset="UTF-8">
    <meta name="viewport" content="width=device-width, initial-scale=1.0">
    <title>Document</title>
</head>
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
        .form {
  background-color: #fff;
  box-shadow: 0 10px 60px rgb(218, 229, 255);
  border: 1px solid rgb(159, 159, 160);
  border-radius: 20px;
  padding: 2rem .7rem .7rem .7rem;
  text-align: center;
  font-size: 1.125rem;
  max-width: 320px;
}

.form-title {
  color: #000000;
  font-size: 1.8rem;
  font-weight: 500;
}

.form-paragraph {
  margin-top: 10px;
  font-size: 0.9375rem;
  color: rgb(105, 105, 105);
}

.drop-container {
  background-color: #fff;
  position: relative;
  display: flex;
  gap: 10px;
  flex-direction: column;
  justify-content: center;
  align-items: center;
  padding: 10px;
  margin-top: 2.1875rem;
  border-radius: 10px;
  border: 2px dashed rgb(171, 202, 255);
  color: #444;
  cursor: pointer;
  transition: background .2s ease-in-out, border .2s ease-in-out;
}

.drop-container:hover {
  background: rgba(0, 140, 255, 0.164);
  border-color: rgba(17, 17, 17, 0.616);
}

.drop-container:hover .drop-title {
  color: #222;
}

.drop-title {
  color: #444;
  font-size: 20px;
  font-weight: bold;
  text-align: center;
  transition: color .2s ease-in-out;
}

.file-input {
  width: 350px;
  max-width: 100%;
  color: #444;
  padding: 2px;
  background: #fff;
  border-radius: 10px;
  border: 1px solid rgba(8, 8, 8, 0.288);
}

.file-input::file-selector-button {
  margin-right: 20px;
  border: none;
  background: #DDB488;
  padding: 10px 20px;
  border-radius: 10px;
  color: #fff;
  cursor: pointer;
  transition: background .2s ease-in-out;
}

.file-input::file-selector-button:hover {
  background: chocolate;
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
</style>
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
        <form class="form" action="request1.php" method="post" enctype="multipart/form-data">
  <span class="form-title">Upload your file</span>
  <p class="form-paragraph">
      File should be an image
    </p>
    <div class="input-box">
    <input type="text" name="fn" id="fn" required><br>
         <label >name of book:</label><br>
    </div>
   <label for="file-input" class="drop-container">
  <span class="drop-title">Drop files here</span>
  or
  <input type="file" class="file-input" id="img" name="img" accept="jpg">
</label><br>
<button id= "btn" class="btn">ارسال</button>
         </form><br>

        </div>
        </div>
</body>
</html>