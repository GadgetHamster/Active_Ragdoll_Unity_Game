using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class domeShrink : MonoBehaviour
{
  public float domeShrinkRate = 50f;
  public float domeSize = 0f;
  public bool isShrinking = true;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
      if(isShrinking == true && domeSize < 8000f)
      {
        domeSize = domeSize + domeShrinkRate;
        this.transform.localScale = new Vector3(10000f - domeSize, 10000f - domeSize, 100000f);
      }
      else{
        isShrinking = false;
        this.transform.localScale = new Vector3(10000f - domeSize, 10000f - domeSize, 100000f);
      }
    }
}
