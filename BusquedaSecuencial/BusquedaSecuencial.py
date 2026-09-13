def findEle(inpupArr, s, targetEle):
    for j in range(s):
        if (inpupArr[j]== targetEle): #Aqui aplica la busqueda linea
            return j #El elemento encontrado se guarda en j
    return -1 #Sino lo encuentra regresa el valor de -1

if __name__ == "__main__":
    inputArr= [12, 34, 10, 6, 40, 89, 98, 57, 19, 69]
    targetElement = 40
    s = len(inputArr)

    idx= findEle(inputArr, s, targetElement)
    if idx != -1:
        print("El elemento se encuentra en la posicion: " + str(idx+1))
    else:
        print("No se encuentra el elemento.")