inputArr = [11, 21, 31, 41, 51, 61]
ele = 22
print("Antes de la insercion, el array es: ")
for j in range (len(inputArr)):
    print(inputArr[j], end=" ")
inputArr.append(ele)
print("\nDespues de la insercion, el array es: ")
for j in range (len(inputArr)):
    print(inputArr[j], end=" ")