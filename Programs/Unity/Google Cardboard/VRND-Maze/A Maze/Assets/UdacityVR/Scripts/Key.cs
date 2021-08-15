using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Key : MonoBehaviour {

	public GameObject KeyPoofPrefab;
	public GameObject KeyObject;
	public Door door;

	//See LifelikeMetalObjects.cs for common GameObject characteristics, such as rotation and OnMouseEnter() events

	public void OnKeyClicked () {
		door.Unlock ();
		Destroy (KeyObject, 0.3f);
		Instantiate (KeyPoofPrefab, transform.position, transform.rotation);
	}
}
