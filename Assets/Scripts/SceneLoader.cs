using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneLoader : MonoBehaviour
{
    public void LoadLevel1Scene()
    {
        StartCoroutine(LoadAndStartLevel1());
    }

    public void LoadLevel2Scene()
    {
        StartCoroutine(LoadAndStartLevel2());
    }

    public void LoadMainMenuScene()
    {
        StartCoroutine(LoadAndStartMainMenu());
    }
    private IEnumerator LoadAndStartLevel1()
    {
        yield return Load(Scenes.LEVEL_1);
        yield return new WaitForSeconds(2);

    }

    private IEnumerator LoadAndStartLevel2()
    {
        yield return Load(Scenes.LEVEL_2);
        yield return new WaitForSeconds(2);

    }

    private IEnumerator LoadAndStartMainMenu()
    {
        yield return Load(Scenes.MAIN_MENU);
        yield return new WaitForSeconds(2);

    }

    private IEnumerator Load(string sceneName)
    {
        yield return SceneManager.LoadSceneAsync(sceneName);
    }
}
