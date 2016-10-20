package org.institutoserpis.ed.juanminm;

import java.util.Random;

public class Adivina {
	public static void main(String[] args) {
		Random random = new Random();
		int numeroAleatorio;

		numeroAleatorio = random.nextInt(1000)+1;
		System.out.println(numeroAleatorio);
	}
}
