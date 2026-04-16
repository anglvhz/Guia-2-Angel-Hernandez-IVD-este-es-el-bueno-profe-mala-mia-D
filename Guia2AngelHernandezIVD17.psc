Algoritmo Ejercicio2
	Definir num1, num2, opc, result Como Real
	Definir msj Como Caracter
	Escribir Sin Saltar "Digite dos valres numericos: "
	Leer num1
	leer num2
	
	Escribir "******************"
	Escribir "MENÚ PRINCIPAL"
	Escribir "1- suma"
	Escribir "2- resta"
	Escribir "3- Multiplicación"
	Escribir "4- División"
	Escribir "5- Salir"
	Escribir Sin Saltar "Digite el numero segun su operacion: "
	Leer opc
	
	Segun opc Hacer
		1:
			msj="El resultado de la suma es: "
			result = num1+num2
		2:
			msj="El resultado de la suma es: "
			result = num1-num2
		3:
			msj="El resultado de la suma es: "
			result = num1*num2	
		4:
			msj="El resultado de la suma es: "
			result = num1/num2
		5:
			msj = "Saliendo del Sistema: "
		De Otro Modo:
			msj = "Seleccione una opcion valida"
	FinSegun
	Escribir msj
	Escribir result
FinAlgoritmo
