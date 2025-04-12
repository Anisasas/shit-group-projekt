using UnityEngine;
using UnityEngine.SceneManagement;

public class DoorSceneLoader : MonoBehaviour
{
    public string sceneToLoad = "Level1";

    private void OnMouseDown()
    {
        SceneManager.LoadScene(sceneToLoad);
    }
}
