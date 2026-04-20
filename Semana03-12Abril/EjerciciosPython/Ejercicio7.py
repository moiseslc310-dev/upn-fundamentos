
#Ejercicio 2: Factura de consumo eléctrico con IGV
kwh =float(input('Ingrese kWh consumido:'))

subotal = 5 + 0.55*kwh
igv = subotal*0.18
total = subotal + igv

print(f'El subtotal (Son IGV): S/. {subotal:.2f}')
print(f'El IGV (18%): S/. {igv:.2f}')
print(f'El Total consumido: S/. {total:.2f}')
