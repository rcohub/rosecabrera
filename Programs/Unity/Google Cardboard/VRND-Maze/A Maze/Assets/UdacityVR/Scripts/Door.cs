using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Door : MonoBehaviour {

	public GameObject leftDoor;
	public GameObject rightDoor;
	public AudioSource audioSource;
	public AudioClip doorOpen;
	public AudioClip doorLocked;
	private bool locked = true;
	private bool opening = false;
	Quaternion leftDoorStartRotation;
	Quaternion leftDoorEndRotation;
	Quaternion rightDoorStartRotation;
	Quaternion rightDoorEndRotation;
	private float timer = 0f;
	private float rotationTime = 10f;

	void Start () {

		audioSource = GetComponent<AudioSource>();

		leftDoorStartRotation = leftDoor.transform.rotation;
		leftDoorEndRotation = leftDoorStartRotation * Quaternion.Euler (0f, 0f, 90f);

		rightDoorStartRotation = rightDoor.transform.rotation;
		rightDoorEndRotation = rightDoorStartRotation * Quaternion.Euler (0f, 0f, -90f);

	}


	void Update () {
		
		if (opening == true) {
			leftDoor.transform.rotation = Quaternion.Slerp (leftDoorStartRotation, leftDoorEndRotation, timer / rotationTime);
			rightDoor.transform.rotation = Quaternion.Slerp (rightDoorStartRotation, rightDoorEndRotation, timer / rotationTime);
			timer += Time.deltaTime;
		}

	}


	public void OnDoorClicked () {

		if (locked != true) {
			opening = true;
			audioSource.PlayOneShot (doorOpen);

			Collider colliderLeft = leftDoor.GetComponentInChildren<Collider> ();
			colliderLeft.enabled = false;

			Collider colliderRight = rightDoor.GetComponentInChildren<Collider> ();
			colliderRight.enabled = false;

		} else {
			audioSource.PlayOneShot (doorLocked);
		}

	}


	public void Unlock () {
		
		locked = false;

	}
}
