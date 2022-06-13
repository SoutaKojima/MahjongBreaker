using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class StickFactory : MonoBehaviour
{
    public Object stick;

    private Vector3 position;
    private Vector3 worldposition;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        position = Input.mousePosition;
        worldposition = Camera.main.ScreenToWorldPoint(new Vector3(position.x,position.y,5f));
        if (Input.GetMouseButtonDown(0))
        {
            Object s = Instantiate(stick,worldposition,Quaternion.identity);
            s.GetComponent<Rigidbody>().velocity = new Vector3(0f,0f,10f);
        }
    }
}
