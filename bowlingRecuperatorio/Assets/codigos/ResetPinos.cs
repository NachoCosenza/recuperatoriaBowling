using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ResetPinos : MonoBehaviour {

	private Rigidbody rb;
	private Vector3 PosicionInicialPinos;
	private Quaternion anguloInicial;
	private bool AutorizadorReset;
	public int ContadorTurno = 0;
	private Pino points;
	public Transform AlmacenadoDePinos;

	void Awake () 
	{
		rb = GetComponent<Rigidbody> ();
		//rs = GetComponent<Renderer> ();
		PosicionInicialPinos = transform.position;
		anguloInicial = transform.rotation;
		AutorizadorReset = true;


	}
	
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
				//points.puntos = 0;
			}
			if(rb.angularVelocity != Vector3.zero && transform.position != PosicionInicialPinos)
			{
				transform.position = AlmacenadoDePinos.position;

				print("si");

			}
		}

	}
}
