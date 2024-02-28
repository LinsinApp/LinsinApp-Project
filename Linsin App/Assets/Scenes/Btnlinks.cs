using UnityEngine;

public class Btnlinks : MonoBehaviour
{
    public string youtubeLink;

    public void OpenYouTubeLink(string youtubeLink)
    {
        Application.OpenURL(youtubeLink);
    }
}
