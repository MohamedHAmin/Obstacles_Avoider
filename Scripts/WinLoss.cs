using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class WinLoss : MonoBehaviour
{
   public void restart()
   {
        SceneManager.LoadScene(1);
   }
   public void QuitGame()
   {
        Application.Quit();
   }
}
