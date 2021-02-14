using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RagdollOnOff : MonoBehaviour
{
  public ConfigurableJoint joint;
  public Vector3 targetPosition;
  JointDrive drive;
    // Create a JointDrive, configure it and assign the JointDrive to
    // the zDrive element of a configurable joint.

    void Start()
    {
      joint = gameObject.GetComponent<ConfigurableJoint>();
      Debug.Log(joint.zDrive);

      drive = new JointDrive();
      drive.positionSpring = 0;
      //  ConfigurableJoint joint = gameObject.GetComponent<ConfigurableJoint>();
        joint.targetPosition = new Vector3(0, 0, -10);

      //  JointDrive drive = new JointDrive();
    //    drive.mode = JointDriveMode.Position;
    //    drive.positionSpring = 20;

      //  joint.zDrive = drive;
    }

    void Update(){
    if (Input.GetKey(KeyCode.P)){
    joint.breakForce = 0f;
    }
    if (Input.GetKey(KeyCode.O)){
      joint.zDrive = drive;
    }

    }

}
