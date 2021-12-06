getFeedback = function(){
    const feedbackApiUrl = "https://gardening-group10-database.herokuapp.com/api/feedback"

    fetch(feedbackApiUrl).then(function(response){
        console.log(response);
        return response.json();
    }).then(function(json){
        console.log(json);
        displayFeedback(json);
    }).catch(function(error){
        console.log(error);
    });
}

function displayFeedback(json){
    let html = "<table style=\"width:100%\">";
    html += "<tr><th>Customer Email</th><th>Feedback</th><th>Delete</th>"
    json.forEach((feedback)=>{
        html += "<tr key= " + feedback.customerID + "><td>" + feedback.customerEmail + "</td><td>" + feedback.feedback
        "</td><td><button onclick = \"removeFeedback("+feedback.customerID+")\">Delete</button></td></tr>";
    });
    html += "</tr></table>";
    document.getElementById("feedback").innerHTML = html;
}

addFeedback = function(){
    const feedbackApiUrl = "https://gardening-group10-database.herokuapp.com/api/feedback";
    const customerName = document.getElementById("customerName").value;
    const customerEmail = document.getElementById("customerEmail").value;
    const phoneNumber = document.getElementById("phoneNumber").value;
    const feedback = document.getElementById("feedback").value;

    fetch(feedbackApiUrl, {
        method: "POST",
        headers: {
            "Accept": 'application/json',
            "Content-Type": 'application/json',
        },
        body: JSON.stringify({
            customerName : customerName,
            customerEmail : customerEmail,
            phoneNumber : phoneNumber,
            feedback : feedback
        })
    })
    .then((response)=>{
        console.log(response);
        getFeedback();
    })
}