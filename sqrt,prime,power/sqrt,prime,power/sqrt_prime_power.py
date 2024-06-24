from ast import Global
from email.mime import base
from math import exp
from pickle import TRUE
from re import I

def isprime(numero):
    
    numero = int(numero)

    if numero <= 1:
        print("Este numero nao e valido")
    
    elif numero == 2 or numero == 3:
        print(f"{numero} e primo")

    elif numero % 2 == 0 or numero % 3 == 0:
        print(f"{numero} nao e primo")
        
    i = 5
    while i * i < numero:
        if numero % i == 0 or numero % i + 2 == 0:
            print(f"{numero} nao e primo")
        i += 6

def sqrt(numero):
    i = 1
    numero = int(numero)
    
    while i * i != numero :
        i+=1
    
    print(f"{i}")
    
def power(base, expoente):

    base = int(base)
    expoente = int(expoente)
    base2 = base
    while expoente != 1:
        base = base2 * base
        expoente-=1
    
    print(f"{base}")
    

operacao = input("Insira a operacao que deseja\n\nIdentificar se o numero e primo\tP\nCalcular a raiz de um numero\tR\nCalcular uma potencia\t^\n\n")

if  operacao == "P" or operacao == "p":
    resultado = isprime(numero = input("Insira o numero\t"))
    
elif  operacao == "R" or operacao == "r":
    resultado = sqrt(numero = input("Insira a raiz\t"))
    
elif  operacao == "^":
    resultado = power(base = input("Insira a base\t"), expoente = input("Insira o expoente\t"))