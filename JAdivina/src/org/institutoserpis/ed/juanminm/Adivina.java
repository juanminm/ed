package org.institutoserpis.ed.juanminm;

import java.util.Random;
import java.util.Scanner;

public class Adivina {
	public static void main(String[] args) {
		Scanner scan = new Scanner(System.in);
		Random random = new Random();
		int numero, numeroAleatorio;

		numeroAleatorio = random.nextInt(1000)+1;
		System.out.println(numeroAleatorio);

		do {
			System.out.print("Introduce el número: ");
			String line = scan.nextLine();
			numero = Integer.parseInt(line);

			if (numero <= numeroAleatorio) {
				System.out.println("El numero introducido es menor.");
			} else if (numero >= numeroAleatorio) {
				System.out.println("El número introducido es mayor.");
			} else {
				System.out.println("¡Adivinaste el número!");
			}

		} while (numero != numeroAleatorio);
	}
}
