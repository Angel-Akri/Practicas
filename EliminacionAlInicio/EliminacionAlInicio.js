let arr = [11, 21, 31, 41, 51, 61];
console.log("Antes de la eliminacion, el array es: " + arr);
for (let i = 0; i < 1; i++) 
    {
    arr.shift(); //shift elimina el primer elemento de un array btw
    }

console.log("\nDespues de la eliminacion, el array es: ");
let resarray= " "
for (let i = 0; i < arr.length; i++) 
    {
    resarray += (arr[i] + " ");
    }
console.log(resarray);