$("#submit").click(function(){
    //get all the values of the form
    var email = $("#wf_email").val();
    var officeLocation = $("#wf_office_location").val();
    var officePhone = $("#wf_office_phone").val();
    var name = $("#wf_name").val();
    var hobbies = $("#wf_hobbies").val();
    var classes = $("#wf_classes").val();
    var attest = $("#wf_attestation").is(":checked");
    //only exicute if the user has agreed to the attestation
    if(attest){
        //create a JSON
        var data = {
            "wf_email": email,
            "wf_office_location": officeLocation,
            "wf_office_phone": officePhone,
            "wf_name": name,
            "wf_hobbies": hobbies,
            "wf_classes": classes,
            "wf_attestation": attest,
        };

        console.log(data);

        //ajax call to send the data to the server
        //uncomment when ready to send data to server
        // $.ajax({
        //     type: "POST",
        //     url: "",
        //     data: data,
        //     success: function(response){
        //         console.log(response);
        //     },
        //     error: function(response){
        //         console.log(response);
        //     }
        // });
    }
});
