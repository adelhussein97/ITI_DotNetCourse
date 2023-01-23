function PlayVideo ()
{
    var element = document.getElementsByTagName( "video" )[ 0 ]
    if ( element.paused )
        element.play()
    else
        element.pause()
}

function AudioPlay ()
{
    var contact = document.getElementById( "contact_audio" )
    if ( contact.paused )
        contact.play()
    else
        contact.pause()
}