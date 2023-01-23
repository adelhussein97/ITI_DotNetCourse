var newwindow;

function GetDate ()
{
    var d = new Date();
    document.write( `Local Date Formate : ${ d.getDate() }` )
}


function OpenWindow ()
{
    // Open window after 3 minutes 
    var d = new Date()
    setTimeout( () =>
    {
        newwindow = open( "index2.html", "_blank", "width=300,height=300,screenx=200,screeny=250" )
    }, 3000 );

}

function CloseWindow ()
{
    newwindow.close()
}

function TestEvenNumber ()
{
    var num = parseInt( prompt( "Enter Number" ) )
    var regex = /^[0-9]*$/
    if ( regex.test( num ) === true )
    {
        if ( num % 2 == 0 )
            alert( `Your num : ${ num } = true` )
        else
            alert( `Your num : ${ num } = false` )
    }
    else
        alert( `Your Input = Invalid` )
}

function PersonalData ()
{
    var regexName = /^[a-z]/i
    var regexPhone = /^[0-9]{8}$/
    var regexMobile = /^(01)(0|1|2|5)[0-9]{8}$/

    var regexEmail = /^[a-zA-Z]{4,15}@(123)(.com)$/i
    var regexcolor = /^(Red|Green|Blue)/

    // Name Validations
    do
    {
        var name = prompt( "Enter your name" )
        if ( regexName.test( name ) == false )
            alert( "Your Name should be Character i,e Not Number" )

    } while ( regexName.test( name ) == false )
    // Phone Validation
    do
    {
        var Phone = prompt( "Enter your Phone Number" )
        if ( regexPhone.test( Phone ) == false )
            alert( "Your Phone Should be Number , length 8" )

    } while ( regexPhone.test( Phone ) == false )
    // Mobile Validation
    do
    {
        var mobile = prompt( "Enter your Mobile Number" )
        if ( regexMobile.test( mobile ) == false )
            alert( "Your Mobile Should be Number (010 | 011 | 012 |015) , length 11" )

    } while ( regexMobile.test( mobile ) == false )

    // Email Validation
    do
    {
        var email = prompt( "Enter your Email" )
        if ( regexEmail.test( email ) == false )
            alert( "Your Email should use Reg Expression , (abc@gmail.com)" )

    } while ( regexEmail.test( email ) == false )
    // Color Validation Red | Green | Blue
    do
    {
        var color = prompt( "Enter your Color Red | Green | Blue" )
        if ( regexcolor.test( color ) == false )
            alert( "Color should be Red | Green | Blue" )

    } while ( regexcolor.test( color ) == false )
    var date = new Date()
    document.write( `
            <p style="color:${ color }">Welcome dear Guest ${ name }<br/>
                    Your Telephone Num ${ Phone } <br/>
                    Your Mobile ${ mobile } </br>
                    Your Email is ${ email } <br/>
                    today is ${ date.getDay() } <br/>
                    we are in month ${ date.getMonth() } <br/>
                    and year ${ date.getFullYear() } <br/>
                    Today is ${ date.toDateString() }
            </p>
    ` )

}

function TestStudentObject ()
{
    var Student = [ { StdName: "Ali", Degree: 75 }
        , { StdName: "Ahmed", Degree: 50 }
        , { StdName: "Mohamed", Degree: 95 }
        , { StdName: "Omar", Degree: 45 }
        , { StdName: "Nour", Degree: 96 }
    ]

    let result = Student.find( ( element ) => element.Degree >= 90 )

    // Find return first element in the provided condition VS Filters
    document.write( `degree between 90 and 100 is  ${ "Name : " + result.StdName + " ,  Degree : " + result.Degree } <br/>` )


    let resultless = Student.filter( ( element ) => element.Degree < 60 )
    for ( var i in resultless )
    {
        document.write( `degree Less than 60 is  ${ "Name : " + resultless[ i ].StdName + " ,  Degree : " + resultless[ i ].Degree } <br/>` )
    }
    document.write( "*********************************************** <br/>" )  // Push new object
    Student.push( { StdName: "Mahmoud", Degree: 35 } )
    for ( var i in Student )
    {
        document.write( `Student Num ${ i }  ${ " Name : " + Student[ i ].StdName + " ,  Degree : " + Student[ i ].Degree } <br/>` )
    }
    document.write( "*********************************************** <br/>" )  // Pop Last item object
    Student.pop()

    for ( var k in Student )
    {
        document.write( `Student Num ${ ++k }  ${ " Name : " + Student[ k ].StdName + " ,  Degree : " + Student[ k ].Degree } <br/>` )
    }
}



