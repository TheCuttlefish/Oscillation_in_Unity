using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class movement : MonoBehaviour {

	float r,g,b = 1.0f;

	void FixedUpdate () {

		//colour oscillation
		r = Mathf.Sin (Time.time * 1f);
		g = Mathf.Sin (Time.time * 2f);
		b = Mathf.Sin (Time.time * 3f);
		GetComponent<Renderer> ().material.color = new Color (r, g, b, 1f);

		//movement oscillation
		transform.Translate (
			(Mathf.Sin(Time.time*3f)/10),
			(Mathf.Cos(Time.time*3f)/20),
			(Mathf.Cos(Time.time*3f)/30)
		);
	}
}
