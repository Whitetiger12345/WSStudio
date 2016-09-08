using UnityEngine;
using System.Collections;

public class FindClue : MonoBehaviour {
	public GameObject Target,S_Target,Player;
	public Eyeglasses glasses;
	// Use this for initialization
	void Start () {
		Target = null;
		Player = GameObject.FindGameObjectWithTag ("Player");
		glasses = Player.GetComponent<Eyeglasses> ();
	}
	
	// Update is called once per frame
	void Update () {
		if (glasses.wear == true) {
			RaycastHit hit;
			Ray ray = Camera.main.ScreenPointToRay (Input.mousePosition);
			if (Physics.Raycast (ray, out hit, 50.0f)) {
				Target = hit.transform.gameObject;
				if (Target.tag == "Clue") {
					Target.GetComponent<Renderer> ().material.color = Color.green;
					S_Target = Target;
				} else {
					S_Target.GetComponent<Renderer> ().material.color = Color.white;
				}
			}
			if (Target.tag == "Clue" && Input.GetKeyDown (KeyCode.Q)) {
				Debug.Log ("Clue" + Target.name);

			}
		}
	}
}
