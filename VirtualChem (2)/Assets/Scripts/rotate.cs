using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class rotate : MonoBehaviour
{
    //public float degrees = 10;
    // Start is called before the first frame update
    void Start()
    {
        
    }
    public float mouseRoateSpeed = 15f;

    //private void OnMouseDrag()
    //{
      //  transform.rotation = Quaternion.AngleAxis (-Input.GetAxis("Mouse X")*
        //    mouseRoateSpeed, Camera.main.transform.up) *
          //  Quaternion.AngleAxis(Input.GetAxis("Mouse Y") * mouseRoateSpeed, Camera.main.transform.right) *
            //                  transform.rotation;
    //}
    void OnMouseDrag()
    {
        if (Input.GetKeyDown(KeyCode.DownArrow))
        {
            transform.Rotate(10, 10, 0, Space.World);
        }
        if (Input.GetKeyDown(KeyCode.UpArrow))
        {
            transform.Rotate(-10, 10, 0, Space.World);
        }
    }

    // Update is called once per frame
    //void Update()
    //{
    //if (Input.GetKey(KeyCode.LeftArrow))
    //{
    //   Vector3 to = new Vector3(10, 0, 0);

    //            transform.eulerAngles = Vector3.Lerp(transform.rotation.eulerAngles, to, Time.deltaTime);
    //      }
    //   if (Input.GetKey(KeyCode.RightArrow))
    // {
    //   Vector3 to = new Vector3(-10, 0, 0);

    // transform.eulerAngles = Vector3.Lerp(transform.rotation.eulerAngles, to, Time.deltaTime);
    //}
    //}


}
