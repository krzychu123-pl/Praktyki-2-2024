<html>

<head>
    <meta charset="UTF-8">
    <meta name="viewport" content="width=device-width, initial-scale=1.0">
    <title>Formularz</title>
    <link href="https://cdn.jsdelivr.net/npm/bootstrap@5.3.0-alpha1/dist/css/bootstrap.min.css" rel="stylesheet">
</head>

    <div class="container mt-5">
        <h2 style="text-align: center;">Dane z formularza:</h2>
        <div class="row">
            <div class="col-12">
                <p style="text-align: center; font-size: 20px;">
                    <b>Imię:</b> 
                    <?php 
                    echo $_POST['name']; 
                    ?>
                       
                    </span>
                </p>
                <p style="text-align: center; font-size: 20px;">
                    <b>Wiadomość:</b> 
                    <?php
                    echo $_POST['message'];
                       ?>
                    </span>
                </p>
            </div>
        </div>
    </div>

    <br><br><br><br>
    <a href="Stronka123.html">Powrót</a>
</body>
</html>
