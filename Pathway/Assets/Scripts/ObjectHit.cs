using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObjectHit : MonoBehaviour
{
	public GameObject doorPrefab;
	public GameObject choice1;
	public GameObject choice2;


    private void OnCollisionEnter(Collision collision)
    {
        Destroy(choice1);
        Destroy(choice2);
        GameObject gameObject = Instantiate(doorPrefab, this.transform.position, doorPrefab.transform.rotation);
        gameObject.transform.position = new Vector3(0f, 2.04f, 7.94f);

    }
}
