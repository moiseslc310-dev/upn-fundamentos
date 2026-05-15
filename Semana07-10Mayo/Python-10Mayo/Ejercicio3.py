
while True:
    nota = int(input("Ingrese nota (0-20): ")) 
    if 0<= nota <=20:
        break
    else:
        print("Error: nota debe ser entre 0 y 20.")

if 18<= nota <=20:
    print("Clasificación: EXCELENTE")
    
elif 14<=nota <=17:
    print("Clasificación: BUENO") 

elif 11<= nota <=13:
    print("Clasificación: REGULAR")

else:
    print("Clasificación: DESAPROBADO")