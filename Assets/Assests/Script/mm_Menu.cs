using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayButton : MonoBehaviour
{
    public void ThisFunctionIsMadeToPlayTheGameAndIsMadeStupidlyLongSoIcanDistinquishBetweenOtherFunctions() {
        SceneManager.LoadSceneAsync(1);
    }
}