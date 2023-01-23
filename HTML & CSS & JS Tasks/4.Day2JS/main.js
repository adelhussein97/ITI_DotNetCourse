function CheckEmail ()
{

    var email = prompt( "Enter Your Email" );
    var emailArr = email.split( "" ).join();
    if ( emailArr.charAt( 0 ) == "@" )
        alert( "Your email not correct and not start @ Try Again" );
    else if ( emailArr.charAt( emailArr.length - 1 ) == "@" )
        alert( "Your email not correct and not End @ Try Again" );

    else if ( emailArr.includes( "@" ) != true )
        alert( "Your email Must have @email Try Again" );
    else alert( "Your Email Registerd Successfully" );
}

function CounterChar ()
{

    var Word = prompt( "Enter Your Word" );
    var char = prompt( "Enter Your Char To Count" );
    var WordArr = Word.split( "" ).join();
    var Counter = 0;
    for ( var i = 0; i < WordArr.length; i++ )
    {
        if ( WordArr.charAt( i ) === char )
            Counter++

    }
    document.write( `Char Count ( ${ char } , ${ Word }  ) = ${ Counter }` )
}

function MathOperations ()
{

    var MathArr = []
    var Add = 0;
    var Multiply = 1;
    var Division = 1;
    for ( var i = 0; i < 3; i++ )
    {
        var num = parseInt( prompt( "Enter The Number of : " + parseInt( i + 1 ) ) );
        MathArr.push( num );
        Add += MathArr[ i ];
        Multiply *= MathArr[ i ];
        Division /= MathArr[ i ];
    }

    document.write( `Sum of 3 Numers = ${ MathArr.join( "+" ) } = ${ Add } ` + "<br/>" )
    document.write( `Multiply of 3 Numers = ${ MathArr.join( "*" ) } = ${ Multiply } ` + "<br/>" )
    document.write( `Divison of 3 Numers = ${ MathArr.join( "/" ) } ` + "<br/>" )
}

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

function AreaCircle ()
{

    var num = parseInt( prompt( "Enter The Radius of Circle : " ) );
    alert( `The Area of Circle = ${ Math.PI * Math.pow( num, 2 ) }` )

}

function SuareRoot ()
{
    var num = parseInt( prompt( "Enter The Square Root : " ) );
    alert( `The Square Root = ${ Math.sqrt( num ) }` )

}

function Cos ()
{
    var num = parseInt( prompt( "Enter The Cos Number : " ) );
    alert( `The cos of ${ num } = ${ Math.cos( num ) }` )

}
