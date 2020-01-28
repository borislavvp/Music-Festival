var width = window.innerWidth;

var sPath = window.location.pathname;
var sPage = sPath.substring(sPath.lastIndexOf('/') + 1);

if ( sPage == "index.php" ) {
	document.getElementById("containerBottom").style.display = "none";
	document.getElementById("respSideBar").style.display = "none";
	if (width > 700){
		magnify("festmap", 2);
	}
}
else if ( sPage == "" ) {
	document.getElementById("containerBottom").style.display = "none";
	document.getElementById("respSideBar").style.display = "none";
	if (width > 700){
		magnify("festmap", 2);
	}
}
else if ( sPage == "aboutUs.php" ) {
	document.getElementById("containerBottom").style.display = "none";
	document.getElementById("respSideBar").style.display = "none";
}
else if ( sPage == "festival.php" ) {
	document.getElementById("bottomNavDiscover").style.display = "none";
	document.getElementById("dropdownBottom-discover").style.display = "none";
	document.getElementById("dropdownBottom-accView").style.display = "none";
}
else if ( sPage == "discover.php") {
	document.getElementById("bottomNavFestival").style.display = "none";
	document.getElementById("festival").style.display = "none";
	document.getElementById("campings").style.display = "none";
	document.getElementById("dropdownBottom-Festivals").style.display = "none";
	document.getElementById("dropdownBottom-Campings").style.display = "none";
	document.getElementById("dropdownBottom-accView").style.display = "none";
}
else if ( sPage == "discoverFestivalsBG2018.php" ) {
	document.getElementById("bottomNavFestival").style.display = "none";
	document.getElementById("festival").style.display = "none";
	document.getElementById("campings").style.display = "none";
}
else if ( sPage == "account.php" ) {
	document.getElementById("containerMain").style.position = "fixed";
	document.getElementById("containerBottom").style.display = "none";
	document.getElementById("dropdownBottom-Festivals").style.display = "none";
	document.getElementById("dropdownBottom-Campings").style.display = "none";
	document.getElementById("dropdownBottom-discover").style.display = "none";
}
else if ( sPage == "SignIn.php" ) {
	document.getElementById("containerBottom").style.display = "none";
	document.getElementById("respSideBar").style.display = "none";
	document.getElementById("acc-check").style.display = "none";
}

function setCookie(cname, cvalue, exdays) {
  var d = new Date();
  d.setTime(d.getTime() + (exdays * 24 * 60 * 60 * 1000));
  var expires = "expires="+d.toUTCString();
  document.cookie = cname + "=" + cvalue + ";" + expires + ";path=/";
}

function getCookie(cname) {
  var name = cname + "=";
  var decodedCookie = decodeURIComponent(document.cookie);
  var ca = decodedCookie.split(';');
  for(var i = 0; i < ca.length; i++) {
    var c = ca[i];
    while (c.charAt(0) == ' ') {
      c = c.substring(1);
    }
    if (c.indexOf(name) == 0) {
      return c.substring(name.length, c.length);
    }
  }
  return "";
}

function changeAccountBar() {
	var loginCookie = getCookie("Logged");

    if (loginCookie != "") {
	  document.getElementById("acc-check").innerHTML = "ACCOUNT";
	  document.getElementById("acc-check").href = "../PHP/account.php";

	  document.getElementById("acc-checkDrp").innerHTML = "ACCOUNT";
	  document.getElementById("acc-checkDrp").href = "../PHP/account.php";
	}else {
	  document.getElementById("acc-check").innerHTML = "SIGN IN";
	  document.getElementById("acc-check").href = "../PHP/SignIn.php";

	   document.getElementById("acc-checkDrp").innerHTML = "SIGN IN";
	  document.getElementById("acc-checkDrp").href = "../PHP/SignIn.php";
	}
}

function notifyForSentMessage() {
	var ticketCookie = getCookie("sentMessage");

    if (ticketCookie != "") {
    	alert("Thank you for your message ! We will send you a reply as soon as possible !");
    	setCookie("sentMessage","",0);
	}
}

function notifyForPurchasedTicket() {
	var ticketCookie = getCookie("existTicket");

    if (ticketCookie != "") {
    	alert("Thank you for purchasing your Festival Ticket ! Check your Email for more information !");
    	setCookie("existTicket","",0);
	}
}


