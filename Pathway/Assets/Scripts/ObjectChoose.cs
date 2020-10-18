using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class ObjectChoose : MonoBehaviour
{
    public GameObject screen;

    private void OnCollisionEnter(Collision other)
    {
    	if (other.gameObject.name == "Door(Clone)") {
			SceneManager.LoadScene (sceneName: screen.name);
			print("Hit door");
    	}

    }
}
