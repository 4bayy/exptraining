// const languages=["C","C++","Java","Python"];
// languages.forEach(element => {
//     console.log(element);
// });

const person = {``
    name:"joe",
    age:20,
    email:null,
    experience:[
        {
            company:' company abc',
            years:2
        },
        {
            company:'company xyz',
            years:4
        }
    ]
};

person.name ='new name'; // normally usedf to select a value from a object
person.email = 'sample @hotmail.com';

// console.log(person.name);
// console.log(person['name']);
// console.log(person.experience[0]);\
person.experience.forEach(exp => {
    console.log(exp.company);
    console.log(exp.years);
});

// matrix

const m1 = {
    [1,2]
    [3,4]
};
console.log(m1);
