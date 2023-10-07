using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Dropper : MonoBehaviour
{

        [SerializeField] float timeToWait = 5f;
        MeshRenderer renderer;
        Rigidbody rigidbody;
     
    // Start is called before the first frame update
    void Start()
    {
        renderer = GetComponent<MeshRenderer>();
        rigidbody = GetComponent<Rigidbody>();
        renderer.enabled = false;
        rigidbody.useGravity = false;
    }

    // Update is called once per frame
    void Update()
    {
       // Debug.Log(Time.time);
        DropTheObj();

    }

    void DropTheObj()
    {
        if (Time.time > timeToWait) 
        {
            rigidbody.useGravity = true;
            renderer.enabled = true;
        }
        else
        {
            return;
        }
    }
}
