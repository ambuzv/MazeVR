using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Key : MonoBehaviour 
{
	public GameObject KeyPoofPrefab;//Create a reference to the KeyPoofPrefab and Door
	public GameObject Keyy;
	public Door door;
	bool KeyCollected;


	//void Update()
	//{
		//Not required, but for fun why not try adding a Key Floating Animation here :)
	//}

	public void OnKeyClicked()
	{
		Instantiate (KeyPoofPrefab, Keyy.transform.position, Keyy.transform.rotation * Quaternion.Euler (-90f, 0, 0));	// Instatiate the KeyPoof Prefab where this key is located
        // Make sure the poof animates vertically
		door.Unlock();// Call the Unlock() method on the Door
		KeyCollected = true;	// Set the Key Collected Variable to true
		Destroy (Keyy);	// Destroy the key. Check the Unity documentation on how to use Destroy
    }

}
