using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CreateBlast : MonoBehaviour
{
    public Object blast;

    private bool flg = true;
    
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnCollisionEnter(Collision collision)
    {
        if (flg)
        {
            Instantiate(blast, transform.position, Quaternion.identity);
            GetComponent<AudioSource>().Play();
            flg = false;
        }
    }
}
