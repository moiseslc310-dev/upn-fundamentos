
promedio=int(input('Ingrese el promedio de notas: '))

if promedio>=0 and promedio<=5:
    print('Calificación: Deficiente')
elif promedio>=6 and promedio<=10:
    print('Calificación: Regular')
elif promedio>=11 and promedio<=14:
    print('"Calificación: Bueno')
elif promedio>=15 and promedio<=20:
    print('Calificación: Excelente')
else:
    print('Valor invalido')
