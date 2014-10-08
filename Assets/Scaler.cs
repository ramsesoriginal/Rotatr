using UnityEngine;
using System.Collections;

public class Scaler : MonoBehaviour {
	
	public float scale = 0.1f;
	public Prefabholder prefab;
	
	void FixedUpdate()
	{
		transform.localScale = transform.localScale * scale ;
		if (transform.localScale.magnitude < 0.5f) {
			Destroy(gameObject);
			var go = (GameObject) Instantiate(prefab.prefab, transform.position, transform.rotation);
			go.transform.localScale=transform.localScale*128;
		}
	}
	// Use this for initialization
	void Start () {
	
	}

}
