<!DOCTYPE html>
<html lang="en">
<head>
    <meta charset="UTF-8">
    <meta name="viewport" content="width=device-width, initial-scale=1.0">
    <title>Document</title>
</head>
<body>
    <?php
                  
                  if(isset($_GET['username']))
                  $username=$_GET['username'];
              $link=mysqli_connect("localhost","root","","user");
              if(mysqli_connect_errno())
                  echo("error:".mysqli_connect_error());
              $query="DELETE FROM `users` WHERE username='$username'";
              if(mysqli_query($link,$query))
                echo("رکورد با موفقیت حذف شد");
              else
                echo("رکورد حذف نشد.");
                            
               mysqli_close($link);
          ?>
</body>
</html>