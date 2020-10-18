using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class changeScene : MonoBehaviour
{
    public void changeMenuScene(string scenename){
    	Application.LoadLevel(scenename);

    }
}

