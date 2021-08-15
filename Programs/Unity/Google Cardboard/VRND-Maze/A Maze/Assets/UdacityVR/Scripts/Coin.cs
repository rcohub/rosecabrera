using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Coin : MonoBehaviour {

	public GameObject CoinPoofPrefab;
	public GameObject CoinObject;

	//See LifelikeMetalObjects.cs for common GameObject characteristics, such as rotation and OnMouseEnter() events

	public void OnCoinClicked () {
		ScoreBoardDisplay.Score += 1;
		Destroy (CoinObject, 0.3f);
		Instantiate (CoinPoofPrefab, transform.position, transform.rotation);
	}
		
}
