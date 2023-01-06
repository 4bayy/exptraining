function validate(e){
    e.preventDefault(); //remove refrersh of the web page

    const email =document.forms["login"]["email"];
    const emailValue =email.value;
    console.log(emailValue);
    
    const pswd =document.forms["login"]["password"]; /// form name >> nameee
    const pswdValue =pswd.value;
    console.log(pswdValue);
   
    //password validation 
    if(pswdValue.length <6){
        // console.log("enter number greater than 6 charector ");
        pswd.style.border ="1px solid red";
        pswd.nextElementSibling.classList.remove('d-none'); //The classList property returns the CSS 
        // classnames of an element.
    }
    //emaail validation 

    if (emailValue.includes (' ') ){
        email.style.border ="1px solid red";
        email.nextElementSibling.classList.remove('d-none');   
    }
    if(pswdValue.length > 6){
        console.log("good password")
        pswd.nextElementSibling.classList.add('d-none');
    }
}