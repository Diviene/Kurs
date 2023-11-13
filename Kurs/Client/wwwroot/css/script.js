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

function scrollIntoHeader(header) {
    document.getElementById('header').scrollIntoView();
}
function scrollIntoServices(services) {
    document.getElementById('services').scrollIntoView();
}
function scrollIntoRooms(rooms) {
    document.getElementById('rooms').scrollIntoView();
}
function scrollIntoCustomers(customers) {
    document.getElementById('customers').scrollIntoView();
}