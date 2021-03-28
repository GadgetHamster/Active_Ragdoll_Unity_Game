using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RandomRockRot : MonoBehaviour
{
  public float rockRot;
    // Start is called before the first frame update
    void Start()
    {
      rockRot = Random.Range(0f, 360f);
      transform.Rotate(Vector3.up * rockRot);
    }

    // Update is called once per frame
    void Update()
    {

    }
}
