using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChangeColor : MonoBehaviour {

    public Color tankColor;
    private  Renderer renderer;

	// Use this for initialization 
	void Start () {
        renderer = GetComponent<Renderer >();
        renderer.material.color = tankColor;
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
