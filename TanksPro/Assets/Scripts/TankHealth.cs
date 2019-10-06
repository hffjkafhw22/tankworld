using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TankHealth : MonoBehaviour {

    public int hp = 100;//tank blood
    public GameObject tankExplosion;//fire effects
    public AudioClip tankExplosionAudio;//explosion effects
    public Slider hpSlider;

    public SorceScript ss;
    private int hpTotal;

	// Use this for initialization
	void Start () {
        hpTotal = hp;
	}
	
	// Update is called once per frame
	void Update () {
		
	}
    void TakeDamage() {
        if (hp <= 0) return;
        hp -= Random.Range(5,10);
        hpSlider.value = (float)hp / hpTotal;
        if (hp<=0) { //if hp = 0 and target destroied
            AudioSource.PlayClipAtPoint(tankExplosionAudio ,transform .position );//audio source 
            GameObject.Instantiate(tankExplosion ,transform .position +Vector3 .up,transform .rotation );
            GameObject.Destroy(this.gameObject );//destroy tank
            //dash board
            ss.Panel.SetActive(false);
            ss.diePanel.SetActive (true);
        }
    }
}
