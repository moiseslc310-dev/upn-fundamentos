
import math

x1 =float(input('x1: '))
y1 =float(input('y1: '))
x2 =float(input('x2: '))
y2 =float(input('y2: '))

dx = x1 - x2
dy = y1 - y2

distancia = math.sqrt(math.pow(dx,2)+math.pow(dy,2))

print(f'Distancia entre los puntos: {distancia:.2f}')
