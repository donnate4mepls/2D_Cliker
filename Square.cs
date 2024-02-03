using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Square : MonoBehaviour
{
    public Vector2 targetPos;
    public float moveStep;

    public bool isTrap;

    public float speedFactor;
    public float scaleFactor;

    public int catchCount;
    // Start is called before the first frame update
    void Start()
    {
        //Проверка на то является ли нужным квадратом
        if(isTrap == false)
        {
            Player.squares.Add(this);
        }
        targetPos = GetRandomPoint();   
    }

    private void OnMouseDown()
    {
        //Проверка на нажатие
        if (isTrap)
        {
            Player.Defeat();
        }
        else
        {
            Catch();
        }
    }

    private void Catch()
    {
        //Обработка нажатия
        Player.score++;
        catchCount--;
        if (catchCount == 0)
        {
            Player.squares.Remove(this);
            Destroy(gameObject);
        }
        moveStep += speedFactor;
        transform.localScale = (Vector2)transform.localScale - new Vector2(scaleFactor, scaleFactor);
        targetPos = GetRandomPoint();
    }
    // Update is called once per frame
    void Update()
    {
        //Перемещение квадратов к заданным координатам
        transform.position = Vector2.MoveTowards(transform.position, targetPos, moveStep * Time.deltaTime);
        if((Vector2)transform.position == targetPos)
        {
            targetPos = GetRandomPoint();
        }
    }
    //Рандомизация координат
    Vector2 GetRandomPoint()
    {
        Vector2 targetPos = new Vector2();
        targetPos.x = Random.Range(-6,6);
        targetPos.y = Random.Range(-3, 3);
        return targetPos;
    }
}
