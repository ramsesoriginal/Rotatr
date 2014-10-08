using UnityEngine;
using System.Collections;

public class Rotater : MonoBehaviour {

	
	public float rotationsPerMinute = 10.0f;
	public float keyspeed = 6;


	void Update()
	{
		transform.Rotate(0,0, (( keyspeed * Input.GetAxis("Horizontal")) + 6.0f)*rotationsPerMinute*Time.deltaTime);
	}
}
