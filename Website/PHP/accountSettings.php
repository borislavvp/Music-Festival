<?php
session_start();

?>
    <form action="settingsChange.php" method="POST" >
        <div class="container">
            <div class="boxAcc container">
                <div class="box_title">
                    <span>Personal details</span>
                </div>
                <div class="form_group">
                    <div class="label-container">
                        <label for="email">First Name</label>
                    </div>
                    <input class="input form-control" type="text" name="fname" style="height: 53px;">
                </div>

                <div class="form_group">
                    <div class="label-container">
                        <label for="email">Email Addres</label>
                    </div>
                    <input class="input form-control" type="email" name="email" readonly="readonly"
                           placeholder='<?php echo $_SESSION['email'] ?> ' style="height: 53px;">
                </div>


                <div class="form_group">
                    <div class="label-container">
                        <label for="Address">Address</label>
                    </div>
                    <input class="input form-control" type="text" name="street" placeholder="STREET"
                           style="height: 53px;">
                    <input class="inputNumber form-control" type="number" name="houseNo" placeholder=" NUMBER"
                           style="height: 53px;">
                    <input class="inputNumber form-control" type="text" name="postCode" placeholder=" POSTAL CODE"
                           style="height: 53px;">
                    <input class="input form-control" type="text" name="city" placeholder="CITY"
                           style="height: 53px;">
                </div>
                <div class="form_group">
                    <div class="label-container">
                        <label for="Nationality">Nationality</label>
                    </div>
                    <input class="input form-control" type="text" name="nationality" style="height: 53px;">
                </div>
                <div class="form_group">
                    <div class="label-container">
                        <label for="Mobile">Mobile Number</label>
                    </div>
                    <input class="input form-control" type="text" name="phone" style="height: 53px;">
                </div>
                <div class="form_group">
                    <div class="label-container">
                        <label for="Address">Date of birth</label>
                    </div>
                    <input class="inputDate form-control" type="date" name="dob" min="1950-12-31"
                           placeholder=" DATE OF BIRTH" style="height: 53px;">
                </div>
                <div class="rowGender form_group">
                    <div class="label-container">
                        <label for="gender">Gender</label>
                    </div>
                    <input type="radio" name="gender" value="male" checked> Male<br>
                    <input type="radio" name="gender" value="female"> Female<br>
                    <input type="radio" name="gender" value="other"> Other
                </div>
                <div class="SavePersonalInfo">
                    <input type="submit" VALUE="SAVE" class="buttonBox buttonImage">
                </div>
            </div>
        </div>
    </form>
    <form action="passwordChange.php" method="POST" >
            <div class="boxResetPassword container">
                <div class="box_title">
                    <span>Reset Password</span>
                </div>
                <div class="form_group">
                    <div class="label-container">
                        <label for="Password">Old Password</label>
                    </div>
                    <input class="input form-control" type="Password" name="password" style="height: 53px;">
                </div>
                <div class="form_group">
                    <div class="label-container">
                        <label for="Password">New Password</label>
                    </div>
                    <input class="input form-control" type="Password" name="passwordNew" style="height: 53px;">
                </div>
                <div class="form_group">
                    <div class="label-container">
                        <label for="ConfPassword">Confirm Password</label>
                    </div>
                    <input class="input form-control" type="Password" name="passwordNewC" style="height:53px;">
                </div>
                <div class="SaveNewPass">
                    <input type="submit" value="SAVE" " class="buttonBox buttonImage">
                </div>
            </div>
        </div>
    </form>