function loadPage(fileName) {
	if(fileName == "discover-photos.php"){
		document.getElementById("photos").className = 'activeBottom';
		document.getElementById("videos").className = '';
		document.getElementById("festivals").className = '';
		document.getElementById("discoverMediaTitle").innerHTML = "PHOTOS";
		console.log('pp');
	}
	// here we do the opposite
	else if(fileName == "discoverVideos.php"){
		document.getElementById("photos").className = '';
		document.getElementById("videos").className = 'activeBottom';
		document.getElementById("discoverMediaTitle").innerHTML = "VIDEOS";
		document.getElementById("festivals").className = '';
		console.log('vv');
	}
	else if (fileName == "discoverFestivals.php"){
		document.getElementById("photos").className = '';
		document.getElementById("videos").className = '';
		document.getElementById("festivals").className = 'activeBottom';
		document.getElementById("discoverMediaTitle").innerHTML = "FESTIVALS";
		console.log('ff');
	}
	else if (fileName == "discoverFestivalsBG2018.php"){
		document.getElementById("photos").className = '';
		document.getElementById("videos").className = '';
		document.getElementById("festivals").className = '';
		document.getElementById("discoverMediaTitle").innerHTML = "BULGARIA 2018";
		console.log('bg');
	}
	else if (fileName == "campings-info.php"){
		document.getElementById("campinfo").className = 'activeBottom';
		document.getElementById("campbook").className = '';
		document.getElementById("article_prev_year").style.display = "none";
		console.log('dd');
	}
	else if (fileName == "campings-book.php"){
		document.getElementById("campinfo").className = '';
		document.getElementById("campbook").className = 'activeBottom';
		document.getElementById("article_prev_year").style.display = "none";
		console.log('ff');
	}
	else {
		return;
	}
	var xhttp = new XMLHttpRequest();
	xhttp.onreadystatechange = function() {
		if (this.readyState == 4 && this.status == 200) {
			document.getElementById("menuPage").innerHTML = this.responseText;
		}
	};
	xhttp.open("GET", fileName, true);
	xhttp.send();
}

function loadFestPage(fileName) {
	if (fileName == "festival-welcome.php") {
		document.getElementById("welcome").className = 'activeBottom';
		document.getElementById("tickets").className = '';
		document.getElementById("line-up").className = '';
		document.getElementById("article_prev_year").style.display = "block";
		console.log('aa');
	}
	// here we do the opposite
	else if (fileName == "festival-tickets.php") {
		document.getElementById("welcome").className = '';
		document.getElementById("tickets").className = 'activeBottom';
		document.getElementById("line-up").className = '';
		document.getElementById("article_prev_year").style.display = "none";
		console.log('bb');
	} else if (fileName == "festival-lineUp.php") {
		document.getElementById("welcome").className = '';
		document.getElementById("tickets").className = '';
		document.getElementById("line-up").className = 'activeBottom';
		document.getElementById("article_prev_year").style.display = "none";
		console.log('cc');
	}
	else {
		return;
	}

	var xhttp = new XMLHttpRequest();
	xhttp.onreadystatechange = function () {
		if (this.readyState == 4 && this.status == 200) {
			document.getElementById("menuPage").innerHTML = this.responseText;
		}
	};
	xhttp.open("GET", fileName, true);
	xhttp.send();
}
function loadTopPage(fileName) {
	if(fileName == "festival-welcome.php"){
		document.getElementById("festival").className = 'bottomNavFestival active';
		document.getElementById("campings").className = 'bottomNavFestival';
		document.getElementById("welcome").className = 'activeBottom';
		document.getElementById("tickets").className = '';
		document.getElementById("line-up").className = '';
		document.getElementById("article_prev_year").style.display = "block";
		document.getElementById("bottContainerFestival").style.display = "block";
		document.getElementById("bottContainerCampings").style.display = "none";
		console.log('dd');
	}
	// here we do the opposite
	else if(fileName == "campings-info.php"){
		document.getElementById("festival").className = 'bottomNavFestival';
		document.getElementById("article_prev_year").style.display = "none";
		document.getElementById("campings").className = 'bottomNavFestival active';
		document.getElementById("campinfo").className = 'activeBottom';
		document.getElementById("campbook").className = '';
		document.getElementById("bottContainerFestival").style.display = "none";
		document.getElementById("bottContainerCampings").style.display = "block";
		console.log('pp');
	}
	else {
		return;
	}
	var xhttp = new XMLHttpRequest();
	xhttp.onreadystatechange = function() {
		if (this.readyState == 4 && this.status == 200) {
			document.getElementById("menuPage").innerHTML = this.responseText;
		}
	};
	xhttp.open("GET", fileName, true);
	xhttp.send();
}

