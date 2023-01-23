function SumTwoNum ( num1, num2 )
{
    let n1 = parseInt( prompt( "Enter First Number " ) );
    let n2 = parseInt( prompt( "Enter Second Number " ) );
    let Sum = n1 + n2;
    console.log("The Result of Sum = "+ Sum);
}

function LessThan100 ( num1, num2 )
{
    let n1 = parseInt( prompt( "Enter First Number " ) );
    let n2 = parseInt( prompt( "Enter Second Number " ) );
    
    let Sum = n1 + n2;

    if(Sum < 100)
        console.log( "The Result of Sum is less than 100 = "+n1 + " + "+n2 +" = "+Sum+" / "+ true );
    else
        console.log( "The Result of Sum is Larger than 100 = "+n1 + " + "+n2 +" = "+Sum+" / "+ false );
}

function StringToInt ( num1 )
{
    let n1 = parseInt( prompt( "Enter Any String " ) );
    console.log("The Result of Int = "+ n1);
}

function PrintStars()
{
    
    for ( var i = 0; i <= 5; i++ )
    {
        var result = '';
        for ( var j = 0; j < i ; j++ )
        {
            result += '*';
            
        }
        console.log(result);
        console.log("\n");
        }
}

PrintStars();

function PrintAlphetString ( )
{
     let valustr = prompt( "Enter Any String to Sort it " );
     
    
    console.log(valustr.split("").sort().join(""));
    
}


