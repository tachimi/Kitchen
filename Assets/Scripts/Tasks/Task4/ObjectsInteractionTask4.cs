using System;
using UnityEngine;

public class ObjectsInteractionTask4 : MonoBehaviour
{
    [SerializeField] private GameObject WaffleRoot;
    [SerializeField] private GameObject Waffle;

    private void Awake()
    {
        var transform = WaffleRoot.GetComponent<Transform>();
    }

    public void SpawnWaffel()
    {
        var waffle = Instantiate(Waffle);
        waffle.transform.position = WaffleRoot.transform.position;
    }
}