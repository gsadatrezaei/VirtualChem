using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class instO : MonoBehaviour
{
    // Start is called before the first frame update
    public GameObject molecule;
    public Transform newpos;
    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.D))
        {
            GameObject mol = Instantiate(molecule, newpos.position, Quaternion.identity);
            mol.transform.localScale = new Vector3(17, 17, 17);
        }
    }
}
