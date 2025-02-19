using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NKScript : SampleScript
{
    [SerializeField] private float speed = 1f; // �������� �����������
    [SerializeField] private Vector3 targetPoint = new Vector3(3, 0, 0); // ������� �����

    private bool isMoving = false; // ����, �����������, ��� ������ ��������
    private Vector3 startPosition; // ��������� ������� �������

    private void Start()
    {
        startPosition = transform.position; // ��������� ��������� �������
    }

    private void Update()
    {
        if (isMoving)
        {
            // ��������� ����� ������� � ������� �������� ������������ (Lerp)
            transform.position = Vector3.MoveTowards(transform.position, targetPoint, speed * Time.deltaTime);

            // ���� ������ ������ ������� �����, ������������� ��������
            if (transform.position == targetPoint)
            {
                isMoving = false;
                Debug.Log("������ ������ ������� �����.");
            }
        }
    }

    // �������������� ����� Use() ��� ������ �����������
    [ContextMenu("Use")]
    public override void Use()
    {
        if (!isMoving)
        {
            isMoving = true;
            Debug.Log("������ ����������� � ������� �����.");
        }
    }
}
