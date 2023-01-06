
    console.log('clicked');
    const search = document.getElementById('myInput');
    const rows = document.querySelectorAll('tbody tr');
    // console.log(rows);
    console.log(search);

    search.addEventListener("keyup",function(event){
        // console.log(event);
        const q = event.target.value.toLowerCase(); //change user input to lower case q contain inpput value
    
        rows.forEach(row => {
            row.querySelector('td').textContent.toLowerCase().startsWith(q) ? 
             null :  row.style.display ='none';
        });
    })
    // filter = input.value.toUpperCase();

    //loop throuhgh the table row ,hide those match

