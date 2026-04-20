
#Ejercicio 3: Conversor de temperatura (°C → °F y °K)

temperatura = float(input('Ingrese temperatura en Celsius (C°): '))
Fahrenheit=temperatura*(9.0/5)+32
kelvin=temperatura+273.15

print(f'Temperatura en Fahrenheit: {Fahrenheit:.2f} °F')
print(f'Temperatura en Kelvin: {kelvin:.2f} K')