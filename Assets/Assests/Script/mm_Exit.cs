using UnityEngine;

public class QuitGame : MonoBehaviour
{
    public void thisIsAnExitFunction()
    {
        Debug.Log("Simulating Quit Function, if you see this then it is working");
        Application.Quit();
    }
}
