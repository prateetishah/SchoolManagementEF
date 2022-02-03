@Code
    ViewData("Title") = "Home Page"
End Code



<div id="carouselExampleIndicators" class="carousel slide" data-ride="carousel">
    <ol class="carousel-indicators">
        <li data-target="#carouselExampleIndicators" data-slide-to="0" class="active"></li>
        <li data-target="#carouselExampleIndicators" data-slide-to="1"></li>
        <li data-target="#carouselExampleIndicators" data-slide-to="2"></li>
        <li data-target="#carouselExampleIndicators" data-slide-to="3"></li>
    </ol>
    <div class="carousel-inner">
        <div class="carousel-item active">
            <img class="d-block w-100" src="~/Content/Images/Slide1.jpg" alt="School Management System">
        </div>
        <div class="carousel-item">
            <img class="d-block w-100" src="~/Content/Images/Slide2images.png" alt="What to expect?">
        </div>
        <div class="carousel-item">
            <img class="d-block w-100" src="~/Content/Images/Slide3.png" alt="Why SMS?">
        </div>
        <div class="carousel-item">
            <img class="d-block w-100" src="~/Content/Images/Slide4.png" alt="How it works?">
        </div>
    </div>
    <a class="carousel-control-prev" href="#carouselExampleIndicators" role="button" data-slide="prev">
        <span class="carousel-control-prev-icon" aria-hidden="true"></span>
        <span class="sr-only">Previous</span>
    </a>
    <a class="carousel-control-next" href="#carouselExampleIndicators" role="button" data-slide="next">
        <span class="carousel-control-next-icon" aria-hidden="true"></span>
        <span class="sr-only">Next</span>
    </a>
</div>


<div class="row">
    <div class="col-md-6">
        <h2>Courses</h2>
        <p>List of courses offerred.</p>
        <p>@Html.ActionLink("Courses", "Index", "Courses")</p>
    </div>
    <div class="col-md-6">
        <h2>Students</h2>
        <p>List of students enrolled.</p>
        <p>@Html.ActionLink("Students", "Index", "Students")</p>
    </div>
</div>
