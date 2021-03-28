using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Threading;

public class EyeBlinking : MonoBehaviour
{
  BlinkVariables Blink;

void Start()
{
  Blink = (BlinkVariables)FindObjectOfType(typeof(BlinkVariables));

}

    // Update is called once per frame
    void Update()
    {
        if(Blink.BlinkStart + Blink.BlinkDuration > Time.time)
        {
          this.transform.localScale = new Vector3(0.003f, 0.003f, 0.003f);
        }

        else
        {
          this.transform.localScale = new Vector3(0.003f, 0.001f, 0.003f);
        }
    }
}
