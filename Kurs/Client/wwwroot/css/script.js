window.showSideNavAndModal = () => {
    var sideNav = document.getElementById('sidenav');
    var modal = document.getElementById('modal');
    sideNav.classList.add('show');
    modal.classList.add('showModal');
};

window.hideSideNavAndModal = () => {
    var sideNav = document.getElementById('sidenav');
    var modal = document.getElementById('modal');
    sideNav.classList.remove('show');
    modal.classList.remove('showModal');
};