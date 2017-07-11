using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class reset : MonoBehaviour {

	public GameObject pinos;
	public GameObject bola;

	private Vector3 PosicionInicialBola;
	private Vector3 PosicionInicialPinos;
	private Quaternion anguloInicial;

	void Start () 
	{
		PosicionInicialBola = bola.transform.position;
		PosicionInicialPinos = pinos.transform.position;
		anguloInicial = pinos.transform.rotation;
	}
	
	void Update () 
	{
		if (Input.GetKeyUp(KeyCode.R))
		{
			bola.GetComponent<Rigidbody> ().velocity = Vector3.zero;
			bola.GetComponent<Rigidbody> ().angularVelocity = Vector3.zero;

			pinos.GetComponent<Rigidbody> ().velocity = Vector3.zero;
			pinos.GetComponent<Rigidbody> ().angularVelocity = Vector3.zero;

			pinos.GetComponent<Rigidbody> ().MovePosition (PosicionInicialPinos);
			bola.GetComponent<Rigidbody> ().MovePosition (PosicionInicialBola);

			
		}


	}
}