function loadPageCampingBook(){
	$.ajax({
			type: 'post',
			url: 'checksession.php',
			data: 
				'nodata=' + "",
			success: function (response) {
				if(response == "set")
				{
					loadPage("campings-book.php");
				}
				else if(response == "no")
				{
					loadPage("campings-info.php");
					alert("Sorry , Please Login or Create Account if you want to book a Camping Spot !");
				}
				else
				{
					loadPage("campings-info.php");
					alert("Sorry , We dont't have any camping spots at the moment !");
				}
			}
		});
}

function loadSidePage(fileName) {
	if(fileName == "accountOverview.php"){
		document.getElementById("accountOvervieww").className = 'activeSideBar';
		document.getElementById("accountTicketss").className = '';
		document.getElementById("accountSettingss").className = '';
		document.getElementById("bottContainerFestival").style.display = "block";
		console.log('ss');
	}
	else if(fileName == "accountTickets.php"){
		document.getElementById("accountOvervieww").className = '';
		document.getElementById("accountTicketss").className = 'activeSideBar';
		document.getElementById("accountSettingss").className = '';
		document.getElementById("contactAcc").style.display = "none";
		console.log('ss');
	}
	else if(fileName == "accountSettings.php"){
		document.getElementById("accountOvervieww").className = '';
		document.getElementById("accountTicketss").className = '';
		document.getElementById("accountSettingss").className = 'activeSideBar';
		document.getElementById("bottContainerFestival").style.display = "block";
		console.log('ss');
	}
	else {
		return;
	}
	var xhttp = new XMLHttpRequest();
	xhttp.onreadystatechange = function() {
		if (this.readyState == 4 && this.status == 200) {
			document.getElementById("menuPage").innerHTML = this.responseText;
		}
	};
	xhttp.open("GET", fileName, true);
	xhttp.send();
}

function signOut() {
	window.location = "signout.php"
}


var modal = document.getElementById('modal');
var modalBodyCover = document.getElementById('modalBodyCover');
// When the user clicks anywhere outside of the modal, close it
window.onclick = function(event) {
	if (event.target == modal) {
		modal.style.display = "none";
	}
	else if (event.target == modalBodyCover) {
		modalBodyCover.style.display = "none";
		closeBottomNav();
	}
}

var dropdownF = document.getElementById("dropdownBottom-Festivals");
var dropdownC = document.getElementById("dropdownBottom-Campings");

function OpenCloseFestDropd() {
  var element = document.getElementById("dropdFest");

  if (element.classList) { 
    element.classList.toggle("dropdBottCont-display");
  } else {
    var classes = element.className.split(" ");
    var i = classes.indexOf("dropdBottCont-display");

    if (i >= 1) {
      classes.splice(i, 1);
    }
    else {
      classes.push("dropdBottCont-display");
      element.className = classes.join(" "); 
 	 }
  }
}
function OpenCloseCampDropd() {
  var element = document.getElementById("dropdCamp");

  if (element.classList) { 
    element.classList.toggle("dropdBottCont-display");
  } else {
    var classes = element.className.split(" ");
    var i = classes.indexOf("dropdBottCont-display");

    if (i >= 1) {
      classes.splice(i, 1);
    }
    else {
      classes.push("dropdBottCont-display");
      element.className = classes.join(" "); 
 	 }
  }
}


