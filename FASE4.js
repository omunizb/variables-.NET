var leapYear = false;
var if_true = "I was born in a leap year.";
var if_false = "I was not born in a leap year.";

var name = "Oriol";
var firstSurname = "Muniz";
var secondSurname = "Baguena";

var day = 2;
var month = 4;
var year = 1997;

// Check if given year is a Gregorian calendar leap year
if ((year % 4 == 0 && year % 100 != 0) || year % 400 == 0) {
    leapYear = true;
}

console.log("My name is " + name + " " + firstSurname + " " + secondSurname);
console.log("I was born on " + day + " / " + month + " / " + year);

if (leapYear) {
    console.log(if_true);
}
else {
    console.log(if_false);
}