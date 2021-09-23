using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Target : MonoBehaviour {

	public int health = 5;

	// Use this for initialization
	void Start () {
		
	}

	public void HitByBullet( int damage ) // process a message HitByBullet
	{
		health -= damage;
	}
	
	// Update is called once per frame
	void Update () {
		if (health < 1)
			Destroy(gameObject);
	}
}
