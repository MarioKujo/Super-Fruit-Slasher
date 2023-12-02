using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Audio;

public class Player1 : MonoBehaviour
{
    [HideInInspector]
    public Animator mechanim;
    bool attack = false;
    void Start()
    {
        mechanim = GetComponent<Animator>();
    }
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.A) && !attack && !Fruit.sliced)
        {
            bool isIdle = mechanim.GetCurrentAnimatorStateInfo(0).IsName("Idle_1");
            if (isIdle)
            {
            mechanim.SetTrigger("Cut");
            attack = true;
            AnimatorStateInfo stateInfo = mechanim.GetCurrentAnimatorStateInfo(0);
            float duration = stateInfo.length;
            StartCoroutine(Cooldown(duration));
            }
        }
    }
    IEnumerator Cooldown(float duration)
    {
        yield return new WaitForSeconds(duration);
        attack = false;
    }

}
