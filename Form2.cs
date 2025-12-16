<!DOCTYPE html>
<html lang="lv">
<head>
    <meta charset="UTF-8">
    <title>2. Forma: Pieslēgties</title>
    <link rel="stylesheet" href="style.css">
</head>
<body>
    <div class="container login-container">
        <div class="sidebar blue-bg">
            <h1>Esi sveicināts ĶLUS</h1>
            <p>Tavas laboratorijas uzskaites sistēma</p>
            </div>

        <div class="content white-bg login-content">
            <a href="index.html" class="back-link">
                &larr; Atpakaļ uz sākumlapu
            </a>
            
            <h2>Pieslēgties</h2>
            <p>Ķīmijas laboratorijas uzskaites sistēmai</p>

            <form action="#" class="login-form">
                <label for="username">Lietotājvārds</label>
                <input type="text" id="username" placeholder="Ievadīt lietotājvārdu">
                
                <label for="password">Parole</label>
                <input type="password" id="password" placeholder="Ievadīt paroli">
                
                <button type="submit" class="button primary">Pieslēgties</button>
            </form>
            
            <p class="register-text">Neesi vēl reģistrēts? <a href="#">Izveidot profilu</a></p>
        </div>
    </div>
    <div class="error-report">
        <button class="error-button">Ziņot par kļūdu</button>
    </div>
</body>
</html>
