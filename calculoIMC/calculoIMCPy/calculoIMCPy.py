M = float(input("Massa (Kg): "))
A = float(input("Altura (m): "))

IMC = M / (A ** 2)

print(f"IMC: {IMC:3.1f}")
if (IMC < 17):
  print("Muito abaixo do peso")
elif (IMC >= 17) and (IMC <= 18.5):
  print("Abaixo do Peso")
elif (IMC >= 18.5 ) and (IMC <= 25):
  print("Peso Ideal")
elif (IMC >= 25) and (IMC <= 30):
  print("Sobrepeso")
elif (IMC >= 30) and (IMC <= 35):
  print("Obesidade")
elif (IMC >= 35) and (IMC <= 40):
  print("Obesidade Severa")
else:
  print("Obesidade Morbida")