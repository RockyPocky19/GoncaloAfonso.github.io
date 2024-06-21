valor = input("Insira a string\n")
countvogais = 0
vogais = "aeiouAEIOU"

countconsoantes = 0
consoantes = "abcdfghjklmnopqrstvwxyz"

countnumeros = 0
numeros = "0123456789"
countoutros = 0

for character in valor:
    if character in vogais:
        countvogais+=1
    
    elif character in consoantes:
        countconsoantes+=1
    
    elif character in numeros:
        countnumeros+=1
      
    else:
        countoutros+=1
        
print("Numero de vogais:\t"+str(countvogais)+"\nNumero de consoantes:\t"+str(countconsoantes)+"\nNumero de numeros:\t"+str(countnumeros)+"\nNumero de caracteres especiais:\t"+str(countoutros)+"")
