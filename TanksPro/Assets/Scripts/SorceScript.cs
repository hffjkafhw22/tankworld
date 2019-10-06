using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SorceScript : MonoBehaviour {

    public Text SorceTest;//score
    public Text SCORE;//score dashboard in the end
    public GameObject diePanel;
    public GameObject Panel;
    public  int enmeycount;
	// Use this for initialization
	void Awake () {
        SorceTest.text = "Score:";
        enmeycount = 0;
	}
	
	// Update is called once per frame
	void Update () {
        SorceTest.text = "Score:" + 50 * enmeycount;
        SCORE .text = "SCORE:" + 50 * enmeycount+"\nＧＡＭＥ　ＯＶＥＲ！";

    }
}
