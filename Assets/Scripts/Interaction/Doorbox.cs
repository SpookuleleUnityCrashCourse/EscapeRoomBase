using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Doorbox : MonoBehaviour, IInteractable
{
	public GameObject doorObject;
	
	public void OnInteract()
	{
		Destroy(doorObject);
	}

	public string GetPrompt()
	{
		return "Destroy Wall";
	}
}