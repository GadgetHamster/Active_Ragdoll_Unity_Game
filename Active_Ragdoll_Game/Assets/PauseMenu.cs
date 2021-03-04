using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class PauseMenu : MonoBehaviour
{
    public bool isRagdoll = false;
    ActiveRagdollAnimator aRagAnim;
    ActiveRagdoll aRag;
    public static bool GameIsPaused = false;

    public GameObject pauseMenuUI;

    void Start()
    {
      Cursor.visible = false;
      aRagAnim = (ActiveRagdollAnimator)FindObjectOfType(typeof(ActiveRagdollAnimator));
      aRag = (ActiveRagdoll)FindObjectOfType(typeof(ActiveRagdoll));
    }
    // Update is called once per frame
    void Update()
    {
  if (Input.GetKey(KeyCode.O)){
    isRagdoll = true;
  }
  else if (Input.GetKey(KeyCode.L)){
    isRagdoll = false;
  }
///////////////////////////
      if (Input.GetKeyDown(KeyCode.Escape))
      {
        if(GameIsPaused && isRagdoll == false)
        {
          aRag.enabled = true;
          Cursor.visible = false;
          Resume();
        }
        else if (GameIsPaused && isRagdoll == true)
        {
          aRag.enabled = false;
          Cursor.visible = false;
          Resume();
        } else
        {
          aRag.enabled = false;
          Pause();
        }
      }





    }

    public void Resume()
    {
      aRagAnim.anim.SetFloat("Vertical", 1f);
      Cursor.visible = false;
      aRagAnim.enabled = true;
      pauseMenuUI.SetActive(false);
      //Time.timeScale = 1f;
      GameIsPaused = false;
    }
    void Pause()
    {
       aRagAnim.anim.SetFloat("Vertical", 0f);
       Cursor.visible = true;
       aRagAnim.enabled = false;
       pauseMenuUI.SetActive(true);
       //Time.timeScale = 0f;
       GameIsPaused = true;
    }
    public void RestartScene()
    {
    //Time.timeScale = 1f;
    SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }
    public void QuitGame()
    {
      Debug.Log("Quitting Game...");
      Application.Quit();
    }
}
