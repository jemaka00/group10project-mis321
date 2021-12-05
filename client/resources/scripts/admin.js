/*!
* Start Bootstrap - Simple Sidebar v6.0.3 (https://startbootstrap.com/template/simple-sidebar)
* Copyright 2013-2021 Start Bootstrap
* Licensed under MIT (https://github.com/StartBootstrap/startbootstrap-simple-sidebar/blob/master/LICENSE)
*/
// 
// Scripts
// 

window.addEventListener('DOMContentLoaded', event => {

    // Toggle the side navigation
    const sidebarToggle = document.body.querySelector('#sidebarToggle');
    if (sidebarToggle) {
        // Uncomment Below to persist sidebar toggle between refreshes
        // if (localStorage.getItem('sb|sidebar-toggle') === 'true') {
        //     document.body.classList.toggle('sb-sidenav-toggled');
        // }
        sidebarToggle.addEventListener('click', event => {
            event.preventDefault();
            document.body.classList.toggle('sb-sidenav-toggled');
            localStorage.setItem('sb|sidebar-toggle', document.body.classList.contains('sb-sidenav-toggled'));
        });
    }

});

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
    let html = 
    json.forEach((plants)=>{
        
    });
    document.getElementById("plants").innerHTML = html;
}

addPlant = function(){
    const plantsApiUrl = "https://gardening-group10-database.herokuapp.com/api/plants";
    const plantName = document.getElementById("plantName").value;
    const plantType = document.getElementById("plantType").value;
    const seasonality = document.getElementById("seasonality").value;
    const difficultyLevel = document.getElementById("difficultyLevel").value;
    const amountOfWater = document.getElementById("amountOfWater").value;
    const amountOfSun = document.getElementById("amountOfSun").value;
    const animalAttraction = document.getElementById("animalAttraction").value;
    const plantImage = document.getElementById("plantImage").value;

    fetch(plantsApiUrl, {
        method: "POST",
        headers: {
            "Accept": 'application/json',
            "Content-Type": 'application/json',
        },
        body: JSON.stringify({
            plantName : plantName,
            plantType : plantType,
            seasonality : seasonality,
            difficultyLevel : difficultyLevel,
            amountOfWater : amountOfWater,
            amountOfSun :amountOfSun,
            animalAttraction : animalAttraction,
            plantImage : plantImage
        })
    })
    .then((response)=>{
        console.log(response);
        getPlant();
    })
}

function removePlant(plantID){
    const deletePlantApiUrl = "https://gardening-group10-database.herokuapp.com/api/plants/"+plantID;

    fetch(deletePlantApiUrl, {
        method: "DELETE",
        headers: {
            "Accept": 'application/json',
            "Content-Type": 'application/json',
        },
    })
    .then((response)=>{
        console.log(response);
        getPlant();
    })
}