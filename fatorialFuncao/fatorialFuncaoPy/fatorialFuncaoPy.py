def Fatorial(A):
  F = 1
  for C in range(1, A + 1):
    F *= C
  return F

N = int(input("Digite um número: "))

F = Fatorial(N)

print(f"O fatorial de {N}! é {F}")