function magnify(imgID, zoom) {
	var img, glass, w, h, bw;
	img = document.getElementById(imgID);
	/*create magnifier glass:*/
	glass = document.createElement("DIV");
	glass.setAttribute("class", "img-magnifier-glass");
	/*insert magnifier glass:*/
	img.parentElement.insertBefore(glass, img);
	/*set background properties for the magnifier glass:*/
	glass.style.backgroundImage = "url('" + img.src + "')";
	glass.style.backgroundRepeat = "no-repeat";
	glass.style.backgroundSize = (img.width/2.7 * zoom) + "px " + (img.height/3.6 * zoom) + "px";
	bw = 3;
	w = glass.offsetWidth / 2;
	h = glass.offsetHeight / 2;
	/*execute a function when someone moves the magnifier glass over the image:*/
	glass.addEventListener("mousemove", moveMagnifier);
	img.addEventListener("mousemove", moveMagnifier);
	/*and also for touch screens:*/
	glass.addEventListener("touchmove", moveMagnifier);
	img.addEventListener("touchmove", moveMagnifier);
	function moveMagnifier(e) {
		var pos, x, y;
		/*prevent any other actions that may occur when moving over the image*/
		e.preventDefault();
		/*get the cursor's x and y positions:*/
		pos = getCursorPos(e);
		x = pos.x;
		y = pos.y;
		/*prevent the magnifier glass from being positioned outside the image:*/
		if (x > img.width - (w / zoom)) {x = img.width - (w / zoom);}
		if (x < w / zoom) {x = w / zoom;}
		if (y > img.height - (h / zoom)) {y = img.height - (h / zoom);}
		if (y < h / zoom) {y = h / zoom;}
		/*set the position of the magnifier glass:*/
		glass.style.left = (x - w -40) + "px";
		glass.style.top = (y - h-40) + "px";
		/*display what the magnifier glass "sees":*/
		glass.style.backgroundPosition = "-" + ((x * zoom) - w + bw) + "px -" + ((y * zoom) - h + bw) + "px";
	}
	function getCursorPos(e) {
		var a, x = 0, y = 0;
		e = e || window.event;
		/*get the x and y positions of the image:*/
		a = img.getBoundingClientRect();
		/*calculate the cursor's x and y coordinates, relative to the image:*/
		x = e.pageX - a.left;
		y = e.pageY - a.top;
		/*consider any page scrolling:*/
		x = x - window.pageXOffset;
		y = y - window.pageYOffset;
		return {x : x, y : y};
	}
}


function noVipTickets() {
	alert("THE VIP TICKETS ARE SOLD OUT. \n \n                  STAY TUNED !");
}

function showSlides(n) {
	var i;
	var slides = document.getElementsByClassName("mySlides");
	var dots = document.getElementsByClassName("dot");
	if (n > slides.length) {slideIndex = 1}
	if (n < 1) {slideIndex = slides.length}
	for (i = 0; i < slides.length; i++) {
		slides[i].style.display = "none";
	}
	for (i = 0; i < dots.length; i++) {
		dots[i].className = dots[i].className.replace(" activeDot", "");
	}
	slides[slideIndex-1].style.display = "block";
	dots[slideIndex-1].className += " activeDot";
}


function moveLeft(contentID) {
	var elem = document.getElementById(contentID);
	var pos = 0;
	var id = setInterval(frame, 10);
	function frame() {
		if (pos == 50) {
			clearInterval(id);
		} else {
			pos++;
			elem.style.left = pos + "px";
		}
	}
}
function moveBack(contentID) {
	var elem = document.getElementById(contentID);
	var pos = 50;
	var id = setInterval(frame, 2);
	function frame() {
		if (pos == 0) {
			clearInterval(id);
		} else {
			pos--;
			elem.style.left = pos + "px";
		}
	}
}
function moveTop(contentID) {
	var elem = document.getElementById(contentID);
	elem.style.display = "block";
	var pos = 50;
	var id = setInterval(frame, 2);
	function frame() {
		if (pos == 0) {
			clearInterval(id);
		} else {
			pos--;
			elem.style.top = pos + "px";
		}
	}
}
function moveDown(contentID) {
	var elem = document.getElementById(contentID);
	var pos = 0;
	var id = setInterval(frame, 2);
	function frame() {
		if (pos == 50) {
			clearInterval(id);
			elem.style.display = "none";
		} else {
			pos++;
			elem.style.top = pos + "px";
		}
	}
}


function myMap() {
	var mapProp= {
		center:new google.maps.LatLng(51.432470,5.470740),
		zoom:5,
	};
	var map = new google.maps.Map(document.getElementById("googleMap"),mapProp);

	var position = {lat: 51.432470, lng: 5.470740};
	var marker = new google.maps.Marker({position: position, map: map});
}


function changePictureModalSrc(index){
	var images = [
		"../Pictures/photo1.jpg" ,
		"../Pictures/photo2.jpg" ,
		"../Pictures/photo3.jpg" ,
		"../Pictures/photo4.jpg" ,
		"../Pictures/photo5.jpg" ,
		"../Pictures/photo6.jpg" ,
		"../Pictures/photo7.jpg" ,
		"../Pictures/photo8.jpg" ,
		"../Pictures/photo9.jpg" ,
		"../Pictures/photo10.jpg" ,
		"../Pictures/photo11.jpg" ,
		"../Pictures/photo12.jpg" ,
	];

	var modalImage = document.getElementById('myimage');
	modalImage.src = images[index];
}

