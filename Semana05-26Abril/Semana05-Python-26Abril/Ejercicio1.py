
edad=int(input("Ingrese la edad: "))

if edad <0:
    print("Error: la edad no puede ser negativa.")
else:
    if edad <=5:
        print("Resultado: viaja gratis, no requiere medio pasaje.")
    else:
        if edad<=17:
            carnet=input("¿Presenta carnet de estudiante? (S/N): ").upper()

            if carnet=="S":
                print("Resultado: Si accede al medio pasaje escolar.")
            else:
                print("Resultado: no accede al beneficio porque no presento carnet.")
        else:
            print("Resultado: no accede al medio pasaje escolar por edad.")
            
