

peso=float(input("Ingrese el peso en Kg: "))
estatura = float(input("Ingrese la estatura en metros: "))

imc=peso/(estatura**2)
imcRed=round(imc,2)

print(f"IMC: {imcRed}")

if imc <18.5:
    print("Bajo peso")
elif imc <25:
    print("Normal")
elif imc <30:
    print("Sobrepeso")
else:
    print("Obesidad")
