function findEle(Arr, l, h, targetvalue)
{
    while (l <= h)
    {
    let mid = l + Math.floor ((h-l)/2);
    if (Arr[mid] === targetvalue)
        {
        return mid;
        }
        else if (Arr[mid] < targetvalue)
            {
            l = mid + 1;
            } 
            else
            {
            h=mid -1;    
            }
    }
    return -1
}
const InputArr = [6, 10, 12, 19, 34, 40, 57, 69, 89, 98];
const TargetElement = 1
const s = InputArr.length
const idx = findEle(InputArr, 0, s -1, TargetElement);
if (idx !== -1) 
{
    console.log("El elemento se encuentra en la posicion: " + (idx + 1));
     } 
     else 
     {
    console.log("El elemento no se encuentra");
}