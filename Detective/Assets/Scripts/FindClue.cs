using UnityEngine;
using System.Collections;

public class FindClue : MonoBehaviour {
	public GameObject Target;
	// Use this for initialization
	void Start () {
		Target = null;
	}
	
	// Update is called once per frame
	void Update () {
		RaycastHit hit;
		Ray ray = Camera.main.ScreenPointToRay (Input.mousePosition);
		if (Physics.Raycast (ray, out hit,50.0f)) {
			Target = hit.transform.gameObject;
		}
		if (Target.tag == "Clue" && Input.GetKeyDown(KeyCode.Q)) {
			Debug.Log ("Clue" + Target.name);
		}
	}
}
