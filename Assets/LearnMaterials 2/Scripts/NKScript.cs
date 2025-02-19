using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NKScript : SampleScript
{
    [SerializeField] private float speed = 1f; // Скорость перемещения
    [SerializeField] private Vector3 targetPoint = new Vector3(3, 0, 0); // Целевая точка

    private bool isMoving = false; // Флаг, указывающий, что объект движется
    private Vector3 startPosition; // Начальная позиция объекта

    private void Start()
    {
        startPosition = transform.position; // Сохраняем начальную позицию
    }

    private void Update()
    {
        if (isMoving)
        {
            // Вычисляем новую позицию с помощью линейной интерполяции (Lerp)
            transform.position = Vector3.MoveTowards(transform.position, targetPoint, speed * Time.deltaTime);

            // Если объект достиг целевой точки, останавливаем движение
            if (transform.position == targetPoint)
            {
                isMoving = false;
                Debug.Log("Объект достиг целевой точки.");
            }
        }
    }

    // Переопределяем метод Use() для старта перемещения
    [ContextMenu("Use")]
    public override void Use()
    {
        if (!isMoving)
        {
            isMoving = true;
            Debug.Log("Начато перемещение к целевой точке.");
        }
    }
}
