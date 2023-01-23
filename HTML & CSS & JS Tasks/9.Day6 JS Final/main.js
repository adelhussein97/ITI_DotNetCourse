function SaveData ()
{

    var userName = document.getElementById( "userName" )
    var password = document.getElementById( "password" )
    localStorage.setItem( "Username", userName.value )
    localStorage.setItem( "Password", password.value )
    alert( "Your Registeration Successfully" )
}

function GetData ()
{
    document.write( `<h2>Thank you for Registration : </h2> ${ localStorage.Username }` )
}
// Save Data if Checked Remmber me
function SaveDataWhenChecked ()
{
    var checkRemember = document.getElementById( "remember" )
    var userName = document.getElementById( "_userName" )
    var password = document.getElementById( "_password" )
    if ( checkRemember.checked == true )
    {
        localStorage.setItem( "Username", userName.value )
        localStorage.setItem( "Password", password.value )
        alert( "Your Registeration Successfully" )
    }

}
function GetDataFromApi ()
{
    var xhr = new XMLHttpRequest();
    xhr.open( 'GET', 'https://reqres.in/api/users/1' );
    xhr.send();

    xhr.addEventListener( "readystatechange", function ()
    {
        if ( xhr.readyState == 4 )
        {

            var users = JSON.parse( xhr.response )
            var users_data = users.data;
            var firstname = document.getElementById( "firstname" )
            var lastname = document.getElementById( "lastname" )
            var image = document.getElementById( "_image" )

            firstname.innerHTML = users_data.first_name
            lastname.innerHTML = users_data.last_name
            image.src = users_data.avatar


        }
    } );
}

function GetDataBasedonID ()
{
    var inp = document.getElementById( "search" )
    var xhr = new XMLHttpRequest();
    xhr.open( 'GET', 'https://reqres.in/api/users/' + inp.value );
    xhr.send();

    xhr.addEventListener( "readystatechange", function ()
    {
        if ( xhr.readyState == 4 )
        {

            var users = JSON.parse( xhr.response )
            var users_data = users.data;
            var firstname = document.getElementById( "firstname" )
            var lastname = document.getElementById( "lastname" )
            var image = document.getElementById( "_image" )

            firstname.innerHTML = users_data.first_name
            lastname.innerHTML = users_data.last_name
            image.src = users_data.avatar


        }
    } );
}

