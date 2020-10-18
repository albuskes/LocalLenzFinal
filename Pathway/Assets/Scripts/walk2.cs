using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class walk2 : MonoBehaviour
{
    // Start is called before the first frame update
    public float speed = 12;
 // Update is called once per frame
 void Update()
 {
     if (Input.GetKey("a"))
     {
         Translate(Vector3.left);
     }
     if (Input.GetKey("d"))
     {
         Translate(Vector3.right);
     }
     if (Input.GetKey("w"))
     {
         Translate(Vector3.forward);
     }
     if (Input.GetKey("s"))
     {
         Translate(Vector3.back);
     }
 }
 private void Translate(Vector3 direction)
 {
     direction = transform.TransformDirection(direction);
     direction = Vector3.ProjectOnPlane(direction, Vector3.up).normalized;
     transform.Translate(direction * Time.deltaTime * speed, Space.World);
 }
}
