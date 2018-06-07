using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class exit : MonoBehaviour {

    public void OnMouseDown()
    {
            Application.Quit();
            Debug.Log("hasta pronto salio del juego");
    }
}