function changeVideoModalSrc(index){
	var images = [
		"https://www.youtube.com/embed/HkyVTxH2fIM" ,
		"https://www.youtube.com/embed/MglnNn_rB3I" ,
		"https://www.youtube.com/embed/1q8djJuIcXo" ,
		"https://www.youtube.com/embed/5egGsrpe9eE" ,
		"https://www.youtube.com/embed/DomObS9staI" ,
		"https://www.youtube.com/embed/GS3GYQQUS3o" ,
		"https://www.youtube.com/embed/PR6DEZXgf-o" ,
		"https://www.youtube.com/embed/79nFO8dTJfY" ,
		"https://www.youtube.com/embed/BlXiKihALys" ,
		"https://www.youtube.com/embed/7DE0TAz5xbg" ,
		"https://www.youtube.com/embed/wCm3TZyIM8E" ,
		"https://www.youtube.com/embed/5ZQjVrzcPs0" ,
	];

	var modalImage = document.getElementById('myimage');
	modalImage.src = images[index];
}

function ShowLineUp15th(){
	document.getElementById("dayData-box1").className = 'dayData-box activeDayDataBox';
	document.getElementById("dayData-box2").className = 'dayData-box ';
	document.getElementById("dayData-box3").className = 'dayData-box ';

	document.getElementById("line-up-15th").style.display = "block";
	document.getElementById("line-up-15th-special").style.display = "block";

	document.getElementById("line-up-16th").style.display = "none";
	document.getElementById("line-up-16th-special").style.display = "none";

	document.getElementById("line-up-17th").style.display = "none";
	document.getElementById("line-up-17th-special").style.display = "none";
}
function ShowLineUp16th(){
	document.getElementById("dayData-box2").className = 'dayData-box activeDayDataBox';
	document.getElementById("dayData-box1").className = 'dayData-box ';
	document.getElementById("dayData-box3").className = 'dayData-box ';

	document.getElementById("line-up-16th").style.display = "block";
	document.getElementById("line-up-16th-special").style.display = "block";

	document.getElementById("line-up-15th").style.display = "none";
	document.getElementById("line-up-15th-special").style.display = "none";

	document.getElementById("line-up-17th").style.display = "none";
	document.getElementById("line-up-17th-special").style.display = "none";
}
function ShowLineUp17th(){
	document.getElementById("dayData-box3").className = 'dayData-box activeDayDataBox';
	document.getElementById("dayData-box2").className = 'dayData-box ';
	document.getElementById("dayData-box1").className = 'dayData-box ';

	document.getElementById("line-up-17th").style.display = "block";
	document.getElementById("line-up-17th-special").style.display = "block";

	document.getElementById("line-up-16th").style.display = "none";
	document.getElementById("line-up-16th-special").style.display = "none";

	document.getElementById("line-up-15th").style.display = "none";
	document.getElementById("line-up-15th-special").style.display = "none";
}

function openBottomNav() {
	document.getElementById("bottomContainerNav").style.display = "block";
	document.body.style.marginLeft = "300px";
	modalBodyCover.style.display = "block";
}

function closeBottomNav() {
	modalBodyCover.style.display = "none";
	document.getElementById("bottomContainerNav").style.display = "none";
	document.body.style.marginLeft= "0";

}

var UserExist = "no";

function checkEmail()
{
	var email = document.getElementById( "email" ).value;
	$.ajax({
			type: 'post',
			url: 'checkemail.php',
			data: 
				'user_email=' + email,
			success: function (response) {
				if(response == "Ok")
				{
					UserExist = "no";
					return true;
				}
				else
				{
					UserExist = "yes";
					
					return false;
				}
			}
		});
}

var SignInEmailValidate = "no";
var SignInPwValidate = "no";

function checkSignInEmail()
{
	var email = document.getElementById( "semail" ).value;
	$.ajax({
			type: 'post',
			url: 'checkemail.php',
			data: 
				'user_email=' + email,
			success: function (response) {
				if(response == "Exist")
				{
					SignInEmailValidate = "yes";
					setCookie("userEmail",email,7);
					return true;
				}
				else
				{
					SignInEmailValidate = "no";
					setCookie("userEmail",email,0);
					return false;
				}
			}
		});
}

