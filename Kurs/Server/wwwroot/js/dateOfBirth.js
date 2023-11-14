//document.getElementById('yourFormId').addEventListener('submit', function (event) {
//    var dateOfBirth = new Date(document.getElementById('dateofbirth').value);
//    var age = new Date().getFullYear() - dateOfBirth.getFullYear();
//    var m = new Date().getMonth() - dateOfBirth.getMonth();
//    if (m < 0 || (m === 0 && new Date().getDate() < dateOfBirth.getDate())) {
//        age--;
//    }
//    if (age < 18) {
//        alert('You must be at least 18 years old.');
//        event.preventDefault();
//    }
//});