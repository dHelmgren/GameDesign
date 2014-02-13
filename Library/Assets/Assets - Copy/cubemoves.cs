using UnityEngine;
using System.Collections;

public class cubemoves : MonoBehaviour {
	public float Speed = -6.0f;
	public float tumble;
	public int count =0;
	// Use this for initialization
		void  start()
	{
		}
	// Update is called once per frame
	void FixedUpdate () 
	{
		if (count < 50) {
						rigidbody.velocity = new Vector3 (0.0f, Speed, 0.0f);
				} else if (count < 100 && count > 50) {
						rigidbody.velocity = new Vector3 (0.0f, -Speed, 0.0f);
				} else {
				}
		if (count == 100) {
			count = 0;
				}
		count++;
	}
}
