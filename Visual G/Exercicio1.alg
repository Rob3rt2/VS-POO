algoritmo "Combustiveis"
// Fun��o : Identificar o tipo de combust�vel e calcular o pre�o
// Autor : Let�cia Lapa e Robert Caio
// Data : 08/03/2023
var
   L, V: real
   COMB: caracter
inicio
      Escreva ("Digite o tipo de combust�vel: ")
      Leia (COMB)
      Escreva ("Digite a quantidade de litros: ")
      Leia (L)
      se (COMB = "A") entao
         se (L <= 20) entao
            V:=L*(4.90*3)/100
            Escreva ("Valor a ser pago � de:", V)
          senao
              V:=L*(4.90*5)/100
              Escreva ("Valor a ser pago � de: ", V)
          fimse
      senao
          se (COMB = "G") entao
             se (L<= 20) entao
                 V:=L*(5.50*4)/100
                 Escreva ("Valor a ser pago � de: ", V)
             senao
                  V:=L*(5.50*6)/100
                  Escreva ("Valor a ser pago � de: ", V)
             fimse
          senao
             Escreva ("C�digo Inv�lido!")
          fimse
      fimse


fimalgoritmo

