using UnityEngine;
using System.Collections;

public class NumberWizard : MonoBehaviour {
	int max;
	int min;
	int guess;

	void Guess () {
		print ("Is the number higher or lower than " + guess + "?");
		print ("Up = higher, down = lower, return = equal");
		
	}
	
	// Use this for initialization
	void Start () {
		max = 1000;
		min = 1;
		guess = 500;

		
		print ("Welcome to Number Wizard");
		print ("Pick a number in your head, but don't tell me");
		print ("The highest number you can pick is " + max);
		print ("The smallest number you can pick is " + min);
		max += 1;

		Guess ();
	}
	
	// Update is called once per frame
	void Update () {
		if (Input.GetKeyDown(KeyCode.UpArrow)) {
			//print ("Up arrow pressed");
			min = guess;
			guess = (max+min) / 2;
			Guess ();
		}
		else if (Input.GetKeyDown(KeyCode.DownArrow)) {
			//print ("Down arrow pressed");
			max = guess;
			guess = (max+min) / 2;
			Guess ();
		}
		else if (Input.GetKeyDown(KeyCode.Return)) {
			print ("I won!");
			print ("======================");
			Start();
		}
	}
}
