using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PuntosDelPartido : MonoBehaviour {

	private Pino points;
	private ResetPinos Turno;
	private int[] arraypuntos;
	private int puntos;
	private int ronda;

	void Start () 
	{
		
	}
	
	void Update () 
	{
		
		if (Input.GetKeyDown (KeyCode.Q)) 
			{
				///Turno.ContadorTurno++;
				//arraypuntos [Turno.ContadorTurno] = points.puntos;
				//print (Turno.ContadorTurno);
				//print (points.puntos);
			}

		//points.puntos;
	}
}
