using UnityEngine;
using UnityEngine.SceneManagement;

public class LevelManager : MonoBehaviour
{
      public string level1;
      public string level2;
      public string level3;
  
      public void LoadLevel1()
      {
        SceneManager.LoadScene(level1);
      }

       public void LoadLevel2()
       {
          SceneManager.LoadScene(level2);
       }

         public void Loadlevel3()
         {
               SceneManager.LoadScence(level3);
         }

}