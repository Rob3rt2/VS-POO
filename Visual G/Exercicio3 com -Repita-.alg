algoritmo "Exercicio3 - repita"
// Função : Elaborar um programa que calcule a tabuada de um numero, com comando repita
// Autor :  Robert Caio e Leticia Lapa
// Data : 15/03/2023
// Seção de Declarações 
var
 N, C:real
 I:inteiro
inicio
 escreva("digite um numero: ")
 leia(N)
 i:=1
 repita
  C:=N*i
  escreva(C)
  i:=i+1
  ate(i>10)
  
fimalgoritmo
