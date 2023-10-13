def ParImpar(A):
  if (A % 2 == 0):
    return "PAR"
  else:
    return "IMPAR"

N = int(input("Digite um Numero: "))

R = ParImpar(N)

print(f"O numero {N} é {R}")