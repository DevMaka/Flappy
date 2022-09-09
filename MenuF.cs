
using UnityEngine;
using UnityEngine.SceneManagement;


public class MenuF : MonoBehaviour
{
    
    public void PlayGame(){


        SceneManager.LoadScene(1); 

    }
    public void QuitGame(){
        Application.Quit();
    }
}
