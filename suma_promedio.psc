//Realizar un programa que lea cuatro valores numéricos e informar su suma y promedio.


Algoritmo suma_promedio
	Definir num1, num2, num3, num4, suma, cantNum Como Entero;
	Definir promedio Como Real;
	cantNum<-4;
	
	
	Escribir "Ingrese el valor del primer numero: ";
	leer num1;
	
	Escribir "Ingrese el valor del segundo numero: ";
	Leer num2;
	
	Escribir "Ingrese el valor del tercer numero: ";
	leer num3;
	
	Escribir "Ingrese el valor del cuarto numero: ";
	Leer num4;
	
	suma<-num1+num2+num3+num4;
	Escribir "El resultado de la suma de los 4 numeros es: " suma;
	
	promedio<-suma/cantNum;
	Escribir "El promedio de los cuatro numeros es: " promedio;
	
	
FinAlgoritmo
