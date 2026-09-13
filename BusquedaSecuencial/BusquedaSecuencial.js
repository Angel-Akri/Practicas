function findelement(arr, i, targetelement) 
{
    for (let j = 0; j < i; j++) 
    {
        if (arr[j] == targetelement) 
         {
         return j;
         }
    }
    return -1;
}

let arr = [12, 34, 10, 6, 40, 89, 98, 57, 19, 69];
let targetelement = 6;
let i = arr.length;
let resultado = findelement(arr, i, targetelement);

if (resultado !== -1)
    {
    console.log("El elemento se encuentra en la posicion: ", resultado+1);
    } else 
        {
        console.log("No se encuentra el elemento");
        }