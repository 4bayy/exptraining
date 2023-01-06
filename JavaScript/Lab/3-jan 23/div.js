document.querySelectorAll('#one button').forEach(btn =>{
    btn.addEventListener("click",moveElement);
});

const second =document.getElementById('two');

function moveElement(e)   //e value 
{
    console.log(e);
    const temp =e.target;
    e.target.remove();
    temp.removeEventListener("click",moveElement)
    console.log(second);
    second.appendChild(temp); // add to second div
}
