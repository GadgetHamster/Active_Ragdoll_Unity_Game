using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CopyMotion : MonoBehaviour
{
  public Transform targetLimb;
  public bool mirror;
  ConfigurableJoint cj;
  public bool flipZ;
  public bool flipW;
  Quaternion startRot;
  Quaternion newRot;
    // Start is called before the first frame update
    void Start()
    {
     startRot =transform.localRotation;
      //  startRot = Quaternion.identity;
      cj = GetComponent<ConfigurableJoint>();
    }

    // Update is called once per frame
    void Update()
    {
    //Quaternion Output;
      if (!mirror)
      {
        cj.targetRotation = targetLimb.localRotation * startRot;
      //  Debug.Log(targetLimb.localEulerAngles);
      }
      else
      {
        cj.targetRotation = Quaternion.Inverse(targetLimb.localRotation) * startRot;
      }


    }
}
