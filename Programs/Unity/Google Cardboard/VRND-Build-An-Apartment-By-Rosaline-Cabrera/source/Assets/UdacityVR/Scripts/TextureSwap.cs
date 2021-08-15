using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class TextureSwap : MonoBehaviour {
	public Texture[] textures;
	private int currentTexture;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {

		if (Input.GetMouseButtonDown(0)) {
			currentTexture++;
			currentTexture %= textures.Length;
			GetComponent<Renderer> ().material.mainTexture = textures [currentTexture];
			GetComponent<Renderer> ().material.SetTexture ("_EmissionMap", textures [currentTexture]);
		}
	}
}