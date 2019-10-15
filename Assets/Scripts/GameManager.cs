using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour {

	public static GameManager Instance {get; private set; }

    //interaction level
    public int socialized = 0;
    //number of partygoers turned
    public int numTurned = 0;

    public float eyeIntensity = 5;

	private void Awake () {
		if (Instance == null) {
			Instance = this;
			DontDestroyOnLoad(gameObject);
		} else {
			Destroy(gameObject);
		}
	}
}
