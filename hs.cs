using UnityEngine;using UnityEngine.UI;

public class hs : MonoBehaviour
{

    public Text hScore;

    // Update is called once per frame
    void Start()
    {
        hScore.text = PlayerPrefs.GetInt("highscore", 0).ToString();
    }
}
