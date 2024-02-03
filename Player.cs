using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Player : MonoBehaviour
{
    public static int score;

    public static List<Square> squares;
    // Start is called before the first frame update
    private void Awake()
    {
        squares = new List<Square>();
    }

     public static void Defeat()
    {
        score = 0;
        Ui.Defeat();
    }
    // Update is called once per frame
    void Update()
    {
        if (squares.Count == 0)
        {
            Ui.Victory();
        }
    }

    public void Victory()
    {
        Ui.Victory();
    }

    public static void Restart()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
    }
}
