using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class RessetBola : MonoBehaviour {

	private Rigidbody rb;
	private Vector3 PosicionInicialBola;
	private Quaternion anguloInicial;
	private Quaternion anguloInicialControlador;
	public Image ControladorDelAngulo;


	void Awake () 
	{
		rb = GetComponent<Rigidbody> ();
		PosicionInicialBola = transform.position;
		anguloInicial = transform.rotation;
		anguloInicialControlador = ControladorDelAngulo.transform.rotation;


	}
	
	void Update ()
	{
		if (Input.GetKeyUp (KeyCode.R))
		{		
			rb.velocity = Vector3.zero;
			rb.angularVelocity = Vector3.zero;
			rb.MovePosition (PosicionInicialBola);
			rb.MoveRotation (anguloInicial);
			ControladorDelAngulo.transform.rotation = anguloInicialControlador;
		}
	}
}
