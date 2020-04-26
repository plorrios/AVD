using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class creditsClick : MonoBehaviour
{
    private Animator anim;
    public void credits() { anim.SetTrigger("credits"); }
}
