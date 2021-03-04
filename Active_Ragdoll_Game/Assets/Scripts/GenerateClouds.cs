using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Linq;

public class CloudData
{
  public Vector3 pos;
  public Vector3 scale;
  public Quaternion rot;
  private bool _isActive;

  //This prevents other classes from directly setting our isActive SV_Target

  public bool isActive
  {
    get
    {
      return _isActive;
    }
  }

  public int x;
  public int y;
  public float distFromCam;

  //Returns the Matrix4x4 of our CloudData
  public Matrix4x4 matrix
  {
    get
    {
      return Matrix4x4.TRS(pos, rot, scale);
    }
  }

  //Used to instanciate our cloud

  public CloudData(Vector3 pos, Vector3 scale, Quaternion rot, int x, int y, float distFromCam)
  {
    this.pos = pos;
    this.scale = scale;
    this.rot = rot;
    SetActive(true);
    this.x = x;
    this.y = y;
    this.distFromCam = distFromCam;
  }

  public void SetActive(bool destate)
  {
    _isActive = destate;
  }
}

public class GenerateClouds : MonoBehaviour{

  public Mesh cloudMesh;
  public Material cloudMat;
  //Cloud Data
  public float cloudSize = 5;
  public float maxScale = 1;
  //Noise Generation
  public float timeScale = 1;
  public float texScale = 1;
  //Cloud Scaling Info
  public float minNoiseSize = 0.5f;
  public float sizeScale = 0.25f;
  //Culling Data
  public Camera cam;
  public int maxDist;
  //Number of Batches
  public int batchesToCreate;
  private Vector3 prevCamPos;
  private float offsetx = 1;
  private float offsety = 1;
  private List<List<CloudData>> batches = new List<List<CloudData>>();
  private List<List<CloudData>> batchesToUpdate = new List<List<CloudData>>();

private void Start()
{
  for(int batchesX = 0; batchesX < batchesToCreate; batchesX++){
    for(int batchesY = 0; batchesY < batchesToCreate; batchesY++){
        BuildCloudBatch(batchesX, batchesY);
    }
  }
}

private void BuildCloudBatch(int xLoop, int yLoop){
  //Mark a batch if it's within the range of our camera
  bool markBatch = false;
  //This is our current cloud batch that we're brewing
  List<CloudData> currBatch = new List<CloudData>();

  for (int x = 0; x < 31; x++)
  {
    for (int y = 0; y < 31; y++)
    {
      //Add a cloud for each loop
      AddCloud(currBatch, x + xLoop * 31, y + yLoop * 31);
    }
  }
  //Check if the batch should be marked
  markBatch = CheckForActiveBatch(currBatch);
  //Add the newest batch to the batches list
  batches.Add(currBatch);
  //If the batch is marked add it to the batchesToUpdate list
  if(markBatch) batchesToUpdate.Add(currBatch);
}

/*This method checks to see if the current batch has a cloud that is within our cameras range
Return true if a cloud is within range
Return false if no clouds are within range
*/

private bool CheckForActiveBatch(List<CloudData> batch){
  foreach (var cloud in batch)
  {
    cloud.distFromCam = Vector3.Distance(cloud.pos, cam.transform.position);
    if (cloud.distFromCam < maxDist) return true;
  }
  return false;
}

//This method created our clouds as a CloudData object
private void AddCloud(List<CloudData> currBatch, int x, int y)
{
  //First we set our new clouds position
  Vector3 position = new Vector3(transform.position.x + x * cloudSize, transform.position.y, transform.position.z + y * cloudSize);

  //We set our new clouds distance to the camera so we can use it later
  float distToCam = Vector3.Distance(new Vector3(x, transform.position.y, y), cam.transform.position);
}
}
