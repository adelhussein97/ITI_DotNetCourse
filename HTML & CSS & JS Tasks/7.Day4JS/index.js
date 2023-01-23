var newwindow

function OpenWindow ()
{
    // Open window after 3 minutes 
    newwindow = open( "message.html", "_blank", "width=500,height=300,screenx=200,screeny=250" )

}
var counter = 0
function ShowMessage ()
{
    // Open window after 3 minutes 
    var message = 'Lorem ipsum dolor sit amet consectetur adipisicing elit. Accusantium dolore officia vitae, optio architecto dignissimos iusto aliquam ad nisi nihil'
    if ( counter < message.length )
    {
        document.getElementById( "msg" ).innerHTML += message.charAt( counter );
        counter++;
        setTimeout( ShowMessage, 60 )

    }
    if ( counter == message.length - 1 )
        this.close()

}

function ChangeFont ( element )
{
    document.getElementById( "PAR" ).style.fontFamily = element
}
function ChangeAlign ( element )
{
    document.getElementById( "PAR" ).style.textAlign = element
}
function ChangeHeight ( element )
{
    document.getElementById( "PAR" ).style.lineHeight = element
}
function ChangeLSpace ( element )
{
    document.getElementById( "PAR" ).style.letterSpacing = element
}
function ChangeIndent ( element )
{
    document.getElementById( "PAR" ).style.textIndent = element
}
function ChangeTransform ( element )
{
    document.getElementById( "PAR" ).style.textTransform = element
}
function ChangeDecorate ( element )
{
    document.getElementById( "PAR" ).style.textDecoration = element
}
function ChangeBorder ( element )
{
    document.getElementById( "PAR" ).style.border = element
}
function ChangeBorderColor ( element )
{
    document.getElementById( "PAR" ).style.borderColor = element
}

function ShowGallary ()
{
    document.getElementsByClassName( "gallary" )[ 0 ].style.display = "block"
}


function ReduceOpacity ( obj )
{
    var degree = 1
    var res = setInterval( function ()
    {
        if ( degree > 0.3 )
        {
            obj.style.opacity = degree
            degree -= 0.1

        }
        else
            clearInterval( res )
    }, 250 );

}

function ResetOpacity ( obj )
{
    var prvDegree = 0.3
    var res = setInterval( function ()
    {
        if ( prvDegree < 1 )
        {
            obj.style.opacity = prvDegree
            prvDegree += 0.1

        }

        else
            clearInterval( res )
    }, 250 );

}