function checkSignInPassword()
{
	var password = document.getElementById( "spassword" ).value;
	var email = getCookie("userEmail");

	if (email != "") {
	$.ajax({
			type: 'post',
			url: 'checkpassword.php',
			data: {
				user_pw:password,
				user_email:email,
			},
			success: function (response) {
				if(response == "Ok")
				{
					SignInPwValidate = "yes";
					return true;
				}
				else
				{

					SignInPwValidate = "no";
					
					return false;
				}
			}
		});
	}
}

function validateSignInForm() {

	if (SignInEmailValidate == "no") {
		alert("Wrong email !");
		return false;
	}
	else if (SignInPwValidate == "no") {
		alert("Wrong password !");
		return false;
	}
	else {
		var email = getCookie("userEmail");
		setCookie("userEmail",email,0);
		return true;
	}
}

function validateRegistrationForm()
{
  
  var reEmail = /^(([^<>()\[\]\\.,;:\s@"]+(\.[^<>()\[\]\\.,;:\s@"]+)*)|(".+"))@((\[[0-9]{1,3}\.[0-9]{1,3}\.[0-9]{1,3}\.[0-9]{1,3}\])|(([a-zA-Z\-0-9]+\.)+[a-zA-Z]{2,}))$/;
  var rePhone = /^[\+]?[(]?[0-9]{3}[)]?[-\s\.]?[0-9]{3}[-\s\.]?[0-9]{4,6}$/im ;

  var email = document.forms["regForm"]["email"].value;
  if (reEmail.test(email) != true) {
    alert("Invalid email !");
    return false;
  }

  var password = document.forms["regForm"]["password"].value;
  var confirmPassword = document.forms["regForm"]["cpassword"].value;
  if (password != confirmPassword) {
    alert("The passwords must match !");
    return false;
  }

  var phone = document.forms["regForm"]["phone"].value;
  if (rePhone.test(String(phone)) != true) {
    alert("Invalid phone number !");
    return false;
  }
	
  if(UserExist == "no")
   {
	 
   }
  else
   {
	 alert("There is already an existing user with this email !");
	 return false;
   }
}

function checkCampingSpotSelection(){
	if ( document.getElementById( "emailcamp6" ).value == "" || document.getElementById( "emailcamp5" ).value == ""
	  || document.getElementById( "emailcamp4" ).value == "" || document.getElementById( "emailcamp3" ).value == ""
	  || document.getElementById( "emailcamp2" ).value == "" || document.getElementById( "emailcamp1" ).value == ""  ) {

	document.getElementById("sel1").disabled = true;
  }else{
  	document.getElementById("sel1").disabled = false;
  }
}

var PersonuserEmail1 = "no";
var PersonuserEmail2 = "no";
var PersonuserEmail3 = "no";
var PersonuserEmail4 = "no";
var PersonuserEmail5 = "no";
var PersonuserEmail6 = "no";

var campBalanceCheck = "no";

var booked = ["yes","yes","yes","yes","yes","yes","yes","yes"];
function checkCampingSpots()
{	
	var spot1 = document.getElementById( "spot1" ).value;
	var spot2 = document.getElementById( "spot2" ).value;
	var spot3 = document.getElementById( "spot3" ).value;
	var spot4 = document.getElementById( "spot4" ).value;
	var spot5 = document.getElementById( "spot5" ).value;
	var spot6 = document.getElementById( "spot6" ).value;
	var spot7 = document.getElementById( "spot7" ).value;
	var spot8 = document.getElementById( "spot8" ).value;

	var spots = [spot1,spot2,spot3,spot4,spot5,spot6,spot7,spot8];

	var availableSpots = ["spot1","spot2","spot3","spot4","spot5","spot6","spot7","spot8"];
	var i;
		
	for (i = 0; i < spots.length; i++) {
 	
	$.ajax({
			type: 'post',
			url: 'checkCampingSpots.php',
			data: 
				'spotId=' + spots[i],
			async: false,
			success: function (response) {
				if(response == "Exist")
				{
					booked[i] = "no";
				}
				else
				{	
					booked[i] = "yes";
					return false;
				}
			}
	  });

	if (booked[i] == "no") {
		document.getElementById(availableSpots[i]).style.display = "none";
	}else{
		document.getElementById(availableSpots[i]).style.display = "block";
	}

	}
}

