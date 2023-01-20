const arr=[200,300,250,,400,350];
//insertion sort
 var i;
for ( i=1; i<arr.length; i++){
    let key_value =arr[i];
    let j= i-1;
    //compare elements
    while(j>=0 && arr[j]> key_value){
        arr[j+1] =arr[j];
        j=j-1;
    }
    arr[j+1] =key_value;
    //print array
    for( i=0;i<arr.length;i++){
        console.log(ar[i]);
    }

}