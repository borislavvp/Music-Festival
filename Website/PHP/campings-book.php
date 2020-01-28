
<article class="tickets-content">
    <div class="ticket-info-imageL">
        <img src="../Pictures/campings.jpg" onload="checkCampingSpotSelection();checkCampBalance();">
    </div>
    <div class="campings-reg-form">
        <div class="tickets-info container" style="height:1150px;background-color:rgba(255,255,255,0.7);">
            <div class="tickets-info-title">
                <h1> Campings Registration</h1>
            </div>
            <div class="tickets-info-text">
                <p>Please enter the <strong>Email </strong>  of every person and<strong> THEN </strong>choose a Camping Spot .<strong>Note that every person must haven an account created and a ticket for the event otherwise you won't be able to book a camping spot .</strong> </p>
            </div>
            <form onsubmit="return CampingBookValidate();" action="camping-registration.php" method="post" class="createCampForm">
                <div class="box2" style="margin-left: 50px;">
                    <div class="box_title" style="width: 370px;">
                        <span>Event Account Number</span>
                    </div>

                    <div class="form_group">
                        <div class="label-container">
                            <label for="email">Person 1 Email</label>
                        </div>
                        <input class="input form-control" type="email" id="emailcamp1" name="email1" oninput="checkCampingSpotSelection();checkUserEmail1();" required style="height: 53px;margin-left: 20px;">
                    </div>
                    <div class="form_group">
                        <div class="label-container">
                            <label for="Password">Person 2 Email</label>
                        </div>
                        <input class="input form-control" type="text" id="emailcamp2" name="email2" oninput="checkCampingSpotSelection();checkUserEmail2();" required style="height: 53px;margin-left: 20px;">
                    </div>
                    <div class="form_group">
                        <div class="label-container">
                            <label for="Password">Person 3 Email</label>
                        </div>
                        <input class="input form-control" type="text" id="emailcamp3" name="email3" oninput="checkCampingSpotSelection();checkUserEmail3();" required style="height: 53px;margin-left: 20px;">
                    </div>
                    <div class="form_group">
                        <div class="label-container">
                            <label for="email">Person 4 Email</label>
                        </div>
                        <input class="input form-control" type="text" id="emailcamp4" name="email4" oninput="checkCampingSpotSelection();checkUserEmail4();" required style="height: 53px;margin-left: 20px;">
                    </div>
                    <div class="form_group">
                        <div class="label-container">
                            <label for="Password">Person 5 Email</label>
                        </div>
                        <input class="input form-control" type="text" id="emailcamp5" name="email5" oninput="checkCampingSpotSelection();checkUserEmail5();" required style="height: 53px;margin-left: 20px;">
                    </div>
                    <div class="form_group">
                        <div class="label-container">
                            <label for="Password">Person 6 Email</label>
                        </div>
                        <input class="input form-control" type="text" id="emailcamp6" name="email6"  oninput="checkCampingSpotSelection();checkUserEmail6();checkCampingSpots();" required style="height: 53px;margin-left: 20px;">
                    </div>
                    <div style ="margin-left: 200px;">
                    <label for="sel1" style ="margin-left: -20px;" >Select a camping spot:</label>
                    <select required name="spotID" class="form-control" id="sel1" style ="width:170px">
                     <option disabled selected>Choose a Spot</option>  
                     <option id="spot1">1</option>
                     <option id="spot2">2</option>
                     <option id="spot3">3</option>
                     <option id="spot4">4</option>
                     <option id="spot5">5</option>
                     <option id="spot6">6</option>
                     <option id="spot7">7</option>
                     <option id="spot8">8</option>
                    </select>
                </div>
                </div>
                
                <div class="createAccBtn" style="margin-left: 500px;">
                    <input type="submit"  value="REGISTER GROUP" class="buttonBox buttonImage">
                </div>
            </form>
        </div>
    </div>
</article>
