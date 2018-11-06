using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class EventManager : MonoBehaviour {

	public delegate void collisionB();
	public static event collisionB Evento;

	public delegate void disparoA (float e);
	public static event disparoA DisparoA;

	public delegate void disparoB ();
	public static event disparoB DisparoB;

	float energy;
	int money;

	public Text energyText;
	public Text moneyText;

	void Start(){
		energy = 1.0f;

		energyText.text = "Energy: " + energy;
		moneyText.text = "Money: " + money;
	}

	void Update(){
		
		if (Input.GetKey (KeyCode.A)) {
			if(DisparoA != null)
				DisparoA (energy);
			energy -= 1.0f;
			if (energy < 0)
				energy = 0;
			
		} else if (Input.GetKey (KeyCode.B)) {
			if(DisparoB != null)
				DisparoB ();
			money++;

		}

		energyText.text = "Energy: " + energy;
		moneyText.text = "Money: " + money;
	}

	public void masEnergia(){
		if (money > 0) {
			money--;
			energy += 1.0f;
		}

		energyText.text = "Energy: " + energy;
		moneyText.text = "Money: " + money;
	}

	void OnCollisionEnter(Collision other) {
		if (other.gameObject.CompareTag ("B")) {
			if(Evento != null)
				Evento();
		}
	}
}
