using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Rotatev2 : MonoBehaviour
{
    public float smooth = 1f;
    private Vector3 targetAngles;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
       targetAngles = transform.eulerAngles + 180f * Vector3.up; 
       transform.eulerAngles = Vector3.Lerp(transform.eulerAngles, targetAngles, smooth*Time.deltaTime);
    }
}
