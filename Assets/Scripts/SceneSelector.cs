using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneSelector : MonoBehaviour
{
    public int idScene;

    public void sceneSelector(){
        SceneManager.LoadScene(idScene);
    }
}
