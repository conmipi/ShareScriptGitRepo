let toggleNavStatus = false;

// Open and close nav
let toggleNav = function () {
	let getSidebar = document.querySelector(".nav-sidebar");
	let getSidebarUl = document.querySelector(".nav-sidebar ul");
	let getSidebarTitle = document.querySelector(".nav-sidebar span");
	let getSidebarLink = document.querySelectorAll(".nav-sidebar a");
	let getBurgerButton = document.getElementById("burger-btn");
	let getContentPage = document.getElementById("content_span");


	// Check if sidebar is closed
	if (toggleNavStatus === false) {
		getSidebarUl.style.visibility = "visible";
		//getBurgerButton.style.visibility = "hidden";
		getBurgerButton.style.display = "none";
		getSidebar.style.width = "200px";
		//getSidebarTitle.style.opacity = "0.5";
		getSidebarTitle.style.display = getSidebarLink[0].style.display;

		let arrayLength = getSidebarLink.length;
		for (let i = 0; i < arrayLength; i++) {
			getSidebarLink[i].style.opacity = "1";
		}
		getContentPage.addEventListener("click", toggleNav, false);
		toggleNavStatus = true;

	}

	// Check if sidebar is open
	else if (toggleNavStatus === true) {
		getSidebar.style.width = "50px";
		//getSidebarTitle.style.opacity = "0";
		//getSidebarTitle.style.visibility = "hidden";
		getSidebarTitle.style.display = "none";

		let arrayLength = getSidebarLink.length;
		for (let i = 0; i < arrayLength; i++) {
			getSidebarLink[i].style.opacity = "0";
		}
		getBurgerButton.style.display = "block";
		getSidebarUl.style.visibility = "hidden";
		getContentPage.removeEventListener("click", toggleNav, false);
		toggleNavStatus = false;

	}

}