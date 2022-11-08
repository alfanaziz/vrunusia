using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PindahScene : MonoBehaviour
{
    public string namaScene;

    public void PindahkeScene()
    {
        Scene sceneini = SceneManager.GetActiveScene();

        if (sceneini.name != namaScene)
        {
            SceneManager.LoadScene(namaScene);
        }
    }

}