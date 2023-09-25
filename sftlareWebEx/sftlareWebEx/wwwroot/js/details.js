<script src="https://code.jquery.com/jquery-3.6.0.min.js"></script>

    $(document).ready(function () {
        var backgroundImage = new Image();
        backgroundImage.src = $("body").css("background-image").replace(/url\(["']?/, "").replace(/["']?\)/, ""); 

        backgroundImage.onload = function () {
            $("#page-loader").fadeOut("slow");
        };

        setTimeout(function () {
            $("#page-loader").fadeOut("slow");
        }, 10000);
    });





$(document).ready(function() {
    var reservedSeatsRaw = @Json.Serialize(reservedSeats); 
    var reservedSeatsDebug = [].concat(...reservedSeatsRaw.map(seat => seat.split(','))).map(s => s.trim()); 

    console.log("Reserved Seats (Processed):", reservedSeatsDebug);
        
    $(".seat").each(function() {
        var seatIdDebug = $(this).attr("data-seat-id");
        console.log("Checking seat:", seatIdDebug);
        if (reservedSeatsDebug.includes(seatIdDebug)) {
            console.log(seatIdDebug + " should be booked!");
            $(this).addClass('booked');
            $(this).append('<span class="booked-label">booked</span>'); 
            } else {
            console.log(seatIdDebug + " is not in the reserved list.");
        }
    });
});




$(document).ready(function () {
    $('#addToCartButton').click(function (event) {
        var selectedSeats = getSelectedSeats(); 
        if (!selectedSeats) {
            event.preventDefault(); 
            alert("Lütfen bir koltuk seçiniz.");
                location.reload();
            } else {
            window.location.href = '/Orders/AddItemToShoppingCart?id=@Model.Id&selectedSeats=' + selectedSeats; 
        }
    });
});



    $(document).ready(function () {
        $(".seat").click(function () {
            if (!$(this).hasClass("booked")) {
                if ($(this).hasClass("selected")) {
                    $(this).removeClass("selected");
                } else {
                    $(this).addClass("selected");
                }
                updateSelectedSeatsDisplay();
            }
        });
    });


    function getSelectedSeats() {
        var selectedSeatIds = [];
        $(".seat.selected").each(function () {
            selectedSeatIds.push($(this).attr("data-seat-id"));
        });
        return selectedSeatIds.join(", ");
    }

    function updateSelectedSeatsDisplay() {
        var selectedSeatsList = getSelectedSeats();
        $("#selected-seats").text(selectedSeatsList);
        console.log("Selected Seats: ", selectedSeatsList);
    }

