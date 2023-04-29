using System;
using Unity.VisualScripting;
using UnityEngine;

public class ObjectsInteractionTask1 : MonoBehaviour
{
    // TODO: Получите доступ к объекту со скриптом Refrigerator при помощи атрибута [SerializeField]
    // TODO: При нажатии на кнопку 1 на клавиатуре вызывайте у него метод Interact
    [SerializeField] private GameObject GameObject;
    private Refrigerator _refrigerator;

    private void Awake()
    {
        _refrigerator = GameObject.GetComponent<Refrigerator>();
    }

    private void Update()
    {
        if (Input.GetKeyDown("1"))
        {
            _refrigerator.Interact();
        }
    }
}