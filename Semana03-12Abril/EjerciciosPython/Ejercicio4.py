
import math

radio = float(input('Radio del circulo: '))

area=math.pi*radio**2

perimetro = 2 * math.pi*radio

print(f'Area: {area:.4f}')
print(f'Perimetro: {perimetro:.4f}')