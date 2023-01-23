// to hold an item in html page
document.querySelector( "h1" ).style.color = "blue";
// to show alert when page load 
// window.alert("Welcome in JS");
// to write in html page 
document.write( "<h1>First App in JS</h1>" );
// to print something in console screen
console.log( "hello" );
console.log( 100 + 200 );
console.log( typeof ( 10.50 + 20.30 ) );
// create variables with var / let /const
let aa = "hello in js",
    bb = "and how to write code in js",
    cc = "thanks for you and ";
console.log( `${ aa } ${ bb } ${ cc }` );
console.log( `${ aa } ${ bb } \\ ${ 100 * 50 }
 ${ cc }` ); // \n new line 

let title = "JAva Script"

let markup =
    `
 <div clas="parent">
    <div class="child">
        <b><hr></b>
        <h1>Hello in ${ title }</h1>
        <p> write html code in js </p>

    </div>


 </div>
 `;
document.write( markup );

let a = 10;
let b = "20";
let c = 80;
console.log( ++a );
console.log( +b++ );
console.log( + +b++ + +c++ - +a++ );
console.log( +a++ );
/*array.forEach(element => {
    a++;
    console.log(a);
});*/


/* variles */

var name = "Adel";
let name1 = "Hello Adel in web";
console.log( Number.MAX_SAFE_INTEGER );
console.log( Number.MAX_VALUE );
console.log( ( 100 ).toString() );
console.log( ( 100.1025 ).toString() );
console.log( ( 100.1025 ).toFixed( 2 ) );
console.log( Math.round( 99.2 ) ); // 99
console.log( Math.round( 99.5 ) ); // 100
console.log( Math.ceil( 99.2 ) ); // 100 اعلي حاجه سقف
console.log( Math.floor( 99.2 ) ); // 99 ارضية

console.log( name1.trim() ); // تحذف كل المسافات 
console.log( name1.indexOf( "adel" ) ); // 6  من index بتعمل بحث مكان الكلمه دي موجود
console.log( name1.lastIndexOf( "adel" ) ); // 6 بتعمل بحث هل الكلمه دي موجود
console.log( name1.slice( 2, 7 ) ); // llo A  Not Enclude last index
console.log( name1.slice( -5, -3 ) ); // يقص من الخلف n w
console.log( name1.split() ); // بيقص الكلمه ل نصفين بيخلي كله array  ["Hello Adel in web"]
console.log( name1.split( "" ) ); // بيقص الكلمه ل نصفين بيخلي كل حرف علي حده  ["H","e","l","l","o"," ","A","d","e","l"," ","i","n"," ","w","e","b"]
console.log( name1.split( " " ) ); // بيقص الكلمه ل نصفين بيخلي كل حرف علي حده  ["Hello", "Adel", "in", "web"]
console.log( name1.repeat( 5 ) ); // للعنصر  تكرار

// default value if null or empty using ||
console.log( `Hello ${ name1 || EmptyValue }` );

let va = 10;
va > 10
    ? console.log( 10 ) : va >= 10 && va <= 40
        ? console.log( "10 to 40" ) :
        va > 40
            ? console.log( "> 40" ) :
            console.log( "Unknown" );

let friends = [ "ahmed,adel,omar,nour,ahmed" ];
let newfriends = [ "ahmemnd,2adel,o1mar,2nour,2ahmed" ];
console.log( friends.indexOf( "ahmed" ) ); // بحث عن الكلمه بيشوف اول كلمه تقابله يشوف index بتاعها(0)
console.log( friends.lastIndexOf( "ahmed" ) ); // بحث عن الكلمه بيشوف من الاخر كلمه تقابله يشوف index بتاعها(4)
console.log( friends.indexOf( "ahmed", 2 ) ); // بحث عن الكلمه بيشوف ابدا من رقم 2 كلمه تقابله يشوف index بتاعها(4)

if ( friends.includes( "ahmed" ) === -1 )
    console.log( "Not Found" );

