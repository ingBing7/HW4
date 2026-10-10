using UnityEngine;
using TMPro;
public class UpdateUI : MonoBehaviour
{
    public TextMeshProUGUI scoreCounter;

    public GameObject itsGameOverMan;

    public float currentScore = 0f;

    private void Start()
    {
        Locator.Instance.Player.BirdScored += UpdateScoreUI;
        Locator.Instance.Player.BirdDied += EnableGameOverScreen;
        scoreCounter.text = currentScore.ToString();
    }
    
    public void UpdateScoreUI()
    {
        currentScore++;
        scoreCounter.text = currentScore.ToString();
    }

    public void EnableGameOverScreen()
    {
        itsGameOverMan.SetActive(true);
    }

}
