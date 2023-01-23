function GetDate ()
{
    var d = new Date();
    document.write( `Local Date Formate : ${ d.toLocaleDateString() }` )
}
var newwindow;

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
    var regex = /^\d*[02468]*$/
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
    var regexName = /^[a-z]$/i
    var regexPhone = /^[0-9]{8}$/
    var regexMobile = /^(01)(0|1|2|5)[0-9]{8}$/
    var regexEmail = /^[a-zA-Z]{4,20}[0-9]*[$_.]@(gmail|yahoo|outlook).com)$/g

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
        var name1 = prompt( "Enter your Phone Number" )
        if ( regexPhone.test( name1 ) == false )
            alert( "Your Phone Should be Number , length 8" )

    } while ( regexPhone.test( name1 ) == false )
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



}



