using UnityEngine; using UnityEngine.UI;

public class Score : MonoBehaviour
{

    public objec pScore;
    public Text scoreText;
    // Update is called once per frame
    void Update()
    {
        scoreText.text = pScore.counter.ToString();
    }
}
