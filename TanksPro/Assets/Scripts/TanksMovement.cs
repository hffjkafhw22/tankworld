using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TanksMovement : MonoBehaviour {

    public float speed = 5;
    public float angularSpeed = 6;
    public float number = 1;      //identify different player with number
    public AudioClip idleAudio;
    public AudioClip drivingAudio;

    private AudioSource audio;
    private Rigidbody rigidBody;
	// Use this for initialization
	void Start () {
        rigidBody = this.GetComponent<Rigidbody>();
        audio = this.GetComponent<AudioSource >();
	}
	
	// Update is called once per frame
	void FixedUpdate () {
        float v = Input.GetAxis("VerticalPlayer"+number );
        rigidBody.velocity = transform.forward * v * speed;//forward/ backword
        float h = Input.GetAxis("HorizontalPlayer"+number );
        rigidBody.angularVelocity = transform.up * h * angularSpeed;//left/right move

        if (Mathf.Abs(h) > 0.1 || Mathf.Abs(v) > 0.1)
        {
            audio.clip = drivingAudio;
            if(audio.isPlaying ==false)
                audio.Play();
        }
        else {
            audio.clip = idleAudio;
            if (audio.isPlaying == false)
                audio.Play();
        }
	}
}