function checkUserEmail1()
{
	var email = document.getElementById( "emailcamp1" ).value;
	$.ajax({
			type: 'post',
			url: 'checkcampemail.php',
			data: 
				'user_email=' + email,
			success: function (response) {
				if(response == "Exist")
				{
					PersonuserEmail1 = "yes";
					return true;
				}
				else
				{
					PersonuserEmail1 = "no";
					return false;
				}
			}
		});
}
function checkUserEmail2()
{
	var email = document.getElementById( "emailcamp2" ).value;
	$.ajax({
			type: 'post',
			url: 'checkcampemail.php',
			data: 
				'user_email=' + email,
			success: function (response) {
				if(response == "Exist")
				{
					PersonuserEmail2 = "yes";
					return true;
				}
				else
				{
					PersonuserEmail2 = "no";
					return false;
				}
			}
		});
}
function checkUserEmail3()
{
	var email = document.getElementById( "emailcamp3" ).value;
	$.ajax({
			type: 'post',
			url: 'checkcampemail.php',
			data: 
				'user_email=' + email,
			success: function (response) {
				if(response == "Exist")
				{
					PersonuserEmail3 = "yes";
					return true;
				}
				else
				{
					PersonuserEmail3 = "no";
					return false;
				}
			}
		});
}
function checkUserEmail4()
{
	var email = document.getElementById( "emailcamp4" ).value;
	$.ajax({
			type: 'post',
			url: 'checkcampemail.php',
			data: 
				'user_email=' + email,
			success: function (response) {
				if(response == "Exist")
				{
					PersonuserEmail4 = "yes";
					return true;
				}
				else
				{
					PersonuserEmail4 = "no";
					return false;
				}
			}
		});
}
function checkUserEmail5()
{
	var email = document.getElementById( "emailcamp5" ).value;
	$.ajax({
			type: 'post',
			url: 'checkcampemail.php',
			data: 
				'user_email=' + email,
			success: function (response) {
				if(response == "Exist")
				{
					PersonuserEmail5 = "yes";
					return true;
				}
				else
				{
					PersonuserEmail5 = "no";
					return false;
				}
			}
		});
}
function checkUserEmail6()
{
	var email = document.getElementById( "emailcamp6" ).value;
	$.ajax({
			type: 'post',
			url: 'checkcampemail.php',
			data: 
				'user_email=' + email,
			success: function (response) {
				if(response == "Exist")
				{
					PersonuserEmail6 = "yes";
					return true;
				}
				else
				{
					PersonuserEmail6 = "no";
					return false;
				}
			}
		});
}
function checkCampBalance()
{
	$.ajax({
			type: 'post',
			url: 'checkcampbalance.php',
			data: 
				'user_check=y' ,
			success: function (response) {
				if(response == "Ok")
				{
					campBalanceCheck = "yes";
					return true;
				}else if (response == "nosess") {
					campBalanceCheck = "no";
					return false;
				}
				else
				{
					campBalanceCheck = "no";
					alert("You dont have enough balance to book a spot . Please deposit and try again !")
					return false;
				}
			}
		});
}
function CampingBookValidate() {

	var userEmail1 = document.getElementById("emailcamp1").value;
	var userEmail2 = document.getElementById("emailcamp2").value;
	var userEmail3 = document.getElementById("emailcamp3").value;
	var userEmail4 = document.getElementById("emailcamp4").value;
	var userEmail5 = document.getElementById("emailcamp5").value;
	var userEmail6 = document.getElementById("emailcamp6").value;

	if (userEmail1 == userEmail2 || userEmail1 == userEmail3 || userEmail1 == userEmail4 || userEmail1 == userEmail5 || userEmail1 == userEmail6) {
		alert("Invalid input!");
		return false;
	}
	if (userEmail2 == userEmail1 || userEmail2 == userEmail3 || userEmail2 == userEmail4 || userEmail2 == userEmail5 || userEmail2 == userEmail6) {
		alert("Invalid input!");
		return false;
	}
	if (userEmail3 == userEmail2 || userEmail3 == userEmail1 || userEmail3 == userEmail4 || userEmail3 == userEmail5 || userEmail3 == userEmail6) {
		alert("Invalid input!");
		return false;
	}
	if (userEmail4 == userEmail2 || userEmail4 == userEmail3 || userEmail4 == userEmail1 || userEmail4 == userEmail5 || userEmail4 == userEmail6) {
		alert("Invalid input!");
		return false;
	}
	if (userEmail5 == userEmail2 || userEmail5 == userEmail3 || userEmail5 == userEmail4 || userEmail5 == userEmail1 || userEmail5 == userEmail6) {
		alert("Invalid input!");
		return false;
	}
	if (userEmail6 == userEmail2 || userEmail6 == userEmail3 || userEmail6 == userEmail4 || userEmail6 == userEmail5 || userEmail6 == userEmail1) {
		alert("Invalid input!");
		return false;
	}

	if (PersonuserEmail1 == "no") {
		alert("Person 1 Email is invalid or the person doesn't have a ticket !");
		return false;
	}	
	if (PersonuserEmail2 == "no") {
		alert("Person 2 Email is invalid or the person doesn't have a ticket !");
		return false;
	}
	if (PersonuserEmail3 == "no") {
		alert("Person 3 Email is invalid or the person doesn't have a ticket !");
		return false;
	}
	if (PersonuserEmail4 == "no") {
		alert("Person 4 Email is invalid or the person doesn't have a ticket !");
		return false;
	}	
	if (PersonuserEmail5 == "no") {
		alert("Person 5 Email is invalid or the person doesn't have a ticket !");
		return false;
	}
	if (PersonuserEmail6 == "no") {
		alert("Person 6 Email is invalid or the person doesn't have a ticket !");
		return false;
	}

	if (campBalanceCheck == "no") {
		alert("Sorry , you don't have enough balance. Please deposit and try again !");
		location.reload();
		return false;	
	}
	alert("Booked Successfully!");
}

