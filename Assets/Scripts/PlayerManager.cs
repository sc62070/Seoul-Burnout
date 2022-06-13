using System.Collections;
using System.Collections.Generic;
using UnityEngine;


namespace SG
{
    public class PlayerManager : MonoBehaviour
    {
        InputHandler inputHandler;
        Animator anim;

        void Start()
        {
            inputHandler = GetComponent<InputHandler>();
        }

        void Update()
        {
            inputHandler.isInteracting = anim.GetBool("isInteracting");
        }
    }
}
