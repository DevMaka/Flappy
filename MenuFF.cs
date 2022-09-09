
using UnityEngine;
using UnityEngine.SceneManagement;


public class MenuFF : MonoBehaviour
{
    
    public void PlayGame1(){


        SceneManager.LoadScene(0); 

    }
    public void QuitGame1(){
        Application.Quit();
    }
}
