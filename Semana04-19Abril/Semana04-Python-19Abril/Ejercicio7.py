
parcial=int(input('Ingrese examen parcial: '))
final=int(input('Ingrese examen final: '))
prac1=int(input('Ingrese practica 1: '))
prac2=int(input('Ingrese practica 2: '))
prac3=int(input('Ingrese practica 3: '))

prom_prac=(prac1+prac2+prac3-min(prac1,prac2,prac3))/2
prom_final=(parcial+final+prom_prac)/3
print(f'Promedio de practicas: {prom_prac}')
print(f'Promedio final: {prom_final}')

if prom_final>=18 and prom_final<=20:
    print('Excelente')
elif prom_final>=14 and prom_final<=17:
    print('Bueno')
elif prom_final>=10 and prom_final<=13:
    print('Regular')
else:
    print('Deficiente')
