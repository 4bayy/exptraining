// const m1 = {
//     [1,2],
//     [3,4]
// };
// console.log(m1);


setInterval(() =>{
    // console.log('code workd');
},5000);

// console.log('completed');

// function inside object

const student = {
    name:'student 1',
    // mark1:40,
    // mark2:50,
    // total :function(){
    //     // console.log(this.mark1  + this.mark2);
    // }
};
const mark = {
    mark3:30,
    mark4:10
};
// const copy = Object.assign({},student); // assign copy of the student  object to  copy
const copy = Object.assign({},student,mark)
// copy.name= 'new name';
// console.log(student);
console.log(copy);