console.log( friends.sort() );
console.log( friends.reverse() );
console.log( friends.sort().reverse() );

console.log( friends.slice() );
console.log( friends.slice( 1, 3 ) );
console.log( friends.slice( -3 ) );

let allfriends = friends.concat( newfriends );
console.log( allfriends );
console.log( allfriends.join( "@" ) );
console.log( allfriends.join( " | " ).toUpperCase() );


mainloop: for ( let i = 0; i < allfriends.length; i++ )
{
    if ( typeof ( allfriends[ i ] === "number" ) )
        continue mainloop;
    console.log( "#".repeat( 15 ) );
    console.log( `#. ${ allfriends[ i ] }` );
    console.log( "#".repeat( 15 ) );


}

mainloop: for ( let i = 0; i < allfriends.length; i++ )
{
    nestedloop: for ( let j = 0; j < 5; j++ )
    {
        if ( typeof ( allfriends[ i ] === "number" ) )
            continue nestedloop; //identifier label 
    }

    console.log( "#".repeat( 15 ) );
    console.log( `#. ${ allfriends[ i ] }` );
    console.log( "#".repeat( 15 ) );


}

for ( let i = 0; i < allfriends.length; i++ )
{
    document.write( `<div>` );

    document.write( `<h1>[${ i + 1 }] ${ allfriends[ i ] } ${ allfriends.join( "|" ) } </h1>` );
    document.write( `</div>` );
}


function sayhello ()
{
    console.log( `hello adel` );
}

sayhello();
function sayhi ( username )
{
    console.log( `hello ${ username }` );
}

sayhi( "ali" );


let vararray = []
let newarray = []
for ( var i = 0; i < 5; i++ )
{
    // To Receive the data from user by prompot
    vararray[ i ] = prompt( "Enter your Number of :" + parseInt( i + 1 ) )
    // To Push data into array
    newarray.push( vararray[ i ] + vararray[ i ] ); // to sum each item 
}

console.log( vararray )
console.log( newarray )

// ممكن اعمل نفس عملية الجمع بواسطة map (Function (element, index , array) {})

newarray = vararray.map( function ( element, index, array ) { return element + element }, 5 );

// Or another way arrow function =>

newarray = vararray.map( ( element ) => element + element );

// or create function then assign to mapping
function addetion ( element ) { return element + element }
newarray = vararray.map( addetion )

console.log( newarray )

// Sorting Asc & Desc
function SortingArray ()
{

    var MathArr = []

    var AcsArr = new Array()
    var DescArr = new Array()
    for ( var i = 0; i < 5; i++ )
    {
        var num = parseInt( prompt( "Enter The Number of : " + parseInt( i + 1 ) ) );
        MathArr.push( num );

    }
    document.write( `The Original = ${ MathArr } ` + "<br/>" )
    DescArr = MathArr.sort( function ( a, b )
    {
        return b - a
    }
    );
    document.write( `The Sorted Descending = ${ DescArr } ` + "<br/>" )
    AcsArr = MathArr.sort( function ( a, b )
    {
        return a - b
    }
    );
    document.write( `The Sorted Ascending = ${ AcsArr } ` + "<br/>" )
}

SortingArray()

// check char capital or small and convert it otherwise capital=> small & small => capital
let Uname = "AdeL huSSeiN"
// let swapping = Uname
//     .split( "" )
//     .map( function ( element )
//     {
//         // ternary condition ? True : False
//         return element === Uname.toUpperCase() ? Uname.toLowerCase() : Uname.toUpperCase()
//     } )
//     .join( "" );

let swapping = Uname
    .split( "" )
    .map( ( element ) =>
        // ternary condition ? True : False
        element === Uname.toUpperCase() ? Uname.toLowerCase() : Uname.toUpperCase()
    )
    .join( "" );

console.log( `After Swapping ${ swapping }` );

// Inverted number from - to + or + to -
let num = [ 1, 2, -10, -20, 30, -5 ]
let inverted = num
    .map( function ( element )
    {
        return -element
    } )
    .join( "," )