function checkBalance()
{
	$.ajax({
			type: 'post',
			url: 'checkbalance.php',
			data: 
				'user_check=y' ,
			success: function (response) {
				if(response == "Ok")
				{
					window.location = "barcode/buyTicket.php";
					return true;
				}
				else if (response == "existTicket") {
					alert("You already have a festival ticket !");
					return false;
				}
				else if (response == "nosess") {
					alert("Please Sign In if you want to buy a ticket !");
					return false;
				}
				else
				{
					alert("Not enough balance. Please deposit and try again !");
					return false;
				}
			}
		});
}
function addBalance10()
{
	var balance = 10;
	
    $.ajax({
      type: "POST",
      url: 'addBalance.php',
      data: 'user_balance=' + balance,
      success: function(response){
      	if(response == "Ok"){
		   alert("Added !");
   		   location.reload();
      	} 
      	else {
      		alert("Something went wrong . Please try again later !");
      	}
      }
    });
}
function addBalance20()
{
	var balance = 20;
	
    $.ajax({
      type: "POST",
      url: 'addBalance.php',
      data: 'user_balance=' + balance,
      success: function(response){
      	if(response == "Ok"){
		   alert("Added !");
   		   location.reload();
      	} 
      	else {
      		alert("Something went wrong . Please try again later !");
      	}
      }
    });
}
function addBalance50()
{
	var balance = 50;
	
    $.ajax({
      type: "POST",
      url: 'addBalance.php',
      data: 'user_balance=' + balance,
      success: function(response){
      	if(response == "Ok"){
		   alert("Added !");
   		   location.reload();
      	} 
      	else {
      		alert("Something went wrong . Please try again later !");
      	}
      }
    });
}

function addBalance100()
{
	var balance = 100;
	
    $.ajax({
      type: "POST",
      url: 'addBalance.php',
      data: 'user_balance=' + balance,
      success: function(response){
      	if(response == "Ok"){
		   alert("Added !");
   		   location.reload();
      	} 
      	else {
      		alert("Something went wrong . Please try again later !");
      	}
      }
    });  
}

function alertForChangedDetails() {
    var success = getCookie("changedDetails");
    var wrongPw = getCookie("wrongPassword");
    var wrongConfirmPw = getCookie("wrongConfirmPassword");
    if (success != 'yes') {

        if( wrongPw == 'yes'){
        	 alert("The old password is wrong !");
        	 document.cookie = "wrongPassword=; expires=Thu, 01 Jan 1970 00:00:00 UTC; path=/;";
        } 
        else if (wrongConfirmPw == 'yes') {
        	alert("The two passwords must be the same !");
        	document.cookie = "wrongConfirmPassword=; expires=Thu, 01 Jan 1970 00:00:00 UTC; path=/;";
        }
    }
    else {
       alert("Details have been changed !");
       document.cookie = "changedDetails=; expires=Thu, 01 Jan 1970 00:00:00 UTC; path=/;";
    }
}