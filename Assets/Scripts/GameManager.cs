using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour {

	public static GameManager Instance {get; private set; }

    //interaction level
    public int socialized = 0;
    //number of partygoers turned
    public int numTurned = 0;
    
    public int minTurnRate;
    public int maxTurnRate;
    public bool turningActive = true;
    
    public List<string> notVisible = new List<string>();

    public float eyeIntensity = 5;

	private void Awake () {
		if (Instance == null) {
			Instance = this;
			DontDestroyOnLoad(gameObject);
		} else {
			Destroy(gameObject);
		}

        //Start Guest Turner Corountine
        StartCoroutine("Countdown");

	}

    void turnPartyGuest(){
        if(notVisible.Count > 0) {
            int randInt = Random.Range(0, notVisible.Count);
            GameObject vic = GameObject.Find(notVisible[randInt]);
            vic.GetComponent<GuestTracker>().GetTurned();
        }

        //set head to follow
        //set eyes to blue
        //update total
        //contort and freeze
        //reduce sound
    }


    IEnumerator Countdown(){

        while(turningActive){
            int waitTime = Random.Range(minTurnRate, maxTurnRate);
            yield return new WaitForSeconds(waitTime);
            Debug.Log("Party Goer Turning. Time waited: " + waitTime);
            turnPartyGuest();
        }
    }

}
