Algoritmo sin_titulo
	definir pesoManzana, pesoTotal Como Entero
	
	//inicializarla variable
	pesoTotal=0 //acumulador
	Mientras pesoTotal<=1000 Hacer
		
		Escribir "ingrese el peso de la manzana comprada: "
		leer pesoManzana 
		Si pesoManzana >= 180 Entonces
			pesoTotal=pesoTotal+pesoManzana
			Escribir "TOTAL: ", pesoTotal, " Gramos"
		SiNo
			Escribir "Error: La manzana debe pesar al menos 180 gramos"
		FinSi
		
		
	Fin Mientras
	Escribir "Ya se alcanzo o supero 1 kilo de manzanas!!"
FinAlgoritmo
