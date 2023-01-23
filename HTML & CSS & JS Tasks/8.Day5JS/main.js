var firstNumber = 0, secondNumber = 0, operator, result, textUser = 0, counter = 0

var Matharr = []
function DisplayNumber ( _val )
{
    textUser = document.getElementById( "Answer" ).value
    if ( textUser === '0' )
        textUser = ""
    textUser += _val
    document.getElementById( "Answer" ).value = textUser


}
function EnterNumber ( _value )
{
    DisplayNumber( _value )

}

function EnterOperator ( _value )
{
    DisplayNumber( _value )

    operator = _value
}
function EnterEqual ()
{

    if ( !operator == "" )
    {
        let resultSplitted = textUser.split( operator )

        DisplayNumber( '=' )
        firstNumber = parseFloat( resultSplitted[ 0 ] )
        // operator = resultSplitted = 1
        secondNumber = parseFloat( resultSplitted[ 1 ] )
        switch ( operator )
        {
            case '+':
                result = firstNumber + secondNumber;
                DisplayNumber( result )
                break;

            case '-':
                result = firstNumber - secondNumber;
                DisplayNumber( result )
                break;

            case '*':
                result = firstNumber * secondNumber;
                DisplayNumber( result )
                break;

            case '/':
                result = firstNumber / secondNumber;
                DisplayNumber( result )
                break;

            default:

                break;




        }
    }
}
function EnterClear ()
{
    document.getElementById( "Answer" ).value = ""

}

var i = 0;
var imagesInterval;

function startSlider ( element )
{
    imagesInterval = setInterval( function ()
    {
        i++;
        element.src = "images/" + i + ".jpg"
        if ( i == 6 )
        {

            i = 0
        }

    }, 2000 )
}

function StopSlider ()
{
    clearInterval( imagesInterval )
}

function GetNext ( element )
{
    if ( i < 6 )
    {
        i += 1
        element.src = "images/" + i + ".jpg"
    }

}
function GetPrevious ( element )
{
    if ( i > 1 )
    {
        i -= 1
        element.src = "images/" + i + ".jpg"
    }

}

function ValidateNumber ( _event )
{

    var keyCode = _event.keyCode // backspace =8 delete= 46 . =110
    const codes = [ 96, 97, 98, 99, 100, 101, 102, 103, 104, 105, 110, 8, 46 ]
    if ( !codes.includes( keyCode ) )
    {
        _event.preventDefault();
        return false;
    }
    return true;
}

// function SaveStudentData ()
// {
//     let table = document.getElementById( "stdtable" )
//     var row = table.insertRow( table.rows.length )

//     var data1 = row.insertCell( 0 )
//     var data2 = row.insertCell( 1 )
//     var data3 = row.insertCell( 2 )
//     data1.innerHTML = document.getElementsByTagName( "input" )[ 0 ].value
//     data2.innerHTML = document.getElementsByTagName( "input" )[ 1 ].value
//     data3.innerHTML = document.getElementsByTagName( "input" )[ 2 ].value
//     table.appendChild( row )

// }

function ChangeStyle ( element, color )
{
    element.style.backgroundColor = color
    // element.setSelectionRange( 0, this.value.length )
}

function ValidateName ( element )
{
    var regex = /^[a-z]{3,10}( )[a-z]{3,10}$/i
    var msg = document.getElementsByTagName( "span" )[ 0 ]
    if ( !regex.test( element.value ) )
    {
        msg.innerHTML = "Invalid Name"
        msg.style.fontSize = '11px'
        msg.style.color = 'red'
        element.focus()
        element.style.backgroundColor = 'gray'
    }
    else
        msg.innerHTML = ""
}

function ValidatePassword ( element )
{
    var pass = document.getElementById( "password" )
    var msg = document.getElementsByTagName( "span" )[ 1 ]
    if ( element.value !== pass.value )
    {
        msg.innerHTML = "password and repeat password should be the same"
        msg.style.fontSize = '11px'
        msg.style.color = 'red'
        element.focus()
        element.style.backgroundColor = 'gray'
    }
    else
        msg.innerHTML = ""
}


