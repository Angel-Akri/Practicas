let arr=[40, 50, 60, 70, 80, 90];
let arreglo=" ";

for (let idx = arr.length - 1; idx >= 0; idx--)//ultimo elemto del arregli menos uno continua hasta que sea mayor o igual a cero mientas va restando uno
    {
        arreglo += arr[idx] + " ";
    }
    console.log("Los elementos del array son: " + arreglo);