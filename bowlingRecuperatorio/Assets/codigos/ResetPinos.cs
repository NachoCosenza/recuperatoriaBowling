using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ResetPinos : MonoBehaviour {

	private Rigidbody rb;
	private Vector3 PosicionInicialPinos;
	private Quaternion anguloInicial;
	private bool AutorizadorReset;
	private int ContadorTurno = 0;



	void Awake () 
	{
		rb = GetComponent<Rigidbody> ();
		PosicionInicialPinos = transform.position;
		anguloInicial = transform.rotation;
		AutorizadorReset = true;

	}
	
	// Update is called once per frame
	void Update () 
	{
				
		if (Input.GetKeyUp (KeyCode.R)) 
		{		
			ContadorTurno = ContadorTurno + 1;

			if (ContadorTurno%2 == 0) 
			{
				rb.velocity = Vector3.zero;
				rb.angularVelocity = Vector3.zero;
				rb.MovePosition (PosicionInicialPinos);
				rb.MoveRotation (anguloInicial);
				AutorizadorReset = false;
			}
			if(rb.angularVelocity != Vector3.zero && transform.position != PosicionInicialPinos)
			{
				// mover con un objeto vacio a la pocicion
				print("si");
			}
		}

	}
}
