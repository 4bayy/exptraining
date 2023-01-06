const student ={
    fullname:'student1',
    mark1:40,
    mark2:30
};

const {fullname,mark1} = student;
console.log(mark1);

const keys = Object.keys(student);  //
const values = Object.values(student);  // get values 

keys.forEach(key=>{
    console.log(student[key]);
});

values.forEach(value=>{                // values of array
    console.log(value);
});
