using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ConfigJointTest : MonoBehaviour
{
  public CopyMotion CMotion;
  ActiveRagdoll aRag;
  WaterDetection WaterD;

  public int positionSpringStrength;
  public Vector3 targetPosition;
  ConfigurableJoint joint;
  JointDrive drive;
  JointDrive regDrive;

  void RagdollOn(){
    CMotion.enabled = false;
    aRag.enabled = false;
    drive. maximumForce = 1000000;
  //  joint.enableCollision = true;
    joint.angularXDrive = drive;
    joint.angularYZDrive = drive;
    regDrive. maximumForce = 1000000;
  }
  void RagdollOff(){
    CMotion.enabled = true;
    aRag.enabled = true;
  //  joint.enableCollision = false;
    joint.angularXDrive = regDrive;
    joint.angularYZDrive = regDrive;
    //regDrive. maximumForce = 1000000;
  //  regDrive. maximumForce = 1000000;
  }
    // Start is called before the first frame update
    void Start()
    {
    //CMotion = (CopyMotion)FindObjectOfType(typeof(CopyMotion));
    WaterD = (WaterDetection)FindObjectOfType(typeof(WaterDetection));
    aRag = (ActiveRagdoll)FindObjectOfType(typeof(ActiveRagdoll));
    joint = gameObject.GetComponent<ConfigurableJoint>();
    Debug.Log(joint.zDrive);

    drive = new JointDrive();
    drive.positionSpring = 100;
    regDrive = new JointDrive();
    regDrive.positionSpring = positionSpringStrength;
//    regDrive. maximumForce = 1000000;
//    regDrive. maximumForce = 1000000;
    RagdollOff();
    }

    // Update is called once per frame
    void Update()
    {
      if (WaterD.IsWaterlogged){
        RagdollOn();

      }
      else if (Input.GetKey(KeyCode.LeftControl)){
        RagdollOn();
      }
      else{
        RagdollOff();
      }




    }

}
