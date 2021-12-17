// 1. Ways to print in JavaScript
// console.log("Hello World");
// alert("me");
// document.write("this is document write")

// 2. Javascript console API
// console.log("Hello World", 4 + 6, "Another log");
// console.warn("this is warning");
// console.error("This is an error");


//3. Variables
var number1 = 34;
var number2 = 56;
console.log(number1 + number2);


//4 data types in js
 //number
var num1 = 455;
var num2 = 56.98;

//string
var str1 = "this is a string";
var str2 = 'this is string';

//objects 
var marks = {
    Aman: 98,
    Satyam: 56,
    Nazish: 100
}


//Boolean
var a = true;
var b =  false;
console.log(a, b);

var und = undefined;
console.log(undefined);

var n = null;
console.log(n);

//Array
var a = [1, 2, 3, 4, 5];

//operatars in JS 
//arithmetic operator
var c = 10
var d = 13
console.log("the sum of c + d is ", c+d)
console.log("the sum of c + d is ", c-d)
console.log("the sum of c + d is ", c*d)
console.log("the sum of c + d is ", c/d)

//assignment operator
var e = d
//e+=2
//e-=2
//e*=2
//e/=2
console.log(e)

// comparison
var x = 23
var y = 100
//console.log(x==y)
//console.log(x<=y)
//console.log(x>=y)
//console.log(x<y)
//console.log(x>y)

//logical

//AND
console.log(true && true)
console.log(true && false)
console.log(false && false)
console.log(false && true)
//OR
console.log(true || true)
console.log(true || false)
console.log(false || false)
console.log(false || true)
//NOT
console.log(!true)
console.log(!false)

//function

function avg(a, b){
    return (a+b)/2
}

c1=avg(10,20)
c2=avg(20,50)
console.log(c1)
console.log(c2)



//conditionals in js
var age = 10
if(age<5){
    console.log("you are baby")
}
else{
    console.log('you are not baby')
}

//loops in js
//for loop
var a = [1, 3, 5, 6, 7]
for(var i=0; i<a.length; i++)
{
    console.log(a[i]);
}

//for each
a.forEach(function(element){
    console.log(element);
})

//while
let j=0
while(j<a.length)
{
    console.log(a[j])
    j++
}


//do while
let j1 = 0
do{
    console.log(a[j1])
    j1++
}while(j1<a.length)

//Array method
let mya = ['Aman', 'chaman', 35, null, true]
console.log(mya.length);
mya.pop()
console.log(mya)
mya.push('Aman')
console.log(mya)
mya.shift()
console.log(mya)
mya.unshift('AMan')
console.log(mya)
mya.toString()
console.log(mya)
mya.sort()
console.log(mya)


//String Method
let f='i am great'
console.log(f.length)
console.log(f.indexOf('i'))
console.log(f.lastIndexOf)
console.log(f.slice(1,3))
console.log(f.replace('great', 'aman'))

//date
let myDate = new Date();
// console.log(myDate.getTime());
// console.log(myDate.getFullYear());
// console.log(myDate.getDay());
// console.log(myDate.getMinutes());
// console.log(myDate.getHours());
 
//Dom manipulation
let ele = document.getElementById('click')
console.log(ele)
let elem = document.getElementsByClassName('container')
console.log(elem)
// elem[0].style.background = "yellow";
elem[0].classList.add("bg-primary")
elem[0].classList.add("text-success")
// console.log(elem.innerHTML);
// console.log(elem.innerText); 
// console.log(elemClass[0].innerHTML);
// console.log(elemClass[0].innerText); 
tn = document.getElementsByTagName('div')
// console.log(tn)
createdElement = document.createElement('p');
createdElement.innerText = "This is a created para";
tn[0].appendChild(createdElement);
createdElement2 = document.createElement('b');
createdElement2.innerText = "This is a created bold";
tn[0].replaceChild(createdElement2, createdElement);
// removeChild(element); ---> removes an element
 
// Selecting using Query
// sel = document.querySelector('.container')
// console.log(sel)
// sel = document.querySelectorAll('.container')
// console.log(sel)

// function clicked(){
//     console.log('The button was clicked')
// }
// window.onload = function(){
//     console.log('The document was loaded')

// }
// Events in JavaScript
// firstContainer.addEventListener('click', function(){
//     document.querySelectorAll('.container')[1].innerHTML = "<b> We have clicked</b>"
//     console.log("Clicked on Container")
// })

// firstContainer.addEventListener('mouseover', function(){
//     console.log("Mouse on Container")
// })

// firstContainer.addEventListener('mouseout', function(){
//     console.log("Mouse out of Container");
// })

// let prevHTML = document.querySelectorAll('.container')[1].innerHTML;
// firstContainer.addEventListener('mouseup', function(){
//     document.querySelectorAll('.container')[1].innerHTML = prevHTML;
//     console.log("Mouse up when clicked on Container");
// })

// firstContainer.addEventListener('mousedown', function(){
//     document.querySelectorAll('.container')[1].innerHTML = "<b> We have clicked</b>"
//     console.log("Mouse down when clicked on Container");
// })


// Arrow Functions
// function summ(a, b){
//     return a+b;
// }
summ = (a,b)=>{
    return a+b;
}

logKaro = ()=>{
    document.querySelectorAll('.container')[1].innerHTML = "<b> Set interval fired</b>"
    console.log("I am your log")
}
// SetTimeout and setinterval
// clr = setTimeout(logKaro, 5000);
// clr = setInterval(logKaro, 2000);
// use clearInterval(clr)/clearTimeout(clr) to cancel setInterval/setTimeout

// JavaScript localStorage
// localStorage.setItem('name', 'harry') 
// localStorage 
// localStorage.getItem('name')
// localStorage.removeItem('name')
// localStorage.clear();

// Json 
// obj = {name: "harry", length: 1, a: {this: 'tha"t'}}
// jso = JSON.stringify(obj);
// console.log(typeof jso)
// console.log(jso)
// parsed = JSON.parse(`{"name":"harry","length":1,"a":{"this":"that"}}`)
// console.log(parsed);

// Template literals - Backticks
a = 34;
console.log(`this is my ${a}`)
