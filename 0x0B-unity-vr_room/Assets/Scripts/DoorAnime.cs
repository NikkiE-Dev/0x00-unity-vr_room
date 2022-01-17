using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DG.Tweening;
using UnityEngine.UI;

public class DoorAnime : MonoBehaviour
{
    [SerializeField] private Transform myDoor;
    [SerializeField] private float endPositionY = -90f;
    [SerializeField] private GameObject canvas;
    
    public void openDoor()
    {
        if (myDoor.transform.rotation.y != endPositionY)
        {
            myDoor
            .DOLocalRotate(new Vector3(0, endPositionY, 0), 3f);
            canvas.SetActive(false);
        }
    }
}












