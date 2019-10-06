using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AITankAttack : MonoBehaviour {

    public float timer;
    private  Transform firePosition;
    public GameObject shell;
    public float min=1.0f;
    public float max=3.0f;
    public float speed;

    void Start()
    {
        firePosition = transform.Find("FirePosition");    // set up the fireposition 
    }
    
   
    public void Update()
    {
        timer += Time.deltaTime * Random.Range(min,max);
        if (timer>4) {
            GameObject go = GameObject.Instantiate(shell, firePosition.position, firePosition.rotation) as GameObject;
            go.GetComponent<Rigidbody>().velocity = transform.forward * speed;             
            timer = 0;
        }
    }
}
