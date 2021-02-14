using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ConfigJointTest : MonoBehaviour
{
  public int positionSpringStrength;
  public Vector3 targetPosition;
  ConfigurableJoint joint;
  JointDrive drive;
  JointDrive regDrive;
    // Start is called before the first frame update
    void Start()
    {
    joint = gameObject.GetComponent<ConfigurableJoint>();
    Debug.Log(joint.zDrive);

    drive = new JointDrive();
    drive.positionSpring = 0;
    regDrive = new JointDrive();
    regDrive.positionSpring = positionSpringStrength;
    regDrive. maximumForce = 1000000;
    regDrive. maximumForce = 1000000;
    }

    // Update is called once per frame
    void Update()
    {

      if (Input.GetKey(KeyCode.O)){
        joint.enableCollision = true;
        joint.angularXDrive = drive;
        joint.angularYZDrive = drive;
      }
      else if (Input.GetKey(KeyCode.L)){
        joint.enableCollision = false;
        joint.angularXDrive = regDrive;
        joint.angularYZDrive = regDrive;
        //regDrive. maximumForce = 1000000;
      //  regDrive. maximumForce = 1000000;

      }



    }
}
