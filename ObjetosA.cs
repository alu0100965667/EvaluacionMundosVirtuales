using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObjetosA : MonoBehaviour {

	public Transform tr;
	// Use this for initialization
	void Start () {
		tr = GetComponent<Transform> ();
		EventManager.Evento += Aumentar;
		EventManager.DisparoA += Disminuir;
	}
	
	void Aumentar () {
		tr.localScale += new Vector3 (0, 1.0f, 0);
	}

	void Disminuir(float e){
		Vector3 tmp = tr.localScale;

		Debug.Log (tmp.y);
		tmp -= new Vector3 (0, e, 0);

		if (tmp.y > 0)
			tr.localScale = tmp;
		else {
			tr.localScale = new Vector3 (tmp.x, 0, tmp.z);
		}
	}
}
