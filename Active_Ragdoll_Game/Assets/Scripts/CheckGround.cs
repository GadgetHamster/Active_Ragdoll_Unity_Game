using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CheckGround : MonoBehaviour
{
public float distanceToGround = 2.4f;
public bool Grounded = false;
public ActiveRagdoll playerController;

int layermask = 1<<9;

    // Start is called before the first frame update
    void Start()
    {
      //distanceToGround = GetComponent<Collider> ().bounds.extents.y;

    }

    // Update is called once per frame
    void FixedUpdate()
    {
   if(!Physics.Raycast (transform.position, -Vector3.up, distanceToGround + 0.1f, layermask)){
     Grounded = false;
     print("we in the air!");
     playerController.isGrounded = false;
     playerController.speed = 200f;
     playerController.strafeSpeed = 200f;
   } else {
     if (Grounded == false){
       playerController.jumpTimer = Time.time;
     }
     Grounded = true;
     print("we on the ground!");
     playerController.isGrounded = true;
     playerController.speed = 300f;
     playerController.strafeSpeed = 250f;


   }





    }
}
