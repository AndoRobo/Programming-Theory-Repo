using System.Collections;
using System.Collections.Generic;

using UnityEngine;
using UnityEngine.SceneManagement;
#if UNITY_EDITOR
using UnityEditor;
#endif
public class MainMenu : MonoBehaviour
{
    // Start is called before the first frame update
    public void StartNew()
    {
        // this will load  new scene 
        SceneManager.LoadScene(1);
    }
    

    public void Exit()
    {


#if UNITY_EDITOR
        EditorApplication.ExitPlaymode();
#else
        Application.Quit(); // original code to quit Unity player
#endif
    }
}
