package org.institutoserpis.ed.juanminm;

import static org.junit.Assert.assertEquals;

import org.junit.Test;

public class VectorTest {

	@Test
	public void indexOfFirst() {
		assertEquals(0, Vector.indexOf(new int[]{32, 15, 7, 9, 12}, 32));
	}

	@Test
	public void indexOfMid() {
		assertEquals(2, Vector.indexOf(new int[]{32, 15, 7, 9, 12}, 7));
	}

	@Test
	public void indexOfLast() {
		assertEquals(4, Vector.indexOf(new int[]{32, 15, 7, 9, 12}, 12));
	}

	@Test
	public void indexOfFalse() {
		assertEquals(-1, Vector.indexOf(new int[]{32, 15, 7, 9, 12}, 99));
	}

	@Test
	public void indexOfEmpty() {
		assertEquals(-1, Vector.indexOf(new int[]{}, 123));
	}

	@Test
	public void minFirst() {
		assertEquals(3,  Vector.min(new int[]{3, 15, 7, 9, 12}));
	}

	@Test
	public void minMid() {
		assertEquals(7,  Vector.min(new int[]{8, 15, 7, 9, 12}));
	}

	@Test
	public void minLast() {
		assertEquals(2,  Vector.min(new int[]{8, 15, 7, 9, 2}));
	}

	@Test
	public void minMultiple() {
		assertEquals(4, Vector.min(new int[]{4, 4, 5, 9, 10}));
	}

	@Test
	public void minAll() {
		assertEquals(4, Vector.min(new int[]{4, 4, 4, 4, 4}));
	}
}
