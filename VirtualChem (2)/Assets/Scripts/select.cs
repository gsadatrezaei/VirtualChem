using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class select : MonoBehaviour
{
    public void changeScene(string name)
    {
        Application.LoadLevel (name);

    }
}
