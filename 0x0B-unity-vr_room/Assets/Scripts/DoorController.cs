
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DoorController : MonoBehaviour
{
    [SerializeField] private Animator myDoor = null;
    [SerializeField] private bool isOpen = false;

    void Start () {
        myDoor = GetComponent<Animator>();
    }
    void OnTriggerEnter(Collider other)
    {
        myDoor.SetBool("character_nearby", true);
    }

    void OnTriggerExit(Collider other)
    {
        myDoor.SetBool("character_nearby", false);
    }

//     private bool IsOpenDoorActive
//     {
//         get
//         {
//             return open_door.activeInHierarchy;
//         }
//     }
//     void Update()
//     {
//         if (isInTrigger && IsOpenDoorActive)
//         {
//             if (Input.GetKeyDown(KeyCode.E))
//             {
//                 isOpen = !isOpen;
//                 _animator.SetBool("isOpen", isOpen);
//             }
//         }
    // }
}