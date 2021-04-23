using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class LoadScene : MonoBehaviour
{
    // Start is called before the first frame update
 public void Level1()
 {
     SceneManager.LoadScene(1);
     Debug.Log("Success");
 }

  public void Level2()
 {
     SceneManager.LoadScene(2);
     Debug.Log("Success");
 }

 
}
