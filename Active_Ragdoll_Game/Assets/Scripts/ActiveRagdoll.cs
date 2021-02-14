using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ActiveRagdoll : MonoBehaviour
{
public Quaternion pelvisYRot;

public float speed;
public float strafeSpeed;
public float jumpForce;

public Rigidbody chest;

public bool isGrounded = true;

  // Start is called before the first frame update
void Start()
  {
    chest = GetComponent<Rigidbody>();
  }

private void FixedUpdate()
  {
/////////////////////////////
    if (Input.GetKey(KeyCode.W))
    {
      if (Input.GetKey(KeyCode.LeftShift))
    {
    chest.AddForce(-chest.transform.forward * speed * 1.5f);
    }
    else
    {
      chest.AddForce(-chest.transform.forward * speed);
    }
  }
///////////////////////////////////////////////
  if (Input.GetKey(KeyCode.S))
  {
  chest.AddForce(chest.transform.forward * strafeSpeed);
  }
  if (Input.GetKey(KeyCode.D))
  {
  chest.AddForce(-chest.transform.right * speed);
  }if (Input.GetKey(KeyCode.A))
  {
  chest.AddForce(chest.transform.right * strafeSpeed);
  }
//////////////////////////////////////////////////////
  if(Input.GetKey(KeyCode.Space))
  {
     if (isGrounded)
     {
       chest.AddForce(new Vector3(0, jumpForce, 0));
       isGrounded = false;
     }
  }

  }













    // Update is called once per frame
    void Update()
    {

    }
}
