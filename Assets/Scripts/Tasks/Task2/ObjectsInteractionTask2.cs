using System;
using UnityEngine;

public class ObjectsInteractionTask2 : MonoBehaviour
{
    // TODO: В методе Awake создайте на сцене в точке LampRoot одну из наборов ламп (из папки Prefabs/Lamps)  
    [SerializeField] private GameObject LampRoot;
    [SerializeField] private GameObject Lamp;

    private void Awake()
    {
        var transform = LampRoot.GetComponent<Transform>();
        var lamp = Instantiate(Lamp);
        lamp.transform.position = transform.position;
    }
}