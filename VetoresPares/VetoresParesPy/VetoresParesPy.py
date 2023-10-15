val = [1, 2, 3, 4, 5, 6, 7]
TotPar = 0

for i in range(7):
  val[i] = int(input(f"Digite o {i+1}o. valor: "))

for i in range(7):
  if (val[i] % 2 == 0):
    print(f"O numero na posicao {i+1} é PAR")
    TotPar += 1

print(f"O total de numero pares: {TotPar}")