using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class QuitApp : MonoBehaviour
{
    public void doquit()
    {
        Debug.Log("has quit the application");
        Application.Quit();
    }
}
