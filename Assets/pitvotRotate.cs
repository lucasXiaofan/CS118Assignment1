using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class pitvotRotate : MonoBehaviour
{

    [SerializeField] Transform open;
    [SerializeField] Transform close;

    bool closed = true;
    public void closeOpendoor()
    {
        if (closed) // do open
        {
            transform.rotation = Quaternion.Slerp(close.rotation, open.rotation, Time.deltaTime);
        }
        else
        {
            transform.rotation = Quaternion.Slerp(open.rotation, close.rotation, Time.deltaTime);
        }
        closed = !closed;
    }
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }
}
