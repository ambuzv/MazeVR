using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Door : MonoBehaviour 
{
	public bool Locked;	// Create a boolean value called "locked" that can be checked in OnDoorClicked() 
	public bool opening;// Create a boolean value called "opening" that can be checked in Update() 

	public GameObject doorr;
	public AudioSource aSource;
	public AudioClip aSource1;
	public AudioClip aSource2;


	void Start() {
		Locked = true;
	}

    void Update() {
        	// If the door is opening and it is not fully raised
            // Animate the door raising up
		if (opening == true && doorr.transform.position.y < 8) {
			doorr.transform.Translate (0, Time.deltaTime , 0);
		}
    }

	public void OnDoorClicked() {
		if (Locked == false) {	
			print("true");						// If the door is clicked and unlocked
			opening = true;						// Set the "opening" boolean to true
			aSource.clip = 	aSource1;
			aSource.Play();		

		}
            
        
		if (Locked == true) { 
			print("false");// (optionally) Else
			aSource.clip = 	aSource2;
			aSource.Play (); // Play a sound to indicate the door is locked
		}
    }

    public void Unlock()
    {
		Locked = false; // You'll need to set "locked" to false here
    }
}
