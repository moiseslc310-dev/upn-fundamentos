
kwh=int(input("Ingrese consumo en kwh: "))
monto=0

if kwh<=0:
    print("Error: consumo debe ser positivo.")
elif kwh<=100:
    monto=kwh*0.50
elif kwh<=300:
    monto=100*0.50+(kwh-100)*0.75
else:
    monto=100*0.50+200*0.75+(kwh-300)*1.20

print(f"Monto a pagar: S/{monto:.2f}")
