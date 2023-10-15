algoritmo "VetoresPares"
var
   val: vetor[1..7] de inteiro
   i, TotPar: inteiro
inicio
      Para i <- 1 ate 7 faca
           Escreva("Digite o ", i, "o. valor; ")
           Leia(val[i])
      FimPara
      Para i <- 1 ate 7 faca
           Se (val[i] % 2 = 0) entao
              Escreval("Valor PAR na Posicao: ", i)
              TotPar <- TotPar + 1
           FimSe
      FimPara
      Escreval("O total de pares foi ", TotPar)
fimalgoritmo