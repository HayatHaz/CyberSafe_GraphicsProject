using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class MainMenu : MonoBehaviour
{
   public void PlayGame(){
    SceneManager.LoadSceneAsync(1);
   }
public void About(){
    SceneManager.LoadSceneAsync(2);
   }
public void Exit(){
    SceneManager.LoadSceneAsync(0);
   }
   public void Back(){
    SceneManager.LoadSceneAsync(0);
   }

}