console.log( `After Inverting ${ inverted }` );

// check is char or num 
let agv = "Adel24 1h55ussein"
let res = agv
    .split( "" )
    .map( function ( element )
    {
        return isNaN( parseInt( element ) ) ? element : ""
    } )
    .join( "," )
// arrow function short hand 
let resArrow = agv
    .split( "" )
    .map( ( element ) => ( isNaN( parseInt( element ) ) ? element : "" ) )
    .join( "" )

console.log( `After Removing Numbers ${ res }` );

// display all names start with A
let d = [ "ahmed", "mona", "ali", "amgad", "mohamed" ]

let aba = d.filter( ( element ) => element
    .startsWith( "a" ) ? true : false )
console.log( `All Names "A" :  ${ aba }` );

// display even number
let dd = [ 2, 5, 8, 9, 6, 15, 12 ]
let ab1a = dd
    .filter( ( element ) => element % 2 === 0 )
console.log( `Even Numbers is  :  ${ ab1a }` );

// display words lower than 4 char
let dhd = [ "i love foode code like c# html" ]
let a1a = dhd
    .splite( " " )
    .filter( ( element ) => element <= 4 )
    .join( " " )
console.log( `Result of words lower than 4 is  :  ${ a1a }` );

// filter vs map فلتر مشش محتاج true or false
// map لازم تكتب الشرط كامل true or false

// retrive chars and multiply numbers
let gh = "hgjn3kmn2kk3"

let resArr = gh
    .split( "" )
    .map( ( element ) => ( isNaN( parseInt( element ) ) ? element : element * element ) )
    .join( " " )

console.log( `After Removing Numbers ${ resArr }` );

// adding the array items reduce

let g1h = [ 5, 10, 20, 45, 30 ]


let addarray = g1h
    .reduce( ( acc, current, index, array ) => ( element + element ), 3 )// initial value 3+5=8 + 10
s

console.log( `Aftr adding the array ${ addarray }` );

// object Propert Values in one variables . Dot notation لو عاوز اضيف اضيف او اعدل او اطبع VS  name[""] Bracket notation وبردك لو اضيف حاجه او اعدل 
// الفرق بينهم ان اقدر اطبع القيمه عن طريق brackets علي عكس dot notation
let myage = "Age"
let Student =
{
    thename: "Adel",
    "Countery of": "Egypt",
    Age: 25,
    hoppies: [ "Reading", "drawing" ],
    // return function into object
    display: function ()
    {
        return { name: Student.name1, Age: this.Age }
    }
}

// add new item to object student
Student.Degree = 95   // or Student["Degree"]=95
//Edit value on existing 
Student.Age = 28
// delete key item from object
delete Student.Age // or delete Student["Age"]

// how to loop in object using  (  for in && for of )

// for in (index) in array but  within object send key not index 
for ( var k in Student )
{
    console.log( k, +": " + Student[ k ] );
}
// for of (Value) within print value 
for ( var k of Student )
{
    console.log( k );
}

// display return function from object
console.log( "Your name is : " + Student.display().name + Student.Age );
// display body of function
Student.display

console.log( Student.thename );
console.log( Student[ "Countery of" ] );
console.log( Student.Age ); // Dot notation or bracket notation
console.log( Student[ myage ] ); // bracket notation

// Calling html content from js

let AllLis = document.querySelectorAll( "ul li" )
let AllLDiv = document.querySelectorAll( ".content div" )

AllLis.forEach( function ( ele )
{
    ele.onclick = function ()
    {
        // remove active class from all elements
        AllLis.forEach( function ( ele )
        {
            ele.classList.remove( "active" )
        } );
        // Add Class active to all element
        this.classList.add( "active" )

        // hide all div  when on click display none
        AllLDiv.forEach( function ( ele )
        {
            ele.style.display = "none";
        } );

    };

} );

// date month start 0 > 11 



