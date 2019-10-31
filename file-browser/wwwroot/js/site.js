// Please see documentation at https://docs.microsoft.com/aspnet/core/client-side/bundling-and-minification
// for details on configuring this project to bundle and minify static web assets.

// Write your Javascript code.

/* Brian JS for circles
-------------------------------------------------- */

document.querySelector('.menu-button').onclick = function(e) {
    e.preventDefault(); document.querySelector('.circle').classList.toggle('open');
 }


 var items = document.querySelectorAll('.circle a');

for(var i = 0, l = items.length; i < l; i++) {
  //LEFT AND TOP BIGGER NUMBER AFTER -/+ MOVES OUT
  if (items.length <= 6) {
    items[i].style.left = (50 - 50*Math.cos(-0.5 * Math.PI - 2*(1/l)*i*Math.PI)).toFixed(4) + "%";
    items[i].style.top = (50 + 35*Math.sin(-0.5 * Math.PI - 2*(1/l)*i*Math.PI)).toFixed(4) + "%";
  } else {
    items[i].style.left = (50 - 60*Math.cos(-0.5 * Math.PI - 2*(1/l)*i*Math.PI)).toFixed(4) + "%";
    items[i].style.top = (50 + 55*Math.sin(-0.5 * Math.PI - 2*(1/l)*i*Math.PI)).toFixed(4) + "%";
  }
}
