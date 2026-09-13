let Arr = [11, 21, 31, 41, 51, 61]
let Elemento = 67

console.log("Antes de la insercion, el array es: ")
let Arrayviejo =" "
for (let i = 0; i < Arr.length; i++) 
    {
        Arrayviejo += Arr[i] + " ";
    }
console.log(Arrayviejo);

Arr.unshift(Elemento); //el unshift agrega el ekemento al inicio del array
console.log("Despues de la insercion, el array es: ")
let Arraynuevo = " "
for (let i = 0; i < Arr.length; i++) 
    {
        Arraynuevo += Arr[i] + " ";
    }
console.log(Arraynuevo);