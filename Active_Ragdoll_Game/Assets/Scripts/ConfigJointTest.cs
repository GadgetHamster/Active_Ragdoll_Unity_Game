using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ConfigJointTest : MonoBehaviour
{
  ActiveRagdollAnimator aRagAnim;
  ActiveRagdoll aRag;

  public int positionSpringStrength;
  public Vector3 targetPosition;
  ConfigurableJoint joint;
  JointDrive drive;
  JointDrive regDrive;
    // Start is called before the first frame update
    void Start()
    {
    aRagAnim = (ActiveRagdollAnimator)FindObjectOfType(typeof(ActiveRagdollAnimator));
    aRag = (ActiveRagdoll)FindObjectOfType(typeof(ActiveRagdoll));
    joint = gameObject.GetComponent<ConfigurableJoint>();
    Debug.Log(joint.zDrive);

    drive = new JointDrive();
    drive.positionSpring = 100;
    regDrive = new JointDrive();
    regDrive.positionSpring = positionSpringStrength;
//    regDrive. maximumForce = 1000000;
//    regDrive. maximumForce = 1000000;
    }

    // Update is called once per frame
    void Update()
    {

      if (Input.GetKey(KeyCode.O)){
        aRagAnim.enabled = false;
        aRag.enabled = false;
        drive. maximumForce = 1000000;
      //  joint.enableCollision = true;
        joint.angularXDrive = drive;
        joint.angularYZDrive = drive;
        regDrive. maximumForce = 1000000;
      }
      else if (Input.GetKey(KeyCode.L)){
        aRagAnim.enabled = true;
        aRag.enabled = true;
      //  joint.enableCollision = false;
        joint.angularXDrive = regDrive;
        joint.angularYZDrive = regDrive;
        //regDrive. maximumForce = 1000000;
      //  regDrive. maximumForce = 1000000;

      }



    }
}
