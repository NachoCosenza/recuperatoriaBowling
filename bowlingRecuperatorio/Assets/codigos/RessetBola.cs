using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RessetBola : MonoBehaviour {

	private Rigidbody rb;
	private Vector3 PosicionInicialBola;
	private Quaternion anguloInicial;


	void Awake () 
	{
		rb = GetComponent<Rigidbody> ();
		PosicionInicialBola = transform.position;
		anguloInicial = transform.rotation;



	}
	
	void Update ()
	{
		if (Input.GetKeyUp (KeyCode.R))
		{		
			rb.velocity = Vector3.zero;
			rb.angularVelocity = Vector3.zero;
			rb.MovePosition (PosicionInicialBola);
			rb.MoveRotation (anguloInicial);
		}
	}
}
