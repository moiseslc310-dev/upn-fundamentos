
votosAna = 0
votosCarlos = 0
votosLucia = 0
nulos = 0

while True:
    print("\n---- Opciones de Votación ----")
    print("1 - Ana Torres")
    print("2 - Carlos Mendoza")
    print("3 - Lucía Paredes")
    print("0 - Cerrar votación")
    
    voto = int(input("Ingrese su opción: "))


    if voto == 1:
        votosAna = votosAna + 1
    elif voto == 2:
        votosCarlos = votosCarlos + 1
    elif voto == 3:
        votosLucia = votosLucia + 1
    elif voto != 0:
        nulos = nulos + 1
        print("Voto nulo")

    if voto == 0:
        break

total = votosAna + votosCarlos + votosLucia + nulos

print("\n==== RESULTADOS DE LA VOTACIÓN ====")
print(f"Votos de Ana Torres: {votosAna}")
print(f"Votos de Carlos Mendoza: {votosCarlos}")
print(f"Votos de Lucía Paredes: {votosLucia}")
print(f"Votos nulos: {nulos}")
print(f"Total de votantes: {total}")

if votosAna > votosCarlos and votosAna > votosLucia:
    print("Ganadora: Ana Torres")
elif votosCarlos > votosAna and votosCarlos > votosLucia:
    print("Ganador: Carlos Mendoza")
elif votosLucia > votosAna and votosLucia > votosCarlos:
    print("Ganadora: Lucía Paredes")
else:
    print("Resultado: EMPATE")