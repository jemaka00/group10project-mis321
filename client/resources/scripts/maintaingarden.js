getPlant = function(){
    const plantsApiUrl = "https://gardening-group10-database.herokuapp.com/api/plants"

    fetch(plantsApiUrl).then(function(response){
        console.log(response);
        return response.json();
    }).then(function(json){
        console.log(json);
        displayPlants(json);
    }).catch(function(error){
        console.log(error);
    });
}

function displayPlants(json){
    let html = "";
    json.forEach((plants)=>{
        html += "<div class = \"polaroid\">";
        html += "<img src = \"" + plants.plantImage + "\" width=\"100%\" height=\"250px\"></img>";
        html += "<p><b>Name: </b>" + plants.plantName + "&emsp;<b>Type: </b>" + plants.plantType + "</p>";
        html += "<p><b>Seasonality: </b>" + plants.seasonality + "&emsp;<b>Difficulty: </b>" + plants.difficultyLevel + "</p>";
        html += "<p><b>Water Level: </b>" + plants.amountOfWater + "</p>";
        html += "<p><b>Sun Level: </b>" + plants.amountOfSun + "</p>";
        html += "<p><b>Animal Attraction: </b>" + plants.animalAttraction + "</p>";
        html += "</div>";
    });
    document.getElementById("plants").innerHTML = html;
}

// function displayPlants(json){
//     let html = "<table style=\"width:100%\">";
//     html += "<tr><th> </th><th style=\"width:100%\"> </th><th style=\"width:100%\"> </th>"
//     json.forEach((plants)=>{
//         html += "<td><div class = \"container\">";
//         html += "<img src = \"" + plants.plantImage + "\" style=\"width:100%\"></img>";
//         html += "<div><p><b>Name : </b>" + plants.plantName + "</p>";
//         html += "<p><b>Type : </b>" + plants.plantType + "</p>";
//         html += "<p><b>Seasonality : </b>" + plants.seasonality + "</p>";
//         html += "</div></td>";
//     });
//     html += "</tr></table>";
//     document.getElementById("plants").innerHTML = html;
// }