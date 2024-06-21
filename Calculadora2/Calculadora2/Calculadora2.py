def Sinal(x,y):
    Operador = input("Insira a operacao que deseja fazer\nDivisao:\t/\nMultiplicacao:\t*\nSubtracao:\t-\nSoma:\t\t+\n\n")
     
    if(Operador == '/'):
        return x/y
    elif(Operador == '*'):
        return x*y
    elif(Operador == '+'):
        return x+y
    elif(Operador == '-'):
        return x-y
            
x = input("Insira o primeiro numero ")
y = input("Insira o segundo numero ")
print(Sinal(int(x),int(y)))