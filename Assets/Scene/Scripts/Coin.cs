using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Coin : MonoBehaviour 
{
    //Create a reference to the CoinPoofPrefab
	public GameObject CoinPoofPrefab;	
	public GameObject Coinn;
		


	public void OnCoinClicked() {
			
		Instantiate(CoinPoofPrefab, Coinn.transform.position, Quaternion.identity * Quaternion.Euler(-90f,0,0)); 	// Instantiate the CoinPoof Prefab where this coin is located
																													// Make sure the poof animates vertically
		Destroy (Coinn);	// Destroy this coin. Check the Unity documentation on how to use Destroy
	} 



}
