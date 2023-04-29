using System;
using Unity.VisualScripting.Dependencies.NCalc;
using UnityEngine;

public class ObjectsInteractionTask5 : MonoBehaviour
{
    [SerializeField] private Shelf _shelf;
    [SerializeField] private int _countItemsToFall = 3;

    private void Awake()
    {
        _shelf.ItemSpawned += OnItemSpawned;
    }

    private void OnItemSpawned()
    {
        if (_shelf.ItemsCount >= _countItemsToFall)
        {
            _shelf.Fall();
        }
    }

    private void OnDestroy()
    {
        _shelf.ItemSpawned -= OnItemSpawned;
    }
}