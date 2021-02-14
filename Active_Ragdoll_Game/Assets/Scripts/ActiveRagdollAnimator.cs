using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ActiveRagdollAnimator : MonoBehaviour
{
  void ChangeState(string stateName){
  //  Debug.Log(stateName);
    anim.SetTrigger(stateName);
  //  Debug.Log(stateName);
}
  public bool isMoving;
  public  Animator anim;

private ActiveRagdoll ARag;
    // Start is called before the first frame update
    void Start()
    {
      ARag = Object.FindObjectOfType<ActiveRagdoll>();
      anim = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
      anim.ResetTrigger("Movement");
      anim.ResetTrigger("Falling");

      if (Input.GetKey(KeyCode.W)){
        if( Input.GetKey(KeyCode.LeftShift)){
       anim.SetFloat("Vertical", 2f);
  //     isMoving = true;
       }
       else{
       anim.SetFloat("Vertical", 1f);
  //     isMoving = true;
       }
     }
     else{
       anim.SetFloat("Vertical", 0f);
    //   isMoving = false;
     }


     if (Input.GetKey(KeyCode.A) || Input.GetKey(KeyCode.D) || Input.GetKey(KeyCode.S)){
        anim.SetFloat("Vertical", 1f);
      }
      /*else{
      anim.SetFloat("movePercent", 0f);
      }*/

    if (ARag.isGrounded){
      ChangeState("Movement");
    }
    else{
      ChangeState("Falling");
    }

//    if (isMoving == true){
  //    ChangeState("Movement");
//    }


    }






    }
