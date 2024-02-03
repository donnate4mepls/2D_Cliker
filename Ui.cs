using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Ui : MonoBehaviour

{
    public static Ui singleton;
    // Start is called before the first frame update
    public GameObject panel;
    public Text score;
    public Text victoryText;
    public Text loseText;
    public Text TotalScore;

    private void Awake()
    {
        singleton = this;
    }

    //Обновление счёта
    // Update is called once per frame
    void Update()
    {
        score.text = Player.score.ToString();
    }
    //Победа
   public static void Victory()
    {
        singleton.panel.SetActive(true);
        singleton.victoryText.gameObject.SetActive(true);
        singleton.TotalScore.text = Player.score.ToString();

    }
    //Поражение
   public static void Defeat()
    {
        singleton.panel.SetActive(true);
        singleton.loseText.gameObject.SetActive(true);
        singleton.TotalScore.text = Player.score.ToString();
    }
    //Рестарт
    public void Restart()
    {
        Player.Restart();
    }
}
