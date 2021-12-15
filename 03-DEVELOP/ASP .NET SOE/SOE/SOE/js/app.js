const btntoggle = document.querySelector(".sidebar__toggle");
btntoggle.addEventListener("click", function () {
    document.getElementById("sidebar").classList.toggle('sidebar--active');
});

const btntoggle2 = document.querySelector(".hac__toggle");
btntoggle2.addEventListener("click", function () {
    document.getElementById("hac").classList.toggle('hac--active');
});