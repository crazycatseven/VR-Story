using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneTransitionManager : MonoBehaviour
{
    public FadeScreen FadeScreen;
    public void GoToScene(int sceneIndex)
    {
        StartCoroutine(GoToSceneRoutine(sceneIndex));
    }

    IEnumerator GoToSceneRoutine(int sceneIndex)
    {
        FadeScreen.FadeOut();
        yield return new WaitForSeconds(FadeScreen.fadeDuration);
        
        //Launch the new scene
        SceneManager.LoadScene(sceneIndex);
    }
}
