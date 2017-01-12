package org.institutoserpis.ed.juanminm;

import java.util.Arrays;
import java.util.Random;

public class Ordenar {
	/* public static int[] selectionSort1(int[] v) {
	 *		int[] vSorted = v.clone();
	 *
	 *		for (int itemIndex = 0; itemIndex < vSorted.length - 1; itemIndex++) {
	 *			int indexOfMin = itemIndex;
	 *
	 *			for (int index = itemIndex + 1; index < vSorted.length; index++) {
	 *				if (vSorted[index] < vSorted[indexOfMin]) {
	 *					indexOfMin = index;
	 *				}
	 *			}
	 *
	 *			int aux = vSorted[itemIndex];
	 *			vSorted[itemIndex] = vSorted[indexOfMin];
	 *			vSorted[indexOfMin] = aux;
	 *		}
	 *	}
	 */
	private static int indexOfMin(int[] v, int initialIndex) {
		int indexOfMin = initialIndex;

		for (int index = initialIndex + 1; index < v.length; index++) {
			if (v[index] < v[indexOfMin]) {
				indexOfMin = index;
			}
		}

		return indexOfMin;
	}

	private static void swap(int[] v, int index1, int index2) {
		int aux = v[index1];
		v[index1] = v[index2];
		v[index2] = aux;

	}

	public static void selectionSort(int[] v) {
		for (int itemIndex = 0; itemIndex < v.length - 1; itemIndex++) {
			swap(v, itemIndex, indexOfMin(v, itemIndex));
		}
	}

	public static void main(String[] args) {
		int[] arr = new int[1000];
		Random rnd = new Random();
		long startTime;
		long endTime;

		for (int i = 0; i < arr.length; i++) {
			arr[i] = rnd.nextInt(2000);
		}

		System.out.println(Arrays.toString(arr));

		startTime = System.currentTimeMillis();
		selectionSort(arr);
		endTime = System.currentTimeMillis();

		System.out.println(Arrays.toString(arr));
		System.out.println("Time: " + (endTime - startTime));
	}
}
