﻿using UnityEngine;
using System.Collections;

public class controlEscena4_3_2 : MonoBehaviour {

	private controladorEscena control;
	private variablesHUD varHUD;
	
	void Start () {
		if (Tracker.T () != null)
			Tracker.T ().Zone("Escena4.3.2");

		GameObject.Find("Claudio").SetActive(VariablesGenerales.Instance.getApareceClaudio ());
		this.varHUD = GameObject.Find ("HUD").GetComponent<variablesHUD> ();
		this.varHUD.aumentaCortesia (10);
		this.control = this.gameObject.GetComponent<controladorEscena> ();
		this.control.marcarTareaCompleta (0);	//Completada en la escena 4.
		this.control.marcarTareaCompleta (1);	//Completada en la escena 4.
		this.control.marcarTareaCompleta (2);	//Completada en la escena 4.2.
		this.control.marcarTareaCompleta (3, true, true);	//Completada en el minijuego Duelo.
	}
}