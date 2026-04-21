
import math

print("=== Menú de operaciones ===")
print("1.- Calcular área de un circulo")
print("2.- Calcular área de un cuadrado")
print("3.- Calcular área de un triángulo")

opcion=int(input("Seleccione una opcón (1-4): "))

match opcion:
    case 1:
        print("Elegiste circulo")
        radio =float(input("Ingrese la radio: "))
        areaCir=math.pi*math.pow(radio,2)
        print(f"El area del circulo: {areaCir:.2f}")
    case 2:
        print("Elegiste Cuadrado")
        lado =float(input("Ingrese lado: "))
        areaCua=math.pow(lado,2)
        print(f"El area del cuadrado es: {areaCua:.2f}")
    case 3:
        print("Elegiste triangulo")
        base=float(input("Ingrese la base: "))
        altura =float(input("Ingrese la altura: "))
        areaTri=(base*altura)/2
        print(f"El area del trinagulo es: {areaTri:.2f}")
    case 4:
        print("Saliendo del programa...")
    
    case _:
        print("Opción invalida. Ingresa un número del 1 al 4")
