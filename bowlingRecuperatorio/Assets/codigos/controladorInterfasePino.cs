using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class controladorInterfasePino : MonoBehaviour {

	public GameObject ControladorDelpino;
	private bool activador;
	private Pino puntopino = new Pino();

	void Start () 
	{
		//ControladorDelpino.GetComponent<Renderer> ().
	}
	
	// Update is called once per frame
	void Update () 
	{
		if (true)
		{
			Renderer render;
			Color colr;
			colr.r = ControladorDelpino.GetComponent<Renderer> ().material.color.r;
			colr.g = ControladorDelpino.GetComponent<Renderer> ().material.color.g;
			colr.b = ControladorDelpino.GetComponent<Renderer> ().material.color.b;
			print ("entra");
			colr.a = 0f;

			ControladorDelpino.GetComponent<Renderer> ().material.color = colr;
		}
	}
}
