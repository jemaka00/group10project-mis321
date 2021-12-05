/*!
* Start Bootstrap - New Age v6.0.5 (https://startbootstrap.com/theme/new-age)
* Copyright 2013-2021 Start Bootstrap
* Licensed under MIT (https://github.com/StartBootstrap/startbootstrap-new-age/blob/master/LICENSE)
*/
//
// Scripts
// 

window.addEventListener('DOMContentLoaded', event => {

    // Activate Bootstrap scrollspy on the main nav element
    const mainNav = document.body.querySelector('#mainNav');
    if (mainNav) {
        new bootstrap.ScrollSpy(document.body, {
            target: '#mainNav',
            offset: 74,
        });
    };

    // Collapse responsive navbar when toggler is visible
    const navbarToggler = document.body.querySelector('.navbar-toggler');
    const responsiveNavItems = [].slice.call(
        document.querySelectorAll('#navbarResponsive .nav-link')
    );
    responsiveNavItems.map(function (responsiveNavItem) {
        responsiveNavItem.addEventListener('click', () => {
            if (window.getComputedStyle(navbarToggler).display !== 'none') {
                navbarToggler.click();
            }
        });
    });

});

getPlant = function(){
    const plantsApiUrl = "https://localhost:5001/api/plants"

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