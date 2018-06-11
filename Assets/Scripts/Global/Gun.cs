﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Gun : MonoBehaviour {
	
	public Transform bullet;
	public Vector2 startVelocity;
	
	public void Fire(float forwardScalar = 1, Transform bulletPos = null) {
		Vector3 startPos = this.transform.position;
		if (bulletPos != null) {
			startPos = bulletPos.position;
		}
		GameObject b = Instantiate(bullet, startPos, Quaternion.identity, null).gameObject;
		b.GetComponent<Rigidbody2D>().velocity = new Vector2(
			startVelocity.x * forwardScalar,
			startVelocity.y
		);

		if (this.GetComponent<Rigidbody2D>() != null) {
			b.GetComponent<Rigidbody2D>().velocity += this.GetComponent<Rigidbody2D>().velocity;
		}
	}
}
