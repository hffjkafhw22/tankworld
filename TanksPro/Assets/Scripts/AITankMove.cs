using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AITankMove : MonoBehaviour {

    public float speed;
    public Transform player;
    public float timer;//Timer
    public float turnToPlayer=3;//AI tank chases the playtank
    public float go=8;//ai tank does not chase the playtank
    public bool isTurn=false ;//whether turn around
	// Use this for initialization
	void Start () {
    }
    private void Update()
    {
        //transform.Translate(Vector3.forward * Time.deltaTime * speed);
        timer += Time.deltaTime;

        //Timely to chase to teh player
        if (timer < go)
        {
            if (timer < turnToPlayer)
            {
                transform.LookAt(player);
            }
            else if (!isTurn)
            {
                transform.Rotate(new Vector3(0, Random.Range(225, 315), 0));
                isTurn = true;
            }
            transform.Translate(Vector3.forward * Time.deltaTime * speed);
        }
        else
        {
            isTurn = false;
            timer = 0;
        }
    }

    public void OnCollisionEnter(Collision collision)
    {
        if (collision.collider .tag!="ground") {
            transform.Rotate(new Vector3 (0,Random .Range (225,315),0));
        }
    }
}
