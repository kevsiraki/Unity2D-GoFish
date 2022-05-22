using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RTest : MonoBehaviour
{
	public void ChangeScene(string sceneName)
    {
        Application.LoadLevel(sceneName);
    }
	public void exit(bool yes) {
		Application.Quit();
	}
}