def findEle(arr, l, h, targetValue):
    while l <= h:
        mid= l+ (h-l) // 2
        #Verifica si x esta presente en mid
        if arr[mid] == targetValue:
            return mid
        #si targetvalue es mayor que el elemento mid, considerar la segunda mitad del array
        elif arr[mid] < targetValue:
            l = mid + 1
            #si targetvalue es mayor que el elemento mid, considerar la primer mitad del array
        else:
            h = mid - 1
        #Si el control llega hasta aqui, significa que el elemento buscado no esta presente en el array
    return -1
if __name__ == "__main__":
    inputArr = [6, 10, 12, 19, 34, 40, 57, 69, 89, 98]
    targetElement = 34
    s = len(inputArr)#tamanio del array
    #operacion de busqueda
    idx = findEle(inputArr, 0, s -1, targetElement)
    if idx != -1:
        print("El elemento se encuentra en la posicion: " + str (idx+1))
    else:
        print("El elemento no se ecuentra")