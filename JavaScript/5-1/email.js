
    //  const email = document.forms.login.email.value;
    // const email = document.forms['login']['email'].value;
    // const pswd = document.forms.login.password.value; // take name of the password
    // console.log(email, pswd);

    // password vbalidate
    function handleClick(e)

{

    e.preventDefault();

    console.log(e);

    // const email = document.forms['login']['email'].value;

    const email = document.forms.login.email;

    const passWord = document.forms['login']['password'];

    const age = document.forms['login']['age'];



    console.log(email, passWord);

    const emailValue = email.value;

    const passWordValue = passWord.value;



    if(passWordValue.length < 6){

        passWord.style.border = '1px solid red';

        passWord.nextElementSibling.classList.remove('d-none');

        passWord.nextElementSibling.innerHtml += `<li>

        password contain spaces

        </li>` ;

    }



    if(emailValue.length < 6){

        email.style.border = '1px solid red';

        email.nextElementSibling.classList.remove('d-none');

    }



    if(passWordValue.includes(' ')){

        passWord.style.border = '1px solid red';

        passWord.nextElementSibling.classList.remove('d-none');

        passWord.nextElementSibling.innerHtml +=

        `<li>

        password contain spaces

        </li>` ;

    }



    if( age.value < 15 || age.value > 100){

        age.style.border = '1px solid red';

        age.nextElementSibling.classList.remove('d-none');

    }

}
    // email validate
    // if(emailValue.length<5){
    //     // alert("Enter a valid email ");
    //     // email.style.border ='1px solid yellow';
    //     email.nextElementSibling.classList.remove('d-none');
    // }

    //Age Validate ()
    // if(ageValue <18 ){
    //     user_age.nextElementSibling.classList.remove('d-none');  //display:none
    //     // passwordErrorDisplay.innerHTML += '<li>include a valid age<li>';
    // }


