using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BlinkVariables : MonoBehaviour
{
  public float BlinkStart = 0;
  public float BlinkDuration;

    // Start is called before the first frame update
    void Start()
    {
      BlinkDuration = Random.Range(1.0f, 5.0f);
    }

    // Update is called once per frame
    void LateUpdate()
    {
      if(BlinkStart + BlinkDuration + 0.5f < Time.time)
     {
       BlinkStart = Time.time;
       BlinkDuration = Random.Range(1.0f, 5.0f);
     }
    }
}
