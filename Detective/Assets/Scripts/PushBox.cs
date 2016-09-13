using UnityEngine;
using System.Collections;

namespace UnityStandardAssets.Characters.ThirdPerson
{

public class PushBox : MonoBehaviour {
		public Animator anim;
		public GameObject Target;
		private Rigidbody rigib;
		// Use this for initialization
		void Start () {
			anim=gameObject.GetComponent<Animator> ();
		}

		// Update is called once per frame
		void Update () {
		rigib=Target.GetComponent<Rigidbody> ();	
		anim.SetFloat ("Pushing", Input.GetAxis ("Pushing"));
		if (Input.GetKeyDown (KeyCode.E)) {
			gameObject.GetComponent<ThirdPersonUserControl> ().enabled = false;
			gameObject.GetComponent<BoxCollider> ().enabled = true;
			rigib.mass = 1;
		}
			if (Input.GetKeyUp (KeyCode.E)) {
				gameObject.GetComponent<BoxCollider> ().enabled = false;
				gameObject.GetComponent<ThirdPersonUserControl> ().enabled = true;
				rigib.mass = 20000;
			}
		}

	}
}
