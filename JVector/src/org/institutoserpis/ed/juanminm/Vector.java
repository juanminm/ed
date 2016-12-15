package org.institutoserpis.ed.juanminm;

public class Vector {

	public static void main(String[] args) {
		int index = indexOf(new int[]{32, 15, 7, 9, 12}, 99);
		System.out.printf("Vector index=%d%n", index);
	}

	public static int indexOf(int[] v, int data) {
		int index = 0;
		while (index < v.length && v[index] != data) {
			index++;
		}

		if (index == v.length) {
			return -1;
		}

		return index;
	}

	public static int min(int[] v) {
		int menor = Integer.MAX_VALUE;

		for (int i = 0; i < v.length; i++) {
			if (v[i] < menor) {
				menor = v[i];
			}
		}

		return menor;
	}
}
