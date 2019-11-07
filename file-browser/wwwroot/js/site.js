// Please see documentation at https://docs.microsoft.com/aspnet/core/client-side/bundling-and-minification
// for details on configuring this project to bundle and minify static web assets.

// Write your Javascript code.

/* Brian JS for circles
-------------------------------------------------- */

document.querySelector('.menu-button').onclick = function(e) {
    e.preventDefault(); document.querySelector('.circle').classList.toggle('open');
 }


  var items = document.querySelectorAll('.circle a');
  var angles = []

  function calculateAngles() {
    for (var i = 0; i < items.length; i++) {
      angles.push((i * (2*Math.PI)) / 8)
    }
  }

  calculateAngles();
  var absMin = - Math.PI/2;
  var absMax = angles[angles.length - 1];

  var dispPort = [absMin, absMin+2*Math.PI];
  var dispInd = [0,7];

  function scrollTest() {
    // console.log('Test');
    // console.log(dispPort)
    // console.log(dispInd)
    // console.log(angles);
    if(dispPort[1] < absMax) {
    dispPort[0] = dispPort[0]+2*Math.PI/20;
    dispPort[1] = dispPort[0]+2*Math.PI;
    }
    dispInd = [Math.round((dispPort[0]+Math.PI/2)/(2*Math.PI/8)),dispInd[0]+8];

    for(var i = 0, l = items.length; i < l; i++) {
      if(i < dispInd[0] || i > dispInd[1]) {
        //Do not display
        document.getElementById(i).style.display = "none";
      } else {
        //Display these items
        document.getElementById(i).style.display = "block";
        if(angles[i]-dispPort[0]>Math.PI/8) {
          document.getElementById(i).style.opacity = Math.abs((angles[i]-dispPort[0])/Math.PI/8)+.5;
        } else {
          document.getElementById(i).style.opacity = 1;
        }
        if(angles[i]-dispPort[1]>-Math.PI/8) {
          document.getElementById(i).style.opacity = 2*Math.abs((dispPort[1]-angles[i])/Math.PI/8)+.5;
        } else {
          document.getElementById(i).style.opacity = 1;
        }
      //LEFT AND TOP BIGGER NUMBER AFTER -/+ MOVES OUT
      if (items.length <= 8) {
        items[i].style.left = (50 - 50*Math.cos(-0.5 * Math.PI - 2*(1/l)*i*Math.PI)).toFixed(4) + "%";
        items[i].style.top = (50 + 35*Math.sin(-0.5 * Math.PI - 2*(1/l)*i*Math.PI)).toFixed(4) + "%";
      } else {
        items[i].style.left = (50 - 60*Math.cos(-(angles[i]-dispPort[0]) - 2*(1/8)*Math.PI)).toFixed(4) + "%";
        items[i].style.top = (50 + 55*Math.sin(-(angles[i]-dispPort[0]) - 2*(1/8)*Math.PI)).toFixed(4) + "%";
      }
    }
    }
  }

for(var i = 0, l = items.length; i < l; i++) {
  if(i < dispInd[0] || i > dispInd[1]) {
    document.getElementById(i).style.display = "none";
  } else {
  //LEFT AND TOP BIGGER NUMBER AFTER -/+ MOVES OUT
  if (items.length <= 8) {
    items[i].style.left = (50 - 50*Math.cos(-0.5 * Math.PI - 2*(1/l)*i*Math.PI)).toFixed(4) + "%";
    items[i].style.top = (50 + 35*Math.sin(-0.5 * Math.PI - 2*(1/l)*i*Math.PI)).toFixed(4) + "%";
  } else {
    items[i].style.left = (50 - 60*Math.cos(-0.5 * Math.PI - 2*(1/8)*i*Math.PI)).toFixed(4) + "%";
    items[i].style.top = (50 + 55*Math.sin(-0.5 * Math.PI - 2*(1/8)*i*Math.PI)).toFixed(4) + "%";
  }
}
}
