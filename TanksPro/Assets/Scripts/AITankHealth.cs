using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class AITankHealth : MonoBehaviour
{

    public int hp = 100;//tank blood
    public GameObject tankExplosion;
    public AudioClip tankExplosionAudio;
    public Slider hpSlider;

    //public Text score;
    private int hpTotal;
    public SorceScript ss;//score
    // Use this for initialization
    void Start()
    {
        hpTotal = hp;
       
    }


    void Update()
    {

    }
    void TakeDamage()
    {
       
        hp -= Random.Range(30, 50);
        hpSlider.value = (float)hp / hpTotal;
        if (hp <= 0)
        { //if hp = 0, the target destroied
            AudioSource.PlayClipAtPoint(tankExplosionAudio, transform.position);
            ss.enmeycount++;
            transform.position = new Vector3(Random .Range(-35,35),0,Random .Range (-35,35));
            hp = 100;
            hpSlider.value = 1;
          
        }
    }
    

}
