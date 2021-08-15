using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LifelikeMetalObjects : MonoBehaviour {

	public AudioSource audioSource;
	public AudioClip hoverSound;
	private float scaleMax = 200f;
	private float scaleMin = 100f;


	// Use this for initialization
	void Start () {
		audioSource = GetComponent<AudioSource>();
	}
	
	// Update is called once per frame
	void Update () {
		transform.Rotate(0,5,0, Space.World);
	}
		
	public void OnMouseEnter() {
		audioSource.PlayOneShot (hoverSound);
		transform.localScale = new Vector3 (scaleMax, scaleMax, scaleMax);
	}

	public void OnMouseExit() {
		transform.localScale = new Vector3 (scaleMin, scaleMin, scaleMin);
	}
}
