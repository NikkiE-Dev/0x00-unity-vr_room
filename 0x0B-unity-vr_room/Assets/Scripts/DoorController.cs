
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DoorController : MonoBehaviour
{
    [SerializeField] private GameObject open_door = null;
    [SerializeField] private bool isInTrigger = false;
    public Animator _animator;
    private bool isOpen = false;

    // When the player enters the trigger zone, the door opens
    void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Player")
        {
            isInTrigger = true;
            open_door.SetActive(true);
        }
    }
    // When the player exits the trigger zone, the door closes
    void OnTriggerExit(Collider other)
    {
        if (other.gameObject.tag == "Player")
        {
            isInTrigger = false;
            open_door.SetActive(false);
        }
    }
    // If bool for IsOpenDoor is true,it becomes active in Hierarchy
    private bool IsOpenDoorActive
    {
        get
        {
            return open_door.activeInHierarchy;
        }
    }
    // Update is called once per frame
    // If player is in trigger area and bool for door is active, the antimation plays
    
    void Update()
    {
        if (isInTrigger && IsOpenDoorActive)
        {
            if (Input.GetKeyDown(KeyCode.E))
            {
                isOpen = !isOpen;
                _animator.SetBool("isOpen", isOpen);
            }
        }
    }
}