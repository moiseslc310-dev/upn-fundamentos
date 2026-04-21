
import math
edad=int(input('Ingrese su edad:'))

if edad>=18:
    print('Acceso permitido. Bienvenidos')
else:
    edadfaltante=abs(edad-18)
    print('Acceso denegado')
    print(f'Te faltan {edadfaltante} año(s) para registrarse')
    