// Asynchronous JavaScript
// console.log("hi");

// ASYNCHRONUS

// function longRun(callback){
// setTimeout(() => {
//     const name = 'javascript';
//     callback(name);
// },5000);
// }
// function showresult(res){
// console.log(res);
// }
// longRun(showresult); //- fst execute
// console.log('I m done');

//PROMISE

// const p = new Promise((resolve, reject)=>{
//     const name = 'javascript';
//     resolve(name);
// });
// p.then(res => console.log(res));

// FETCH DATA FROM A LIST

// fetch('https://reqres.in/api/users')
// .then(res => res.json())
// .then(result=>{
//     result.data.forEach(user=>{
//         console.log(user.email)
//     });
// });
const tbody = document.querySelector('#target')
const user = document.getElementById('myInput');


    fetch('https://reqres.in/api/users')
        .then(res => res.json())
        .then(result => {
            const users = result.data;
            // console.log(users);
            users.forEach(user => {
                const row = `
        <tr id="table_row">
        <td>${user.id}</td>
        <td>
            <img src="${user.avatar}" height="50"></img>
        </td>
        <td>${user.first_name} ${user.last_name}</td>
        <td>${user.email}</td>
        </tr>
        `;
                tbody.innerHTML += row;
            });
        })


