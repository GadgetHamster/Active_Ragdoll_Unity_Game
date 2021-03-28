using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DayNightCycle : MonoBehaviour
{}
  /*
  public GameObject targetLight;
  public GameObject targetMainCamera;
  public Material[] skys;
  public float dayTimer;
  public bool isCycle;

  Color topColor0;
  Color horizonColor0;
  Color bottomColor0;

  float topColorFactor0;
  float bottomColorFactor0;
  float intensity0;


  Color topColor1;
  Color topColor2;
  Color topColor3;

  float topColor1Factor;


  [SerializeField] private float LerpTime = 10f;


    private void Awake()
    {
        targetLight = GameObject.FindGameObjectWithTag("Light");
        targetMainCamera = GameObject.FindGameObjectWithTag("MainCamera");
    }

    void Start()
    {
        dayTimer = targetLight.GetComponent<Light>().intensity;

        topColor0 = Noon.GetColor("Top Color");
        horizonColor0 = Noon.GetColor("Horizon Color");
        bottomColor0 = Noon.GetColor("Bottom Color");

        topColor1 = skys[1].GetColor("Top Color");

    }

    void Update()
    {
       if(!isCycle)
       {
       targetLight.GetComponent<Light>().intensity = dayTimer -= Time.deltaTime * 0.3f;
          if(dayTimer <= 0)
          {
             isCycle = true;
          }
       }

       else if(isCycle)
       {
         targetLight.GetComponent<Light>().intensity = dayTimer += Time.deltaTime * 0.3f;

         if(dayTimer >= 1)
         {
           isCycle = false;
         }
       }
       ChangeCycle();
    }

    void ChangeCycle()
    {
       if(dayTimer >= 0.9f)
       {
         targetMainCamera.GetComponent<Skybox>().material = Mathf.Lerp(topColor0.r, topColor1.r, LerpTime);
         targetMainCamera.GetComponent<Skybox>().material = Mathf.Lerp(topColor0.g, topColor1.g, LerpTime);
         targetMainCamera.GetComponent<Skybox>().material = Mathf.Lerp(topColor0.b, topColor1.b, LerpTime);

       } else  if(dayTimer >= 0.5f)
        {
        //  targetMainCamera.GetComponent<Skybox>().material = skys[1];
        } else  if(dayTimer >= 0.3f)
         {
        //   targetMainCamera.GetComponent<Skybox>().material = skys[2];
         } else  if(dayTimer >= 0.1f)
          {
        //    targetMainCamera.GetComponent<Skybox>().material = skys[3];
          }
    }

//Mathf.Lerp(skys[0], skys[1], 1)













}
*/
