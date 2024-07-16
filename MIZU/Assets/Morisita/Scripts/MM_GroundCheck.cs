using System.Collections;
using System.Collections.Generic;
using UnityEngine;
public class MM_GroundCheck : MonoBehaviour
{
    //[Header("�G�t�F�N�g���������𔻒肷�邩")] public bool checkPlatformGroud = true;

    private string groundTag = "Ground";
    //private string platformTag = "GroundPlatform";
    //private string moveFloorTag = "MoveFloor";
    //private string fallFloorTag = "FallFloor";
    private bool isGround = false;
    private bool isGroundEnter, isGroundStay, isGroundExit;


    //�ڒn�����Ԃ����\�b�h
    public bool IsGround()
    {
        if (isGroundEnter || isGroundStay)
        {
            isGround = true;
        }
        else if (isGroundExit)
        {
            isGround = false;
        }
        return isGround;
    }

    private void OnTriggerEnter(Collider collision)
    {
        if (collision.CompareTag(groundTag))
        {
            isGroundEnter = true;
            isGroundExit = false;
        }
    }

    private void OnTriggerStay(Collider collision)
    {
        if (collision.CompareTag(groundTag))
        {
            isGroundStay = true;
            isGroundExit = false;
        }
    }

    private void OnTriggerExit(Collider collision)
    {
        if (collision.CompareTag(groundTag))
        {
            isGroundExit = true;
            isGroundEnter = false;
            isGroundStay = false;
        }
    }
}