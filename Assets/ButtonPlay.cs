using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class ButtonPlay : MonoBehaviour
{
    public Button play;

    void loadScene(){
        SceneManager.LoadScene(1);
        Debug.Log("load scene");
    }
    
    void Start()
    {
        play.onClick.AddListener(onClick);
    }
    
    public void onClick(){
        Debug.Log("onClick");
        loadScene();
    }
}
