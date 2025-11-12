using UnityEngine;
using UnityEngine.UI;

public class ImageDisplayController : MonoBehaviour
{
    public GameObject imagePanel;        
    public Button showButton;            
    public Button closeButton;           

    void Start()
    {
        imagePanel.SetActive(false);

        showButton.onClick.AddListener(ShowImage);
        closeButton.onClick.AddListener(HideImage);
    }

    void ShowImage()
    {
        imagePanel.SetActive(true);
    }

    void HideImage()
    {
        imagePanel.SetActive(false);
    }
}
