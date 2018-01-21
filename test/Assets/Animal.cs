using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Animal : MonoBehaviour {

	// Use this for initialization
	void Start () {
        print("I love my cat.");
        print("No, I really don't.");
		
	}
	
	// Update is called once per frame
	void Update () {
	}

	void OnMouseDown()
	{
		print("Meow.");
	}
}
