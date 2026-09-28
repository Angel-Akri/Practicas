function bubblesort(a) 
{
    let s = a.length;
    for (let i = 0; i < s; i++)
    {
        let isSwapped = false;
        for (let j = 0; j < s - i - 1; j++) 
        {
            if (a[j] > a[j + 1]) 
            {
                [a[j], a[j + 1]] = [a[j + 1], a[j]];
                isSwapped = true; // Si hubo cambios la lista no estaba ordenada
            }
        }
        if (!isSwapped) break; // Si ya no hay cambios la lista esta ordenada
    }
}

const a = [15, 16, 11, 13, 14];
//toString convierte arrrays en cadenas de texto
console.log("Antes de ordenar los elementos del array son: ");
console.log(a.toString(" "));

bubblesort(a);
console.log("Despues de ordenar los elementos del array son: ");
console.log(a.toString(" "));