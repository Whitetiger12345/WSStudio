using UnityEngine;
using System.Collections;

public class FirstPerson : MonoBehaviour {
	private Eyeglasses glasses;
	public GameObject Detective, FPS,TCam;
	// Use this for initialization
	void Start () {
		glasses = gameObject.GetComponent<Eyeglasses> ();
	}
	
	// Update is called once per frame
	void Update () {
		if (glasses.wear == true) {
			Detective.SetActive (false);
			TCam.SetActive (false);
			FPS.SetActive (true);


		} else {
			Detective.SetActive (true);
			TCam.SetActive (true);
			FPS.SetActive (false);
		}
	}
}
