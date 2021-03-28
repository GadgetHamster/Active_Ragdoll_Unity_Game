using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class placeRand : MonoBehaviour
{
  public float randPlace;

  int layerMask = 1 << 9;

        // Does the ray intersect any objects excluding the player layer


  public void spawnObject(){
    RaycastHit hit;
    Vector3 down = transform.TransformDirection(Vector3.down);

    randPlace = Random.Range(0f, 1500f);
    this.transform.position = new Vector3 (randPlace, 100f, randPlace);

    if (Physics.Raycast(transform.position, transform.TransformDirection(Vector3.down), out hit, 95f, layerMask))
      {
          Debug.DrawRay(transform.position, transform.TransformDirection(Vector3.forward) * hit.distance, Color.yellow);
          Debug.Log("Did Hit");
          return;
      }
    else
      {
          Debug.DrawRay(transform.position, transform.TransformDirection(Vector3.forward) * 1000, Color.white);
          Debug.Log("Did not Hit");
          spawnObject();
      }

  }
    // Start is called before the first frame update
    void Start()
    {
  //    randPlace = Random.Range(0f, 1000f);
  //    this.transform.position = new Vector3 (randPlace, 50f, randPlace);
  spawnObject();

    }

    // Update is called once per frame
    void Update()
    {

    }
}
