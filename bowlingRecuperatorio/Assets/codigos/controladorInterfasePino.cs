using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class controladorInterfasePino : MonoBehaviour {

	public GameObject ControladorDelpino;
	private bool activador;
	Renderer render;
	private Rigidbody rb;
	private ResetPinos rs;
	Color colr;

	void Start () 
	{
		rb = GetComponent<Rigidbody> ();
		rs = GetComponent<ResetPinos> ();
	}
	
	void Update () 
	{
		if (rb.angularVelocity != Vector3.zero)
		{
			colr.r = ControladorDelpino.GetComponent<Renderer> ().material.color.r;
			colr.g = ControladorDelpino.GetComponent<Renderer> ().material.color.g;
			colr.b = ControladorDelpino.GetComponent<Renderer> ().material.color.b;
			print ("entra al esto");
			colr.a = 0f;
			ControladorDelpino.GetComponent<Renderer> ().material.color = colr;
		}

		if (rs.ContadorTurno%2 == 0 && Input.GetKeyDown(KeyCode.R)) 
		{
			colr.a = 1f;
			ControladorDelpino.GetComponent<Renderer> ().material.color = colr;
			print ("fuciona");
		}


	}
}
