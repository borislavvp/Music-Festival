<div id="containerMain" class="container-fluid navContainer">
    <nav class="mainNav">
        <ul>
            <li><a href="../index.php">HOME</a></li>
            <li><a href="../PHP/festival.php" >Festival</a></li>
            <li><a href="../PHP/discover.php" >DISCOVER</a></li>
            <li><a href="../PHP/aboutUs.php" >about us</a></li>
            <li class="navSignIn"><a id="acc-check" href="../PHP/SignIn.php">SIGN IN</a></li>
        </ul>
    </nav>
    <nav class="navSocialNetwork">
        <ul>
            <li><a href="https://www.facebook.com/borislav.pavlov11" target="blank1"><i class='fab fa-facebook-f' ></i></a></li>
            <li><a href="https://www.instagram.com/borislavvp/" target="blank1"><i class='fab fa-instagram' ></i></a></li>
            <li><a href="#" target="blank1"><i class='fab fa-twitter' ></i></a></li>
        </ul>
    </nav>
    <div class="dropdown">
        <button type="button" class="btn dropBtn-style dropdown-toggle" data-toggle="dropdown">
            Festival Content
        </button>
        <div class="dropdown-menu">
            <a class="dropdown-item" href="../index.php">HOME</a>
            <a class="dropdown-item" href="../PHP/festival.php">FESTIVAL</a>
            <a class="dropdown-item" href="../PHP/discover.php">DISCOVER</a>
            <a class="dropdown-item" href="../PHP/aboutUs.php">ABOUT US</a>
            <a class="dropdown-item" id="acc-checkDrp" href="../PHP/SignIn.php">SIGN IN</a>
        </div>
    </div>
    <span id="respSideBar" class="resp-side-navbar-open" onclick="openBottomNav()">&#9776; Menu</span>
</div>

<div id="containerBottom" class="containerBottom">
    <div class="containerBottom1">
        <nav id="festival" onclick="loadTopPage('festival-welcome.php')" class="bottomNavFestival active">
            <ul>
                <li><a href="#">Festival</a></li>
            </ul>
        </nav>
        <nav id="campings" onclick="loadTopPage('campings-info.php')" class="bottomNavFestival">
            <ul>
                <li><a href="#">Campings</a></li>
            </ul>
        </nav>
    </div>
    <div id="bottContainerCampings" class="containerBottom2">
        <nav class="bottomNav">
            <ul>
                <li><a class="activeBottom" href="#" id="campinfo" onclick="loadPage('campings-info.php')">Info</a></li>
                <li><a href="#" id="campbook" onclick="loadPageCampingBook();">Book</a></li>
            </ul>
        </nav>
    </div>
    <div id="bottContainerFestival" class="containerBottom2">
        <nav id="bottomNavFestival" class="bottomNav">
            <ul>
                <li><a class="activeBottom" href="#" id="welcome" onclick="loadFestPage('festival-welcome.php')">Welcome</a></li>
                <li><a href="#" id="tickets" onclick="loadFestPage('festival-tickets.php')">Tickets</a></li>
                <li><a href="#" id="line-up" onclick="loadFestPage('festival-lineUp.php')">Line-up</a></li>
            </ul>
        </nav>
        <nav id="bottomNavDiscover" class="bottomNav">
            <ul>
                <li><a class="activeBottom" href="#" id="photos" onclick="loadPage('discover-photos.php')">Photo</a></li>
                <li><a href="#" id="videos" onclick="loadPage('discoverVideos.php')">Video</a></li>
                <li><a href="#" id="festivals" onclick="loadPage('discoverFestivals.php')">Festivals</a></li>
            </ul>
        </nav>
    </div>
</div>
<div id="bottomContainerNav" class="dropdownBottom">
    <div id="dropdownBottom-discover">
        <a href="#" id="videos" onclick="loadPage('discoverVideos.php');closeBottomNav()">Videos</a>
        <a href="#" id="photos" onclick="loadPage('discover-photos.php');closeBottomNav()">Photos</a>
        <a href="#" id="festivals" onclick="loadPage('discoverFestivals.php');closeBottomNav()">Festivals</a>
    </div>
    <div id="dropdownBottom-accView">
        <a href="#" id="accountOverview" onclick="loadSidePage('accountOverview.php');closeBottomNav()">Overview</a>
        <a href="#" id="accountTickets" onclick="loadSidePage('accountTickets.php');closeBottomNav()">Tickets</a>
        <a href="#" id="accountSettings" onclick="loadSidePage('accountSettings.php');closeBottomNav()">Settings</a>
    </div>
    <button id="dropdownBottom-Festivals" onclick="OpenCloseFestDropd()" class="dropdownBottom-btn">Festival
        <i class="fa fa-caret-down"></i>
    </button>
    <div id="dropdFest" class="dropdownBottom-container dropdBottCont-display" >
        <a href="#" id="welcome" onclick="loadFestPage('festival-welcome.php');closeBottomNav()">Welcome</a>
        <a href="#" id="tickets" onclick="loadFestPage('festival-tickets.php');closeBottomNav()">Tickets</a>
        <a href="#" id="line-up" onclick="loadFestPage('festival-lineUp.php');closeBottomNav()">Line-up</a>
    </div>
    <button id="dropdownBottom-Campings" onclick="OpenCloseCampDropd()" class="dropdownBottom-btn">Campings
        <i class="fa fa-caret-down"></i>
    </button>
    <div id="dropdCamp" class="dropdownBottom-container dropdBottCont-display">
        <a href="#" id="campinfo" onclick="loadPage('campings-info.php');closeBottomNav()">Info</a>
        <a href="#" id="campbook" onclick="loadPageCampingBook();closeBottomNav()">Book</a>
    </div>
    <div class="navSignOutbtn" style="margin-top: 500px; margin-left: 100px;">
        <a href="#" style="letter-spacing: 2px;" onclick="closeBottomNav()">CLOSE</a>
    </div>
</div>
<script src="../JavaScript/javascript.js"></script>