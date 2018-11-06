using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChangeColor : MonoBehaviour {

	public Material mA;
	public Material mB;

	bool cambiar;
	// Use this for initialization
	void Start () {
		cambiar = false;
		EventManager.DisparoB += SwitchColor;
	}
	
	// Update is called once per frame
	void SwitchColor () {
		Debug.Log (GetComponent<Renderer> ().material.ToString());
		Debug.Log (mA.ToString());

		if(cambiar)
			GetComponent<Renderer> ().material = mB;
		else
			GetComponent<Renderer> ().material = mA;

		cambiar = !cambiar;
	}
}
