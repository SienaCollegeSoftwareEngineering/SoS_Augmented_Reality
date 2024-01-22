$("#submit").click(function(){
    //get all the values of the form
    var email = $("#wf_email").val();
    var fname = $("#wf_fname").val();
    var lname = $("#wf_lname").val();
    var about = $("#wf_about").val();
    var attest = $("#wf_attestation").is(":checked");
    //only exicute if the user has agreed to the attestation
    if(attest){
        //create a JSON
        var data = {
            "wf_email": email,
            "wf_fname": fname,
            "wf_lname": lname,
            "wf_about": about,
            "wf_attestation": attest
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
